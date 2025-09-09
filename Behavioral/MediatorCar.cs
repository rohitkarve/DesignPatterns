namespace DesignPatterns.Behavioral {
    // Mediator Pattern: Defines an object that encapsulates how a set of objects interact.
    public interface IMediator {
        void Notify(object sender, string ev);
    }
    public class CarMediator : IMediator {
        public void Notify(object sender, string ev) {
            System.Console.WriteLine($"Mediator received: {ev}");
        }
    }
    public class CarComponent {
        private IMediator _mediator;
        public CarComponent(IMediator mediator) {
            _mediator = mediator;
        }
        public void DoAction(string action) {
            _mediator.Notify(this, action);
        }
    }
}
