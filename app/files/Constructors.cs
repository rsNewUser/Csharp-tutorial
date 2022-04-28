using System;
namespace HelloWorld
{
    class Person
    {
        public string model;
        public string color;
        public int year;
        // the constructor has the same name as the class 
        public Person(string models,string colors,int years){
            model=models;
            color=colors;
            year=years;
            Console.WriteLine(model+" "+color+" "+year);
        }

        public static void Main(string[] args)
        {
            // this is how a parameterized constructor is made
            Person obj1=new Person("Tesla","red",1986);
            Person obj2=new Person("Quad","blue",1593);   
        }
 
    }
}

// this are constructors these are used to take the input 
// required which can be taken initially when the object
// is created 
// constructors help to save a lot of time 

// this is the program without constructor
/*
using System;
namespace HelloWorld
{
    class Car{
        public string model;
        public string color;
        public int year;

        public static void Main(string[] args){
            Car obj1=new Car();
            obj1.model="Tesla";
            obj1.color="red";
            obj1.year=1986;

            Car obj2=new Car();
            obj2.model="Quad";
            obj2.color="blue";
            obj2.year=1593;

        }
    }
}

this takes a lot of time for each object with same parameters to
not have constructor 

*/