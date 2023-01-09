using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public enum Degree{select, BE,BTECH}
    public enum Department{select, EEE,ECE,IT,CSE}
    public class StudentInfo:PersonalInfo
    {
        private int _studentID=100;
        public string StudentID{get;set;}

        public Degree Degree{get;set;}

        public Department Department{get;set;}

        public StudentInfo(string name,string fatherName,Gender gender,int age,Degree degree,Department department):base(name,fatherName,gender,age)
        {
            _studentID++;
            this.StudentID="SID"+_studentID;
            Degree=degree;
            Department=department;

        }
    }
}