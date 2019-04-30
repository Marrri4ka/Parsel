using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ItemsController: Controller
  {
    [HttpGet("/items")]
     public ActionResult IndexList()
     {
       List<Item> allItems = Item.GetAll();
       return View(allItems);
     }

     [HttpGet("/items/new")]
     public ActionResult IndexForm()
     {
       return View();
     }

     [HttpPost ("/items")]
     public ActionResult Create (string description, int weight, int height, int width, int length)
     {
       Item myItem = new Item ( description, weight,  height, width, length);
       return RedirectToAction("IndexList");
     }

  }
}
