namespace OOPS_Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Objects of a class
            //Object  obj = new Object();
            //obj.name = "Bruce";
            //obj.age = 25;
            //obj.Display();

            //Polymorphism
            //PolymorphismDemo obj = new PolymorphismDemo();
            //obj.SnakeSound();
            //Dog dog = new Dog();
            //dog.SnakeSound();

            //MethodOverLoading
            //MethodOverloading obj = new MethodOverloading();
            //obj.Method();
            //obj.Method(4, 5);

            //MethodOVerRide
            //MethodOverRide obj = new MethodOverRide();
            //obj.Method();
            //Derived obj_One = new Derived();
            //obj_One.Method();
            //Console.ReadKey();

            //Encapsulation
            Encapsulation obj = new Encapsulation();
            Console.WriteLine($"Name : {obj.Name}");
            Console.WriteLine($"Age : {obj.Age}");


        }
    }
}
