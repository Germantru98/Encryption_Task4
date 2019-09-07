using System;
using System.IO;
using System.Text;

namespace Task4_Polybius_Square
{
    public class DataPharser
    {
        public string getMessage(string filePath)
        {
            using (StreamReader stream = new StreamReader(filePath, Encoding.Default))
            {
                return stream.ReadToEnd();
            }
        }

        public char[,] GetKeyMatrix()
        {
            using (StreamReader stream = new StreamReader("Alphabet.txt", Encoding.Default))
            {
                char[,] test = new char[9, 9];
                Console.WriteLine(test.Length);
                for (int i = 0; i < test.GetLength(0); i++)
                {
                    for (int j = 0; j < test.GetLength(1); j++)
                    {
                        test[i, j] = (char)stream.Read();
                    }
                }
                return test;
            }
        }
    }
}