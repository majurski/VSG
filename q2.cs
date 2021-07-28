using System;
using System.Linq;


namespace myapp
{
    class Program
    {   

        static void Main(string[] args)
        {   
            int intFizz = Convert.ToInt32(Console.ReadLine());
            foreach (int i in Enumerable.Range(1, intFizz))
        {  
            if (i % 3 == 0 && i % 5 == 0)  
            {  
                Console.WriteLine("FizzBuzz");  
            }  
            else if (i % 3 == 0)  
            {  
            Console.WriteLine("Fizz");  
            }  
            else if (i % 5 == 0)  
            {  
            Console.WriteLine("Buzz");  
            }  
            else  
            {  
                Console.WriteLine(i);  
            }  
    }  
        }
    }
}
