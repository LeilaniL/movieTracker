using System;
using System.Collections.Generic;
using System.Threading;

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
        Console.WriteLine("Great! Enter their name:");
        newMovie.Director = Console.ReadLine();
        Console.WriteLine(newMovie);
      }
      else
      {
        Console.WriteLine("No worries. You can always add it later.");
      }
      Console.ResetColor();
      AllMovies.Add(newMovie);
      Menu();
    }
    private static void ViewList()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You have {0} movies in your watch list.", AllMovies.Count);
      foreach (Movie film in AllMovies)
      {
        Console.WriteLine(film);
      }
      Menu();
    }

    private static void RateMovie()
    {
      Movie selectedFilm = null;
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("What movie are you rating?");
      Movie inputFilm = new Movie(Console.ReadLine());
      if (AllMovies.Contains(inputFilm))
      {
        selectedFilm = AllMovies[AllMovies.IndexOf(inputFilm)];
      }
      else
      {
        selectedFilm = inputFilm;
        AllMovies.Add(selectedFilm);
      }
      Console.WriteLine("What is {0}'s rating?", selectedFilm.Name);
      selectedFilm.RateMovie(Console.ReadLine());
      Menu();
    }

    private static void Menu()
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(@"**********MENU***********
      
      Please choose from the following options:
      1 - View Your Movies
      2 - Add A New Movie
      3 - Rate A Movie You've Seen");
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
        case 3:
          RateMovie();
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
      Thread.Sleep(1000);
      ShowPic();
      Thread.Sleep(1000);
      Menu();
      // Console.WriteLine("Rate your new movie! 1 -5");
      // newMovie.RateMovie(Console.ReadLine());
      // //newMovie.Genre = "test";
      // Console.WriteLine("What genre is your movie?");
      // newMovie.SetGenre(Console.ReadLine());
    }
    private static void ShowPic()
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine(@"WNXNXXWNXNNNNXXWNXNNXX0dc'.       ..;ldkKWNXNNXNNNNNXNNXNNXNNXNNNNNXNNXNNNN
NNNNNNNNNNNNNNNNNNKOo;..               .,lkKXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNNNNXNN0o,.      ,ldkkxxo;.       'lOXNNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNKo'        :0NNNNNNNXo.        .:xKNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNXNNNNXO;          cKNNNNNNNNd.          .;xXNNNNXNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNNXk,    ...    .c0XNNNNKd.     ...     .:OXXNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNNO'   'oOK0x:.   .:dkxl,     'dO00k:     .dXNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNK:   ,ONNNNNXo.            .:0NNNNNKc     .c0NNNNNNNNNNNNNNNNNNNN
NNNNNNNNNNx.  .dNNNNNNNK:           'lONNNNNNNO'   ,'.;0NNNNNNNNNNNNNNNNNNN
NNNNNNNNNXo.  .kNNNNNNN0;   .:ol.   .:xXNNNNNN0;   ;x,.cKNNNNNNNNNNNNNNNNNN
NNNNNNNNNXl    ;x0XK0xc.    ,OXK:     .;dOKXKk:.   ,0k..oXNNNNNNNNNNNNNNNNN
NNNNNNNNNNo.     ....        .,'.        .''..     :KXl.'ONNNXNNNNNNNNNNNNN
NNNNNNNNNNk'         ...'..        .',,'..        .dXNk'.oXNNNNNNNNNNNNNNNN
NNNNNNNNNNXo.      ;dO0KKKk;     'xKXXXX0kl.      ;0NNK: :KNNNNNNNNNNNNNNNN
NNNNNNNNNNN0:     :KNNNNNNN0,   .xNNNNNNNNXd.    'kNNNXl ,0NNNNNNNNNNNNNNNN
NNNNNNNNNNNN0c    ;0NNNNNNNXl   ,0NNNNNNNNXo.   ,kXNNNNo.'ONNNNNNNNNNNNNNNN
NNNNNNNNNNNNNKd.   'd0XNNNN0,   .oKNNNNXKx;.  .c0NNNNNNo.'ONNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNX0l.   .;oddc'      ,lool:'   .;kXNNNNNNNo 'ONNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNNNX0d,.                    .'ckXNNNNNNNNXl ,0NNNNNNNNNNNNNNNN
NNNNNNNXNNNNNXNNNNNXOdc,..          ..':okKNNXNNNNNNNNXc ;KNNNNNNNNNNNNNNNN
NNNNNNNNNNXNNNNNNNNNXNNXKOxdolllodxk0KXNNNNNNNNNNNNNNNXc ;KNNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXc ;0NNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNXNNNNNNNNNNNNNNNNNNNNNNNNXo..kNNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNXNNNNNNNXNNNNNNNNNNNNNNNNNO;.cKNNNNNNNNNNNNNNN
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXNNNXNNNNNNNNNNNNNNNNNNXk,.;xKNNNNNNNNNNNNN
NNNNNNNNNNXNNNNNNNNNNNNNNNNNNNNNXNNNNNNNNNNNNNNNNNNNXNNNN0o'.':d0NNNNNNNNNN
XNNXNNXNNXNNXNNXNNXNNXNNXXNNXNNXNNNNNXXNNXNNNNNXNNXNWNXNXNNOl' .dXXNNXNNXNN");
      Console.ResetColor();
    }
  }

}
