using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class SupportLivreBU
    {
        int id;
        string type;

        public SupportLivreBU(Supportlivre supportLivre)
        {
            this.id = supportLivre.id;
            this.type = supportLivre.type;
        }

        public SupportLivreBU(string type)
        {
            this.type = type;
        }

        public Supportlivre GetModel()
        {
            Supportlivre _result = new Supportlivre();

            _result.id = this.id;
            _result.type = this.type;

            return _result;
        }
    }
}
