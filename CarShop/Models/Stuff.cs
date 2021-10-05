using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Stuff
{
    public Stuff()
    {
        Orders = new HashSet<Order>();
    }

    public int StuffId { get; set; }
    public string Name { get; set; }
    public long? Phone { get; set; }
    public long? Passport { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
}