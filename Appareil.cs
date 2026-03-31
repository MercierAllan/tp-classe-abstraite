abstract class Appareil
{
    protected string marque;
    protected string modele;
    protected DateTime dateFabrication;

    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
    }

    public void Allumer()
    {
        Console.WriteLine("L'appareil s'allume");
    }

    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil");
    }

    public virtual void AfficherGarentie()
    {
        Console.WriteLine("Garantie standard de l'appareil");
    }

    public abstract void AfficherInfos();

    public abstract void CalculerAnciennete();

    public string Modele
    {
        get { return modele; }
    }
}