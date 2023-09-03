namespace ComplexDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //通过无参数构造函数创建c对象
            Complex c = new Complex();
            //通过有参数构造函数创建对象c1和c2
            Complex c1 = new Complex(5,6);
            Complex c2 = new Complex(7,8);
            //因为COmplex类型中重载了"+"运算符,因此可以让两个Complex对象进行相加的操作，此处即为c1+c2
            c = c1 + c2;
            //输出相应的值
            Console.Write("c1=");c1.OutPut();
            Console.Write("c2=");c2.OutPut();
            Console.Write("c1+c2=");c.OutPut();
            Console.ReadLine();
        }
    }
    class Complex
    {
        //声明两个int类型的私有字段
        private int real, imag;
        //默认的无参数构造函数（备注：默认情况下，如果使用了带参数的构造函数，那么默认的无参数构造函数就会失效，除非将无参数构造函数显式声明出来）
        public Complex()
        {

        }
        //通过有参数构造函数为私有字段赋值，如果在创建对象时不通过构造函数传值的话，参数r和i的默认值均为0
        public Complex(int r = 0, int i = 0)
        {
            this.real = r;
            this.imag = i;
        }
        //通过OutPut方法在终端输出赋值后的私有字段的值
        public void OutPut()
        {
            Console.WriteLine("{0},{1}", real, imag);
        }
        //重载"+"运算符：让两个Complex对象相加，实际运算过程就是两个Complex对象(c1和c2)中的同名同类型字段相加，将相加后的值赋给新准备的Complex对象(c)的相应字段,返回新的对象
        public static Complex operator +(Complex c1, Complex c2)
        {
            //注意：此处新创建Complex对象是调用了Complex类型的默认无参数构造函数
            Complex c = new Complex();
            c.real = c1.real + c2.real;
            c.imag = c1.imag + c2.imag;
            return c;
        }
    }
}