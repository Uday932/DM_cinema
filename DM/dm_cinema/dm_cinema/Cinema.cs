using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Cinema
    {
        private Cinema cine;
        private List<Acteur>LesActeurs;
        private List<Film> LesFilms;

        public Cinema()
        {
            LesActeurs = new List<Acteur>();
            LesFilms = new List<Film>();
        }
        public Cinema(Cinema cine, List<Film> LesFilms, List<Acteur> LesActeurs)
        {
            this.cine = cine;
            this.LesActeurs = LesActeurs;
            this.LesFilms = LesFilms;
        }

        public void GetInstance()
        {
            Cinema cinema = new Cinema();
        }
        public void SetActeur(Acteur acteur)
        {
            LesActeurs.Add(acteur);
        }

        public void SetFilm(Film film)
        {
            LesFilms.Add(film);
        }

        public Acteur GetActeur(int id)
        {
            return LesActeurs[id];
        }

        public Film GetFilm(int id)
        {
            return LesFilms[id];
        }

        public List<Acteur> NbActeurs()
        {
            return LesActeurs;
        }

        public List<Film> NbFilms()
        {
            return LesFilms;
        }
    }
}

