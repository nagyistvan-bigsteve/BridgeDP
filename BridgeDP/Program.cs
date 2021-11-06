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

            dview.View(person);
            tview.View(phone);

            person.View();
            phone.View();

            new TableView().View(phone);
            new DetailsView().View(person);


        }
    }
}
