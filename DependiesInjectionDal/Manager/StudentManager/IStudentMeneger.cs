using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Menager.StudentMeneger
{
    public interface IStudentManager
    {
        void ogremciEkle();
        void ogrenciSil();
        void ogrenciListele();
        void ogrenciGuncelle();
    }
}
