using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormViewLibraries.Forms
{
    public class FormCollection
    {
        public string? FormNumber {  get; set; }
        public List<Form>? FormList { get; set; }
        public DateTime Timestamp { get; set; }

        public FormCollection()
        {
            FormList = new List<Form>();
        }
    }
}
