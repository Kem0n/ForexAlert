using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexAlert
{
    public class API
    {
        public bool status { get; set; }
        public string msg { get; set; }
        public response[] response { get; set; }
        public info info { get; set; }
    }
}
