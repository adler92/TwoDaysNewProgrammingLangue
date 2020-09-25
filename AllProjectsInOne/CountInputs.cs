using System;
using System.Data.SqlTypes;

namespace AllProjectsInOne
{
    //Andreas Ravn Code
    public class CountInputs
    {
        public static void Counting()
        {
            Console.WriteLine("Input your text for counting");
            string text = Console.ReadLine();
            Console.WriteLine("Length = " + text.Length);
            
        }
    }
}