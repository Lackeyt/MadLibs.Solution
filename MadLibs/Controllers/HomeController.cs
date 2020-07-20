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

    [Route("/form2")]
    public ActionResult Form2() {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string person1, string person2, string animal, string exclamation, string verb, string noun) {
      MadLib storyInputs = new MadLib(person1, person2, animal, exclamation, verb, noun);
      return View(storyInputs);
    }

    [Route("/story2")]
    public ActionResult Story2(string adjective, string adjective2, string noun, string noun2, string nounPlural, string game, string nounPlural2, string ingVerb, string noun3, string plant, string bodyPart, string location, string ingVerb2, string adjective3, string number, string nounPlural3) {
      MadLibVacation vacaInputs = new MadLibVacation(adjective, adjective2, noun, noun2, nounPlural, game, nounPlural2, ingVerb, noun3, plant, bodyPart, location, ingVerb2, adjective3, number, nounPlural3);
      return View(vacaInputs);
    }
  }
}