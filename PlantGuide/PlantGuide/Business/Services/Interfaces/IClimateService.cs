﻿using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;

namespace PlantGuide.Business.Services.Interfaces;

public interface IClimateService : ICrud<Climate, CreateClimateDTO>
{
}
