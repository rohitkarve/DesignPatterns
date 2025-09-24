namespace DesignPatterns.Behavioral {
    // Strategy Pattern: Defines a family of algorithms, encapsulates each one, and makes them interchangeable.
    public interface IDriveStrategy {
        void Drive();
    }
    public class EcoDrive : IDriveStrategy {
        public void Drive() {
            System.Console.WriteLine("Eco driving mode");
        }
    }
    public class SportDrive : IDriveStrategy {
        public void Drive() {
            System.Console.WriteLine("Sport driving mode");
        }
    }
    public class StrategyCar {
        private IDriveStrategy _strategy;
        public StrategyCar(IDriveStrategy strategy) {
            _strategy = strategy;
        }
        public void PerformDrive() {
            _strategy.Drive();
        }
    }
}
