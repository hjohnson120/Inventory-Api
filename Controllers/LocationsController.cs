using inventory_api;
using Inventory_Api.Model;
using Inventory_Api.Model.cs;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LocationsController : ControllerBase

  {
    [HttpPost]
    public ActionResult<Locations> Post([FromBody]Locations info)
    {
      var db = new DatabaseContext();
      db.Location.Add(info);
      db.SaveChanges();
      return info;
    }
  }
}