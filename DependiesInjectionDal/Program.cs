using DependiesInjectionDal.Dal;
using DependiesInjectionDal.Dal.StudentDal;
using DependiesInjectionDal.GenericOperation;
using DependiesInjectionDal.Manager.NewFolder;
using DependiesInjectionDal.Menager.CustomerMenager;
using DependiesInjectionDal.Menager.StudentMeneger;
using System;

namespace DependiesInjectionDal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string param = "KAdir öğrencisi";

            // CustomerManeger, Dal katmanı olan Dependency Injection örneği
            //Katmanlı mimaride kullanılan
            CustomerManager customerManager = new CustomerManager(new CustomerDal());
            customerManager.musteriEkle();

            // StudentManager, Dal katmanı olan ve Generic operation'u paremetre alan Dependency Injection örneği
            StudentManager studentrManager = new StudentManager(new StudentDal(param));
            studentrManager.ogremciEkle();

            // ProductManager, Dal katmanı olmayan Dependency Injection
            ProductManager productManeger = new ProductManager(new Operation());
            productManeger.urunSil();

            //Dependency Injection Maneger klosörünün altındaki Maneger.cs lerde ctor da yapılan enjekte şekli
            //Dependency Injection Interface entegre edersin

        }
    }
}
