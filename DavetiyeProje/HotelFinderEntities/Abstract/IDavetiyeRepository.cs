using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Abstract
{
    public interface IDavetiyeRepository
    {
        List<Davetiye> GetAllDavetiye();//katılanlar listeleneck
        //Davetiye GetDavetiyeById(int id);
        List<Davetiye> Gelenler(bool b);//gelenler
        Davetiye CreateDavetiye(Davetiye davetiye);//ekle
        //Davetiye UpdateDavetiye(Davetiye davetiye);
    }
}
