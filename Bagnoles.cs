namespace TPfinalC
{
    public class Merceges : Voiture
    {
        public Merceges(int Id, string Marque = "Mercedes", string Modele = "Benz", int Annee = 2018) : base(Id, Marque, Modele, Annee)
        {}
    }

    public class Pegeo : Voiture
    {
        public Pegeo(int Id, string Marque = "Pegeo", string Modele = "berlyngot", int Annee = 2012) : base(Id, Marque, Modele, Annee)
        {}
    }

    public class Reno : Voiture
    {
        public Reno(int Id, string Marque = "Reno", string Modele = "C4", int Annee = 2020) : base(Id, Marque, Modele, Annee)
        {}
    }
}