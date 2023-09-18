using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Object
    {
        public int id { get; set; }
        public string name { get; set; }
        public float area { get; set; }

        public Object() 
        {
            area = 0;
        }

        public override string ToString()
        {
            return id.ToString() + " - " + name;
        }        
    }
}
