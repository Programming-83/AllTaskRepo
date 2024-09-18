using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Employee
    {
        public int Eid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
  
        public static List<Employee> getEmployees()
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee();
        //First Employee
            emp1.Eid = 1; emp1.name = "JOJo"; emp1.age = 25; emp1.city = "Mirzapur";
            empList.Add(emp1);
            // Second Employee
            Employee emp2 = new Employee();
            emp2.Eid = 2; emp2.name = "AOAO"; emp2.age = 26; emp2.city = "MI";
            empList.Add(emp2);
            //Third Employee
            Employee emp3 = new Employee();
            emp3.Eid = 3; emp3.name = "UOUO"; emp3.age = 24; emp3.city = " Pahon";
            empList.Add(emp3);
            //Fourth Employee
            Employee emp4= new Employee();
            emp4.Eid = 4; emp4.name = "POPO"; emp4.age = 28; emp4.city = "Domanpur";
            empList.Add(emp4);
            //Fifth Employee
            Employee emp5= new Employee();
            emp5.Eid = 5; emp5.name = "SOSO"; emp5.age = 27; emp5.city = "GU";
            empList.Add(emp5);
        return empList;
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                List<Employee> empList=  Employee.getEmployees();
            var city_name = empList.Select(x => x.city);
            foreach ( var city in city_name )
            {
                Console.WriteLine(city);
               
            }
            Console.ReadLine();
        }
        
        
        }

    }





