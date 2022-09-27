using System;
using System.Collections.Generic;
using System.Text;

namespace layihe1.Services.Interfaces
{
    public interface IBranchService<T> : IBankService
    {
        public void HireEmployee();
        public void GetProfit();
        public void TransferMoney();
        public void TransferEmployee();
    }
}
