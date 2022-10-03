using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai n");
            var piyik1 = int.Parse(Console.ReadLine());
            var piyik2 = piyik1 - 1;
            Console.WriteLine(" ");

            if (piyik1>=1 && piyik1<=10)
            {
                for (int i = piyik1; i > 0; i--)
                {
                    if (i > 1)
                    {
                        var j = i - 1;
                        Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggallah " + j);
                    }
                    else { Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya"); }
                }
            } else { Console.WriteLine("Nilai n tidak valid"); }

        }
    }
}
