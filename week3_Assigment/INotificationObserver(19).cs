namespace Assessmentc_
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    public class NotificationService
    {
        private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void RegisterObserver(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"EmailNotifier received message: {message}");
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMSNotifier received message: {message}");
        }
    }

}
