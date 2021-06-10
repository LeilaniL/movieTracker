using System;
using System.Collections.Generic;

namespace ObjectsDemo
{
  class Movie
  {
    public string Name { get; set; }
    public string Director { get; set; }
    public string Genre { get; private set; }
    public bool Seen { get; set; }
    private int Rating;
    private static List<Movie> Favorites = new List<Movie> { };

    public Movie(string movieName, string director = "", string genre = "")
    {
      Name = movieName;
      Director = director;
      Genre = genre;
      Seen = false;
      Rating = 0;
    }

    public override string ToString()
    {
      if (Director != "" && Rating != 0)
      {
        return Director + "'s " + Name + ": " + Rating + " stars";
      }
      else if (Director != "")
      {
        return Director + "'s " + Name;
      }
      else if (Rating != 0)
      {
        return Name + ": " + Rating + " stars";
      }
      else
      {
        return Name;
      }
    }

    public static List<Movie> getDefaultList()
    {
      Movie lotr = new Movie("The Lord of the Rings: Fellowshp of the Ring", "Peter Jackson", "fantasy");
      Movie parasite = new Movie("Parasite", "Bong Joon-Ho", "drama");
      Movie nomadland = new Movie("Nomadland", "Chloe Zhao", "drama");
      Movie montyPython = new Movie("Monty Python and the Holy Grail", "Terry Gilliams", "comedy");
      return new List<Movie> { lotr, parasite, nomadland, montyPython };
    }

    public void RateMovie(string rating)
    {
      Seen = true;
      try
      {
        Rating = int.Parse(rating);
      }
      catch (System.Exception)
      {
        Console.WriteLine("There was an error. Please try again.");
        throw;
      }
      if (Rating >= 4)
      {
        Favorites.Add(this);
      }
      Console.WriteLine("{0} has a rating of {1}", Name, Rating);
    }

    public void SetGenre(string movieType)
    {
      string typeNoSpaces = movieType.Trim();
      var genreList = new List<string> { "drama", "comedy", "scifi", "fantasy", "romance", "romcom" };
      if (genreList.Contains(typeNoSpaces))
      {
        Genre = typeNoSpaces;
        Console.WriteLine("{0} is a {1}", Name, Genre);
      }
      else
      {
        Console.WriteLine("??? Unknown genre");
      }
    }
  }
}