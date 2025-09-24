namespace DesignPatterns.Behavioral {
    // Chain of Responsibility Pattern: Passes a request along a chain of handlers.
    public abstract class CarHandler {
        protected CarHandler? nextHandler;
        public void SetNext(CarHandler handler) {
            nextHandler = handler;
        }
        public abstract void Handle(string request);
    }
    public class EngineHandler : CarHandler {
        public override void Handle(string request) {
            if (request == "engine") {
                System.Console.WriteLine("Engine handled");
            } else {
                nextHandler?.Handle(request);
            }
        }
    }
    public class BodyHandler : CarHandler {
        public override void Handle(string request) {
            if (request == "body") {
                System.Console.WriteLine("Body handled");
            } else {
                nextHandler?.Handle(request);
            }
        }
    }
}
