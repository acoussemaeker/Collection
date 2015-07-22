using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class UtilisateurBU
    {
        int id;
        string mail;
        string password;
        string nom;
        string prenom;
        string adresse;
        decimal codePostal;
        string ville;

        public UtilisateurBU(Utilisateur utilisateur){
            this.id = utilisateur.id;
            this.mail = utilisateur.mail;
            this.password = utilisateur.password;
            this.nom = utilisateur.nom;
            this.prenom = utilisateur.prenom;
            this.adresse = utilisateur.adresse;
            this.codePostal = utilisateur.codePostal;
            this.ville = utilisateur.ville;
        }

        public UtilisateurBU(string mail, string password, string nom, string prenom, string adresse, decimal codePostal, string ville)
        {
            this.mail = mail;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
        }

        public Utilisateur GetModel()
        {
            Utilisateur _result = new Utilisateur();

            _result.id = this.id;
            _result.mail = this.mail;
            _result.password = this.password;
            _result.nom = this.nom;
            _result.prenom = this.prenom;
            _result.adresse = this.adresse;
            _result.codePostal = this.codePostal;
            _result.ville = this.ville;

            return _result;
        }
    }
}
