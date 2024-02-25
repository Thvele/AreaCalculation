using System.ComponentModel;

namespace AreaCalcualtion
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle() { }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool isExist()
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
    
        public bool isRectangular()
        {
            bool res = false;
    
            if (b > a && b > c)
                res = (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2));
            else if (c > a && c > b)
                res = (Math.Pow(b, 2) + Math.Pow(a, 2) == Math.Pow(c, 2));
            else
                res = (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2));
    
            return res;
        }
    
        public double calculateArea()
        {
            if (a == b && b == c && a == c)
            {
                double a1 = ((Math.Sqrt(3) * Math.Pow(a, 2)) / 4);
                return (Math.Round(((Math.Sqrt(3) * Math.Pow(a, 2)) / 4) * 10)) / 10;
            }
    
            double semiPerimeter = (a + b + c) / 2;
            return (Math.Round((Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c))) * 10)) / 10;
        }
    }
    
    
    public class Circle
    {
        public double r;
    
        public Circle() { }

        public Circle(int r)
        {
            this.r = r;
        }

        public double calculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }
    }
}
