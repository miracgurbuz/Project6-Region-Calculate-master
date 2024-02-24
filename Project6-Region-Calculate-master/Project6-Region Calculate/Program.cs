// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen seçiminizi yapınız," +
            "\nÜçgen için -> 1" +
            "\nDikdörtgen için -> 2" +
            "\nDaire için -> 3  yazarak enter a basın.");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("kenar giriniz: ");
                        Üçgen obj = new Üçgen(int.Parse(Console.ReadLine()));
                        obj.bilgiYaz();
                        break;
                    case "2":
                        Console.WriteLine("kenar giriniz: ");
                        Dikdörtgen obj1 = new Dikdörtgen(int.Parse(Console.ReadLine()));
                        obj1.bilgiYaz();
                        break;
                    case "3":
                        Console.WriteLine("yarıçap giriniz: ");
                        Daire obj2 = new Daire(int.Parse(Console.ReadLine()));
                        obj2.bilgiYaz();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
class Üçgen
{
    public int kenar;
    double Alan()
    {
        return kenar * kenar / 4 * Math.Sqrt(3);
    }
    double Cevre()
    {
        return 3 * kenar;
    }

    public Üçgen(int kenar)
    {
        this.kenar = kenar;
    }
    public void bilgiYaz()
    {
        Console.WriteLine($"Çevre: {this.Cevre()}\n Alan: {this.Alan()}");
    }
}
class Dikdörtgen
{
    int kenar;
    double Alan()
    {
        return kenar * kenar;
    }
    double Cevre()
    {
        return 4 * kenar;
    }

    public Dikdörtgen(int kenar)
    {
        this.kenar = kenar;
    }
    public void bilgiYaz()
    {
        Console.WriteLine($"Çevre: {this.Cevre()}\n Alan: {this.Alan()}");
    }
}
class Daire
{
    int yaricap;
    const double pi = 3.14;
    double Alan()
    {
        return pi * yaricap * yaricap;
    }
    double Cevre()
    {
        return 2 * yaricap * pi;
    }
    public Daire(int yaricap)
    {
        this.yaricap = yaricap;
    }
    public void bilgiYaz()
    {
        Console.WriteLine($"Çevre: {this.Cevre()}\n Alan: {this.Alan()}");
    }
}
