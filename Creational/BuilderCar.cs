namespace DesignPatterns.Creational {
    // Builder Pattern: Separates the construction of a complex object from its representation.
    public class BuilderCar {
    public string? Engine { get; set; }
    public string? Body { get; set; }
    public string? Wheels { get; set; }
        public override string ToString() => $"Engine: {Engine}, Body: {Body}, Wheels: {Wheels}";
    }
    public interface ICarBuilder {
        void BuildEngine();
        void BuildBody();
        void BuildWheels();
        BuilderCar GetCar();
    }
    public class SportsCarBuilder : ICarBuilder {
        private BuilderCar _car = new BuilderCar();
        public void BuildEngine() => _car.Engine = "V8";
        public void BuildBody() => _car.Body = "Coupe";
        public void BuildWheels() => _car.Wheels = "Alloy";
        public BuilderCar GetCar() => _car;
    }
    public class Director {
        public void Construct(ICarBuilder builder) {
            builder.BuildEngine();
            builder.BuildBody();
            builder.BuildWheels();
        }
    }
}
