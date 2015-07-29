using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class
{

    public class Taiwaneese : Employee
    {
        public Taiwaneese(string name)
        {
            this.Name = name;
        }

        public int Age{ get; set; }

        public string Name{ get; set; }

        public string Nationailty
        {
            get { return "中華台北"; }
        }

        public bool Hire{ get; }
    }
}
