using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask07._14.model
{
    public class employee
    {
        public int employeeid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public int staffid { get; set; }

        public staff staff { get; set; }

    }
}
