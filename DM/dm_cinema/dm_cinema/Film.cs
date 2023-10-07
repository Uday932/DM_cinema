using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;
        
        public int Annee
        { 
          get { return annee; }
          set { annee = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }


        public Film()
        { 
        }

        public Film(string titre,int annee, string genre, int idFilm, string resume)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
        }

        public void GetInstance()
        {
         Film f = new Film();
        }


        public override string ToString()
        {
            string str = "\nTitre : " + this.titre + "\nAnnée : " + this.annee + "\nGenre : " + this.genre + "\nResumé : " + this.resume;
            return str;
        }
    }

    
}
