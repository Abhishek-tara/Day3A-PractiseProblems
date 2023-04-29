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
            PolymorphismDemo obj = new PolymorphismDemo();
            obj.SnakeSound();
            Dog dog = new Dog();
            dog.SnakeSound();
            

        }
    }
}
