using HelloProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloProj.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()    //contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)    //contacts
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
