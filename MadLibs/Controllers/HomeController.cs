using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() {
      return View();
    }

    [Route("/form")]
    public ActionResult Form() {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string person1, string person2, string animal, string exclamation, string verb, string noun) {
      MadLib storyInputs = new MadLib(person1, person2, animal, exclamation, verb, noun);
      return View(storyInputs);
    }
  }
}