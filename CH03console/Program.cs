using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("3일차 수업시작");
              int a = 100;
              if (a > 50)
              {
                  Console.WriteLine("참입니다");
              }
              if (!(a > 150))
              {
                  Console.WriteLine("거짓입니다");
              }

              if (a > 200)
              {
                  Console.WriteLine("참입니다");
              }*/
            int height = 165;
            /*
            if (height >= 180)
            {
                Console.WriteLine("180 이상입니다");
            }
            else
            {
                if (height >= 170)
                {
                    Console.WriteLine("170이상입니다");
                }
                else
                {
                    if (height >= 160)
                    {
                        Console.WriteLine("160이상입니다");
                    }
                    else
                        Console.WriteLine("그외입니다");
                }
            }
            */
            if (height >= 180)
            {
                Console.WriteLine("180 이상입니다");
            }
            else if (height >= 170)
            {
                Console.WriteLine("170이상입니다");
            }
            else if (height >= 160)
            {
                Console.WriteLine("160이상");
            }
            else
            {
                Console.WriteLine("논외");
            }



















        }

    }
}
