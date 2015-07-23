using fr.epsi.group.multitech.business.business;
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
            
            //1
            GenreFilmBU filmbu = new GenreFilmBU("FILMBU");
            GenreJeuxBU jeuxbu = new GenreJeuxBU("JEUXBU");
            GenreLivreBU livrebu = new GenreLivreBU("LIVREBU");
            //context.GenreFilm.Add(filmbu.GetModel());
            //context.GenreJeux.Add(jeuxbu.GetModel());
            //context.GenreLivre.Add(livrebu.GetModel());
            //context.SaveChanges();

            //2
            DateTime time1 = new DateTime(2015, 12 , 31);
            FilmBU toto = new FilmBU("toto", "beaufilm","jeanpol Morel" , time1 ,"alaska", 0);
            //context.Film.Add(toto.GetModel());
            //context.SaveChanges();

            //3
            SupportFilmBU supportfilmbu = new SupportFilmBU("Supportfilm");
            SupportLivreBU supportlivrebu = new SupportLivreBU("SupportLivre");
            SupportJeuxBU supportjeuxbu = new SupportJeuxBU("SupportJeux");
            //context.Supportfilm.Add(supportfilmbu.GetModel());
            //context.Supportlivre.Add(supportlivrebu.GetModel());
            //context.Supportjeux.Add(supportjeuxbu.GetModel());
            //context.SaveChanges();

            //4
            UtilisateurBU anthony = new UtilisateurBU("antlel@hotmail.fr", "anthony", "leloire", "anthony", "1 bis rue d'hinges", 62000, "Gonnehem");
            //context.Utilisateur.Add(anthony.GetModel());
            //context.SaveChanges();

            //5
            

            FilmRepository _fr = new FilmRepository(context);
           
            
        }
    }
}
