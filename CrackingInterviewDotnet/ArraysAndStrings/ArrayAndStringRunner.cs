

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
    }
}