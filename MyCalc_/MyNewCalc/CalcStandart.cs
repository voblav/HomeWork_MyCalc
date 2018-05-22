using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCalc
{
    class CalcStandart
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public double Sin(double a)
        {
            return Math.Sin((a * Math.PI) / 180);
        }
        public double Cos(double a)
        {
            return Math.Cos((a * Math.PI) / 180);
        }
        public double Tan(double a)
        {
            return Math.Tan((a * Math.PI) / 180);
        }
        public double Lg(double a)
        {
            return Math.Log(a);
        }
        public double Ln(double a)
        {
            return Math.Log10(a);
        }
        public double Pow(double a)
        {
            return Math.Pow(a, 2);
        }
        public double Percent(double a)
        {
            return a / 100;
        }
    }
}
