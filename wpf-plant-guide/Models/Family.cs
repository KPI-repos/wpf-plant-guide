using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class Family
{
    public int FamilyId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FamilyPlant> FamilyPlants { get; set; } = new List<FamilyPlant>();
}
