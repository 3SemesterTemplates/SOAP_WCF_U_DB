using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAP_Movie_Consumer.MovieReference;

namespace SOAP_Movie_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
                Movie[] ListOfMovies = client.GetMovie();
                foreach (var mov in ListOfMovies)
                {
                    Console.WriteLine(mov.Titel + " " + mov.Rating);
                }

                

                
            }

            Console.ReadLine();
        }
    }
}
