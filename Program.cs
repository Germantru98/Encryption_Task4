using System;

namespace Task4_Polybius_Square
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            char[,] alfrus = dp.GetKeyMatrix();
            string message = dp.getMessage("Message.txt");
            Encryption_tools tools = new Encryption_tools();
            var code = tools.Coding(message, alfrus);
            foreach (var item in code)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(tools.Decoding(code, alfrus));
        }
    }
}