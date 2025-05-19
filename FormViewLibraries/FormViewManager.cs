using FormViewLibraries.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Security.AccessControl;
namespace FormViewLibraries
{
    public class FormViewManager
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string FileServer { get; set; }
        public SqlCredential Credentials { get; set; }

        public FormViewManager() 
        {
        }

        public List<FormCollection> GetAllFormsForID(string id)
        {
            var connection = new SqlConnection(BuildConnectionString());
            connection.Credential = Credentials;
            var command = new SqlCommand()
            {
                Connection = connection,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spGetFormsByReferenceNumber",    //TODO - parameterise
            };
            command.Parameters.Add(new SqlParameter("ReferenceNumber", id));    //TODO - parameterise

            var groupedSets = new Dictionary<DateTime, FormCollection>();

            connection.Open();
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //TODO - currently only return one result set, not sure if needed, might expand if we make this function generic
                    //do
                    //{
                    while (reader.Read())
                    {
                        var form = ReadFormFromSql(reader);

                        //TODO - work out form grouping, currently based on date
                        var key = form.Timestamp.Date;

                        FormCollection formCollection;
                        if(!groupedSets.TryGetValue(key, out formCollection))
                        {
                            formCollection = new FormCollection();
                            formCollection.Timestamp = key;
                            formCollection.FormNumber = id;
                            groupedSets[key] = formCollection;
                        }

                        formCollection.FormList.Add(form);

                    }
                    //} while (reader.Read());
                }
            }
            connection.Close();

            return groupedSets.Values.ToList();
        }

        private string BuildConnectionString()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.Add("Server", Server);
            builder.Add("Database", Database);

            if(Credentials == null)
            {
                builder.Add("Integrated Security", true);
            }

            return builder.ToString();
        }

        private Form ReadFormFromSql(SqlDataReader reader)
        {
            Form result;

            //TODO - parameterise these
            var sqlType = reader["Type"] as string;

            if (sqlType == null)
            {
                throw new InvalidDataException();
            }

            switch(sqlType.ToLower())
            {
                case "image":
                    {
                        var imageForm = new ImageForm();
                        imageForm.Filename = Path.Combine(FileServer,reader["Path"] as string);
                        result = imageForm;
                    }
                    break;
                case "pdf":
                    {
                        var pdfForm = new PdfForm();
                        pdfForm.Url = Path.Combine(FileServer, reader["Path"] as string);
                        result = pdfForm;
                    }
                    break;
                default:
                    throw new InvalidDataException();
            };

            result.Timestamp = (DateTime)reader["Timestamp"];
            return result;
        }
    }
}
