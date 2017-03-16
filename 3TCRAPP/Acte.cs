using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TCRAPP
{
    class Acte
    {
        public string Num { get; set; }
        public string AnneeAct { get; set; }
        public string Nom { get; set; }
        public string NomAr { get; set; }
        public string Prenom { get; set; }
        public string PreAr { get; set; }
        public string Nationnalite { get; set; }
        public string NationAr { get; set; }
        public string LieuNaiss { get; set; }
        public string LieuNaissAr { get; set; }
        public string Jour { get; set; }
        public string Mois { get; set; }
        public string Annee { get; set; }
        public string Pere { get; set; }
        public string PereAr { get; set; }
        public string Mere { get; set; }
        public string MereAr { get; set; }
        public string Deces { get; set; }
        public string DecesAr { get; set; }
        public string JourH { get; set; }
        public string MoisH { get; set; }
        public string AnneeH { get; set; }
        public Acte() { }

        public Acte( string num, string anneeAct, string nom, string nomAr,
            string prenom, string preAr, string nationnalite, string nationAr,
            string lieuNaiss, string lieuNaissAr, string jour, string mois, string annee,
            string pere, string pereAr, string mere, string mereAr, string deces,
            string decesAr, string jourH, string moisH, string anneeH)
        {
            Num = num;
            AnneeAct = anneeAct;
            Nom = nom;
            NomAr = nomAr;
            Prenom = prenom;
            PreAr = preAr;
            Nationnalite = nationnalite;
            NationAr = nationAr;
            LieuNaiss = lieuNaiss;
            LieuNaissAr = lieuNaissAr;
            Jour = jour;
            Mois = mois;
            Annee = annee;
            Pere = pere;
            PereAr = pereAr;
            Mere = mere;
            MereAr = mereAr;
            Deces = deces;
            DecesAr = decesAr;
            JourH = jourH;
            MoisH = moisH;
            AnneeH = anneeH;
        }
     public static List<Acte> list_act = new List<Acte>();
    }
}
