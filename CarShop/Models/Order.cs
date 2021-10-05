using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Order
{
    public int OrderId { get; set; }
    public int? ClientId { get; set; }
    public int? CarId { get; set; }
    public int? StuffId { get; set; }
    public DateTime? Date { get; set; }

    public virtual Car Car { get; set; }
    public virtual Client Client { get; set; }
    public virtual Stuff Stuff { get; set; }
}
}