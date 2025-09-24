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




# Benefits of Using the Adapter Pattern in Large Projects

1. **Code Reusability**: The Adapter Pattern allows existing classes to be reused in new contexts without modifying their code. This promotes the reuse of well-tested components.

2. **Decoupling**: It decouples the client code from the specific implementations of the classes it uses. This means that changes in the underlying classes do not affect the client code, leading to easier maintenance.

3. **Flexibility**: The Adapter Pattern provides flexibility in integrating new components or systems. You can easily adapt new classes to fit into existing interfaces without altering the original codebase.

4. **Simplified Testing**: By using adapters, you can create mock or stub implementations of interfaces for testing purposes, making unit tests easier to write and maintain.

5. **Improved Readability**: The use of adapters can make the code more readable by clearly defining the relationships between different components and their interfaces.

6. **Support for Multiple Interfaces**: It allows a single class to be adapted to multiple interfaces, enabling the same class to be used in different contexts.

7. **Ease of Integration**: When integrating third-party libraries or legacy code, the Adapter Pattern can bridge the gap between incompatible interfaces, facilitating smoother integration.

8. **Single Responsibility Principle**: Adapters can help adhere to the Single Responsibility Principle by separating the adaptation logic from the business logic, making the codebase cleaner and more organized.


## Usage
- Each pattern is implemented in a separate file under its type folder.
- See comments in each file for details and usage examples.

## References
- [Gang of Four: Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns)
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)

---
Created: 9 September 2025
## Pattern Overview
This section provides a high-level explanation of the different pattern categories:

### Creational Patterns
Creational patterns focus on object creation mechanisms, providing flexibility in what gets created, how it's created, and who creates it. In our car context, these patterns help manage how different types of cars and their components are instantiated.

### Structural Patterns
Structural patterns deal with object composition, creating relationships between objects to form larger structures. These patterns help define how car parts and systems connect and interact with each other in flexible ways.

### Behavioral Patterns
Behavioral patterns focus on communication between objects, defining how objects distribute responsibility and interact. These patterns help manage complex operations in a car's systems, from engine control to driver interaction.
The table below summarizes all 23 patterns by category:

| Category | Patterns |
|----------|----------|
| **Creational** | Singleton, Factory Method, Abstract Factory, Builder, Prototype |
| **Structural** | Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy |
| **Behavioral** | Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor |



## License
MIT License. See LICENSE file for details.
git checkout -b main
git push -u origin main

