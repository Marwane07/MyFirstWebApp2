using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp2.Controllers{
    public class TestController:Controller{
        public IActionResult Index(){
            return View();
        }
    }
}