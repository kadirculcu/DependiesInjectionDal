using DependiesInjectionDal.GenericOperation;
using DependiesInjectionDal.Manager.ProductManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Manager.NewFolder
{
    public class ProductManager : IProductManager
    {
        Ioperation _ıoperation;
        public ProductManager(Ioperation ıoperation)
        {
            _ıoperation = ıoperation;
        }
        public void urunEkle()
        {
            _ıoperation.ekle();
        }

        public void urunGuncelle()
        {
            _ıoperation.guncelle();
        }

        public void urunListele()
        {
            _ıoperation.listele();
        }

        public void urunSil()
        {
            _ıoperation.sil();
        }
    }
}
