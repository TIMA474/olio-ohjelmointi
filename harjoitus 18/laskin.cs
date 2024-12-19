using System;

public static class Laskin
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Difference(double a, double b)
    {
        return a - b;
    }

    public static double Product(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("nolla numero ei ole sallittu");
        }
        return a / b;
    }
}