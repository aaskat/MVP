using System;
using StoreAplication.Interfaces.Presenter;
using StoreAplication.Interfaces.View;

namespace StoreAplication.Presenter
{
    public class MainPresenter : IMainPresenter, IMainPresenterCallbacks
    {
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
        }

        public object View
        {
            get { return _view; }
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            _view.Attach(this);
            _view.Show();
        }
    }
}