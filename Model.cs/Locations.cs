using System.Collections.Generic;

namespace Inventory_Api.Model.cs
{
  public class Locations
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public string ManagerName { get; set; }
    public string PhoneNumber { get; set; }

    public List<StoreItem> Item { get; set; } = new List<StoreItem>();

  }
}