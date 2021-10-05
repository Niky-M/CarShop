using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Car
{
    public Car()
    {
        Orders = new HashSet<Order>();
    }

    public int CarId { get; set; }
    public int? BrandId { get; set; }
    public int? ModelId { get; set; }
    public int? Year { get; set; }
    public int? ComplicationId { get; set; }
    public int? Price { get; set; }

    public virtual Brand Brand { get; set; }
    public virtual Complication Complication { get; set; }
    public virtual Model Model { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
}