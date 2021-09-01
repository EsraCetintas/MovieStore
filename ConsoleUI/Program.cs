using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilmManager manager = new FilmManager(new EfFilmDal());
            //FilmAddtest(manager);
            //FilmGetAllTest(manager);
            //FilmDeleteTest(manager);

            //ActorManager actorManager = new ActorManager(new EfActorDal());
            //ActorAddTest(actorManager);
            //ActorGetAllTest(actorManager);

            //DirectorManager directorManager = new DirectorManager(new EfDirectorDal());
            //DirectorAddTest(directorManager);
            //DirectorGetAllTest(directorManager);
            Console.ReadKey();
        }

        private static void DirectorAddTest(DirectorManager directorManager)
        {
            directorManager.Add(new Director { DirectorName = "Gore", DirectorSurname = "Verbinski" });
        }

        private static void DirectorGetAllTest(DirectorManager directorManager)
        {
            foreach (var director in directorManager.GetAll().Data)
            {
                Console.WriteLine(director.DirectorName + " " + director.DirectorSurname);
            }
        }

        private static void ActorGetAllTest(ActorManager actorManager)
        {
            foreach (var actor in actorManager.GetAll().Data)
            {
                Console.WriteLine(actor.ActorName + " " + actor.ActorSurname);
            }
        }

        private static void ActorAddTest(ActorManager actorManager)
        {
            actorManager.Add(new Actor { ActorName = "Orlando", ActorSurname = "Bloom" });
        }

        private static void FilmDeleteTest(FilmManager manager)
        {
            manager.Delete(new Film { FilmId = 1, DirectorId = 1, FilmTypeId = 6, FilmName = "Inception", FilmYear = 2010, Price = 18});
        }

        private static void FilmGetAllTest(FilmManager manager)
        {
            foreach (var film in manager.GetAll().Data)
            {
                Console.WriteLine(film.FilmName);
            }
        }

        private static FilmManager FilmAddtest(FilmManager manager)
        {
            return new FilmManager(new EfFilmDal());
            //manager.Add(new Film { DirectorId = 1, FilmTypeId = 6, FilmName = "Inception", FilmYear = 2010, Price = 18, DirectorType = false });
        }
    }
}
