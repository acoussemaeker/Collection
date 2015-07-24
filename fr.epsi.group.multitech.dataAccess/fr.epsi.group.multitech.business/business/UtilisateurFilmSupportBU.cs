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
        int SupportFilmId;


        public UtilisateurFilmSupportBU(UtilisateurFilmSupport utilisateurFilmSupport)
        {
            this.utilisateurId = utilisateurFilmSupport.utilisateurID;
            this.filmId = utilisateurFilmSupport.filmID;
            this.SupportFilmId = utilisateurFilmSupport.supportFilmID;
        }

        public UtilisateurFilmSupportBU(int utilisateurID, int FilmId, int SupportFilmId)
        {
            this.utilisateurId = utilisateurID;
            this.filmId = FilmId;
            this.SupportFilmId = SupportFilmId;
        }

        public UtilisateurFilmSupport GetModel()
        {
            UtilisateurFilmSupport _result = new UtilisateurFilmSupport();

            _result.utilisateurID = this.utilisateurId;
            _result.filmID = this.filmId;
            _result.supportFilmID = this.SupportFilmId;

            return _result;
        }
    }
}
