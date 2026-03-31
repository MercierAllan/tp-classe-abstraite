class CatalogueAppareils
{
    private Dictionary<string, Appareil> appareils;

    public CatalogueAppareils()
    {
        appareils = new Dictionary<string, Appareil>();
    }

    public  void AjouterAppareil(Appareil appareil)
    {
        appareils.Add(appareil.Modele, appareil);
    }

    public void RechercheAppareil(string modele)
    {
        try
        {
            Appareil appareilTrouve = appareils[modele];

            Console.WriteLine("Appareil Trouvé : ");
            appareilTrouve.AfficherInfos();
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Aucun appareil trouvé avec le modèle : " + modele);
        }
    }
}