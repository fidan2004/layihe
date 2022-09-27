using layihe1.Data;
using layihe1.Models;
using layihe1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace layihe1.Services.Implementations
{
    public class EmployeeService : IEmployeeService<Employee>
    {
        private Bank<Employee> data;
        public EmployeeService()
        {
            data = new Bank<Employee>();
        }

        public void Create(Employee emplye)
        {
            if (emplye.softDelete == false)
            {
                data.Datas.Add(emplye);
            }
        }

        public void Delete(string name)
        {
            Employee emp = data.Datas.Find(x => x.name.ToLower().Trim() == name.ToLower().Trim());
            emp.softDelete = true;
            GetAll();

        }

        public void Get(string filter)
        {
            try
            {
                Employee emp = data.Datas.Find(x => x.name.Contains(filter.ToLower().Trim()) || x.surname.Contains(filter.ToLower().Trim()));
                Console.WriteLine(emp.name + " " + emp.surname); 
            }
            catch (Exception)
            {
                Console.WriteLine("employee wasnt found");
            }
        }

        public void GetAll()
        {
            foreach (var empl in data.Datas.Where(m => m.softDelete = false))
            {
                Console.WriteLine(empl.name + " " + empl.surname);
            }
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
