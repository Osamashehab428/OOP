using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_and_Problem_Solving
{
    internal class Cinema
    {

        List<Movie> movieList = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            foreach (Movie movie2 in movieList)
            {
                if (movie2.MovieId == movie.MovieId)
                {
                    Console.WriteLine("Movie already exists .....");
                    return;
                }


            }

            movieList.Add(movie);
            Console.WriteLine("Movie added");



        }
        public void View()
        {
            if (movieList.Count == 0) { Console.WriteLine("Sorry No movies for today."); return; }
            
            foreach (Movie movie in movieList)
            {
                Console.WriteLine(movie);
                Console.WriteLine();
            }
        }

   
       public Movie SearchForMovieById(int movieId)
        {
            foreach (var movie in movieList)
            {
                if(movie.MovieId == movieId)
                {
                    return movie;
                }
            
            }
            return null;
            
        
        }
    
    



    }
     
}