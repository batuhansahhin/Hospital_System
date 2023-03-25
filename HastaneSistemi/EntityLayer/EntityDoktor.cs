using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDoktor
    {
        private string DoktorNo;
        private string TcNo;
        private string Ad;
        private string Soyad;
        private string Cinsiyet;
        private DateTime DogumTarihi;
        private string TelefonNo;
        private string Bolumu;
        private int PoliklinikId;
        private string Sifre;
       

        public string DoktorNo1 { get => DoktorNo; set => DoktorNo = value; }
        public string TcNo1 { get => TcNo; set => TcNo = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Cinsiyet1 { get => Cinsiyet; set => Cinsiyet = value; }
        public string TelefonNo1 { get => TelefonNo; set => TelefonNo = value; }
        public string Bolumu1 { get => Bolumu; set => Bolumu = value; }
        public string Sifre1 { get => Sifre; set => Sifre = value; }
    }
}
