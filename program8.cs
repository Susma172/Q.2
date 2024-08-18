using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma
{
    internal class LabQN8
    {
        public static string Reverse(string Input)
        {
            char[] chars = Input.ToCharArray();

            string reversedString = String.Empty;

            for (int i = chars.Length - 1; i > -1; i--)
            {
                reversedString += chars[i];
            }
            return reversedString;
        }
      /*  static void Main(string[] args)
        {
            Console.Write("Enter a name:");
            string name = Console.ReadLine();

            Console.WriteLine(Reverse(name));
        }*/
    }
}
