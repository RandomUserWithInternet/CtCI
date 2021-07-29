using System;

namespace Unique_Charicters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string stuffs = Console.ReadLine();
            int x = stuffs.Length;
            int i = 0; 
            while (i < x)
            {
                char a = stuffs[i];
                int z = 0; 
                while (z < i)
                {
                    char b = stuffs[z];
                    if (b == a)
                    {
                        z = i;
                        i = x;
                        Console.WriteLine("The string has non-unique charicters.");
                    }
                    z++;
                }
                i++;
            }
        }
    }
}