using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class Employee:Personal
    {
        public string Role{get;set;}

        public Employee(string name,string fatherName,string role):base(name,fatherName)
        {
            Role=role;
        }
    }
}