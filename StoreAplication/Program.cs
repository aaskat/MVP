using System;
using System.Windows.Forms;
using StoreAplication.Presenters;
using StoreAplication.Repositories;
using StoreAplication.Views;

namespace StoreAplication
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new MainView(), new MainRepository(new StoreAplicationContext()));
            presenter.Run();
            Application.Run();
        }
    }
}

