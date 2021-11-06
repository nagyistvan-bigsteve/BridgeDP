using System;

namespace BridgeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IView tview = new TableView();
            IView dview = new DetailsView();

            Structure person = new Person("Peti", "worker",tview);
            Structure phone = new Product("Iphone", "IOS, 2000mAh",dview);

            person.View();
            phone.View();

            person.NewDisplay(dview);
            phone.NewDisplay(new TableView());

            person.View();
            phone.View();

        }
    }
}
