

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
            var url = text.Trim().Replace(" ", "%20");
            return url;
        }

        /// <summary>
        /// 1.4 Given a string, write a function to check if it is a permutation of a palindrome.
        /// *Hint : For an even length string, it shouldn't have any character with an odd occurrence, whereas for an odd length string, it should have only 1*
        /// </summary>
        /// <param name="text"></param>
        /// <param name="palindrome"></param>
        /// <returns></returns>
        public static bool PalindromePermutation(string text)
        {
            var trimmedText = text.ToLower().Replace(" ", "");
            var length = trimmedText.Length;
            var isEven = length % 2 == 0;

            var textDictionary = Dictionarify(trimmedText);

            var countOfOddCharacters = textDictionary.Where(x => x.Value % 2 > 0).Count();

            if (isEven)
            {
                if (countOfOddCharacters > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (countOfOddCharacters > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }



        /// <summary>
        /// 1.5 Given two strings, write a function to check if they are one edit or zero edits away from each other. An edit is an insert, a removal or replacement of a character. 
        /// </summary>
        /// <param name="text_A"></param>
        /// <param name="text_B"></param>
        /// <returns></returns>
        public static bool OneAway(string text_A, string text_B)
        {
            //their lengths must only differ by one
            var lengthA = text_A.Length;
            var lengthB = text_B.Length;

            if (Math.Abs(lengthA - lengthB) > 1)
            {
                return false;
            }

            //there should only be one character different
            var listA = text_A.ToList();
            var listB = text_B.ToList();

            var aNotInB = listA.Where(x => !listB.Contains(x)).ToList();
            var bNotInA = listB.Where(x => !listA.Contains(x)).ToList();

            if (aNotInB.Count > 1 || bNotInA.Count > 1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 1.6 Implement a method to perform basic string compression using the counts of repeated characters e.g aabcccccaaa => a2b1c5a3. If the compressed string is not smaller than the original string , return the original
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string StringCompression(string text)
        {
            var compressed = "";
            var textArray = text.ToCharArray();
            var currentCharacter = textArray[0].ToString();
            var countOfCurrentCharacter = 1;

            for (int i = 1; i < textArray.Count(); i++)
            {
                if (textArray[i].ToString() != currentCharacter)
                {
                    compressed += $"{currentCharacter}{countOfCurrentCharacter}";

                    currentCharacter = textArray[i].ToString();
                    countOfCurrentCharacter = 1;
                }
                else
                {
                    countOfCurrentCharacter += 1;
                }
            }
            compressed += $"{currentCharacter}{countOfCurrentCharacter}";

            return compressed.Count() < text.Count() ? compressed : text;
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