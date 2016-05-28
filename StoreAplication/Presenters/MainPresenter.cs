using System;
using System.Linq;
using StoreAplication.Interfaces.IPresenters;
using StoreAplication.Interfaces.IRepositories;
using StoreAplication.Interfaces.IViews;

namespace StoreAplication.Presenters
{
    public class MainPresenter : IMainPresenter, IMainPresenterCallbacks
    {
        private IMainRepository _repository;
        private readonly IMainView _view;

        public MainPresenter(IMainView view, 
            IMainRepository repository)
        {
            _view = view;
            _repository = repository;
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
            var products = _repository.GetAll().ToList();
            _view.SetProducts(products);
        }
    }
}