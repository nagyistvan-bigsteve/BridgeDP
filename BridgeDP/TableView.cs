using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
     class TableView : IView
    {
        public void View(Structure structure)
        {
            Console.WriteLine("Table view:");
            Console.WriteLine("-------------");
            Console.WriteLine("| "+structure.name+" |");
            Console.WriteLine("-------------");
            Console.WriteLine("| " +structure.about+" |");
            Console.WriteLine("------------- \n");

        }
    }
}
