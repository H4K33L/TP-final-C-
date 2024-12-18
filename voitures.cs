using System;

namespace TPfinalC
{
public class Voiture {
    private int Id;
    private string Marque;
    private string Modele;
    private int Annee;
    private bool Statut = true;

    public Voiture(int id, string marque, string modele, int annee)
        {
            Id = id;
            Marque = marque;
            Modele = modele;
            Annee = annee;
        }

    public void set_Statut(bool NewStatut)
    {
        Statut = NewStatut;
     }

    public void AfficherVoiture()
        {
                string ToPrint = "Id:"+ Id +"Marque:" + Marque +"Modele:" + Modele +"Annee:" + Annee +"Statut:";
                if (Statut) {
                        ToPrint += "Libre";
                } else {
                        ToPrint += "Occupé";
                }
                Console.WriteLine(ToPrint);
        }
}
}