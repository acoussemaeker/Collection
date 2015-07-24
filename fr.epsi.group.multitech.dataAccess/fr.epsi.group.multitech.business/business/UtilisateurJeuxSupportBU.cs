using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class UtilisateurJeuxSupportBU
    {
        int utilisateurId;
        int jeuxId;
        int SupportId;


        public UtilisateurJeuxSupportBU(UtilisateurJeuxSupport utilisateurJeuxSupport)
        {
            this.utilisateurId = utilisateurJeuxSupport.utilisateurID;
            this.jeuxId = utilisateurJeuxSupport.jeuxID;
            this.SupportId = utilisateurJeuxSupport.supportJeuxID;
        }

        public UtilisateurJeuxSupportBU(int utilisateurID, int JeuxId, int SupportId)
        {
            this.utilisateurId = utilisateurID;
            this.jeuxId = JeuxId;
            this.SupportId = SupportId;
        }

        public UtilisateurJeuxSupport GetModel()
        {
            UtilisateurJeuxSupport _result = new UtilisateurJeuxSupport();

            _result.utilisateurID = this.utilisateurId;
            _result.jeuxID = this.jeuxId;
            _result.supportJeuxID = this.SupportId;

            return _result;
        }
    }
}
