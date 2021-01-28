# DesignPatterns

Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

Identify the aspects of application that vary and separate them from what stays the same…

Abstract duck class have IFlyBehavior and IQuackBehavior with getters and setters.. and child class will set those behaviors. with this approach we can adapt to any future changes easily.