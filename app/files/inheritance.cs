using System;

namespace HelloWorld{
    class Vehicle{ //parent class
    public string company="ford";
    public void honk(){
        Console.WriteLine("boink boink");
    } // never write static when you want to access the method 
    // outside the class 
        
    }
}