using System;

namespace D4Homeworkcs.proj
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "Gaye");
            myDictionary.Add(1, "Gönül");
            myDictionary.Add(2, "Hilal");
            myDictionary.Add(3, "İlayda");
            myDictionary.Add(4, "Hazal");
            Console.WriteLine(myDictionary.Count);

            foreach (var my in myDictionary.Item1)
            {
                Console.WriteLine(my);
            }

            foreach (var my in myDictionary.Item2)
            {
                Console.WriteLine(my);
            }
        }
    }
}