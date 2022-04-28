using System;

namespace HelloWorld{
    // this is when you have a single class to execute 
    class ClassObjectsMainMethod{
            // everything inside a class is called as members the variables declared the methods declared 
            //are all members of the class
        string car="Volvo";
        public static void main(string[] args){
            ClassObjectsMainMethod obj1=new ClassObjectsMainMethod();
            Console.WriteLine(obj1.car);
            // here I have introduced a different class to the main class from another file so you can do something like this 
            // keeping the main function or method in a single file and other classes in a different file
            // this helps organizing the code and keeping it nice and clean
            Car obj2=new Car();
            Console.WriteLine(obj2.carName);
        }
    }
}