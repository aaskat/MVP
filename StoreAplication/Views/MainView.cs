using System.Collections.Generic;
using System.Windows.Forms;
using StoreAplication.Interfaces.IPresenters;
using StoreAplication.Interfaces.IViews;
using StoreAplication.Models;

namespace StoreAplication.Views
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

        public void SetProducts(List<Product> products)
        {
            _productObjectListView.SetObjects(products);
        }
    }
}
