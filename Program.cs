using System;
using System.Collections.Generic;

namespace ObjectsDemo
{
  class Program
  {
    static List<Movie> AllMovies = new List<Movie> { };
    private static void AddMovie()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("What is a movie you want to see?");
      Movie newMovie = new Movie(Console.ReadLine());
      Console.WriteLine(newMovie);
      Console.WriteLine("Do you know who directed it? (Y or N)");
      string knowsDirector = Console.ReadLine().ToUpper();
      if (knowsDirector == "Y" | knowsDirector == "YES")
      {
        Console.WriteLine("Good for you!");
      }
      else
      {
        Console.WriteLine("No worries. You can always add it later.");
      }
      Console.ResetColor();
      AllMovies.Add(newMovie);
      Program.Menu();
    }
    void RateMovie(string inputRating)
    {

    }
    private static void ViewList()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You have {0} movies in your watch list.", AllMovies.Count);
      foreach (Movie film in AllMovies)
      {
        Console.WriteLine(film);
      }
      Program.Menu();
    }
    private static void Menu()
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(@"**********MENU***********
      
      Please choose from the following options:
      1 - View Your Movies
      2 - Add A New Movie");
      Console.ResetColor();
      int choice = int.Parse(Console.ReadLine());
      switch (choice)
      {
        case 1:
          ViewList();
          break;
        case 2:
          AddMovie();
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Unrecognized choice. Hit Ctrl + C to exit the program.");
          Console.ResetColor();
          Main();
          break;
      }
    }
    static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(@"------Welcome to the MOVIE LIST!-----");

      Program.Menu();
      // Console.WriteLine("Rate your new movie! 1 -5");
      // newMovie.RateMovie(Console.ReadLine());
      // //newMovie.Genre = "test";
      // Console.WriteLine("What genre is your movie?");
      // newMovie.SetGenre(Console.ReadLine());
    }
  }
}
