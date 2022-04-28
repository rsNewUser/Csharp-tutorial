using System;
namespace HelloWorld{
    class Entry{
        public static void Main(string[] args){
            Change obj1=new Change();
            obj1.Name="Ansh"; // this is to change the value of field 'name' 
            // without actually accessing the field name 
            // this is encapsulation , to update or read the data 
            // without giving the access of the field to the outer variables of class 
            
        }
    }
}