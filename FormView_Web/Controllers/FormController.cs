using FormViewLibraries;
using FormViewLibraries.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Security;

namespace FormView_Web.Controllers
{
    public class FormController : Controller
    {
        private FormViewManager
            _manager;

        private AppSettings
            _appSettings;

        public FormController(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;

            SqlCredential credentials = null;

            if (!_appSettings.UseDefaultCredentials)
            {
                credentials = new SqlCredential(_appSettings.Username, GetSecurePassword());
            }
            _manager = new FormViewManager()
            {
                Server = _appSettings.Server,
                Database = _appSettings.Database,
                Credentials = credentials,
                FileServer = _appSettings.FileServer,
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Form/{id}")]
        public IActionResult Index(string id)
        {
            var results = _manager.GetAllFormsForID(id);
            var translatedResults = new SortedDictionary<DateTime, List<string>>();
            foreach (var result in results)
            {
                var files = new List<string>();
                foreach(var form in result.FormList)
                {
                    if(form is ImageForm image)
                    {
                        files.Add(image.Filename);
                    }
                }

                translatedResults[result.Timestamp] = files;
            }
            ViewBag.Results = translatedResults;
            return View();
        }

        //TODO - put this somewhere better
        private SecureString GetSecurePassword()
        {
            var result = new SecureString();

            foreach (var c in _appSettings.Password)
            {
                result.AppendChar(c);
            }

            result.MakeReadOnly();

            return result;
        }
    }
}
