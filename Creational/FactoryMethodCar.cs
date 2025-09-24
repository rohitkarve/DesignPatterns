namespace DesignPatterns.Creational {
    // Factory Method Pattern: Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.
    public abstract class CarFactory {
        public abstract IFactoryCar CreateCar();
    }
    public interface IFactoryCar {
        string GetDetails();
    }
    public class Sedan : IFactoryCar {
        public string GetDetails() => "Sedan Car";
    }
    public class SUV : IFactoryCar {
        public string GetDetails() => "SUV Car";
    }
    public class SedanFactory : CarFactory {
        public override IFactoryCar CreateCar() => new Sedan();
    }
    public class SUVFactory : CarFactory {
        public override IFactoryCar CreateCar() => new SUV();
    }
}
