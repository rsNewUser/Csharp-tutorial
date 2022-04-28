using System;
namespace HelloWorld{
    class Dog:Animal{// this is the derived class from the parent class
        public void sound(){ // this actually uses the property of overriding 
            Console.WriteLine("The dog barks Woof woof");
        }
    }
}