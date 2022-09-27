using layihe1.Models;
using System;
using System.Collections.Generic;

namespace layihe1
{
    public class Program
    {
       public static List< Employee> employee = new List<Employee>();
        static void Main(string[] args)
        {
            SeedDataBase(employee);


        }

        
        public static void SeedDataBase(List<Employee> employee)
        {
            Employee emp1 = new Employee("Fidan", "Karimova", 2000, "Developer", false);
            Employee emp2 = new Employee("Jale", "Abilova", 3000, "server", false);
            Employee emp3 = new Employee("omer", "Aliyeva", 4000, "translator", false);
            Employee emp4 = new Employee("Ayxan", "Karimli", 5000, "teacher", false);
            Employee emp5 = new Employee("Aylin", "Priyeva", 6000, "backend", false);
            Employee emp6 = new Employee("Jasmin", "Suleymanli", 7000, "frontend", false);
            employee.Add(emp1);
            employee.Add(emp2);
            employee.Add(emp3);
            employee.Add(emp4);
            employee.Add(emp5);
            employee.Add(emp6);
        }
    }
}
