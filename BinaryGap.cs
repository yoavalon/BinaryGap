using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        public static int solution(int N)
        {
            int result = 0;

            string c = Convert.ToString(N, 2);
            c += "1";
            Console.WriteLine(c);
           
            int d = 0;
            int last = 0;
            
            while (d!=-1)
            {
                d = c.IndexOf('1', last);
                if (d != -1)
                {                  
                    if (d - last > result)
                        result = d - last;

                    last = d + 1;                                     
                }
            }




            return result;
        }

        static void Main(string[] args)
        {
            solution(256);
            Console.ReadKey();

        }
    }
}
