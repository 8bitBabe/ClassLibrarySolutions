using System;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        //adds an extension method to the String class 
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
            //returns true if Char is uppercase 
        }
    }
}