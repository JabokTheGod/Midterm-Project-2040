using System;

namespace MidtermProject
{
    public class Employee
    {
        private string firstName { get; }
        private string lastName { get; }
        private string id { get; }
        private EmployeeType empType { get; }

        //Enumerator
        public enum EmployeeType
        {
            Sales,
            Manager,
            Production
        }

        //Contructor
        public Employee(string getfirstName, string getlastName, string getid, EmployeeType getType)
        {
            firstName = getfirstName;
            lastName = getlastName;
            id = getid;
            empType = getType;
        }
        
        public void getEmployeeInfo(string getfirstName, string getlastName, string getid, EmployeeType getType) 
        {
            Console.WriteLine("Name: " , getfirstName , " " , getlastName);
            Console.WriteLine("ID: " , getid);
            Console.WriteLine("Type: " , getType);
        }
    }
}

//Constructors do not have a return type, but you can pass values by reference using the ref keyword.

//to pull/use a variable from a namespace
//using My.Other.Namespace

// //SalesPerson
//         namespace SalesPerson
//         {
//             class SalesPerson 
//             {
                
//             }
//         }
//         //Manager
//         namespace Manager
//         {
//             class Manager 
//             {

//             }
//         }

//static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }

//comment ctrl + K + C
//uncomment ctrl + K + U