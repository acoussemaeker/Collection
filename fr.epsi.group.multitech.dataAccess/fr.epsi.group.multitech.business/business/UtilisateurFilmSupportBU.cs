using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class UtilisateurFilmSupportBU
    {
        int utilisateurId;
        int filmId;
        int SupportId;


        UtilisateurFilmSupportBU(UtilisateurFilmSupport utilisateurFilmSupport)
        {
            this.utilisateurId = utilisateurFilmSupport.utilisateurID;
            this.filmId = utilisateurFilmSupport.filmID;
            this.SupportId = utilisateurFilmSupport.supportFilmID;
        }

        UtilisateurFilmSupportBU(int utilisateurID, int FilmId, int SupportId)
        {
            this.utilisateurId = utilisateurID;
            this.filmId = FilmId;
            this.SupportId = SupportId;
        }

        public UtilisateurFilmSupport GetModel()
        {
            UtilisateurFilmSupport _result = new UtilisateurFilmSupport();

            _result.utilisateurID = this.utilisateurId;
            _result.filmID = this.filmId;
            _result.supportFilmID = this.SupportId;

            return _result;
        }
    }
}
