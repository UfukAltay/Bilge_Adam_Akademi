using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_Encapsulation_Properties
{
    public class Ogrenci
    {
        private string adi;
        public string Adi
        {
            // değer okumak için kullanılır 

            get
            {
                return adi.ToUpper();
            }
            set
            {
                #region Okuyun
                // değer atamak için kullanılır..
                // value parametredir.. property'e atanan değerdir.. atanan değeri adi fieldında saklıyoruz...properynin tipi neyse value tipide odur...     
                #endregion
                adi = value;
            }
        }

        // propertyler fieldlara dışarıdan erişmek için kullanılırlar..propertyleri SoyAdi propertysi kullanırsak kendisi bir gizli field tanımlar
        public string SoyAdi { get; set; }

        public float VizeNotu { get; set; }

        public float FinalNotu { get; set; }

        public float Ortalama
        {
            get
            {
                return VizeNotu * 0.4f + FinalNotu * 0.6f;
            }
        }

        #region Okuyun


        // properties

        // sınıf üyesidir... sınıfın özellikleridir...fieldlara dışarıdan kontrollü erişim için vardır... c#'da 3.0 dan önce javadaki gibi bu methodlarla yapılırdı.. 3.0 'dan sonra ise propertylerle yapılır...propertyler fieldların daha gelişmiş halidir... 


        // Sınıf üyelerine sınıf seviyesinde erişilemez..Sınıf üyelerine sadece sınıfın alt scoparında erişebiliriz...bu alt scopelar method veya properties'lerdir

        //public float Ortalama = VizeNotu
        #endregion
    }
}
