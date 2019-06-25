using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BelajarWebKP.Controllers
{
    public class UsersController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }



         public string Wellcome(string name, int ID = 1)
        {
                return HtmlEncoder.Default.Encode($"Selamat Datang {name} dengan id = {ID} ") ;
        }
        

    }
}