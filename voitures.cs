using System;

namespace TP_final_C
{
class Voiture {
        private int Id;
        private string Marque;
        private string Modele;
        private int Annee;
        private bool Statut {
                set {Statut = value;}
                get {
                        if (Statut){
                                return true;}
                        else (Statut) {
                                return false;}
                }
        }



        public Voiture(int Id, string Marque, string Modele, int Annee, string Statut)
        {
                Id = id;
                Marque = marque;
                Modele = modele;
                Annee = annee;
                Statut = statut;
        }

    public bool Statut1 { get => Statut; set => Statut = value; }

    public void AfficherVoiture()
        {
                Console.Writeline ("Id:"+ id "Marque:" + Marque "Modele:" + Modele "Annee:" + Annee "Statut:" + Statut1)
        }
}
}