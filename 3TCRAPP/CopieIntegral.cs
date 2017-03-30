using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TCRAPP
{
    class CopieIntegral : Acte
    {
        #region Properties        
        
        public string Sexe { get; set; }
        public string SexeAr { get; set; }
        public string NationPere { get; set; }
        public string NationPereAr { get; set; }
        public string NationMere { get; set; }
        public string NationMereAr { get; set; }
        public string LieuPere { get; set; }
        public string LieuPereAr { get; set; }
        public string LieuMere { get; set; }
        public string LieuMereAr { get; set; }
        public int JourPere { get; set; }
        public int MoisPere { get; set; }
        public int AnneePere { get; set; }
        public int JourHP { get; set; }
        public int MoisHP { get; set; }
        public int AnneeHP { get; set; }
        public int JourM { get; set; }
        public int MoisM { get; set; }
        public int AnneeM { get; set; }
        public int JourHM { get; set; }
        public int MoisHM { get; set; }
        public int AnneeHM { get; set; }
        public string Domicile { get; set; }
        public string DomicileAr { get; set; }
        public int JourDr { get; set; }
        public int MoisDr { get; set; }
        public int AnneeDr{ get; set; }
        public int JourHD{ get; set; }
        public int MoisHD{ get; set; }
        public int AnneeHD{ get; set; }
        public string FaitePar{ get; set; }
        public string FaiteAr{ get; set; }
        public string Signe{ get; set; }
        public string SigneAr{ get; set; }
        public string Officier{ get; set; }
        public string OfficierAr{ get; set; }
        public string Heure{ get; set; }
        public string HeureAr{ get; set; }
        public string MinuNaiss{ get; set; }
        public string MinArv{ get; set; }
        public string ProfessionP{ get; set; }
        public string ProfessionPAr{ get; set; }
        public string ProfessionM{ get; set; }
        public string ProfessionMAr{ get; set; }
        public string Ham{ get; set; }
        public string HamAr{ get; set; }
        #endregion Properties
        public CopieIntegral() { }

        public CopieIntegral(string num, string anneeAct, string nom, string nomAr,
            string prenom, string preAr, string nationnalite, string nationAr, 
            string lieuNaiss, string lieuNaissAr, string jour, string mois, string annee, 
            string pere, string pereAr, string mere, string mereAr, string deces, 
            string decesAr, string jourH, string moisH, string anneeH, string sexe, string sexeAr, 
            string nationPere, string nationPereAr, string nationMere, string nationMereAr, 
            string lieuPere, string lieuPereAr, string lieuMere, string lieuMereAr, int jourPere, 
            int moisPere, int anneePere, int jourHP, int moisHP, int anneeHP, int jourM, int moisM, 
            int anneeM, int jourHM, int moisHM, int anneeHM, string domicile, string domicileAr, int jourDr, 
            int moisDr, int anneeDr, int jourHD, int moisHD, int anneeHD, string faitePar, string faiteAr, 
            string signe, string signeAr, string officier, string officierAr, string heure, string heureAr,
            string minuNaiss, string minArv, string professionP, string professionPAr, string professionM, 
            string professionMAr, string ham, string hamAr):base(num,anneeAct,nom,nomAr,
             prenom,preAr,nationnalite,nationAr,
             lieuNaiss,lieuNaissAr,jour,mois,annee,
             pere,pereAr,mere,mereAr,deces,
             decesAr,jourH,moisH,anneeH)
        {
            
            Sexe = sexe;
            SexeAr = sexeAr;
            NationPere = nationPere;
            NationPereAr = nationPereAr;
            NationMere = nationMere;
            NationMereAr = nationMereAr;
            LieuPere = lieuPere;
            LieuPereAr = lieuPereAr;
            LieuMere = lieuMere;
            LieuMereAr = lieuMereAr;
            JourPere = jourPere;
            MoisPere = moisPere;
            AnneePere = anneePere;
            JourHP = jourHP;
            MoisHP = moisHP;
            AnneeHP = anneeHP;
            JourM = jourM;
            MoisM = moisM;
            AnneeM = anneeM;
            JourHM = jourHM;
            MoisHM = moisHM;
            AnneeHM = anneeHM;
            Domicile = domicile;
            DomicileAr = domicileAr;
            JourDr = jourDr;
            MoisDr = moisDr;
            AnneeDr = anneeDr;
            JourHD = jourHD;
            MoisHD = moisHD;
            AnneeHD = anneeHD;
            FaitePar = faitePar;
            FaiteAr = faiteAr;
            Signe = signe;
            SigneAr = signeAr;
            Officier = officier;
            OfficierAr = officierAr;
            Heure = heure;
            HeureAr = heureAr;
            MinuNaiss = minuNaiss;
            MinArv = minArv;
            ProfessionP = professionP;
            ProfessionPAr = professionPAr;
            ProfessionM = professionM;
            ProfessionMAr = professionMAr;
            Ham = ham;
            HamAr = hamAr;
        }

        public static List<CopieIntegral> list_ci = new List<CopieIntegral>();

    }
}
