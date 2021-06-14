using Buutti_Movie_DataBase.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Buutti_Movie_DataBase.Controllers
{
    public class MovieController
    {
        public string GetPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.FullName + @"Movies.json";
            return path;
        }

        public List<Movie> GetMovies()
        {
            string json = File.ReadAllText(GetPath());
            List<Movie> deserializedDataBase = JsonConvert.DeserializeObject<List<Movie>>(json);
            return deserializedDataBase;
        }

        public void AddMovie(string name, string description, double length, string moviePosterUrl)
        {
            List<Movie> allMovies = GetMovies();
            int id = allMovies.Count;
            Movie movie = new Movie
            {
                Id = 1 + id++,
                Name = name,
                Description = description,
                Length = length,
                MoviePosterUrl = moviePosterUrl
            };
            allMovies.Add(movie);
            string jsonNewMovie = JsonConvert.SerializeObject(allMovies);
            File.WriteAllText(GetPath(), jsonNewMovie);
        }

        public void UpdateMoviesList()
        {
            List<Movie> allMovies = new List<Movie>();
            string jsonUpdateMovies = JsonConvert.SerializeObject(allMovies);
            File.WriteAllText(GetPath(), jsonUpdateMovies);
        }
        
        public void AddDummyMovies()
        {
            List<Movie> allMovies = new List<Movie>
            {
                new Movie{Id = 1, Name = "The Avengers", Description = "Super hero movie", Length = 2.24, MoviePosterUrl = "https://images-na.ssl-images-amazon.com/images/I/719SFBdxRtL._AC_SY679_.jpg"},
                new Movie{Id = 2, Name = "Saw", Description = "Horror movie", Length = 1.43, MoviePosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Saw_official_poster.jpg"},
                new Movie{Id = 3, Name = "The Expendables", Description = "Action movie", Length = 1.53, MoviePosterUrl = "https://images-na.ssl-images-amazon.com/images/I/81S7i5ejqlL._AC_SY741_.jpg"}
            };

            string jsonDummyMovies = JsonConvert.SerializeObject(allMovies);
            File.WriteAllText(GetPath(), jsonDummyMovies);
        }

        public string PrintMovie(Movie movie)
        {
            movie.Name = movie.Name;
            movie.Description = movie.Description;
            movie.Length = movie.Length;
            return $"Name: {movie.Name}\nDescription: {movie.Description}\nLength: {movie.Length.ToString("F")}";
        }
    }
}
