namespace StoreAplication.Interfaces.View
{
    public interface IView<in TCallbacks>
    {
        void Attach(TCallbacks presenterCallbacks);
        void Show();
    }
}
