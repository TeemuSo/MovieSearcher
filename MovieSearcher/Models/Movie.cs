using System;
using Windows.Data.Json;
using System.Collections.ObjectModel;
using MovieSearcher.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;

// aytac

namespace MovieSearcher.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public string Image { get; set; }
        public string Overview { get; set; }    // For first page
        public bool Favorited { get; set; }     // Just in testing phase, probs not needed
        public ObservableCollection<IReview> Reviews { get; set; } = new ObservableCollection<IReview>();      // Create new instance of Review model (from Providers)

        public Movie(string JsonString)
        {
            Console.WriteLine(JsonString);      // Add objects from Providers.
            JsonObject root = Windows.Data.Json.JsonValue.Parse(JsonString).GetObject();    // Get the first layer
            Name = root["original_title"].GetString();      // Get second layer for every object
            Id = (int)(root["id"].GetNumber());             // Sets all values from class Movie
            Year = root["release_date"].GetString();
            Image = "https://image.tmdb.org/t/p/w500/" + root["backdrop_path"].GetString();
            Overview = root["overview"].GetString();
            Reviews.Add(new Imdb(JsonString));         // Prototype for reviews. Pass values to Review model. Do this in reviews
        }

        public Movie(int a)
        {
            Id = -1;
            Name = "Movie Name";
            Age = "age here";
            Year = "00-00-0000";
            Runtime = "0s";
            Image = "https://i.redd.it/1yoqu2n58yy11.png";
            Reviews.Add(new Imdb(""));
        }


        }



}

