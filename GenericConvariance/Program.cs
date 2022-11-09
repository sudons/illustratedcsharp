namespace GenericConvariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory<Dog> dogMaker = MakeDog;
            Factory<Animal> animalMaker = dogMaker;
            Console.WriteLine(animalMaker().Legs.ToString());
        }
        static Dog MakeDog()
        {
            return new Dog();
        }
    }
    class Animal
    {
        public int Legs = 4;
    }
    class Dog : Animal
    {

    }
    delegate T Factory<out T>();




    /// <summary>
    /// 关于协变和逆变的小知识
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //泛型协变类型参数不能用于方法的输入参数类型
    public interface IConvariance<out T>
    {
        public T Hit(string it);
    }
    //泛型逆变类型参数不能用于访求的返回值类型
    public interface IContravariance<in T>
    {
        public string Hit(T it);
    }
}