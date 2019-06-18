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

  }
}