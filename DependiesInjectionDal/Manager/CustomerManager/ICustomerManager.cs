using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Menager.CustomerMenager
{
    public interface ICustomerManager 
    {
        void musteriEkle();
        void müusteriSil();
        void müusteriListele();
        void musteriGuncelle();
    }
}
