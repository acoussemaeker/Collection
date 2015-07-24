using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class UtilisateurLivreSupportBU
    {
        int utilisateurId;
        int livreId;
        int SupportId;


        public UtilisateurLivreSupportBU(UtilisateurLivreSupport utilisateurLivreSupport)
        {
            this.utilisateurId = utilisateurLivreSupport.utilisateurID;
            this.livreId = utilisateurLivreSupport.livreID;
            this.SupportId = utilisateurLivreSupport.supportLivreID;
        }

        public UtilisateurLivreSupportBU(int utilisateurID, int LivreId, int SupportId)
        {
            this.utilisateurId = utilisateurID;
            this.livreId = LivreId;
            this.SupportId = SupportId;
        }

        public UtilisateurLivreSupport GetModel()
        {
            UtilisateurLivreSupport _result = new UtilisateurLivreSupport();

            _result.utilisateurID = this.utilisateurId;
            _result.livreID = this.livreId;
            _result.supportLivreID = this.SupportId;

            return _result;
        }
    }
}
