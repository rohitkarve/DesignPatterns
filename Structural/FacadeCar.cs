namespace DesignPatterns.Structural {
    // Facade Pattern: Provides a simplified interface to a complex subsystem.
    public class Engine {
        public void Start() => System.Console.WriteLine("Engine started");
    }
    public class Lights {
        public void TurnOn() => System.Console.WriteLine("Lights on");
    }
    public class FacadeCar {
        private Engine _engine = new Engine();
        private Lights _lights = new Lights();
        public void StartCar() {
            _engine.Start();
            _lights.TurnOn();
        }
    }
}
