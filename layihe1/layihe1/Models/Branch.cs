using System;
using System.Collections.Generic;
using System.Text;

namespace layihe1.Models
{
    public class Branch :BaseModel 
    {
        public string address { get; set; }
        public int budget { get; set; } 
        public List<Employee> employees { get; set; }

    }
}
