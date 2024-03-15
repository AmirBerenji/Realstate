using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate.Model
{
    public class Property
    {
        public string DefaultImage { get; set; }
        public string Address { get; set;}
        public int Price { get; set;}
        public List<string> Images { get; set;}
    }
}
