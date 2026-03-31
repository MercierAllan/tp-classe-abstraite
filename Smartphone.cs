class Smartphone : Appareil
{
    protected int nbCapteursPhoto;
    public Smartphone(string marque, string modele, DateTime dateFabrication, int nbCapteursPhoto)
        : base(marque, modele, dateFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}, Modèle: {modele}, Date de fabrication: {dateFabrication.ToShortDateString()}, Nombre de capteurs photo: {nbCapteursPhoto}, L'ancienneté du smartphone est de {DateTime.Now.Year - dateFabrication.Year} ans");
    }

    public override void CalculerAnciennete()
    {
        Console.WriteLine($"L'ancienneté du smartphone est de {DateTime.Now.Year - dateFabrication.Year} ans");
    }
}