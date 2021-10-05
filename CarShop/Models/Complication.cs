using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Complication
{
    public Complication()
    {
        Cars = new HashSet<Car>();
    }

    public int ComplicationId { get; set; }
    public string ComplicationName { get; set; }

    public virtual ICollection<Car> Cars { get; set; }
}
}