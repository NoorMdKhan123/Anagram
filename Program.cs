﻿using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string v1 = new string(ch1);
            string v2 = new string(ch2);
            if(v1 ==v2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
            
        }
    }
}
