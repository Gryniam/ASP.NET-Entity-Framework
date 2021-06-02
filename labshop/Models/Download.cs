using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labshop.Models
{
    public class Download
    {
        public int DownloadId { get; set; }

        public string TovarName { get; set; }
        public string Link { get; set; }
        public string DemoLink { get; set; }
    }
}
