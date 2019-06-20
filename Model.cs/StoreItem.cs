
using System;
using Inventory_Api.Model.cs;

namespace Inventory_Api.Model
{

  public class StoreItem
  {

    public int Id { get; set; }
    public int SKU { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public int NumberInStock { get; set; }
    public int Price { get; set; }
    public DateTime DatePurchased { get; set; }


    public int? LocationId { get; set; }
    public Locations Location { get; set; }

  }
}