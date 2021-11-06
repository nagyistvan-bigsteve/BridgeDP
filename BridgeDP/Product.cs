using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
     class Product : Structure
    {
        private string Name;
        private string About;
        public Product(string name, string about, IView view)
        {
            this.Name = name;
            this.About = about;
            this.view = view;
        }

        public override void NewDisplay(IView newView)
        {
            this.view = newView;
        }

        public override void View()
        {
            view.View(this.Name, this.About);
        }
    }
}
