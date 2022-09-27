using layihe1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace layihe1.Services.Interfaces
{
    public interface IBankService
    {
        public void Create(Employee emplye);
        public void Update();
        public void Delete(string name);
        public void Get(string filter);
        public void GetAll();
    }
}
