using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstblood
{
    class Restoraunt
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Human> Owners { get; set; }
        public Kitchen Kitchen { get; set; }
        public List<Hall> Halls { get; set; }
        public Bar Bar { get; set; }
    }
}
