using fr.epsi.group.multitech.business.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = new DateTime(2015, 12 , 31);
            Film toto = new Film("toto", "beaufilm","jeanpol Morel" , time1 ,"alaska");
        }
    }
}
