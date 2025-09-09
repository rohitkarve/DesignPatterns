namespace DesignPatterns.Structural {
    // Bridge Pattern: Decouples an abstraction from its implementation so that the two can vary independently.
    public interface IEngine {
        string Start();
    }
    public class PetrolEngine : IEngine {
        public string Start() => "Petrol engine started";
    }
    public class DieselEngine : IEngine {
        public string Start() => "Diesel engine started";
    }
    public abstract class Car {
        protected IEngine engine;
        public Car(IEngine engine) {
            this.engine = engine;
        }
        public abstract string Drive();
    }
    public class Sedan : Car {
        public Sedan(IEngine engine) : base(engine) {}
        public override string Drive() => $"Sedan driving with {engine.Start()}";
    }
}
