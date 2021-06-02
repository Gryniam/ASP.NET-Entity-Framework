using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labshop.Models
{
    public class Tovar
    {
        public int TovarId { get; set; }
        public string TovarName { get; set; }
        public string TovarPrice { get; set; }
        public int NumberOfPur { get; set; }
    }
}
