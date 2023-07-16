using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask07._14.model
{
    public class staff
    {
        public int staffid { get; set; }
        public string staffname { get; set; }
        public string staffdescription { get; set;}
        public ICollection<staff> staffs { get; set; }
    }

    
}
