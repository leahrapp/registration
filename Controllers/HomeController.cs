using registration.Models;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RazorRegister()
        {
            return View();
        }



        [HttpPost]
        public ActionResult RazorRegister(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Success = "Form Submitted";
            }
            return View(model);

        }

        public ActionResult HtmlRegister()
        {
            return View();
        }


        [HttpPost]
        public ActionResult HtmlRegister(string FirstName, string LastName)
        {

            var firstName = FirstName;
            ViewBag.Success = "Awesome";
    //anything else 
         return View();
        }


        [HttpPost]
        public ActionResult HtmlSubmitRequest()
        {
            var firstName = Request["FirstName"];
            
           //do some validation or logic 

            return RedirectToAction("Success");

        }



        [HttpPost]
        public ActionResult HtmlSubmit(RegisterViewModel register)
        {
         
            if (!ModelState.IsValid)
            {

                RedirectToAction("Error");
            }

           

            return RedirectToAction("Success"); 
        }


        public ActionResult Error()
        {



            return View(); 
        }


        public ActionResult Success()
        {



            return View(); 
        }


    }
}