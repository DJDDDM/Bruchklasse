using System.Security.Cryptography;

namespace Fabian
{
    internal class Bruch_output
    {
        private const string fullnumberseperator = " ";
        private const string dividend_divisor_seperator = "/";

        public static Bruch_output output_factory(int dividend, int divisor)
        {
            if (divisor == 1) return new Fullnumber_output(dividend);
            if (dividend > divisor) return new MixedNumber_Output(dividend, divisor);
            return new CommonBruch_Output(dividend, divisor);
        }

        public virtual string ToString()
        {
            return "FAKE";
        }

        private class Fullnumber_output : Bruch_output
        {
            private int fullnumber;
            public Fullnumber_output(int number)
            {
                fullnumber = number;
            }

            public override string ToString()
            {
                return fullnumber.ToString();
            }
        }

        private class CommonBruch_Output : Bruch_output
        {
            private int dividend;
            private int divisor;
            public CommonBruch_Output(int dividend, int divisor)
            {
                this.dividend = dividend;
                this.divisor = divisor;
            }

            public override string ToString()
            {
                return string.Concat(dividend, dividend_divisor_seperator, divisor);
            }
        }
        private class MixedNumber_Output : CommonBruch_Output
        {
            private int fullnumber;
            private int dividend;
            private int divisor;
            public MixedNumber_Output(int dividend, int divisor) : base(dividend, divisor)
            {
                fullnumber = dividend / divisor;
                this.dividend = dividend % divisor;
                this.divisor = divisor;
            }

            public override string ToString()
            {
                string output = string.Concat(
                    fullnumber,
                    fullnumberseperator,
                    dividend,
                    dividend_divisor_seperator,
                    divisor
                    );
                return output;
            }
        }
    }
}