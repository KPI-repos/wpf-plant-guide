using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class Plant
{
    public int PlantId { get; set; }

    public string? ScientificName { get; set; }

    public string? CommonName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Climate> Climates { get; set; } = new List<Climate>();

    public virtual ICollection<FamilyPlant> FamilyPlants { get; set; } = new List<FamilyPlant>();

    public virtual ICollection<FloweringSeasonPlant> FloweringSeasonPlants { get; set; } = new List<FloweringSeasonPlant>();

    public virtual ICollection<Origin> Origins { get; set; } = new List<Origin>();

    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    public virtual ICollection<SourcePlant> SourcePlants { get; set; } = new List<SourcePlant>();
}
