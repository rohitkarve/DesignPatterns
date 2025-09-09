namespace DesignPatterns.Creational {
    // Prototype Pattern: Creates new objects by copying an existing object, known as the prototype.
    public abstract class CarPrototype {
        public string Model { get; set; }
        public abstract CarPrototype Clone();
    }
    public class ElectricCar : CarPrototype {
        public override CarPrototype Clone() {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
}
