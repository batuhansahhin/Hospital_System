using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data;

namespace LogicLayer
{
    public class LogicHasta
    {
     
        public static DataTable LLHastaAraTc(EntityHasta p)
        {
            return DALHasta.HastaAraTc(p);
        }
        
        public static int LLHastaEkle(EntityHasta p)
        {
            if (p.Ad1 != "" && p.Soyad1 != "" && p.TcNo1 != "" && p.Cinsiyet1 != "" && p.TelefonNo1 != "" && p.TelefonNo1.Length == 10 && p.TcNo1.Length == 11)
            {
                return DALHasta.HastaEkle(p);
            }
            else
            {
                return -1;
            }
            return DALHasta.HastaEkle(p);
        }


        public static List<EntityHasta> LLHastaGuncelle()
        {
            return DALHasta.HastaListesi();
        }


        public static bool LLHastaSil(int per)
        {
            if (per >= 1)
            {
                return DALHasta.HastaSil(per);

            }
            else
            {
                return false;
            }
        }

        public static bool LLHastaGuncelle(EntityHasta ent)
        {
            if (ent.Ad1 != "" && ent.Soyad1 != "" && ent.TelefonNo1.Length == 10 && ent.TelefonNo1 != "" && ent.TcNo1.Length == 11 && ent.TcNo1 != "")
            {
                return DALHasta.HastaGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static bool RaporEkle(EntityHasta s)
        {
           if(s.HastaNo1 != "")
            {
                return DALHasta.RaporEkle(s);

            }

            else
            {
                return false;
            }
            
        }
        public static bool TahlilSonucu(EntityHasta s)
        {
            if (s.HastaNo1 != "")
            {
                return DALHasta.TahlilSonucu(s);

            }

            else
            {
                return false;
            }

        }
    }
}
