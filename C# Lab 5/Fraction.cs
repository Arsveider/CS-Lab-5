using System.Security.Cryptography;

internal class Fraction
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

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public Fraction() : this(0, 1) { }

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

    public void Sum(Fraction fraction2)
    {
        Numerator = Numerator * fraction2.denominator + fraction2.numerator * Denominator;
        Denominator = Denominator * fraction2.denominator;
    }

    public void Diff(Fraction fraction2)
    {
        Numerator = Numerator * fraction2.denominator - fraction2.numerator * Denominator;
        Denominator = Denominator * fraction2.denominator;
    }

    public void Prod(Fraction fraction2)
    {
        Numerator *= fraction2.numerator;
        Denominator *= fraction2.denominator;
    }

    public void Div(Fraction fraction2)
    {
        Numerator *= fraction2.denominator;
        Denominator *= fraction2.numerator;
    }


    }





