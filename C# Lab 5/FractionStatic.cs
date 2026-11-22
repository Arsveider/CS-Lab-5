using System;
using System.Collections.Generic;
using System.Text;

internal class FractionStatic
{
    private int numerator, denominator;

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю, применяется значение 1");
                value = 1;
            }
            denominator = value;
        }
    }

    public FractionStatic(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public FractionStatic() : this(0, 1) { }

    public int GCD()
    {
        int a = Math.Abs(Numerator);
        int b = Math.Abs(Denominator);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }


    public void FractionReduction()
    {
        if (Numerator != 0)
        {
            int gcd = GCD();

            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
    }
    public string PrintFraction()
    {
    return $"{Numerator}" + "\n-\n" + $"{Denominator}";
    }

    public static FractionStatic Sum(FractionStatic fraction1, FractionStatic fraction2)
        {
            int numerator = fraction1.numerator * fraction2.denominator + fraction2.numerator * fraction1.denominator;
            int denominator = fraction1.denominator * fraction2.denominator;
            return new FractionStatic(numerator, denominator);
        }

        public static FractionStatic Diff(FractionStatic fraction1, FractionStatic fraction2)
        {
            int numerator = fraction1.numerator * fraction2.denominator - fraction2.numerator * fraction1.denominator;
            int denominator = fraction1.denominator * fraction2.denominator;
            return new FractionStatic(numerator, denominator);
        }

        public static FractionStatic Prod(FractionStatic fraction1, FractionStatic  fraction2)
        {
            int numerator = fraction1.numerator * fraction2.numerator;
            int denominator = fraction1.denominator * fraction2.denominator;
            return new FractionStatic(numerator, denominator);
        }

        public static FractionStatic Div(FractionStatic fraction1, FractionStatic fraction2)
        {
            int numerator = fraction1.numerator * fraction2.denominator;
            int denominator = fraction1.denominator * fraction2.numerator;
            return new FractionStatic(numerator, denominator);
        }

        public static FractionStatic operator +(FractionStatic fraction1, FractionStatic fraction2)
        {
            return Sum(fraction1, fraction2);
        }

        public static FractionStatic operator -(FractionStatic fraction1, FractionStatic fraction2)
        {
            return Diff(fraction1, fraction2);
        }

        public static FractionStatic operator *(FractionStatic fraction1, FractionStatic fraction2)
        {
            return Prod(fraction1, fraction2);
        }

        public static FractionStatic operator /(FractionStatic fraction1, FractionStatic fraction2)
        {
            return Div(fraction1, fraction2);
        }
}
