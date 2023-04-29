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
            //Encapsulation obj = new Encapsulation();
            //Console.WriteLine($"Name : {obj.Name}");
            //Console.WriteLine($"Age : {obj.Age}");

            //Abstraction
            //Child obj = new Child();
            //obj.NormalMethod();
            //obj.AbstractMethod();

            //Reference And Value type.
            //int value = 20;
            //int value_One = 40;
            //ValueAndReferenceType obj = new ValueAndReferenceType();
            //obj.Method(value, value_One);
            //obj.Method_One(ref value, ref value_One);

            //Method Types
            //TypesOFMethod obj = new TypesOFMethod();
            //obj.Method();
            //obj.Method_One("Tom", "Hardy");
            //Console.WriteLine(obj.Method_Two("Clark", "Kent"));
            //Console.ReadKey();

            //Single Inheritence types
            ChildClass obj = new ChildClass();
            obj.Method();

            //Multilevel
            Sibling objj = new Sibling();
            objj.Method();

            //Heirarchical
            Daughter daughter= new Daughter();
            daughter.Method();


        }
    }
}
