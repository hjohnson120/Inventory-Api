using System.Collections.Generic;
using System.Linq;
using inventory_api;
using Inventory_Api.Model;
using Inventory_Api.Model.cs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LocationsController : ControllerBase

  {

    [HttpGet]

    public ActionResult<List<Locations>> Get()
    {
      var db = new DatabaseContext();
      var data = db.Location.Include(i => i.Item).FirstOrDefault();
      return data.Item;
      // var rv = db.Location;
      // return rv.ToList();
    }


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