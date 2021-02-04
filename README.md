# Design Patterns

A way for me to learn and understand various Design Patterns defined by the GoF. Code is written in C# and I take no ownership of the original methodologies or strutures being implemented.

### OO Principles:

- Encapsulate what varies.
- Favor composition over inheritance.
- Program to interfaces, not implementations.
- Strive for loosely coupled designs between objects that interact.
- Depend on abstractions. Do not depend on concrete classes.

## Patterns

**1. Strategy:**

Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.

**2. Observer:**

Defines a one-to-many relationship between a set of objects. When the state of one object changes, all of its dependents are notified and updated automatically.

**3. Decorator:**

Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

**4. Factory Method:**

 Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

 **5. Abstract Factory:**

 Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
 
  **6. Singleton:**

 Ensures a class has only one instance, and provides a global point of access to it.
