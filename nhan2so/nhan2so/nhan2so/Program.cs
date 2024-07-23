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

            Console.Write("nhap so nguyen dau tien: ");
            num1 = BigInteger.Parse(Console.ReadLine());

            Console.Write("nhap so nguyen thu 2: ");
            num2 = BigInteger.Parse(Console.ReadLine());

            product = num1 * num2;

            Console.WriteLine("ket qua cua " + num1 + " va " + num2 + " la: " + product);
        }
    }
}
