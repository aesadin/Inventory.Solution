using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
  public class Inventory
  {
    public int InventoryId { get; set; }
    public string Collection { get; set; }
    public string Description { get; set; }

  }
}