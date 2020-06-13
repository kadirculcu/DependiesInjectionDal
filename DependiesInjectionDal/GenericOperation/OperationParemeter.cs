using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.GenericOperation
{
    public class OperationParemeter : Ioperation
    {
        private readonly string _param;
        public OperationParemeter(string param)
        {
            _param = param;
        }
        public void ekle()
        {
            Console.WriteLine(_param + " Eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine(_param + " Güncellendi");
        }

        public void listele()
        {
            Console.WriteLine(_param + " Listelendi");
        }

        public void sil()
        {
            Console.WriteLine(_param + " Silindi");
        }
    }
}
