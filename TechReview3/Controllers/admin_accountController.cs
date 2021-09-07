using System.Web.Mvc;

namespace TechReview3.Controllers
{
    public class admin_accountController : Controller
    {
        // GET: admin_account
        public ActionResult LogIn()
        {
            return View();
        }
    }
}