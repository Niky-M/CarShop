using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Client
{
    public Client()
    {
        Orders = new HashSet<Order>();
    }

    public int ClentId { get; set; }
    public string Name { get; set; }
    public long? Phone { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
}