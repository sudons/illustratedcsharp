namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalArray = new Animal[3];
            animalArray[0] = new Cat();
            animalArray[1] = new Bird();
            animalArray[2] = new Dog();
            foreach (Animal animal in animalArray)
            {
                ILiveBirth liveBirth = animal as ILiveBirth;
                if (liveBirth!=null)
                {
                    Console.WriteLine($"Baby is called:{liveBirth.BabyCalled()}");
                }
            }
        }
    }
    interface ILiveBirth
    {
        string BabyCalled();
    }
    class Animal { }
    class Cat:Animal,ILiveBirth
    {
        public string BabyCalled()
        {
            return "Kitten";
        }
    }
    class Dog : Animal, ILiveBirth
    {
        public string BabyCalled()
        {
            return "puppy";
        }
    }
    class Bird : Animal
    {

    }
}