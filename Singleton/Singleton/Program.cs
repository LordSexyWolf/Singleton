using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudentDetails();
            PrintEmployeeDetails();

            Console.WriteLine("-------------------------------------");

            Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            derivedObj.PrintDetails("From Derived");

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}