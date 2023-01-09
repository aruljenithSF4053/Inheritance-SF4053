using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class PersonalDetails
    {
        private static int s_aadharID=100;

        public int AadharID{get;}

        public string Name {get;set;}

        public string FatherNmae{get;set;}

        public string Gender{get;set;}

        public DateTime DOB{get;set;}

        //public PersonalDetails(){}
      

        public PersonalDetails(string name,string fatherName,string gender,DateTime dob)
        {
            s_aadharID++;
            AadharID=s_aadharID;
            Name=name;
            FatherNmae=fatherName;
            Gender=gender;
            DOB=dob;
        }

        public PersonalDetails(int aadharID,string name,string fatherName,string gender,DateTime dob)
        {
            s_aadharID++;
            AadharID=s_aadharID;
            Name=name;
            FatherNmae=fatherName;
            Gender=gender;
            DOB=dob;
            AadharID=aadharID;
        }
    }
}