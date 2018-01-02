using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAP_WCF_U_DB
{
    public class Movie
    {
        public int Id { get; set; }
        public String Titel { get; set; }
        public double Rating { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string titel, double rating)
        {
            Id = id;
            Titel = titel;
            Rating = rating;
        }


        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Titel)}: {Titel}, {nameof(Rating)}: {Rating}";
        }
    }
}