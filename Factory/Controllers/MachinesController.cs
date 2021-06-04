using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Machine> allMachines = _db.Machines.OrderBy(m => m.Type).ToList();
      return View(allMachines);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
        .Include(m => m.JoinEntities)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(m => m.MachineId == id);
      return View(thisMachine);
    }
    public ActionResult Edit(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(e => e.MachineId == id);
      return View(thisMachine);
    }
    [HttpPost]
    public ActionResult Edit(Machine machine)
    {
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = machine.MachineId});
    }
    public ActionResult Delete(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      return View(thisMachine);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(e => e.MachineId == id);
      _db.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}