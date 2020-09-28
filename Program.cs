using System;
using System.Collections.Generic;

namespace objects_demo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Movie defaultMovie = new Movie("Star Wars");
      List<Movie> allMovies = new List<Movie> { defaultMovie };
      Console.WriteLine("What is a movie you want to see?");
      string inputFave = Console.ReadLine();
      var newMovie = new Movie(inputFave);
      newMovie.Director = "James Cameron";
      allMovies.Add(newMovie);
      Console.WriteLine("Your Watch List:");
      foreach (Movie movie in allMovies)
      {
        Console.WriteLine(movie);
      }
    }
  }
}
