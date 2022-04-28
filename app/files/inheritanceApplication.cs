using System;

namespace HelloWorld{
    class Program{
        public static void Main(string[] args){
            Carmodel objCar=new Carmodel();
            objCar.honk();
            Console.WriteLine(objCar.company+" "+objCar.modelName);
        }
    }
}