using System;

public interface IHareketEdebilme
{
    void HizliGit();
    void Yuz();
    void Uc();
}

public class BMW : IHareketEdebilme
{
    public void HizliGit()
    {
        Console.WriteLine("BMW çok hızlı gidiyor.");
    }

    public void Yuz()
    {
        Console.WriteLine("BMW denizde yüzüyor.");
    }

    public void Uc()
    {
        Console.WriteLine("BMW havada uçuyor.");
    }
}

public class Mercedes : IHareketEdebilme
{
    public void HizliGit()
    {
        Console.WriteLine("Mercedes normal hızda gidiyor.");
    }

    public void Yuz()
    {
        Console.WriteLine("Mercedes denizde yüzüyor.");
    }

    public void Uc()
    {
        Console.WriteLine("Mercedes havada uçuyor.");
    }
}

public class Porsche : IHareketEdebilme
{
    public void HizliGit()
    {
        Console.WriteLine("Porsche normal hızda gidiyor.");
    }

    public void Yuz()
    {
        Console.WriteLine("Porsche yüzemez.");
    }

    public void Uc()
    {
        Console.WriteLine("Porsche havada uçuyor.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BMW bmw = new BMW();
        Mercedes mercedes = new Mercedes();
        Porsche porsche = new Porsche();

        Console.WriteLine("BMW Hareketleri:");
        bmw.HizliGit();
        bmw.Yuz();
        bmw.Uc();

        Console.WriteLine("\nMercedes Hareketleri:");
        mercedes.Yuz();
        mercedes.Uc();

        Console.WriteLine("\nPorsche Hareketleri:");
        porsche.Uc();

        Console.ReadKey(); // Konsolun kapanmasını engeller
    }
}