using Microsoft.AspNetCore.Mvc;
using Numbers.Models;

namespace Numbers.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/numberpage")]
    public ActionResult NumbersConvert(string number)
    {
      Number newNum = new Number();
      newNum.EndWord = Number.CheckFullNum(number);
      return View(newNum);
    }
  }
}    