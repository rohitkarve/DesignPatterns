using System.Collections.Generic;
namespace DesignPatterns.Structural {
    // Flyweight Pattern: Reduces memory usage by sharing as much data as possible with similar objects.
    public class CarFlyweight {
        public string Color { get; private set; }
        public CarFlyweight(string color) {
            Color = color;
        }
        public void Display(string model) {
            System.Console.WriteLine($"Car Model: {model}, Color: {Color}");
        }
    }
    public class CarFlyweightFactory {
        private Dictionary<string, CarFlyweight> _flyweights = new Dictionary<string, CarFlyweight>();
        public CarFlyweight GetCar(string color) {
            if (!_flyweights.ContainsKey(color)) {
                _flyweights[color] = new CarFlyweight(color);
            }
            return _flyweights[color];
        }
    }
}
