using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Manager.ProductManager
{
    public interface IProductManager
    {
        void urunEkle();
        void urunSil();
        void urunListele();
        void urunGuncelle();
    }
}
