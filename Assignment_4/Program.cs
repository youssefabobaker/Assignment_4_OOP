namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions 
            #region Q1  Abstraction
            // What is Abstraction --> The process of hiding complex implementation details and showing only the essential features of an object.
            // Why is abstraction considered one of the four pillars of OOP --> because it allows developers to focus on the essential features of an object, rather than being distracted by the complex implementation details. This leads to more maintainable and flexible code.
            #endregion

            #region Q2  Abstract Classes vs. Interfaces 
            // What is the difference between an Abstract Class and an Interface? --> An abstract class can have both abstract and non-abstract methods, while an interface can only have abstract methods. An abstract class can have fields, constructors, and access modifiers, while an interface cannot. A class can inherit from only one abstract class, but it can implement multiple interfaces.
            // When would you choose an Interface instead of an Abstract Class? --> to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for defining capabilities that can be shared across unrelated classes, promoting flexibility and decoupling in your design.
            // Can a class inherit from multiple abstract classes? Can it implement multiple interfaces? --> A class cannot inherit from multiple abstract classes due to C#'s single inheritance model, but it can implement multiple interfaces.
            #endregion
            #endregion



        }
    }
}
