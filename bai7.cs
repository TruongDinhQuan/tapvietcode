﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, t;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Write("Nhập chỉ số điện: ");
                p = Convert.ToInt32(Console.ReadLine());
                if (p > 0)
                {
                    if (p <= 50)
                    {
                        t = (p * 1484);
                        Console.WriteLine("số tiền phải trả là: {0}", t);
                    }
                    else if (p <= 100)
                    {
                        t = (50 * 1484) + ((p - 50) * 1533);
                        Console.WriteLine("số tiền phải trả là: {0}", t);
                    }
                    else if (p <= 200)
                    {
                        t = (50 * 1484) + (50 * 1533) + ((p - 100) * 1786);
                        Console.WriteLine("số tiền phải trả là: {0}", t);
                    }
                    else if (p <= 300)
                    {
                        t = (50 * 1484) + (50 * 1533) + (100 * 1786) + ((p - 200) * 2242);
                        Console.WriteLine("số tiền phải trả là: {0}", t);
                    }
                    else if (p <= 400)
                    {
                        t = (50 * 1484) + (50 * 1533) + (100 * 1786) + (100 * 2242) + ((p - 300) * 2503);
                        Console.WriteLine("số tiền phải trả là: {0}", t);
                    }
                    else
                    {
                        t = (50 * 1484) + (50 * 1533) + (100 * 1786) + (100 * 2242) + (100 * 2503) + ((p - 400) * 2587);
                        Console.WriteLine("số tiền phải trả là: ", t);
                    }
                }

                else { Console.WriteLine("nhâp sai"); };

            } while (p < 0);
            Console.ReadKey();
        }
    }
}
