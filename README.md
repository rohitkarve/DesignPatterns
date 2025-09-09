# Design Patterns in C# - Car Context

This repository demonstrates 23 classic software design patterns, each implemented in the context of a car system. Patterns are organized by type and each has its own class file with descriptive comments.

## Creational Patterns
- **Singleton**: Ensures a car instance is unique. ([SingletonCar.cs](Creational/SingletonCar.cs))
- **Factory Method**: Creates car types via factories. ([FactoryMethodCar.cs](Creational/FactoryMethodCar.cs))
- **Abstract Factory**: Produces families of car parts. ([AbstractFactoryCar.cs](Creational/AbstractFactoryCar.cs))
- **Builder**: Constructs complex car objects step by step. ([BuilderCar.cs](Creational/BuilderCar.cs))
- **Prototype**: Clones car objects. ([PrototypeCar.cs](Creational/PrototypeCar.cs))

## Structural Patterns
- **Adapter**: Adapts truck to car interface. ([AdapterCar.cs](Structural/AdapterCar.cs))
- **Bridge**: Separates car abstraction from engine implementation. ([BridgeCar.cs](Structural/BridgeCar.cs))
- **Composite**: Car parts as tree structure. ([CompositeCar.cs](Structural/CompositeCar.cs))
- **Decorator**: Adds features to cars dynamically. ([DecoratorCar.cs](Structural/DecoratorCar.cs))
- **Facade**: Simplifies car subsystem usage. ([FacadeCar.cs](Structural/FacadeCar.cs))
- **Flyweight**: Shares car data to save memory. ([FlyweightCar.cs](Structural/FlyweightCar.cs))
- **Proxy**: Controls access to car operations. ([ProxyCar.cs](Structural/ProxyCar.cs))

## Behavioral Patterns
- **Chain of Responsibility**: Passes car requests along handlers. ([ChainOfResponsibilityCar.cs](Behavioral/ChainOfResponsibilityCar.cs))
- **Command**: Encapsulates car actions as objects. ([CommandCar.cs](Behavioral/CommandCar.cs))
- **Interpreter**: Implements car-related expressions. ([InterpreterCar.cs](Behavioral/InterpreterCar.cs))
- **Mediator**: Coordinates car components. ([MediatorCar.cs](Behavioral/MediatorCar.cs))
- **Memento**: Saves and restores car state. ([MementoCar.cs](Behavioral/MementoCar.cs))
- **Observer**: Notifies car observers of changes. ([ObserverCar.cs](Behavioral/ObserverCar.cs))
- **State**: Changes car behavior by state. ([StateCar.cs](Behavioral/StateCar.cs))
- **Strategy**: Switches car driving algorithms. ([StrategyCar.cs](Behavioral/StrategyCar.cs))
- **Template Method**: Defines car build steps. ([TemplateMethodCar.cs](Behavioral/TemplateMethodCar.cs))
- **Visitor**: Adds operations to car parts. ([VisitorCar.cs](Behavioral/VisitorCar.cs))

## Usage
- Each pattern is implemented in a separate file under its type folder.
- See comments in each file for details and usage examples.

## References
- [Gang of Four: Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns)
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)

---
Created: 9 September 2025
## Pattern Overview

The table below summarizes all 23 patterns by category:

| Category | Patterns |
|----------|----------|
| **Creational** | Singleton, Factory Method, Abstract Factory, Builder, Prototype |
| **Structural** | Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy |
| **Behavioral** | Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor |

## License
MIT License. See LICENSE file for details.