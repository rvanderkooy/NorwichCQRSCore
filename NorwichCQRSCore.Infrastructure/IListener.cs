namespace NorwichCQRS.Infrastructure
{
    public interface IListener
    {
        void Start();
        void Stop();
    }
}
