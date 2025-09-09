namespace DesignPatterns.Behavioral {
    // Interpreter Pattern: Implements a specialized language.
    public interface IExpression {
        int Interpret(Context context);
    }
    public class Context {
        public int Value { get; set; }
    }
    public class CarExpression : IExpression {
        public int Interpret(Context context) {
            return context.Value * 2;
        }
    }
}
