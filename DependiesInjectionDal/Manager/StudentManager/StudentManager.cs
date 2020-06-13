using DependiesInjectionDal.Dal.StudentDal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Menager.StudentMeneger
{
    public class StudentManager : IStudentManager
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void ogremciEkle()
        {
            _studentDal.ekle();
        }

        public void ogrenciGuncelle()
        {
            _studentDal.guncelle();
        }

        public void ogrenciListele()
        {
            _studentDal.listele();
        }

        public void ogrenciSil()
        {
            _studentDal.sil();
        }
    }
}
