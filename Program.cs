namespace Huffman
{
    class Huffman {         
        static void Main(string[] args)
        {
            string str = "A DEAD DAD CEDED A BAD BABE A BEADED ABACA BED";

            var frequencies = CharacterFrequency(str);
            foreach (var f in frequencies)
                Console.WriteLine("{0}: {1}", f.Key, f.Value);
        }

        // Generate a list with each character in the string and 
        // number of times we encounter it. Sorted by the number.
        private static List<KeyValuePair<char, int>> CharacterFrequency(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in str)
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
            
            return dict.OrderBy(d => d.Value).ToList();
        }
    }
}