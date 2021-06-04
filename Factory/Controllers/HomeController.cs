using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.EngineersList = _db.Engineers.OrderBy(e => e.Name).ToList();
      ViewBag.MachinesList = _db.Machines.OrderBy(m => m.Type).ToList();
      return View();
    }
  }
}