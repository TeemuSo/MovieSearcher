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
           float Score { get; set; }
           string Image { get; }
        }

        public class Imdb : IReview
        {

        public float Score { get; set; }
        //int _score;   Old. What is it for?

        // search for string based on id from imdb

        // Imdb getImdbReview 
        
        public Imdb(string jsonString)        // For finding the score.
        {
            Console.WriteLine(jsonString);
            JsonObject root = Windows.Data.Json.JsonValue.Parse(jsonString).GetObject();
            this.Score = (float)(root["vote_average"].GetNumber());
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
                return "Icons\rt-100.png";
            }
        }
    }
    
}
