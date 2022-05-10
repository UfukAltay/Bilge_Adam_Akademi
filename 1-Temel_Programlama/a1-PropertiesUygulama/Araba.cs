using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1_PropertiesUygulama
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }

        string renk;


        public string Renk
        {
            get { return renk; }
            set
            { renk = value; }
        }

        private string aciklama;
        public string Aciklama
        {
            get
            {
                return aciklama;
            }
            set
            {
                if (value.Length > 30)
                {
                    aciklama = value.Substring(0, 30);
                }
                else
                {
                    aciklama = value;
                }

            }
        }

        public string TumOzellikler
        {
            get
            {
                return String.Format("İlan Açıklama = {0} Marka = {1} Model= {2} Üretim Yılı= {3} Renk= {4}", Aciklama, Marka, Model, UretimYili, Renk);
            }
        }
    }
}
