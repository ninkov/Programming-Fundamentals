using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            // read input
            var words = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            //creat dictionary
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                //create all words tolower
                var toLowerWord = word.ToLower();
                //count words 
                if (wordCount.ContainsKey(toLowerWord))
                {
                    wordCount[toLowerWord]++;
                }
                else
                {
                    wordCount[toLowerWord] = 1;
                }

            }
            //declare collection for result
            List<string> result = new List<string>();

            foreach (var kvp in wordCount)
            {
                string word = kvp.Key;
                int count = kvp.Value;
                //check count value if is odd add to result
                if (kvp.Value % 2 == 1)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
