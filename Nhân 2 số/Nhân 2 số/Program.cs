using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;// khai báo để sử dụng biết bigintger
namespace Nhân_2_số
{
   internal class Program
    {
        static void Main(string[] args)
        {

            BigInteger num1, num2, product;

            Console.Write("Enter the first large integer: ");
            num1 = BigInteger.Parse(Console.ReadLine());

            Console.Write("Enter the second large integer: ");
            num2 = BigInteger.Parse(Console.ReadLine());

            product = num1 * num2;

            Console.WriteLine("The product of " + num1 + " and " + num2 + " is: " + product);
        }
    }
}
