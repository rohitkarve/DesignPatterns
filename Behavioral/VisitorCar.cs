namespace DesignPatterns.Behavioral {
    // Visitor Pattern: Allows adding new operations to existing object structures without modifying them.
    public interface VisitorCarElement {
        void Accept(VisitorCarVisitor visitor);
    }
    public class VisitorCarWheel : VisitorCarElement {
        public void Accept(VisitorCarVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public class VisitorCarEngine : VisitorCarElement {
        public void Accept(VisitorCarVisitor visitor) {
            visitor.Visit(this);
        }
    }
    public interface VisitorCarVisitor {
        void Visit(VisitorCarWheel wheel);
        void Visit(VisitorCarEngine engine);
    }
    public class VisitorCarPrintVisitor : VisitorCarVisitor {
        public void Visit(VisitorCarWheel wheel) {
            System.Console.WriteLine("Visiting wheel");
        }
        public void Visit(VisitorCarEngine engine) {
            System.Console.WriteLine("Visiting engine");
        }
    }
}
