using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.GenericOperation
{
    public class Operation : Ioperation
    {
        public void ekle()
        {
            Console.WriteLine("Eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine("Güncellendi");
        }

        public void listele()
        {
            Console.WriteLine("Listelendi"); ;
        }

        public void sil()
        {
            Console.WriteLine("Silindi");
        }
    }
}

