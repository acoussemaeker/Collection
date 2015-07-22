
using fr.epsi.group.multitech.dataAccess;
using fr.epsi.group.multitech.dataAccess.repositories;
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
            CollectionEntities context = new CollectionEntities();
            DateTime time1 = new DateTime(2015, 12 , 31);
            FilmBU toto = new FilmBU("toto", "beaufilm","jeanpol Morel" , time1 ,"alaska");

            context.Film.Add(toto.GetModel());
            context.SaveChanges();


            FilmRepository _fr = new FilmRepository(context);
           
            
        }
    }
}
