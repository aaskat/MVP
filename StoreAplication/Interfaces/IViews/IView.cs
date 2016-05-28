namespace StoreAplication.Interfaces.IViews
{
    public interface IView<in TCallbacks>
    {
        void Attach(TCallbacks presenterCallbacks);
        void Show();
    }
}
