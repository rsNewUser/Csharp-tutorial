// See https://aka.ms/new-console-template for more information
/*
In this we will learn how to make custom methods according to our needs 
the thing with methods is they are actually functions but they act as a part of the class which carries a particular set of 
instructions to be executed 
*/
using System;
// namespace is used to organize the code and it consists of all the methods and classes inside it , 
//it is basically the name of your project
namespace Methods{
    // class is a unit object which consists of small small methods inside it we can say that if Human body is a class 
    // then all the organs are the methods inside it which have there own variables and all for the execution for the whole 
    // human body 
    class Program{
        /*methods are always declared or created inside a class */
        // this is my first method
        static void MyMethod(){
            Console.WriteLine("This is my method");
        }

        static void MyMethodArgumented(int age,string name){
            Console.WriteLine("This is my name :"+name+" This is my age :"+age);
        }

        /*
        Method OverLoading:
        when we want a functionality of a particular method to be done on different data types then we use method overloading
        remember DIFFERENT DATA TYPES SHOULD BE ASSIGNED FOR DIFFERENT METHODS WITH THE SAME NAME TO ACHIEVE METHOD OVERLOADING 
        it is not a must rule but it keeps the code systematic and the purpose of method overloading precise
        */

        // here I am trying to return int datatype value and I am also taking integer data type from the main method
        static int myMethodOverLoadingSum(int x,int y){
            return x+y;
        }

        static double myMethodOverLoadingSum(double x, double y){
            return x+y;
        }

        /*this is my entry point for the execution the main function 
        public - it denotes the authorization one method gets to be or not to be accessed , they can be public or private
        static - denotes that it is the method of the Program class and we will learn more about it further in OOP's concepts
        void - it does not return any value
        */
        public static void main(string[] args){
            // here I called myMethod which I created
            MyMethod();
            // this is how you pass the arguments to the method 
            // the order matters how you pass it so to be precise don't send the parameters just like that 
            // write the argument variable names as well
            // like this I can send them in different orders as well  
            MyMethodArgumented(age:15,name:"rohit");
            // that's why always pass arguments with variable names
            MyMethodArgumented(name:"harish",age:19);

            // here I am storing the return value from the method to the variables
            int intSum=myMethodOverLoadingSum(5,6); // integer sum will be stored in this variable
            double doubleSum=myMethodOverLoadingSum(5.2,5.3); // decimal sum will be stored in this variable

            Console.WriteLine("This is integer sum from the same method : ",intSum);
            Console.WriteLine("This is decimal sum from the same method : ",doubleSum);
        }
    }
}