using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class FloweringSeasonPlant
{
    public int FloweringSeasonPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? TypeSeasonId { get; set; }

    public virtual Plant? Plant { get; set; }

    public virtual TypeSeason? TypeSeason { get; set; }
}
