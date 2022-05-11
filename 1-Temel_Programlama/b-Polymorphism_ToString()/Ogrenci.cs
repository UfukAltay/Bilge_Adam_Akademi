using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Polymorphism_ToString__
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }


        // c#'da hazır bütün tipler ve bizim kullandığımız tipler birer objedir..

        // obje bir sınıftır..bütün sınıflara gizli miras verir

        public override string ToString()
        {
            //return "Ekrem YILDIRIM";
            return Adi + " " + SoyAdi;
        }
    }
}
