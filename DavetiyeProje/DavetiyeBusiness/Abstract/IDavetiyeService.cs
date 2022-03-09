using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Abstract
{
   public interface IDavetiyeService
    {
        List<Davetiye> GetAllDavetiye();
        //Davetiye GetDavetiyeById(int id);
        List<Davetiye> Gelenler(bool b);//gelenler
        Davetiye CreateDavetiye(Davetiye davetiye);
        //Davetiye UpdateDavetiye(Davetiye davetiye);    
    }
}
