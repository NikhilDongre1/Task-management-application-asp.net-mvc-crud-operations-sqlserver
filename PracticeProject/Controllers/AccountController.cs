using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PracticeProject.Models;

namespace PracticeProject.Controllers
{
    public class AccountController : Controller
    {
         // locahost:54321/Account/WeaklyTypedLogin 
          // view for form
        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }

        // view for form data after submited.
        [HttpPost]
        public IActionResult LoginPost(string username,string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();

        }
        public IActionResult StronglyTypedLogin() {
            return View();

        }
        [HttpGet]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;

            return View();
        }
        public IActionResult UserDetails()
        {
            var user = new LoginViewModel() {Username = "nikhil", Password = "123123"};
            return View(user);
        }
        public IActionResult UserList()
        {
            var userlist = new List<LoginViewModel>() {
                new LoginViewModel() { Username = "farhar", Password = "123345" },
                new LoginViewModel() { Username = "raju", Password= "34556" },
                new LoginViewModel() { Username = "rancho", Password = "343556" }
                } ;
            return View(userlist);
        }
    }
}
