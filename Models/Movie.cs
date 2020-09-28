using System;
using System.Collections.Generic;

namespace objects_demo
{
  class Movie
  {
    public string Name { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }

    public bool Seen { get; set; }
    public int Rating { get; set; }
    private static List<Movie> Favorites = new List<Movie> { };
    public Movie(string movieName)
    {
      Name = movieName;
      Director = "";
      Genre = "Drama";
      Seen = false;
      Rating = 0;
    }
    public override string ToString()
    {
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      if (Director != "")
      {
        return Director + "'s " + Name;
      }
      else
      {
        return Name;
      }
    }
    public void RateMovie(string rating)
    {
      Rating = int.Parse(rating);
      Seen = true;
      if (Rating >= 4)
      {
        Favorites.Add(this);
      }
      Console.WriteLine("{0} has a rating of {1}", this.Name, this.Rating);
    }
  }
}