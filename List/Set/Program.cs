using System;
using System.Collections.Generic;

namespace SampleSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet <int> t = new HashSet<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            // HashSetに1があるため複数登録されない
            t.Add(1);
            
            foreach (int i in t)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}