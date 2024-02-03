using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers; //change name

public class HomeController : Controller
{
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}
