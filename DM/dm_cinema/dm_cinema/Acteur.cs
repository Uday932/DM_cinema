using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Acteur
    {
        private int anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public int AnneeNaissance
        {
            get { return anneeNaissance; }
            set { anneeNaissance = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public Acteur(string prenom,string nom,int anneeNaissance, int id)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Acteur()
        {

        }

       
        public void GetInstance()
        {
            Acteur a = new Acteur();
        }

        public override string ToString()
        {
            string str = "Nom : " + this.nom + "Prénom : " + this.prenom + "Année de naissance : " + this.anneeNaissance;
            return str;
        }
    }
}
