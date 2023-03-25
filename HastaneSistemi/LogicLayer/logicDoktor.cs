using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicDoktor
    {
        public static int LLDoktorEkle(EntityDoktor p)
        {
            if (p.Ad1 != "" && p.Soyad1!="" && p.TcNo1!="" && p.Cinsiyet1!="" && p.Bolumu1!="" && p.TelefonNo1!="" && p.TelefonNo1.Length == 10 && p.TcNo1.Length == 11)
            {
                return DALDoktor.DoktorEkle(p);
            }
            else
            {
                return -1;
            }
            return DALDoktor.DoktorEkle(p);
        }

        public static List<EntityDoktor> LLDoktorListele()
        {
            return DALDoktor.DoktorListesi();
        }

        public static bool LLDoktorSil(int per)
        {
            if (per >= 1)
            {
                return DALDoktor.DoktorSil(per);

            }
            else
            {
                return false;
            }
        }

       public static bool LLDoktorGuncelle(EntityDoktor ent)
        {
            if(ent.Ad1!="" && ent.Soyad1 != "" && ent.TelefonNo1.Length == 10 && ent.TelefonNo1 != "" && ent.TcNo1.Length == 11 && ent.TcNo1 != "")
            {
                return DALDoktor.DoktorGuncelle(ent);
            }
            else
            {
                return false;
            }
       }
    }
}
