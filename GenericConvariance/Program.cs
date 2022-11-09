namespace GenericConvariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            Console.WriteLine($"Number of dog legs:{a2.NumberOfLegs}");
        }
    }
    class Animal
    {
        public int NumberOfLegs = 4;
    }
    class Dog : Animal
    {

    }
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