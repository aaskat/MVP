using System;
using System.Windows.Forms;
using StoreAplication.Presenter;
using StoreAplication.View;

namespace StoreAplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new MainView());
            presenter.Run();
            Application.Run();
            
        }
    }
}

