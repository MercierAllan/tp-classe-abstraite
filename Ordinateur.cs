class Ordinateur : Appareil
{
    protected double tailleEcran;

    public Ordinateur(string marque, string modele, DateTime dateFabrication, double tailleEcran)
        : base(marque, modele, dateFabrication)
    {
        this.tailleEcran = tailleEcran;
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur");
    }

    public override void CalculerAnciennete()
    {
        Console.WriteLine($"L'ancienneté de l'ordinateur est de {DateTime.Now.Year - dateFabrication.Year} ans");
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}, Modèle: {modele}, Date de fabrication: {dateFabrication.ToShortDateString()}, Taille de l'écran: {tailleEcran} pouces, L'ancienneté de l'ordinateur est de {DateTime.Now.Year - dateFabrication.Year} ans");
    }

    public override string ToString()
    {
        return $"Marque: {marque}, Modèle: {modele}, Taille de l'écran: {tailleEcran} pouces";
    }
}