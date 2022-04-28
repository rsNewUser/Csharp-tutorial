using System;
namespace HelloWorld{
    class Program2{
        public static void Main(string[] args){
            Animal animalObj=new Animal();
            Animal myPigObj=new Pig();
            Animal myDogObj=new Dog();
            animalObj.sound();
            myPigObj.sound();
            myDogObj.sound();
        }
    }
}