using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    class DetailsView : IView
    {
        public void View(string name, string about)
        {
            Console.WriteLine("Details view:");
            Console.WriteLine(name);
            Console.WriteLine(about +"\n");
        }
    }
}
