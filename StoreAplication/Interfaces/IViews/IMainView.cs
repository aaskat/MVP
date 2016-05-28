using System.Collections.Generic;
using StoreAplication.Interfaces.IPresenters;
using StoreAplication.Models;

namespace StoreAplication.Interfaces.IViews
{
    public interface IMainView : IView<IMainPresenterCallbacks>
    {
        void SetProducts(List<Product> products);
    }
}