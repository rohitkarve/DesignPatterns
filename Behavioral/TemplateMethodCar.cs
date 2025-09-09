namespace DesignPatterns.Behavioral {
    // Template Method Pattern: Defines the skeleton of an algorithm, deferring some steps to subclasses.
    public abstract class CarTemplate {
        public void BuildCar() {
            AssembleBody();
            InstallEngine();
            AddWheels();
        }
        protected abstract void AssembleBody();
        protected abstract void InstallEngine();
        protected abstract void AddWheels();
    }
    public class SedanCar : CarTemplate {
        protected override void AssembleBody() {
            System.Console.WriteLine("Assembling sedan body");
        }
        protected override void InstallEngine() {
            System.Console.WriteLine("Installing sedan engine");
        }
        protected override void AddWheels() {
            System.Console.WriteLine("Adding sedan wheels");
        }
    }
}
