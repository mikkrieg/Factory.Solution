using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Factory.Controllers
{
  public class EngineersController : Controller 
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {      
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Engineer> Engineers = _db.Engineers.ToList();
      List<Machine> Machines = _db.Machines.ToList();
      model.Add("Engineers", Engineers);
      model.Add("Machines", Machines);
      return View(model);
    }
  }
}