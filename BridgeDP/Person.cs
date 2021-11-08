using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    class Person : Structure
    {
        private string Name;
        private string About;
        public Person(string name, string about, IView view) : base(view)
        {
            this.Name = name;
            this.About = about;
        }

        public override void NewDisplay(IView newView)
        {
            this.view = newView;
        }

        public override void View()
        {
            this.view.View(this.Name, this.About);
        }
    }
}
