namespace DesignPatterns.Structural {
    // Proxy Pattern: Provides a surrogate or placeholder for another object to control access to it.
    public interface IProxyCar {
        void Drive();
    }
    public class RealCar : IProxyCar {
        public void Drive() {
            System.Console.WriteLine("Driving the real car");
        }
    }
    public class CarProxy : IProxyCar {
        private RealCar _realCar;
        public CarProxy() {
            _realCar = new RealCar();
        }
        public void Drive() {
            System.Console.WriteLine("Proxy checks access");
            _realCar.Drive();
        }
    }
}
