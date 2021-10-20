using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            string longestCommonSequence = "";

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 1; j < str1.Length - i; j++)
                {
                    var substringToFind = str1.Substring(i, j);
                    if (str2.Contains(substringToFind))
                    {
                        if (substringToFind.Length > longestCommonSequence.Length)
                        {
                            longestCommonSequence = substringToFind;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return longestCommonSequence;
        }
    }
}
