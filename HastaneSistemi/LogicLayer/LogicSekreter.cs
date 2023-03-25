using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicSekreter
    {
        public static int LLSekreterEkle(EntityLayer.EntitySekreter p)
        {
            if (p.Ad1 != "" && p.Soyad1 != "" && p.TcNo1 != "" && p.Cinsiyet1 != "" && p.TelefonNo1 != "" && p.TelefonNo1.Length == 10 && p.TcNo1.Length == 11)
            {
                return DataAccessLayer.DALSekreter.SekreterEkle(p);
            }
            else
            {
                return -1;
            }
            return DataAccessLayer.DALSekreter.SekreterEkle(p);
        }

        public static List<EntitySekreter> LLSekreterListele()
        {
            return DALSekreter.SekreterListesi();
        }

        public static bool LLSekreterSil(int per)
        {
            if (per >= 1)
            {
                return DALSekreter.SekreterSil(per);

            }
            else
            {
                return false;
            }
        }

        public static bool LLSekreterGuncelle(EntitySekreter ent)
        {
            if (ent.Ad1 != "" && ent.Soyad1 != "" && ent.TelefonNo1.Length == 10 && ent.TelefonNo1 != "" && ent.TcNo1.Length == 11 && ent.TcNo1 != "")
            {
                return DALSekreter.SekreterGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
