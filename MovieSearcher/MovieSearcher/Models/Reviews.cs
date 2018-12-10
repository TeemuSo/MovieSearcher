using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSearcher.Providers;
using Windows.Data.Json;
using MovieSearcher.Controls;
using MovieSearcher.Models;

// Teemu takes this
namespace MovieSearcher.Models
{
    

    public interface IReview
    {
           string Name { get;  }
           string Score { get; set; }
           string Image { get; }
    }

    public class RottenRomatoes : IReview
    {

        public string Score { get; set; }
        private string ImdbId;
        //int _score;   Old. What is it for?

        // search for string based on id from imdb
        
        public RottenRomatoes(string jsonString)        // For finding the score.
        {
            Console.WriteLine(jsonString);
            JsonObject root = Windows.Data.Json.JsonValue.Parse(jsonString).GetObject();
            this.Score = root["vote_average"].GetString();
        }

        public RottenRomatoes(string value, string imdbId)
        {
            Score = value;
            ImdbId = imdbId;
        }

        public string Name
        {
            get
            {
                return "Rotten Tomatoes";
            }
        }

        public string Image
        {
            get
            {
                return "/MovieSearcher;component/Icons/rt-100.png";
            }
        }
    }
    public class Imdb : IReview
    {

        public string Score { get; set; }
        private string ImdbId;
        //int _score;   Old. What is it for?

        // search for string based on id from imdb

        // Imdb getImdbReview 

        public Imdb(string value, string imdbId)
        {
            Score = value;
            ImdbId = imdbId;
        }

        public string Name
        {
            get
            {
                return "Imdb";
            }
        }

        public string Image
        {
            get
            {
                return "/MovieSearcher;component/Icons/imdb.png";
            }
        }
    }
    public class Metacritic : IReview
    {
        public string Score { get; set; }
        private string ImdbId;
        //int _score;   Old. What is it for?

        // search for string based on id from imdb

        // Imdb getImdbReview 
        
        public Metacritic(string value, string imdbId)
        {
            Score = value;
            ImdbId = imdbId;
        }

        public string Name
        {
            get
            {
                return "Metacritic";
            }
        }

        public string Image
        {
            get
            {
                return "/MovieSearcher;component/Icons/metacritic.ico";
            }
        }
    }
    

}
