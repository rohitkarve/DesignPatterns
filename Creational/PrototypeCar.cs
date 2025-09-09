namespace DesignPatterns.Creational {
    // Prototype Pattern: Creates new objects by copying an existing object, known as the prototype.
    public abstract class PrototypeCar {
    public string? Model { get; set; }
        public abstract PrototypeCar Clone();
    }
    public class ElectricPrototypeCar : PrototypeCar {
        public override PrototypeCar Clone() {
            return (PrototypeCar)this.MemberwiseClone();
        }
    }
}
