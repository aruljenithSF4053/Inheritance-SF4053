using System;
namespace MultiLevel;

class Program
{
    public static void Main(string[] args)
    {
        //1.Aathar 
        PersonalDetails personal =new ("Ravi","chandran","gender",new DateTime(1999,11,11));
        System.Console.WriteLine("AadharID :" +personal.AadharID+ " Name: "+personal.Name+" FatherName: "+personal.FatherNmae+" ");
        System.Console.WriteLine("Gender: "+personal.Gender +" DOB: "+personal.DOB.ToString("dd/MM/yyyy"));

        //2.Student Registrstion 
        StudentDetails student=new(112,"arul","chandran","Male",new DateTime(2000,12,11),"I");
        System.Console.WriteLine("StudentID : "+student.StudentID+" AadharID : "+student.AadharID+" name "+student.Name+"FatherName :"+student.FatherNmae);
        System.Console.WriteLine("Gender "+student.Gender+ " DOB "+student.DOB.ToString("dd/MM/yyyy")+ "Standard :"+student.Standard);
        

        //4.Employement Application

        Employment user=new("SF102",190,"arul","jenith","male",new DateTime(2001,07,05),"XII",DateTime.Now);
        System.Console.WriteLine("EmploymentID: "+user.EmploymentID+"StudentID " +user.StudentID+" AadharID : "+user.AadharID+" name "+user.Name+"FatherName :"+user.FatherNmae);
        System.Console.WriteLine("Gender "+user.Gender+ " DOB "+user.DOB.ToString("dd/MM/yyyy")+"Standard :"+student.Standard+"Date of Registration "+user.DateOfRegistrstion);

        

    }
}