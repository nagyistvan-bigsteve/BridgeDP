using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
     class TableView : IView
    {
        public void View(string name, string about)
        {
            Console.WriteLine("Table view:");
            Console.WriteLine("-------------");
            Console.WriteLine("| "+name+" |");
            Console.WriteLine("-------------");
            Console.WriteLine("| " +about+" |");
            Console.WriteLine("------------- \n");

        }
    }
}
