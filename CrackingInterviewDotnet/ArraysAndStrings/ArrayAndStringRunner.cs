

namespace CrackingInterviewDotnet.ArraysAndStrings
{
    public class ArrayAndStringRunner
    {
        /// <summary>
        /// 1.1 Implement an algorithm to see if a string has all unique characters
        /// </summary>
        /// <returns></returns>
        public static bool IsUnique(string testString)
        {
            var stringDictionary = new Dictionary<char, int>();

            var charArray = testString.ToCharArray().Where(c => !char.IsWhiteSpace(c));

            foreach (var letter in charArray)
            {
                if (stringDictionary.ContainsKey(letter))
                {
                    stringDictionary[letter] = stringDictionary[letter] + 1;
                    return false;
                }
                else
                {
                    stringDictionary[letter] = 1;
                }
            }

            return true;

        }

        /// <summary>
        /// 1.2 Given two strings, write a method to decide if one is a permutation of the other
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool CheckPermutation(string textA, string textB)
        {
            //if string lengths are not the same, return false
            if (textA.Count() != textB.Count())
            {
                return false;
            }

            var textAarray = textA.ToCharArray();
            var textBarray = textB.ToCharArray();

            //turn textA and textB into a char dictionary, with each key beying a character and value being count of characters

            var textAdict = Dictionarify(textA);
            var textBdict = Dictionarify(textB);


            //compare keys, if any are different, return false, else return true
            foreach (var key in textAdict.Keys)
            {
                if (!textBdict.ContainsKey(key) || textBdict[key] != textAdict[key])
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 1.3 Write a method to replace all spaces in a string with '%20'
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string URLify(string text)
        {
            return string.Empty;
        }


        public static Dictionary<char, int> Dictionarify(string text)
        {
            var charArray = text.ToCharArray();

            var dictionary = new Dictionary<char, int>();

            foreach (var letter in charArray)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = dictionary[letter] + 1;

                }
                else
                {
                    dictionary[letter] = 1;
                }
            }


            return dictionary;

        }
    }
}