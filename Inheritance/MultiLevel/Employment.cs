using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class Employment:StudentDetails
    {
        private static int _employmentID=100;

        public string EmploymentID{get;}

        public DateTime DateOfRegistrstion{get;set;}

        public Employment(string studentID,int aadharID,string name,string fatherName,string gender,DateTime dob,string standard,DateTime dateOfRegistrstion):
                            base(studentID,aadharID,name,fatherName,gender,dob,standard)
        {
            _employmentID++;
            EmploymentID="ER"+_employmentID;
            DateOfRegistrstion=dateOfRegistrstion;
        }
    }
}