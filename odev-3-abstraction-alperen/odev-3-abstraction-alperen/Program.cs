using System;

public interface IYakitTuketimi
{
    double YakitTuketimiHesapla();
}

public abstract class Araba : IYakitTuketimi
{
    public abstract double YakitTuketimiHesapla();
}

public class BMW : Araba
{
    public override double YakitTuketimiHesapla()
    {
        return 80.0;
    }
}

public class Mercedes : Araba
{
    public override double YakitTuketimiHesapla()
    {
        return 70.0;
    }
}

public class Porsche : Araba
{
    public override double YakitTuketimiHesapla()
    {
        return 60.0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Araba[] arabalar = { new BMW(), new Mercedes(), new Porsche() };
        double toplamYakit = 0;

        foreach (var araba in arabalar)
        {
            toplamYakit += araba.YakitTuketimiHesapla();
        }

        Console.WriteLine("Toplam yakıt tüketimi: " + toplamYakit + " L");
        Console.ReadKey(); // Konsolun kapanmasını engeller.
    }
}