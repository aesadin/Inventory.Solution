using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class InventoriesController : Controller
  {
    private readonly InventoryContext _db;

    public InventoriesController(InventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Inventory> model = _db.Inventory.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Create(Inventory inventory)
    {
      _db.Inventories.Add(inventory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}