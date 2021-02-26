using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> products = new MyDictionary<int, string>();

            products.Add(524781, "Iphone Pro 12");
            products.Add(534864, "LG G4");
            products.Add(536948, "Samsung Note 10");
            products.Add(543897, "Xiaomi Note 9 Pro");

            products.List();
        }
    }
}
