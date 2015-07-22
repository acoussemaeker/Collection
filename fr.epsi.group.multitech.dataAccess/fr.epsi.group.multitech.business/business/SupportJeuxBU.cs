using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class SupportJeuxBU
    {
        int id;
        string type;

        public SupportJeuxBU(Supportjeux supportJeux)
        {
            this.id = supportJeux.id;
            this.type = supportJeux.type;
        }

        public SupportJeuxBU(string type)
        {
            this.type = type;
        }

        public Supportjeux GetModel()
        {
            Supportjeux _result = new Supportjeux();

            _result.id = this.id;
            _result.type = this.type;

            return _result;
        }
    }
}
