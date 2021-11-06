using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public abstract class Structure
    {
        protected IView view;
        public string name { get; set; }
        public string about { get; set; }

        public Structure(string Name, string About)
        {
            this.name = Name;
            this.about = About;
        }
        public abstract void View();
        
    }
}
