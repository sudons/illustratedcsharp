namespace GenericStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intData = new PieceOfData<int>(10);
            var stringData = new PieceOfData<string>("Hi there.");
            Console.WriteLine($"intData   ={intData.Data}");
            Console.WriteLine($"stringData={stringData.Data}");
        }
    }
    struct PieceOfData<T>
    {
        public PieceOfData(T value)
        {
            data = value;
        }

        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}