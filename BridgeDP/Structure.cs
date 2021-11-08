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
     
        protected Structure(IView view)
        {
            this.view = view;
        }
        public abstract void View();

        public abstract void NewDisplay(IView newView);
        
    }
}
