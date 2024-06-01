# DependencyInjectionDemos

This project aims to show the power of Dependency Injection and why every developer that use Object-Oriented Programming must use DI.
DI is a programming technique (set of patterns) that helps us to make loosley coupled code. DI is based on Dependency Inversion Principle from SOLID.
Dependency Injection is an implementation of this principle in code and states that we do not have to create our dependencies, instead we have to inject them
from outside via interfaces (mostly via constructor injection). 

Why tightly coupled code is bad?

![Tight](https://github.com/velizar92/DependencyInjectionDemos/assets/40525254/809a96e1-33e9-4399-b6d2-21656f5c6014)

1. Lack of Flexibility - Tightly coupled systems are hard to change. Changing in one component often requires changes in all connected components.
2. Difficult to maintain - As the system grows, maintaining tightly coupled systems can become increasingly difficult.
3. Hard to Test - Tightly coupled systems are very hard for unit testing because each component (class) depends not on abstraction (interface) but on concrete implementations.
4. Poor separation of concerns - One class should not be responsible of creating of its dependencies. The class should make one thing and to make it in a good way.
5. Reuse and Scalability Issues - In tightly coupled systems, it's hard to reuse a component or scale a single component independently because it's closely connected to other components.
6. Parallel developent is hindered - This is because one class depend on another class directly and the first class should wait for the implementation of it's dependency.

What says Dependency Inversion Principle: High-level modules SHOULD NOT depend on low-level modules. Both SHOULD depend on abstractions.

Important: Dependency Injection is crucial point for every good software engineer. If you want to see the power of Dependency Injection, check the repo.

If you want to see a project that has both 3 examples: 1. Tight Coupling, 2. Loose Coupling without DI Container (Poor Man DI) and 3. Loose Coupling with DI (Autofac)
please refer to project number 5 (AutofacDI).

DI containers are also a BIG part from the right implementation of Dependency Injection. They are optional tool/s but if are used they help a lot with our the wiring of our application. Such DI frameworks are Autofac, Unity, Ninject and now in .NET the dependency injection is build in an can be used as well.

There is also a presentation about Dependency Injection that shows the code examples on the slides. The same examples with even more explanations are set
in the code itself.

![last](https://github.com/velizar92/DependencyInjectionDemos/assets/40525254/cc2d8892-fbee-4602-b43e-392756ddd7da)

![6666](https://github.com/velizar92/DependencyInjectionDemos/assets/40525254/72a236b2-c6f7-4380-9986-d868a300a64e)

![nwe](https://github.com/velizar92/DependencyInjectionDemos/assets/40525254/c1f09cd2-6de3-4e8b-a8d4-d950137d1ac4)



