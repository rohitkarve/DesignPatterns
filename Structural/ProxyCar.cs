namespace DesignPatterns.Structural {
    // Proxy Pattern: Provides a surrogate or placeholder for another object to control access to it.
    public interface ICar {
        void Drive();
    }
    public class RealCar : ICar {
        public void Drive() {
            System.Console.WriteLine("Driving the real car");
        }
    }
    public class CarProxy : ICar {
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
