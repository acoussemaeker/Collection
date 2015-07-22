using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess
{
    public class FilmBU
    {
        int id;
        string nom;
        string description;
        string realisateur;
        DateTime dateSortie;
        string paysOrigine;

        public FilmBU(Film film)
        {
            this.id = film.id;
            this.nom = film.nom;
            this.description = film.description;
            this.realisateur = film.realisateur;
            this.dateSortie = film.dateSortie;
            this.paysOrigine = film.paysOrigine;
        }

        public FilmBU(string nom, string description, string realisateur, DateTime dateSortie, string paysOrigine)
        {
            this.nom = nom;
            this.description = description;
            this.realisateur = realisateur;
            this.dateSortie = dateSortie;
            this.paysOrigine = paysOrigine;
        }

        public Film GetModel()
        {
            Film _result = new Film();

            _result.id = this.id;
            _result.nom = this.nom;
            _result.description = this.description;
            _result.realisateur = this.realisateur;
            _result.dateSortie = this.dateSortie;
            _result.paysOrigine = this.paysOrigine;
            _result.idGenre = 1;

            return _result;
        }
    }
}
