namespace DesignPatterns.Behavioral {
    // Command Pattern: Encapsulates a request as an object, thereby letting you parameterize clients with queues, requests, and operations.
    public interface ICommand {
        void Execute();
    }
    public class StartEngineCommand : ICommand {
        public void Execute() {
            System.Console.WriteLine("Engine started");
        }
    }
    public class CarInvoker {
        private ICommand _command;
        public CarInvoker(ICommand command) {
            _command = command;
        }
        public void Run() {
            _command.Execute();
        }
    }
}
