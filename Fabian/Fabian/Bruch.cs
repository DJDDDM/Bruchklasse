using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Fabian
{
    public class Bruch
    {
        private int dividend;
        private int divisor;
        private const string divisionsign = "/";
        private const string fullnumberseperator = "";
        public Bruch(int dividend, int divisor)
        {
            int GGT = calculateGGT(dividend, divisor);
            this.dividend = dividend / GGT;
            this.divisor = divisor / GGT;
        }

        public Bruch(int full_number)
            : this(full_number, 1)
        {
        }

        public static Bruch operator -(Bruch a, Bruch b)
        {
            return new Bruch(1);
        }

        public static Bruch operator *(Bruch a, Bruch b)
        {
            return new Bruch(a.dividend * b.dividend , a.divisor * b.divisor );
        }

        public static Bruch operator /(Bruch a, Bruch b)
        {
            return new Bruch(4, 3);
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
            return false;
        }

        public static bool operator <(Bruch a, Bruch b)
        {
            return false;
        }
        
        private int calculateGGT(int a, int b)
        {
            int h;
            while (b != 0){
                h = a % b;
                a = b;
                b = h;
            }
            return a;
        }



        public string ToString()
        {
            string fullnumber = "";
            string dividendstring = dividend.ToString();
            string divisorstring = divisor.ToString();

            string[] output = {
                fullnumber,
                fullnumberseperator,
                dividendstring,
                divisionsign,
                divisorstring
            };
            return string.Concat(output);
        }
    }
}