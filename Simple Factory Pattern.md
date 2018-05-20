## Simple Factory Pattern
Eine Fabrik, die Objekte erzeugt, die von einer bestimmten Basisklasse stammen.
Ein Objekt wird durch den Aufruf einer Methode anstatt durch direkten Aufruf eines Konstruktors erzeugt.
* Objekt

Beispiel: Das Fabrikmuster basiert auf einer Typenhierarchie. Eine abstrakte Klasse wird als Basis verwendet. Die Klassen müssen alle ein Interface implementieren oder von einer
Basisklasse abgeleitet sein. Die Klassen Dog, Cat und Fish leiten sich von Animals ab. 
* Schnittstelle
* Abstrakt 


```csharp
     using System;  
      
    class Program  
    {  
        abstract class Animal  
        {  
            public abstract string Title { get; }  
        }  
      
        class Dog : Animal  
        {  
            public override string Title  
            {  
                get  
                {  
                    return "Dog";  
                }  
            }  
        }  
      
        class Cat : Animal  
        {  
            public override string Title  
            {  
                get  
                {  
                    return "Cat";  
                }  
            }  
        }  
      
        class Fish : Animal  
        {  
            public override string Title  
            {  
                get  
                {  
                    return "Fish";  
                }  
            }  
        }  
      
        static class Factory  
        {  
            public static Animal Get(int id)  
            {  
                switch (id)  
                {  
                    case 0:  
                        return new Dog();  
                    case 1:  
                    case 2:  
                        return new Cat();  
                    case 3:  
                    default:  
                        return new Fish();  
                }  
            }  
      
      
            static void Main()  
            {  
                for (int i = 0; i <= 3; i++)  
                {  
                    var position = Factory.Get(i);  
                    Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);  
      
                }  
                Console.ReadLine();  
            }  
        }  
    }  
