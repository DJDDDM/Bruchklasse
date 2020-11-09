using System;
using System.CodeDom;

namespace Fabian
{
    public class Bruch
    {
        private int dividend;
        private int divisor;

        public Bruch(int dividend, int divisor)
        {
            check_divisor(divisor);
            int GGT = calculateGGT(dividend, divisor);
            this.dividend = dividend / GGT;
            this.divisor = divisor / GGT;
        }

        private void check_divisor(int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException();
        }

        public Bruch(int full_number)
            : this(full_number, 1)
        {
        }

        public float ToFloat()
        {
            return (float)dividend/divisor;
        }

        public static Bruch operator -(Bruch a, Bruch b)
        {
            int newdividend = a.dividend * b.divisor - b.dividend * a.divisor;
            int newdivisor = a.divisor * b.divisor;
            return new Bruch(newdividend, newdivisor);
        }

        public static Bruch operator *(Bruch a, Bruch b)
        {
            return new Bruch(a.dividend * b.dividend, a.divisor * b.divisor);
        }

        public static Bruch operator /(Bruch a, Bruch b)
        {
            return new Bruch(a.dividend*b.divisor, a.divisor*b.dividend);
        }

        public static bool operator ==(Bruch a, Bruch b)
        {
            if (a.dividend == b.dividend && a.divisor == b.divisor) return true;
            return false;
        }

        public static bool operator !=(Bruch a, Bruch b)
        {
            return !(a == b);
        }

        public static bool operator >(Bruch a, Bruch b)
        {
            Bruch difference = a - b;
            if (difference.dividend > 0) return true;
            return false; 
        }

        public static bool operator <(Bruch a, Bruch b)
        {
            return ((a-b).dividend < 0);
        }

        public static bool operator <=(Bruch a, Bruch b)
        {
            return (a == b || a < b);
        }
        public static bool operator >=(Bruch a, Bruch b)
        {
            return (a == b || a > b);
        }

        private int calculateGGT(int a, int b)
        {
            int h;
            while (b != 0)
            {
                h = a % b;
                a = b;
                b = h;
            }
            return a;
        }

        public override string ToString()
        {
            Bruch_output Output = Bruch_output.output_factory(dividend, divisor);
            return Output.ToString();
        }
    }
}