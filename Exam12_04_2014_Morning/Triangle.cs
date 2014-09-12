using System;

namespace Triangle
{
    class Triangle
    {
       
        public static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

            double pointAX;
            double pointAY;
            double pointBX;
            double pointBY;
            double pointCX;
            double pointCY;
            getInputData(out pointAX, out pointAY, out pointBX, out pointBY, out pointCX, out pointCY);


            double ab;
            double bc;
            double ac;
            calculateSides(pointAX, pointAY, pointBX, pointBY, pointCX, pointCY, out ab, out bc, out ac);

            if (isTriangle(ab, bc, ac))
            {
                double p =(ab + bc + ac) / 2;
                double areaTriangle = Math.Sqrt(p*(p - ab)*(p - bc)*(p - ac));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", areaTriangle);
            }
            else
	        {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", ab);
	        }

        }

        private static void getInputData(out double pointAX, out double pointAY, out double pointBX, out double pointBY, out double pointCX, out double pointCY)
        {
            pointAX = double.Parse(Console.ReadLine());
            pointAY = double.Parse(Console.ReadLine()); ;
            pointBX = double.Parse(Console.ReadLine()); ;
            pointBY = double.Parse(Console.ReadLine()); ;
            pointCX = double.Parse(Console.ReadLine()); ;
            pointCY = double.Parse(Console.ReadLine()); ;
        }

        private static bool isTriangle(double ab, double bc, double ac)
        {
            return (ab + bc > ac && ab + ac > bc && ac + bc > ab);
        }

        private static void calculateSides(double pointAX, double pointAY, double pointBX, double pointBY, double pointCX, double pointCY, out double ab, out double bc, out double ac)
        {
            ab = Math.Sqrt(Math.Pow(pointBX - pointAX, 2) + Math.Pow(pointBY - pointAY, 2));
            bc = Math.Sqrt(Math.Pow(pointBX - pointCX, 2) + Math.Pow(pointBY - pointCY, 2));
            ac = Math.Sqrt(Math.Pow(pointCX - pointAX, 2) + Math.Pow(pointCY - pointAY, 2));
        }
    }
}
