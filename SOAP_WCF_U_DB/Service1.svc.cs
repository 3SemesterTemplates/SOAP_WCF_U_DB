using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_WCF_U_DB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Movie> ListOfMovies = new List<Movie>()
        {
            new Movie(){Id=1, Titel="Den glade Dame", Rating=3},
            new Movie(){Id=2, Titel="Avengers", Rating=5},
            new Movie(){Id=3, Titel="Harry Potter", Rating=4.5}
        };


        public void AddMovie(Movie newFilm)
        {
            ListOfMovies.Add(newFilm);
        }

        public void DeleteMovie(Movie deleteFilm)
        {
            var film = ListOfMovies.Find(mov => mov.Id == deleteFilm.Id);
            ListOfMovies.Remove(film);
        }

        public List<Movie> GetMovie()
        {
            return ListOfMovies;
        }

        public void UpdateMovie(int id, Movie film)
        {
            var nyfilm = ListOfMovies.Find(mov => mov.Id == film.Id);
            nyfilm.Titel = film.Titel;
            nyfilm.Rating = film.Rating;
        }
    }
}
