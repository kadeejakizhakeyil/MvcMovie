using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
    }
}
