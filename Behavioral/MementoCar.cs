namespace DesignPatterns.Behavioral {
    // Memento Pattern: Captures and restores an object's internal state.
    public class CarMemento {
        public string State { get; private set; }
        public CarMemento(string state) {
            State = state;
        }
    }
    public class MementoCar {
    public string? State { get; set; }
    public CarMemento SaveState() => new CarMemento(State ?? string.Empty);
        public void RestoreState(CarMemento memento) {
            State = memento.State;
        }
    }
}
