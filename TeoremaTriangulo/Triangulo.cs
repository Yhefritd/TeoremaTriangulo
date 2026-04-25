using System;

public class Triangulo
{
    private double ladoA;
    private double ladoB;
    private double ladoC;

    public Triangulo(double a, double b, double c)
    {
        ladoA = a;
        ladoB = b;
        ladoC = c;
    }

    public bool getExiste()
    {
        double max = Math.Max(ladoA, Math.Max(ladoB, ladoC));
        double sumaTotal = ladoA + ladoB + ladoC;

        return max < (sumaTotal - max);
    }

    public double getPerimetro()
    {
        return ladoA + ladoB + ladoC;
    }

    public double getArea()
    {
        double s = getPerimetro() / 2;
        return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
    }

    public string getTipo()
    {
        if (ladoA == ladoB && ladoB == ladoC)
            return "Equilátero";
        if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            return "Isósceles";

        return "Escaleno";
    }
}