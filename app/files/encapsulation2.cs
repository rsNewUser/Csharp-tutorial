using System;
namespace HelloWorld{
class Change{
        private string name; // here I have initialized a private field name
        public string Name{ // here I have initialized a property Name
            get { return name; } // the get method is use to read the value of private field
            set { name = value;} // the set method is used to update the value of private field
        }
        public static void Main(string[] args){
            Change obj1=new Change();
            Console.WriteLine(obj1.name);
        }
        
}
}