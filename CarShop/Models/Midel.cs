using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Models
{
    public partial class Model
{
    public Model()
    {
        Cars = new HashSet<Car>();
    }

    public int ModelId { get; set; }
    public string ModelName { get; set; }
    public int? BrandId { get; set; }

    public virtual Brand Brand { get; set; }
    public virtual ICollection<Car> Cars { get; set; }
}
}