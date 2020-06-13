using DependiesInjectionDal.GenericOperation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependiesInjectionDal.Dal.StudentDal
{
   public class StudentDal:OperationParemeter,IStudentDal
   {
        public StudentDal(String param):base(param)
        {

        }
   }
}
