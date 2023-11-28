using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Write("Nhập năm: ");
                t = Convert.ToInt32(Console.ReadLine());
                if (t > 0)
                {
                    if (t % 4 == 0 )
                    {
                        if (t % 100 == 0)
                        {
                            if (t % 400 == 0)
                            {
                                Console.WriteLine("{0} là năm nhuận", t);
                            }
                            else { Console.WriteLine("{0} là năm không nhuận", t); }
                        }  
                        else { Console.WriteLine("{0} là năm nhuận", t); }
                    }    
                    else { Console.WriteLine("{0} là năm không nhuận", t); }
                }
                else { Console.WriteLine("nhập sai năm rồi , nhập lại"); }
            }while (t < 0);
            Console.ReadKey();
        }
    }
}
