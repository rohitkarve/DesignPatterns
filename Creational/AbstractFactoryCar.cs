namespace DesignPatterns.Creational {
    // Abstract Factory Pattern: Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    public interface ICarFactory {
        IEngine CreateEngine();
        IBody CreateBody();
    }
    public interface IEngine {
        string GetEngineType();
    }
    public interface IBody {
        string GetBodyType();
    }
    public class LuxuryEngine : IEngine {
        public string GetEngineType() => "Luxury Engine";
    }
    public class LuxuryBody : IBody {
        public string GetBodyType() => "Luxury Body";
    }
    public class EconomyEngine : IEngine {
        public string GetEngineType() => "Economy Engine";
    }
    public class EconomyBody : IBody {
        public string GetBodyType() => "Economy Body";
    }
    public class LuxuryCarFactory : ICarFactory {
        public IEngine CreateEngine() => new LuxuryEngine();
        public IBody CreateBody() => new LuxuryBody();
    }
    public class EconomyCarFactory : ICarFactory {
        public IEngine CreateEngine() => new EconomyEngine();
        public IBody CreateBody() => new EconomyBody();
    }
}
