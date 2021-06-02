using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labshop.Models
{
    public class BuyTovar
    {
        public int BuyTovarId { get; set; }
        public string UserMail { get; set; }
        public string TovarName { get; set; }
        public DateTime DateTime { get; set; }

    }
}
