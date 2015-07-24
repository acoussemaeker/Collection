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
            //GenreFilmBU genrefilm = new GenreFilmBU("haha");
            //GenreJeuxBU genrejeux = new GenreJeuxBU("hihi");
            //GenreLivreBU genrelivre = new GenreLivreBU("hoho");
            //context.GenreFilm.Add(genrefilm.GetModel());
            //context.GenreJeux.Add(genrejeux.GetModel());
            //context.GenreLivre.Add(genrelivre.GetModel());
            //context.SaveChanges();

            //2
            //DateTime time1 = new DateTime(2015, 12, 31);
            //FilmBU toto = new FilmBU("toto", "beaufilm", "jeanpol Morel", time1, "alaska", 1);
            //context.Film.Add(toto.GetModel());
            //context.SaveChanges();

            //JeuxBU jeux1 = new JeuxBU("jeux", "bon jeux", time1, "bah l'éditeur", 1);
            //context.Jeux.Add(jeux1.GetModel());
            //context.SaveChanges();

            //3
            //SupportFilmBU supportfilmbu = new SupportFilmBU("Supportfilm");
            //SupportLivreBU supportlivrebu = new SupportLivreBU("SupportLivre");
            //SupportJeuxBU supportjeuxbu = new SupportJeuxBU("SupportJeux");
            //context.Supportfilm.Add(supportfilmbu.GetModel());
            //context.Supportlivre.Add(supportlivrebu.GetModel());
            //context.Supportjeux.Add(supportjeuxbu.GetModel());
            //context.SaveChanges();

            //4
            UtilisateurBU anthony = new UtilisateurBU("antlel@hotmail.fr", "anthony", "leloire", "anthony", "1 bis rue d'hinges", 62000, "Gonnehem");
            //context.Utilisateur.Add(anthony.GetModel());
            //context.SaveChanges();

            //5
            //UtilisateurFilmSupportBU test = new UtilisateurFilmSupportBU(1, 1, 1);
            //context.UtilisateurFilmSupport.Add(test.GetModel());
            //context.SaveChanges();

            //UtilisateurJeuxSupportBU test = new UtilisateurJeuxSupportBU(1, 1, 1);
            //context.UtilisateurJeuxSupport.Add(test.GetModel());
            //context.SaveChanges();

            UtilisateurBU toto = new UtilisateurBU(anthony.GetModel());
            toto.AddUtilisateurFilmSupportBU(1, 1);
            context.UtilisateurFilmSupport.Add(toto.AddUtilisateurFilmSupportBU(1, 1));
            context.SaveChanges();
            FilmRepository _fr = new FilmRepository(context);
            
        }
    }
}
