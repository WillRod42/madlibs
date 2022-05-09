using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLibForm() { return View(); }

    [Route("/view")]
    public ActionResult MadLibOutput(string color, string superlative, string adj, string bodyParts, string bodyPart, string noun, string animal, string adj2, string adj3, string adj4) 
    { 
      MadLib madlib = new MadLib(10);
      madlib.addWord(color);
      madlib.addWord(superlative);
      madlib.addWord(adj);
      madlib.addWord(bodyParts);
      madlib.addWord(bodyPart);
      madlib.addWord(noun);
      madlib.addWord(animal);
      madlib.addWord(adj2);
      madlib.addWord(adj3);
      madlib.addWord(adj4);
      return View(madlib); 
    }
  }
}