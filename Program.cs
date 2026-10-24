using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Binary string: ");
            string Binary = (Console.ReadLine());

            Console.Write("Result: " +BinaryToDecimal(Binary));


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static int BinaryToDecimal(string binary)
        {
            int DecimalValue = 0;
            int BaseValue = 1;
           
            for (int i = binary.Length - 1;i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    DecimalValue += BaseValue;
                   
                }
               
                BaseValue *= 2;
               
            }
            return DecimalValue;






        }

    }
}
