using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_plant_guide.Models;
using wpf_plant_guide.Repository.Base;

namespace wpf_plant_guide.Repository
{
    public  interface IPlantRepository:IRepo<Plant,int>
    {
        
    }
}
