namespace DesignPatterns.Creational {
    // Factory Method Pattern: Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.
    public abstract class CarFactory {
        public abstract ICar CreateCar();
    }
    public interface ICar {
        string GetDetails();
    }
    public class Sedan : ICar {
        public string GetDetails() => "Sedan Car";
    }
    public class SUV : ICar {
        public string GetDetails() => "SUV Car";
    }
    public class SedanFactory : CarFactory {
        public override ICar CreateCar() => new Sedan();
    }
    public class SUVFactory : CarFactory {
        public override ICar CreateCar() => new SUV();
    }
}
