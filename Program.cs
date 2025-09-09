// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Design Patterns Interactive Console");
Console.WriteLine("==================================\n");
bool running = true;

while (running)
{
    Console.WriteLine("Choose a design pattern to explore:");
    Console.WriteLine("1. Creational Patterns");
    Console.WriteLine("2. Structural Patterns");
    Console.WriteLine("3. Behavioral Patterns");
    Console.WriteLine("0. Exit");

    Console.Write("\nEnter your choice: ");
    string input = Console.ReadLine();

    Console.Clear();

    switch (input)
    {
        case "1":
            ShowCreationalPatterns();
            break;
        case "2":
            ShowStructuralPatterns();
            break;
        case "3":
            ShowBehavioralPatterns();
            break;
        case "0":
            running = false;
            Console.WriteLine("Thank you for exploring design patterns. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.\n");
            break;
    }
}

void ShowCreationalPatterns()
{
    while (true)
    {
        Console.WriteLine("Creational Patterns:");
        Console.WriteLine("1. Singleton");
        Console.WriteLine("2. Factory Method");
        Console.WriteLine("3. Abstract Factory");
        Console.WriteLine("4. Builder");
        Console.WriteLine("5. Prototype");
        Console.WriteLine("0. Back to Main Menu");

        Console.Write("\nEnter your choice: ");
        string input = Console.ReadLine();
        
        Console.Clear();

        if (input == "0") break;

        switch (input)
        {
            case "1": ExplainPattern("Singleton", "Ensures a class has only one instance and provides a global point of access to it."); break;
            case "2": ExplainPattern("Factory Method", "Defines an interface for creating an object, but lets subclasses decide which class to instantiate."); break;
            case "3": ExplainPattern("Abstract Factory", "Provides an interface for creating families of related or dependent objects without specifying their concrete classes."); break;
            case "4": ExplainPattern("Builder", "Separates the construction of a complex object from its representation, allowing the same construction process to create different representations."); break;
            case "5": ExplainPattern("Prototype", "Creates new objects by copying an existing object, known as the prototype."); break;
            default: Console.WriteLine("Invalid option. Please try again.\n"); break;
        }
    }
}

void ShowStructuralPatterns()
{
    while (true)
    {
        Console.WriteLine("Structural Patterns:");
        Console.WriteLine("1. Adapter");
        Console.WriteLine("2. Bridge");
        Console.WriteLine("3. Composite");
        Console.WriteLine("4. Decorator");
        Console.WriteLine("5. Facade");
        Console.WriteLine("6. Flyweight");
        Console.WriteLine("7. Proxy");
        Console.WriteLine("0. Back to Main Menu");

        Console.Write("\nEnter your choice: ");
        string input = Console.ReadLine();
        
        Console.Clear();

        if (input == "0") break;

        switch (input)
        {
            case "1": ExplainPattern("Adapter", "Converts the interface of a class into another interface clients expect."); break;
            case "2": ExplainPattern("Bridge", "Decouples an abstraction from its implementation so that the two can vary independently."); break;
            case "3": ExplainPattern("Composite", "Composes objects into tree structures to represent part-whole hierarchies."); break;
            case "4": ExplainPattern("Decorator", "Attaches additional responsibilities to an object dynamically."); break;
            case "5": ExplainPattern("Facade", "Provides a unified interface to a set of interfaces in a subsystem."); break;
            case "6": ExplainPattern("Flyweight", "Uses sharing to support large numbers of fine-grained objects efficiently."); break;
            case "7": ExplainPattern("Proxy", "Provides a surrogate or placeholder for another object to control access to it."); break;
            default: Console.WriteLine("Invalid option. Please try again.\n"); break;
        }
    }
}

void ShowBehavioralPatterns()
{
    while (true)
    {
        Console.WriteLine("Behavioral Patterns:");
        Console.WriteLine("1. Chain of Responsibility");
        Console.WriteLine("2. Command");
        Console.WriteLine("3. Interpreter");
        Console.WriteLine("4. Iterator");
        Console.WriteLine("5. Mediator");
        Console.WriteLine("6. Memento");
        Console.WriteLine("7. Observer");
        Console.WriteLine("8. State");
        Console.WriteLine("9. Strategy");
        Console.WriteLine("10. Template Method");
        Console.WriteLine("11. Visitor");
        Console.WriteLine("0. Back to Main Menu");

        Console.Write("\nEnter your choice: ");
        string input = Console.ReadLine();
        
        Console.Clear();

        if (input == "0") break;

        switch (input)
        {
            case "1": ExplainPattern("Chain of Responsibility", "Passes a request along a chain of handlers."); break;
            case "2": ExplainPattern("Command", "Encapsulates a request as an object, allowing parameterization of clients with queuing, requests, and operations."); break;
            case "3": ExplainPattern("Interpreter", "Implements a specialized language by representing its grammar as object-oriented structures."); break;
            case "4": ExplainPattern("Iterator", "Provides a way to access elements of a collection sequentially without exposing its underlying representation."); break;
            case "5": ExplainPattern("Mediator", "Defines an object that encapsulates how a set of objects interact."); break;
            case "6": ExplainPattern("Memento", "Captures and externalizes an object's internal state so it can be restored later."); break;
            case "7": ExplainPattern("Observer", "Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified."); break;
            case "8": ExplainPattern("State", "Allows an object to alter its behavior when its internal state changes."); break;
            case "9": ExplainPattern("Strategy", "Defines a family of algorithms, encapsulates each one, and makes them interchangeable."); break;
            case "10": ExplainPattern("Template Method", "Defines the skeleton of an algorithm, deferring some steps to subclasses."); break;
            case "11": ExplainPattern("Visitor", "Represents an operation to be performed on elements of an object structure."); break;
            default: Console.WriteLine("Invalid option. Please try again.\n"); break;
        }
    }
}

void ExplainPattern(string patternName, string description)
{
    Console.WriteLine($"Design Pattern: {patternName}");
    Console.WriteLine("=".PadRight(patternName.Length + 15, '='));
    Console.WriteLine($"\nDescription: {description}\n");
    
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}