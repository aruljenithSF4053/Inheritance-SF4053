using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public enum Gender{select,Male,Female}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}

        public int Age{get;set;}

        public PersonalInfo(string name,string fatherName,Gender gender,int age)
        {
            this.Name=name;
            this.FatherName=fatherName;
            this.Gender=gender;
            this.Age=age;
        }
    }
}