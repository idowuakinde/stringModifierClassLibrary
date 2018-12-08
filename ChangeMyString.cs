using System;

namespace stringModifierClassLibrary
{
    public class ChangeMyString
    {
        public static string MakeAllUpperCase(string inputString)
        {
            return inputString.ToUpper();
        }

        public static string MakeReverse(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            
            return new string(arr);
        }
    }
}
