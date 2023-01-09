using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class RegisterPerson : PersonalInfo, IFamilyInfo//,IShowData // we can implement multiple interface using interfaces.
    {
        private int _registrationID=100;

        public string RegistrationID{get;set;}

        public DateTime DateOfRegistration{get;set;}
        public string FatherName { get;set; }
        public string MotherName { get;set; }
        public int NoOfSiblings {get;set; }

        public RegisterPerson(string name, string gender, int age,string fatherName,string motherName,int noOfSiblings,DateTime date) : base(name, gender, age)
        {
            _registrationID++;
            RegistrationID="RID"+_registrationID;
            
            FatherName=fatherName;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            DateOfRegistration=date;
        }

        public new void ShowInfo()
        {
            System.Console.WriteLine(RegistrationID+"||"+Name+"||"+Gender+"||"+Age+"||"+FatherName+"||"+MotherName+"||"+NoOfSiblings+"||"+DateOfRegistration);
        }

      
    }
}