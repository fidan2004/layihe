using layihe1.Data;
using layihe1.Models;
using layihe1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace layihe1.Services.Implementations
{
    public class BranchService : IBranchService<Branch>
    {
        public Bank<Branch> data;
        public BranchService()
        {
            data = new Bank<Branch>();
        }
        public void Create(Branch branch)
        {
            if (branch.softDelete == false)
            {
                data.Datas.Add(branch);
            }
        }

        public void Delete(string name)
        {
            Branch brnc = data.Datas.Find(x => x.name.ToLower().Trim() == name.ToLower().Trim());
            brnc.softDelete = true;
            GetAll();
        }

        public void GetAll()
        {
            foreach (var brnch in data.Datas.Where(m => m.softDelete = false))
            {
                Console.WriteLine(brnch.name + " " + brnch.address + " " + brnch.budget);
            }
        }

        public void Get(string filter)
        {
            try
            {
                Branch brnch = data.Datas.Find(x => x.name.Contains(filter.ToLower().Trim()) || x.address.Contains(filter.ToLower().Trim()));
                Console.WriteLine(brnch.name + " " + brnch.address);
            }
            catch (Exception)
            {
                Console.WriteLine("branch wasnt found");
            }
        }
    }

        public void GetProfit(Branch branch,Employee employee)
        {
        int lastbudget = branch.budget - employee.salary;
        Console.WriteLine(lastbudget);
         }

        public void HireEmployee()
        {


        }

        public void TransferEmployee()
        {
            throw new NotImplementedException();
        }

        public void TransferMoney()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
