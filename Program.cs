namespace Tp_classe_Abstraite;

class Program
{
    static void Main(string[] args)
    {
        Appareil a1 = new Ordinateur("Lenovo","ThinkPad", new DateTime(2020, 5, 15), 15.6);
        a1.Allumer();
        a1.AfficherType();
        a1.AfficherGarentie();
        a1.AfficherInfos();
        Console.WriteLine(a1.ToString());
    }
}
