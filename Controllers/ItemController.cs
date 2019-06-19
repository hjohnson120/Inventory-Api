using System.Collections.Generic;
using System.Linq;
using inventory_api;
using Inventory_Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Api.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ItemController : ControllerBase
  {
    [HttpGet]

    public ActionResult<List<StoreItem>> Get()
    {
      var db = new DatabaseContext();
      var rv = db.Item;
      return rv.ToList();
    }


    [HttpPost]
    public ActionResult<StoreItem> Post([FromBody]StoreItem info)
    {
      var db = new DatabaseContext();
      db.Item.Add(info);
      db.SaveChanges();
      return info;
    }

    [HttpGet("{Id}")]

    public ActionResult<StoreItem> GetOneItem(int Id)
    {
      var db = new DatabaseContext();
      var getOne = db.Item.FirstOrDefault(f => f.Id == Id);
      return getOne;
    }

    [HttpPut("{Id}")]

    public ActionResult<StoreItem> updateItem(int Id, [FromBody]StoreItem item)
    {
      var db = new DatabaseContext();
      var updateOne = db.Item.FirstOrDefault(f => f.Id == Id);
      item.Price = item.Price;
      db.SaveChanges();
      return item;
    }

    [HttpDelete("{Id}")]

    public ActionResult deleteItem(int Id)
    {
      var db = new DatabaseContext();
      var deleteItem = db.Item.FirstOrDefault(f => f.Id == Id);
      if (deleteItem == null)
      {
        return NotFound();
      }
      else
      {
        db.Item.Remove(deleteItem);
        db.SaveChanges();
        return Ok();
      }
    }
    [HttpGet("OutOfStock")]

    public ActionResult<List<StoreItem>> showOutOfStock()
    {
      var db = new DatabaseContext();
      var outOfStock = db.Item.Where(w => w.NumberInStock == 0);
      return outOfStock.ToList();
    }

    [HttpGet("SKU{SKU}")]

    public ActionResult<StoreItem> searchBySKU(int SKU)
    {
      var db = new DatabaseContext();
      var findBySKU = db.Item.FirstOrDefault(f => f.SKU == SKU);
      return findBySKU;

    }

  }

}
