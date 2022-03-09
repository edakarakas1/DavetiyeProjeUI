using DavetiyeBusiness.Abstract;
using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Concrete
{
    public class DavetiyeManeger : IDavetiyeService
    {
        private IDavetiyeRepository rep;
        public DavetiyeManeger(IDavetiyeRepository _rep)
        {
            rep = _rep;
        }
        public Davetiye CreateDavetiye(Davetiye davetiye)
        {
            return rep.CreateDavetiye(davetiye);
        }

        public List<Davetiye> Gelenler(bool b)
        {
            return rep.Gelenler(b);
        }

        public List<Davetiye> GetAllDavetiye()
        {
            return rep.GetAllDavetiye();
        }

        //public Davetiye GetDavetiyeById(int id)
        //{
        //    if (id > 0)
        //    {
        //        return rep.GetDavetiyeById(id);
        //    }
        //    throw new Exception("aaaa");
        //}

        //public Davetiye UpdateDavetiye(Davetiye davetiye)
        //{
        //    return rep.UpdateDavetiye(davetiye);
        //}
    }
}
