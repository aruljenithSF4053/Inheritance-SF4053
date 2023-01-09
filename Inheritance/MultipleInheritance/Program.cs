using System;
namespace MultipleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson person =new RegisterPerson("Arul","Male",21,"Berkmans","Arockiamary",3,DateTime.Now);
        person.ShowInfo();
    }
}