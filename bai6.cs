using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            char traloi;
            int t;
            int   st50=0, st20=0, st10 = 0, st5 = 0;
            while (b == true)
            {
                do
                {
                    Console.Write("nhập số tiền: ");
                    t = int.Parse(Console.ReadLine());
                } while (t % 50000 != 0 || t <= 0);

                if (t >= 500000)
                {
                    st50 = t / 500000;
                    t = t % 500000;
                }
                if (t >= 200000)
                {
                    st20 = t / 200000;
                    t = t % 200000;
                }
                if (t >= 100000)
                {
                    st10 = t / 100000;
                    t = t % 100000;
                }
                if (t >= 50000)
                {
                    st5 = t / 50000;
                    t = t % 50000;
                }
                Console.WriteLine("{0}  :số tờ tiền 500000", st50);
                Console.WriteLine("{0}  :số tờ tiền 200000", st20);
                Console.WriteLine("{0}  :số tờ tiền 100000", st10);
                Console.WriteLine("{0}  :số tờ tiền 50000", st5);
                st50 = 0; st20 = 0; st10 = 0; st5 = 0;
                Console.Write("\n");
                Console.Write("bạn có tiếp tục chương trình không (y/n): ");
                traloi = char.Parse(Console.ReadLine());
                if (traloi == 'n')
                    Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}

