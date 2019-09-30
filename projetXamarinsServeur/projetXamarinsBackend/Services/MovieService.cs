using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using projetXamarinsBackend.Contracts;
using projetXamarinsBackend.Models;

namespace projetXamarinsBackend.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<Movie> movies;

        public MovieService(IXamarinProjectDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            movies = database.GetCollection<Movie>(settings.MoviesCollectionName);
        }

        public List<Movie> Get() =>
            movies.Find(book => true).ToList();

        public Movie Get(string id) =>
            movies.Find<Movie>(movie => movie.Id == id).FirstOrDefault();

        public Movie Create(Movie movie)
        {
            movies.InsertOne(movie);
            return movie;
        }

        public void Update(string id, Movie MovieIn) =>
            movies.ReplaceOne(book => book.Id == id, MovieIn);

        public void Remove(Movie bookIn) =>
            movies.DeleteOne(movie => movie.Id == bookIn.Id);

        public void Remove(string id) =>
            movies.DeleteOne(movie => movie.Id == id);
    }
}
