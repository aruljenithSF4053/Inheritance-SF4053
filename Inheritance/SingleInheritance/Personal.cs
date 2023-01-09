using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class Personal
    {
        

        public string Name{get;set;}
        public string FatherName{get;set;}

        public Personal(string name, string fatherName)
        {
            Name = name;
            FatherName = fatherName;
        }

        public string ShowName()
        {
            return Name;
        }


    }
}