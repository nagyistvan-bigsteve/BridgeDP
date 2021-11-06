using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    class Person : Structure
    {
        private string Name { get; set; }
        private string About { get; set; }
        public Person(string Name, string about, IView view)
        {
            this.Name = Name;
            this.About = about;
            this.view = view;
        }

        public override void View()
        {
            view.View(this.Name, this.About);
        }

        public override void NewDisplay(IView newView)
        {
            this.view = newView;
        }
    }
}
