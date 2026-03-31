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

        Appareil a2 = new Smartphone("Apple", "iPhone 12", new DateTime(2021, 10, 23), 3);
        a2.Allumer();
        a2.AfficherType();
        a2.AfficherGarentie();
        a2.AfficherInfos();

        List<Appareil> appareils = new List<Appareil>();
        appareils.Add(a1);
        appareils.Add(a2);

        foreach (Appareil appareil in appareils)
        {
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherGarentie();
            appareil.AfficherInfos();
        }
    
        Dictionary<string, Appareil> dictAppareils = new Dictionary<string, Appareil>();
        dictAppareils.Add(a1.Modele, a1);
        dictAppareils.Add(a2.Modele, a2);
        string cleRecherche = "ThinkPad";
        if (dictAppareils.ContainsKey(cleRecherche))
        {
            Appareil appareilTrouve = dictAppareils[cleRecherche];
            Console.WriteLine($"Appareil trouvé : {appareilTrouve.ToString()}");
        }
        else
        {
            Console.WriteLine($"Aucun appareil trouvé avec le modèle : {cleRecherche}");
        }

    }
}
