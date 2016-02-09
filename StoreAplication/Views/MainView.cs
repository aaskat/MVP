using System.Windows.Forms;
using StoreAplication.Interfaces.Presenter;
using StoreAplication.Interfaces.View;

namespace StoreAplication.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void Attach(IMainPresenterCallbacks presenterCallbacks)
        {
            //throw new NotImplementedException();
        }
    }
}
