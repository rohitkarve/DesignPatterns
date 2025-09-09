namespace DesignPatterns.Structural {
    // Decorator Pattern: Adds new functionality to an object dynamically.
    public interface IDecoratorCar {
        string GetDescription();
    }
    public class BasicCar : IDecoratorCar {
        public string GetDescription() => "Basic Car";
    }
    public abstract class CarDecorator : IDecoratorCar {
        protected IDecoratorCar _car;
        public CarDecorator(IDecoratorCar car) {
            _car = car;
        }
        public virtual string GetDescription() => _car.GetDescription();
    }
    public class SportsPackage : CarDecorator {
        public SportsPackage(IDecoratorCar car) : base(car) {}
        public override string GetDescription() => base.GetDescription() + ", Sports Package";
    }
}
