namespace GenericContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<Animal> act = ActOnAnimal;
            Action<Dog> dog = act;
            dog(new Dog());
        }
        static void ActOnAnimal(Animal a)
        {
            Console.WriteLine(a.Legs);
        }
    }

    internal class Animal
    {
        public int Legs = 4;
    }
    internal class Dog : Animal
    {

    }
    delegate void Action<in T>(T a);
}