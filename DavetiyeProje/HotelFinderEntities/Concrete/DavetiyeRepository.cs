using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Concrete
{
    public class DavetiyeRepository : IDavetiyeRepository
    {
        public Davetiye CreateDavetiye(Davetiye davetiye)
        {
            using (var db = new DavetiyeDbContext())
            {
                db.Davetiye.Add(davetiye);
                db.SaveChanges();
                return davetiye;
            }
        }

        public List<Davetiye> Gelenler(bool b)
        {
            return GetAllDavetiye().Where(x => x.KatilimaDurumu == b).ToList();
        }

        public List<Davetiye> GetAllDavetiye()
        {
            using (var db = new DavetiyeDbContext())
            {
                return db.Davetiye.ToList();
            }
        }

        //public Davetiye GetDavetiyeById(int id)
        //{
        //    using (var db = new DavetiyeDbContext())
        //    {
        //        return db.Davetiye.FirstOrDefault(x => x.Id == id);
        //    }
        //}

        //public Davetiye UpdateDavetiye(Davetiye davetiye)
        //{
        //    using (var db = new DavetiyeDbContext())
        //    {
        //        db.Davetiye.Update(davetiye);
        //        db.SaveChanges();
        //        return davetiye;
        //    }
        //}
    }
}
