using System;

namespace HelloWorld{
    abstract class AnimalAbstract{ 
    /* abstracted class cannot be used to create object they can only be created with the class they are parent to 
    */ 
        public abstract void animalSound(); /*abstract method the body is not provided for the abstraction method */ 
        public void sleep(){
            Console.WriteLine("Zzz!......");
        }

    }
}