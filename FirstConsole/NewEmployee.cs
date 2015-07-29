using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_class;

namespace FirstConsole
{
    class NewEmployee
    {
        static void Main(string[] args)
        {
            Employee Cindy = new Taiwaneese("Cindy");
            Cindy.Age = 20;

            Console.WriteLine("{0}來自 {2} 今年{1}歲", Cindy.Name, Cindy.Age, Cindy.Nationailty);
            Console.WriteLine("我們可以雇用他嗎?", Cindy.Hire);
            Console.ReadLine();
        }
    }
}
