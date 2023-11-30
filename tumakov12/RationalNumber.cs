using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov12
{ //12.2
    internal class RationalNumber
    {
        private int numerator;
        private int denominator;

     
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator <= b.numerator * a.denominator;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator >= b.numerator * a.denominator;
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int commonDenominator = a.denominator * b.denominator;
            int sumNumerator = a.numerator * b.denominator + b.numerator * a.denominator;

            return new RationalNumber(sumNumerator, commonDenominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int commonDenominator = a.denominator * b.denominator;
            int diffNumerator = a.numerator * b.denominator - b.numerator * a.denominator;

            return new RationalNumber(diffNumerator, commonDenominator);
        }

        public static RationalNumber operator +(RationalNumber a)
        {
            return new RationalNumber(a.numerator, a.denominator);
        }

        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.numerator, a.denominator);
        }

        public static RationalNumber operator ++(RationalNumber a)
        {
            return a + new RationalNumber(1, 1);
        }

        public static RationalNumber operator --(RationalNumber a)
        {
            return a - new RationalNumber(1, 1);
        }

        public static implicit operator float(RationalNumber a)
        {
            return (float)a.numerator / a.denominator;
        }

        public static explicit operator int(RationalNumber a)
        {
            return a.numerator / a.denominator;
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }

       
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.numerator == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            return new RationalNumber(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public static RationalNumber operator %(RationalNumber a, RationalNumber b)
        {
            if (b.numerator == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            RationalNumber quotient = (a / b);
            return a - (b * quotient);
        }
    }
}
