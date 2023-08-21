﻿public class Movie
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