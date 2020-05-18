using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNumber._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCatagory = "";
            var movies = getMovieList();
            string userWantsToContinue;
            List<Movie> movieByCatagory; 

            Console.WriteLine("Welcome to the movie list application");

            do 
            {
                Console.Write("What catagory of movies are you interested in? (Animated, Drama, Horror): ");
                myCatagory = Console.ReadLine();
                movieByCatagory = GetMoviesByCatagory(myCatagory, movies);

                foreach (var movie in movieByCatagory)
                {
                    Console.WriteLine($"{movie.Title}");
                }

                Console.Write("Whould you like to contiue? (y/n) ");
                userWantsToContinue = Console.ReadLine();
            }
            while (userWantsToContinue.ToLower() == "y");



        }

        static List<Movie> getMovieList()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie("Up", "Animated"));
            movies.Add(new Movie("Inside Out", "Animated"));
            movies.Add(new Movie("Coco", "Animated"));
            movies.Add(new Movie("Finding Nemo", "Animated"));
            movies.Add(new Movie("A Star Is Born", "Drama"));
            movies.Add(new Movie("The Godfather", "Drama"));
            movies.Add(new Movie("12 Years Slave", "Drama"));
            movies.Add(new Movie("Jaws", "Drama"));
            movies.Add(new Movie("Hurt Locker", "Drama"));
            movies.Add(new Movie("A Quiet Place", "Horror"));

            return movies;
        }
        static List<Movie> GetMoviesByCatagory(string catagory, List<Movie> movies)
        {
            List<Movie> myMovies = new List<Movie>();

            foreach (var movie in movies)
            {
                if (movie.Catagory.ToLower() == catagory.ToLower())
                {
                    myMovies.Add(movie);
                }
            }
            return myMovies;
        }
    }
}



//            var myMovies = movies.Where(m => m.Catagory == myCatagory);