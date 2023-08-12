using System;
using System.Linq;

public class Movie
{
    public string Title;
    public string Studio;
    public string Rating;

    public Movie(string title, string studio, string rating)
    {
        Title = title;
        Studio = studio;
        Rating = rating;
    }

    public Movie(string title, string studio)
    {
        Title = title;
        Studio = studio;
        Rating = "PG";
    }

    public static Movie[] GetPG(Movie[] movies)
    {
        return movies.Where(m => m.Rating == "PG").ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Movie casino = new Movie("Casino Royale", "Eon Productions", "PG-13");
        Movie glass = new Movie("Glass", "Buena Vista International", "PG-13");
        Movie spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

        Movie[] movies = { casino, glass, spiderMan };

        Movie[] pgMovies = Movie.GetPG(movies);

        foreach (var movie in pgMovies)
        {
            Console.WriteLine($"Title: {movie.Title}, Studio: {movie.Studio}, Rating: {movie.Rating}");
        }
    }
}
