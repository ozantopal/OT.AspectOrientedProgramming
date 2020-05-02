using Microsoft.AspNetCore.Mvc;
using OT.AspectOrientedProgramming.Business.Abstracts;

namespace OT.AspectOrientedProgramming.Web.Controllers
{
    public class HomeController : Controller
    {
        private IFooService fooService;

        public HomeController(IFooService fooService)
        {
            this.fooService = fooService;
        }

        public IActionResult Index()
        {
            fooService.Foo();
            fooService.Do();
            fooService.Bar();

            return Ok(new { FirstName = "Ozan", LastName = "Topal" });
        }
    }
}
