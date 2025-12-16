using FormViewLibraries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Security;

namespace FormView_Web.Controllers
{
    public class ImageController : Controller
    {
        private FormViewManager
            _manager;

        private AppSettings
            _appSettings;

        public ImageController(IOptions<AppSettings> options)
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

        [HttpGet("Image/{filename}")]
        public IActionResult Index(string filename)
        {
            var fullPath = Path.Combine(_manager.FileServer, filename);

            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound();
            }
            var image = System.IO.File.OpenRead(fullPath);
            return File(image, "image/jpeg");
        }

        //TODO- put this somewhere better
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
