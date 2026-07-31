using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_and_Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie movie = new Movie(111, "1408", 500, 50);
                Movie movie2 = new Movie(112, "Saving Private Ryan", 499, 60);
                Movie movie3 = new Movie(113, "Enemy at the gates", 498, 70);

                Cinema cinema = new Cinema();
                // Console.WriteLine(movie2);

                cinema.AddMovie(movie);
                cinema.AddMovie(movie2);
                cinema.AddMovie(movie3);


                // cinema.View();

                int id = int.Parse(Console.ReadLine());
                var MovieExists = cinema.SearchForMovieById(id);


                if (MovieExists == null)
                {
                    Console.WriteLine("Movie doesn't exist....");
                }
                Console.WriteLine(MovieExists.ToString());


                movie.BookTicket(5);
                Console.WriteLine($"Available seats:  {movie.AvailableSeats}");

                movie.CancelTicket(2);
                Console.WriteLine($"Available Seats:  {movie.AvailableSeats}");

            }
            catch ( Exception exc)
            {

                Console.WriteLine(exc.Message);
            }
         
        
        
        }
    }
}
