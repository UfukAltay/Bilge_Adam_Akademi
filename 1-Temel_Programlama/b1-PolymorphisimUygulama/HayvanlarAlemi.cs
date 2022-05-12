using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1_PolymorphisimUygulama
{
    // Insan base class düşünce methodu var
    // Personel,Patron,Hoca,Ogrenci sınıfları Insan'dan miras alıyor.. insan sınıfının düşünce methoduda miras alan sınıflar tarafındn gövdesi farklı şekilde yazılmalı.
    public abstract class HayvanlarAlemi
    {
        public abstract string CikardigiSes();
    }
    public class Kedi : HayvanlarAlemi
    {
        public override string CikardigiSes()
        {
            return "miyav miyav";
        }
    }
    public class Kus : HayvanlarAlemi
    {
        public override string CikardigiSes()
        {
            return "cik cik";
        }
    }
}
