using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class SupportFilmBU
    {
        int id;
        string type;

        public SupportFilmBU(Supportfilm supportFilm)
        {
            this.id = supportFilm.id;
            this.type = supportFilm.type;
        }

        public SupportFilmBU(string type)
        {
            this.type = type;
        }

        public Supportfilm GetModel()
        {
            Supportfilm _result = new Supportfilm();

            _result.id = this.id;
            _result.type = this.type;

            return _result;
        }
    }
}
