using System.Collections.Generic;

namespace Task4_Polybius_Square
{
    public class Encryption_tools
    {
        public List<int> Coding(string message, char[,] keyMatrix)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < keyMatrix.GetLength(0); j++)
                    for (int k = 0; k < keyMatrix.GetLength(1); k++)
                        if (keyMatrix[j, k] == message[i])
                        {
                            tmp.Add(j);
                            tmp.Add(k);
                            break;
                        }
            }
            return tmp;
        }

        public string Decoding(List<int> message, char[,] keyMatrix)
        {
            string result = "";
            for (int a = 0; a < message.Count; a += 2)
            {
                result += keyMatrix[message[a], message[a + 1]];
            }
            return result;
        }
    }
}