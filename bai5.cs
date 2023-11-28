using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Chương trình xắp xếp học lực của sinh viên");
            Console.WriteLine("/n");
            do
            {
                Console.Write("Nhap diem: ");
                t = double.Parse(Console.ReadLine());
                if (0 <= t && t <= 10)
                {
                    if (t >= 9)
                    {
                        Console.WriteLine("xuất sắc");
                    }
                    else if (t >= 8)
                        {
                            Console.WriteLine("Giỏi");
                        }
                        else if (t >= 6.5)
                            {
                                Console.WriteLine("Khá");
                            }
                            else if (t >= 5)
                                {
                                    Console.WriteLine("Trung Bình");
                                }
                                else if (t >= 3.5)
                                    {
                                        Console.WriteLine("Yếu");
                                    }
                                    else {   Console.WriteLine("kém");  }
                }
                else {  Console.WriteLine("nhập sai");  }
            } while (0 >= t || t >= 10);
            Console.ReadKey();
        }
    }
}
