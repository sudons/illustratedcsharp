using System.Collections;

namespace CustomEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum spectrum= new Spectrum();
            foreach (string color in spectrum)
            {
                Console.WriteLine(color);
            }
        }
    }
    class Spectrum : IEnumerable
    {
        string[] Colors = new string[]
        {
            "violet","blue","cyan","green","yellow","orange","red"
        };

        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(Colors);
        }
    }

    internal class ColorEnumerator : IEnumerator
    {
        string[] colors;
        int position = -1;
        public ColorEnumerator(string[] theColors)
        {
            this.colors = new string[theColors.Length];
            for (int i = 0; i < theColors.Length; i++)
            {
                colors[i] = theColors[i];
            }
        }
        public object Current
        {
            get
            {
                if (position == -1)
                {
                    throw new InvalidOperationException();
                }
                if (position>=colors.Length)
                {
                    throw new InvalidOperationException();
                }
                return colors[position];
            }
        }
        public bool MoveNext()
        {
            if (position<colors.Length-1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
    }
}