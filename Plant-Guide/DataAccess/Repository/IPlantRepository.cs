using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Repository.Base;

namespace DataAccess.Repository
{
    public  interface IPlantRepository:IRepo<Plant,int>
    {
        
    }
}
