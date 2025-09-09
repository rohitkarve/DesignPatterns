using System.Collections.Generic;
namespace DesignPatterns.Structural {
    // Composite Pattern: Composes objects into tree structures to represent part-whole hierarchies.
    public interface ICarComponent {
        void ShowDetails();
    }
    public class CarLeaf : ICarComponent {
        private string _name;
        public CarLeaf(string name) {
            _name = name;
        }
        public void ShowDetails() {
            System.Console.WriteLine(_name);
        }
    }
    public class CarComposite : ICarComponent {
        private List<ICarComponent> _components = new List<ICarComponent>();
        public void Add(ICarComponent component) {
            _components.Add(component);
        }
        public void ShowDetails() {
            foreach (var component in _components) {
                component.ShowDetails();
            }
        }
    }
}
