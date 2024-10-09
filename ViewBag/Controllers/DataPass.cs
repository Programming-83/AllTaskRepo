using Microsoft.AspNetCore.Mvc;

namespace ViewBag.Controllers
{
    public class DataPass : Controller
    {
        public IActionResult Index()
        {
            ViewData["Data1"] = "ViewData";
            ViewData["Data2"] = 250;
            ViewData["Data3"]= DateTime.Now.ToLongDateString();
            
            string[] srt = { "Abhishek", "Sandip", "Rahul", "Ashish", "Kiran" };
            ViewData["Str"]= srt;

            List<string> st = new List<string>
            {
                "Abhishek", "Sandip","Rahul","Ashish", "Kiran"
            };
            ViewData["Lis"] = st;
            return View();
        }
    }
}
