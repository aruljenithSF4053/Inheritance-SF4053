using System;
using System.Collections.Generic;

namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
       //create the object for employee class
        Employee employee=new Employee("Arul", "Berk","Developer");
        //show the Name from Base class Method using emp object
        System.Console.WriteLine(employee.ShowName());
        


    }
}