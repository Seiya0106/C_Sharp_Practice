using System;
using System.Collections.Generic;

namespace Sample
{
    public struct Data
    {
        public int id;
        public List<string> names;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data db = new Data();
            db.id = 1;
            db.names = new List<string>();
            db.names.Add("Alice");
            db.names.Add("Bob");
            Console.WriteLine("ID: {0}", db.id);
            Console.WriteLine("Names:");
            foreach (string name in db.names)
            {
                Console.WriteLine("- " + name);
            }
        }
    }
}