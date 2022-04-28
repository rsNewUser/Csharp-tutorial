using System;
namespace HelloWorld{
    class Program3{
        public static void Main(string[] args){
            Pigs absObj=new Pigs();
            absObj.animalSound(); // here I can also access the abstract method from the abstract class from the inherited class 
            // with the definition of the inherited class method which over rides the animalSound method of the abstract class
            absObj.sleep(); // see here I can access the class from the inherited class Pigs
        }
    }
}