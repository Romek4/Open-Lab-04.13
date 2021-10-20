namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            string longestCommonSequence = "";

            for (int substringStartIndex = 0; substringStartIndex < str1.Length; substringStartIndex++)
            {
                var maxPossibleLengthOfSubstring = str1.Length - substringStartIndex;
                for (int lengthOfSubstring = 1; lengthOfSubstring < maxPossibleLengthOfSubstring; lengthOfSubstring++)
                {
                    var substringToFind = str1.Substring(substringStartIndex, lengthOfSubstring);
                    if (str2.Contains(substringToFind))
                    {
                        if (substringToFind.Length > longestCommonSequence.Length)
                        {
                            longestCommonSequence = substringToFind;
                        }
                    }
                    else
                    {
                        break; // do not continue in the second 'for' as there will not be any longer common substring found
                    }
                }
            }

            return longestCommonSequence;
        }
    }
}
