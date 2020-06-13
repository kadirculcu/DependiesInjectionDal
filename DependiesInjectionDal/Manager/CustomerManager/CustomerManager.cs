using DependiesInjectionDal.Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Menager.CustomerMenager
{
    public class CustomerManager : ICustomerManager
    {
        ICustomerDal _ıcustomerDal;
        public CustomerManager(ICustomerDal ıcustomerDal)
        {
            _ıcustomerDal = ıcustomerDal;
        }
        public void musteriEkle()
        {
            _ıcustomerDal.ekle();
        }

        public void musteriGuncelle()
        {
            _ıcustomerDal.guncelle();
        }

        public void müusteriListele()
        {
            _ıcustomerDal.listele();
        }

        public void müusteriSil()
        {
            _ıcustomerDal.sil();
        }
    }
}
