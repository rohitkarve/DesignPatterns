using System.Collections.Generic;
namespace DesignPatterns.Behavioral {
    // Observer Pattern: Defines a one-to-many dependency between objects.
    public interface IObserver {
        void Update(string message);
    }
    public interface ISubject {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
    public class CarSubject : ISubject {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);
        public void Notify(string message) {
            foreach (var observer in _observers) {
                observer.Update(message);
            }
        }
    }
    public class CarObserver : IObserver {
        public void Update(string message) {
            System.Console.WriteLine($"CarObserver received: {message}");
        }
    }
}
