using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hafman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string:");
            string input = Console.ReadLine(); // вводим строку которую будем сжимать
            Hafman_tree haffmanTree = new Hafman_tree();

            // Строим дерево
            haffmanTree.Build(input);

            // Шифруем
            BitArray encoded = haffmanTree.Encode(input);

            Console.Write("Encoded: "); // выводим зашифрованый вариант
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            // Расшифровываем
            string decoded = haffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded); // выводим расшифровку

            Console.ReadLine();
        }
    }
}
