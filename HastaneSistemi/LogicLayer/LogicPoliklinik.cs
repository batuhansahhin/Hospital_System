using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPoliklinik
    {
        public static List<EntityPoliklinik> LLPoliklinikListesi()
        {
            return DALPoliklinik.PoliklinikListesi();
        }
    }
}
