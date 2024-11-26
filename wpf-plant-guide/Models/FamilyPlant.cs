﻿using System;
using System.Collections.Generic;

namespace wpf_plant_guide.Models;

public partial class FamilyPlant
{
    public int FamilyPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? FamilyId { get; set; }

    public virtual Family? Family { get; set; }

    public virtual Plant? Plant { get; set; }
}