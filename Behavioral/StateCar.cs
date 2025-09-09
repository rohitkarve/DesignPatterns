namespace DesignPatterns.Behavioral {
    // State Pattern: Allows an object to alter its behavior when its internal state changes.
    public interface ICarState {
        void Handle(StateCarContext context);
    }
    public class StateCarContext {
        public ICarState State { get; set; }
        public StateCarContext(ICarState state) {
            State = state;
        }
        public void Request() {
            State.Handle(this);
        }
    }
    public class ParkedState : ICarState {
        public void Handle(StateCarContext context) {
            System.Console.WriteLine("Car is parked");
            context.State = new DrivingState();
        }
    }
    public class DrivingState : ICarState {
        public void Handle(StateCarContext context) {
            System.Console.WriteLine("Car is driving");
            context.State = new ParkedState();
        }
    }
}
