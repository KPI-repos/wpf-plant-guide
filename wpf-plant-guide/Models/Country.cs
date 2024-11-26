using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Origin> Origins { get; set; } = new List<Origin>();
}
