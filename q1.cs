using System;

namespace myapp
{
    class Program
    {   
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main(string[] args)
        {
            string val;
            val = Console.ReadLine();
            string last_two = ReverseString(val.Substring(val.Length - 2));
            string new_word = "";
            foreach (var word in last_two)
                new_word += word + " ";
                Console.WriteLine($"{new_word}");
        }
    }
}
