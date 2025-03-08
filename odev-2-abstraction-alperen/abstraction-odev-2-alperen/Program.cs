using System;

public interface IMaasHesaplama
{
    int MaasHesapla();
}

public abstract class Calisan : IMaasHesaplama
{
    public abstract int MaasHesapla();
}

public class GenelMudur : Calisan
{
    public override int MaasHesapla()
    {
        return 80000;
    }
}

public class Mudur : Calisan
{
    public override int MaasHesapla()
    {
        return 60000;
    }
}

public class Programci : Calisan
{
    public override int MaasHesapla()
    {
        return 40000;
    }
}

public class Stajyer : Calisan
{
    public override int MaasHesapla()
    {
        return 5000;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calisan[] calisanlar = { new GenelMudur(), new Mudur(), new Programci(), new Stajyer() };
        int toplamMaas = 0;

        foreach (var calisan in calisanlar)
        {
            toplamMaas += calisan.MaasHesapla();
        }

        Console.WriteLine("Toplam maaş: " + toplamMaas);
        Console.ReadKey(); // Konsolun kapanmasını engeller.
    }
}