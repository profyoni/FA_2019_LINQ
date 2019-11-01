using System;

namespace LINQ
{
    public static class Extensions
    {
        public static bool MyContains(this string s, string key)
        {
            Console.WriteLine("MyContains called");
            return s.Contains(key);
        }
        public static bool IsPrime(this int x)
        {
            return true;
        }
    }
}