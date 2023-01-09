using System;
namespace HierarchicalInheritance;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student1=new StudentInfo("arul","jenith",Gender.Male,21,Degree.BE,Department.IT);
        System.Console.WriteLine($"{student1.StudentID} || {student1.Name}  || {student1.FatherName}  ||  {student1.Gender}   || {student1.Age}   || {student1.Degree}    || {student1.Department} ");

        System.Console.WriteLine(" ");

        TeacherInfo teacher1=new TeacherInfo("Baskaran","Sethu",Gender.Male,36,Department.CSE,"Programming in c",5);
        System.Console.WriteLine($"{teacher1.TeacherID} || {teacher1.Name}  || {teacher1.FatherName}    || {teacher1.Gender}    || {teacher1.Age}   || {teacher1.Department}   || {teacher1.SubjectTaken}   || {teacher1.YearOfExperience}");
    }
}