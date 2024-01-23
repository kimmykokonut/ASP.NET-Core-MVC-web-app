using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    [Route("/")]
    public ActionResult Index() //routeMethodName
    {
      ClassName starterClassName = new ClassName("words");
      return View(starterClassName);
    }
  }
}