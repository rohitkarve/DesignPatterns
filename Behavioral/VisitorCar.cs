namespace DesignPatterns.Behavioral {
    // Visitor Pattern: Allows adding new operations to existing object structures without modifying them.
    public interface ICarElement {
        void Accept(ICarVisitor visitor);
    }
    public class Wheel : ICarElement {
        public void Accept(ICarVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public class Engine : ICarElement {
        public void Accept(ICarVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public interface ICarVisitor {
        void Visit(Wheel wheel);
        void Visit(Engine engine);
    }
    public class CarElementPrintVisitor : ICarVisitor {
        public void Visit(Wheel wheel) {
            System.Console.WriteLine("Visiting wheel");
        }
        public void Visit(Engine engine) {
            System.Console.WriteLine("Visiting engine");
        }
    }
}
