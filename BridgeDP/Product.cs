using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
     class Product : Structure
    {
        public Product(string Name, string About, IView view) : base(Name, About)
        {
            this.view = view;
        }

        public override void View()
        {
            view.View(this);
        }
    }
}
