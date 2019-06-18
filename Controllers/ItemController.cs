using inventory_api;
using Inventory_Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Api.Controllers
{

  [ApiController]
  [Route("api/[controller")]
  public class ItemController : ControllerBase
  {
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