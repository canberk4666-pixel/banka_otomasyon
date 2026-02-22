using System;

class BankaHesabi
{
    public string HesapSahibi;
    public double Bakiye;

    public void ParaYatir(double miktar)
    {
        Bakiye += miktar;
        Console.WriteLine("Yeni Bakiye: " + Bakiye + " TL");
    }
}

class Program
{
    static void Main()
    {
        BankaHesabi hesap = new BankaHesabi();
        hesap.HesapSahibi = "hasan";
        hesap.Bakiye = 1000;

        hesap.ParaYatir(200);
    }
}
