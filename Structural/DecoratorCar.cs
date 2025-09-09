namespace DesignPatterns.Structural {
    // Decorator Pattern: Adds new functionality to an object dynamically.
    public interface ICar {
        string GetDescription();
    }
    public class BasicCar : ICar {
        public string GetDescription() => "Basic Car";
    }
    public abstract class CarDecorator : ICar {
        protected ICar _car;
        public CarDecorator(ICar car) {
            _car = car;
        }
        public virtual string GetDescription() => _car.GetDescription();
    }
    public class SportsPackage : CarDecorator {
        public SportsPackage(ICar car) : base(car) {}
        public override string GetDescription() => base.GetDescription() + ", Sports Package";
    }
}
