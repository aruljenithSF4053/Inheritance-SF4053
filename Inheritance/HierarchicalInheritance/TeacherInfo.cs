using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class TeacherInfo:PersonalInfo
    {
        private int _teacherID=200;
        public string TeacherID{get;set;}
        public Department Department{get;set;}
        public string SubjectTaken{get;set;}
        public int YearOfExperience{get;set;}

        public TeacherInfo(string name,string fatherName,Gender gender,int age,Department department,string subjectTaken,int yearOfExperience):base(name,fatherName,gender,age)
        {
            _teacherID++;
            TeacherID="TID"+_teacherID;
            Department=department;
            SubjectTaken=subjectTaken;
            YearOfExperience=yearOfExperience;
        }
    }
}