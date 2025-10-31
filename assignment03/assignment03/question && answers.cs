/*
 * Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 
    -public: allows any program to use.
    -private: allows only the properties/methods inside current class to use.
    -protected: allows only within the same class and child classes to use.
    -internal: allows only within the same assembly to use.
    -protected internal: within the same assembly and child classes to use.
    -private protected: within the same class or child classes to use.
    
2.What is the difference between the static, const, and readonly keywords when applied to
a type member?
    -when applied to type member static makes it shared across all the instances of the class,
    const doesnt allow the type member to be altered after it is initialized. It is a compile-time constant
    and readonly keywords are runtime constants that are fixed when program starts and object is created. 
    
3. What does a constructor do?
    -When an instance is created, constructor allows the instance to be created with starting properties
    upon creation.
    
4. Why is the partial keyword useful?
    -partial keyword allows you to split classes, interface, and structs into multiple files in order to
    have better maintenance and organization.
    
5. What is a tuple?
    -unlike array, tuple allows varying element types to be together.
    
6. What does the C# record keyword do?
    -when used the compiler creates a class with its get set of parameters given and the constructor.
    The Equals and gethashcode and tostring is auto generated such that equality comparison between object
    will come out to be true if all the property values are equal instead of reference values.
    
7. What does overloading and overriding mean?
    -overloading means creating multiple same named methods with varying parameters.
    -overriding means redefining method inherited from the parent in the child class.
    
8. What is the difference between a field and a property?
    -field is a variable that belongs to a class. The data is stored in stack or heap directly.
    property contains two hidden methods get and set that controls access to a private field.
    field is only used internally in a program while property can be given to other codes safely.

9. How do you make a method parameter optional?
    -you assign the pre-registered value by assigning with a default value.
    
10. What is an interface and how is it different from abstract class?
    -The interface is a signature that any implementing class should follow like a contract.
    it cant have fields and constructors and used when unrelated classes must share common behaviour.
    Abstract class provides a base with shared code so that you can utilize methods inside abstract class.
    however what is defined as abstract you must implement it and override the method.
    
11. What accessibility level are members of an interface?
    -All members of an interface are public by default and you cannot change that.

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method. T
13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method. T
14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method. F
15. True/False. Abstract methods can be used in a normal (non-abstract) class. F
16. True/False. Normal (non-abstract) methods can be used in an abstract class. T
17. True/False. Derived classes can override methods that were virtual in the base class. T
18. True/False. Derived classes can override methods that were abstract in the base class. T
19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.F
20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface. F
21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface. T
22. True/False. A class can have more than one base class. F
23. True/False. A class can implement more than one interface. T
*/