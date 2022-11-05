namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";
            Dictionary<string, int> frequencies = CountWords(text);
            foreach (KeyValuePair<string,int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}-----{1}", word,frequency);
            }
        }
        static Dictionary<string,int> CountWords(string text)
        {
            Dictionary<string,int> frequencies = new Dictionary<string,int>();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            return frequencies;
        }
    }
}