using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IFamilyInfo
    {
        public string FatherName{get;set;}
        public string MotherName{get;set;}

        public int NoOfSiblings{get;set;}

   

        public  void ShowInfo(); // new keyword used to hides this method from the Ishowdata methods.

    }
}