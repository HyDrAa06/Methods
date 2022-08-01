using System;

namespace CenterPoints
{
    internal class Program
    {
        static void CenterPoint(int x1, int x2, int y1, int y2)
        {
            int temp1 = 0;
            int temp2 = 0;

            int tempX1 = x1;
            int tempY1 = y1;
            int tempX2 = x2;
            int tempY2 = y2;



            for(; ; )
            {
                if (x1 < 0)
                {
                    x1++;
                }
                if (x1 > 0)
                {
                    x1--;
                }
                if (y1 < 0)
                {
                    y1++;
                }
                if (y1 > 0)
                {
                    y1--;
                }
                temp1++;
                
                if(x1 ==0 && y1 == 0)
                {
                    break;
                }

            }
            for(; ; )
            {
                if(x2 < 0)
                {
                    x2++;
                }
                if(x2 > 0)
                {
                    x2--;
                }
                if(y2 < 0)
                {
                    y2++;
                }
                if(y2 > 0)
                {
                    y2--;
                }


                temp2++;
               
                if (x2 == 0 && y2 == 0)
                {
                    break;
                }
            }

            if(temp1 < temp2)
            {
                Console.WriteLine("({0}, {1})", tempX1, tempY1);
            }

            if (temp1 > temp2)
            {
                Console.WriteLine("({0}, {1})", tempX2, tempY2);
            }
            if(temp1 == temp2)
            {
                Console.WriteLine("({0}, {1})", tempX1, tempY1);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("X1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("X2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y2:");
            int y2 = int.Parse(Console.ReadLine());

            CenterPoint(x1, x2, y1, y2);
        }        
    }
}