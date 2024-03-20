using CLDV.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV.Controllers
{
    public class UserController : Controller
    {
        public tblUsers usertbl = new tblUsers();

        [HttpPost]

        public ActionResult About(tblUsers Users)
        {
            var result = tblUsers.insert_User(Users);
            return RedirectToAction("Home", "About");
        }
        [HttpGet]


        public IActionResult About()
        {
            return View(usertbl);
        }
    }
}
