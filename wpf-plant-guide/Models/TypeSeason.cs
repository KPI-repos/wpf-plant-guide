using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class TypeSeason
{
    public int TypeSeasonId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FloweringSeasonPlant> FloweringSeasonPlants { get; set; } = new List<FloweringSeasonPlant>();
}
