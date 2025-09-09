namespace DesignPatterns.Creational {
    // Builder Pattern: Separates the construction of a complex object from its representation.
    public class Car {
        public string Engine { get; set; }
        public string Body { get; set; }
        public string Wheels { get; set; }
        public override string ToString() => $"Engine: {Engine}, Body: {Body}, Wheels: {Wheels}";
    }
    public interface ICarBuilder {
        void BuildEngine();
        void BuildBody();
        void BuildWheels();
        Car GetCar();
    }
    public class SportsCarBuilder : ICarBuilder {
        private Car _car = new Car();
        public void BuildEngine() => _car.Engine = "V8";
        public void BuildBody() => _car.Body = "Coupe";
        public void BuildWheels() => _car.Wheels = "Alloy";
        public Car GetCar() => _car;
    }
    public class Director {
        public void Construct(ICarBuilder builder) {
            builder.BuildEngine();
            builder.BuildBody();
            builder.BuildWheels();
        }
    }
}
