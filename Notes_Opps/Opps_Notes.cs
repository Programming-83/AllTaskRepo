using System;
using System.Runtime.InteropServices;
// Piller's Of Opp's
// 1. Data Abstraction
// 2. Encapsulation
// 3.Inheritance
// 4.Polymorpshism
//  Data Abstraction
abstract class Employee // We can Create Abstract clss using Abstract Keyword
{
    protected Employee()
    {
        Console.WriteLine("Constroctor"); // Also we can create Constroctor in abstroct class
    }
    int age = 25; // We can also creat data member in abstrct class 
    string name="abk";
    public void dis() // Also We can Create non-abstract method in abstrac class bu impliment His body
    {
        Console.WriteLine("Details = "); // Body Impliment 
    }
    abstract public void sum(); // We can create abstract method using 'abstract' keywerd but abstract method have no Body 
    // You Can not Create an object of Abstract Class
    // You can not Support multiple Inheritance
    // You cna impliment abstrac class into other calss and we have to nesserary to impliment all method using override
}
//---------------------------------------------------------------------------------------------------------------------------------------
class Inheritance
{
    // Inheritance
    //  >> Chile class always inherit the properties of Parent Class
    //  >> Re-Usability
    // There are five type of inheritance in C# :-
    //    >> Single Inheritance
    //    >> Multiple Inheritance
    //    >> Multilevel Inheritance
    //    >> Hybrid Inheritance
    //    >> Hierarchical Inheritance
    //        >> Parent Class know as Supper and Base Class
    //        >> Child Class know as Sub and Derived Class
    //    >> In C# class by defult internal and Data Member / Method Privet
}
// ------------------------------------------------------------------------------------------------------
 
class Interface
{
   
    // Interface Support Multiple Inhertance in c#
    interface  Parent // Interface Keyword in used to create interface Class
    {
        public Parent() // You can not create a controctor in interfce
        {
            Console.WriteLine("Hello");
        }
       
        int a = 52; // We can not make data member in Interface
         int sum(int a, int b); // You can create not-abstract methode in interface but do't make a body
    }
    
}
// Q.1 What is Different between Abstract Class & Interface Class
//                        Abstract                                                  Interface
// 1. Abstract Keyword used to create Abstract Class                        1. Interface keyword used to create Interface Class
// 2. We can create Data Member( int a) in Abstract Class                   2. We can not create Data Member( int a) in Abstract Class
// 3. You can create non-abstract methode in abstract but impliment body    3. You can create non-abstract methode in interface but don't impliment body
// 4. We Provied mehtod declartion and implimetn his body                   4. We Provied only mehtod declartion inside interface
// 5. All methode not nessery to implimetn in abstract                      5. All methode nessery to impliment in interface
// 6. You Can create a constroctor in abstract class                        6. You can not create a constroctor in interface
// 7. Interface bydefult is 'Puble'
class MultipleInheritance
{
    // You have to need Interface to perfomr MultipleInheritance
    // C# does not support multiple Inheritance if you want to support multiple Inheritance then Perfome Interface
}
class Encapsulation
{
    // The Wrapping up to data and function into a single unit is know as Encapsulation
    // It is also know as Data Hiding or information Hiding
    // In C# Encapsultion can be achieved by following modifiers
    //    1.public ----> It can be access anywere in a programm within same namespace and different namespace
    //    2.privet ----> It can be accessbil whith in class only where it is declared
    //    3.protected --> It is same as privet but it can accessbile when we perfome inheritance
    //    4.internal----> Within same namespace/accembly accessbile
    //    5.procted internal ---> It can be accessbil withinh same name space & other namespace when you perfome inheritance 
}

class Polymorphism
{
    // Types of Polymorphism
    //   >> Compile Time Polymorphism --> Eary Binding--> It can be acchived by 'Function Overloading'
    //           >> Function Overloading --> function name is same but their parameter is different
    //   >> Run Time Polymorphism    ---> Late Bindin---> It can be acchived bu 'Function Overriding'
    //             >> Function Overriding --> Function name is same and their parameter should also be same
}