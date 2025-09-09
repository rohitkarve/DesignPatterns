namespace DesignPatterns.Behavioral {
    // State Pattern: Allows an object to alter its behavior when its internal state changes.
    public interface ICarState {
        void Handle(CarContext context);
    }
    public class CarContext {
        public ICarState State { get; set; }
        public CarContext(ICarState state) {
            State = state;
        }
        public void Request() {
            State.Handle(this);
        }
    }
    public class ParkedState : ICarState {
        public void Handle(CarContext context) {
            System.Console.WriteLine("Car is parked");
            context.State = new DrivingState();
        }
    }
    public class DrivingState : ICarState {
        public void Handle(CarContext context) {
            System.Console.WriteLine("Car is driving");
            context.State = new ParkedState();
        }
    }
}
