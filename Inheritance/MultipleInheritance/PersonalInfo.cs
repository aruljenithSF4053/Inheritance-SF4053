using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class PersonalInfo:IShowData
    {
        public string Name{get;set;}
        public string Gender{get;set;}
        public int Age{get;set;}

        public PersonalInfo(string name,string gender,int age)
        {
            Name=name;
            Gender=gender;
            this.Age=age;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine(Name+""+Gender+""+Age);
        }
    }
}