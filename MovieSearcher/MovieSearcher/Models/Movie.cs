using System;
using Windows.Data.Json;
using System.Collections.ObjectModel;
using MovieSearcher.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using MovieSearcher.Providers;

// aytac

namespace MovieSearcher.Models
{
    public class Movie
    {
        public static ReviewProvider reviewProvider=new ReviewProvider();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public string Image { get; set; }
        public string Overview { get; set; }    // For first page
        public bool Favorited
        {
            get
            {
                return MainControl.User.Favorites.Contains(this);
            }
            set
            {
                if (value)
                {
                    MainControl.User.Favorites.Add(this);
                    Console.WriteLine("Favorite movie list size is now: " + MainControl.User.Favorites.Count);
                }
                else
                {
                    MainControl.User.Favorites.Remove(this);
                }
            }
        }

        public bool Watched
        {
            get
            {
                return MainControl.User.Watched.Contains(this);
            }
            set
            {
                if (value)
                {
                    MainControl.User.Watched.Add(this);
                    Console.WriteLine("Watched movie list size is now: " + MainControl.User.Watched.Count);
                }
                else
                {
                    MainControl.User.Watched.Remove(this);
                }
            }
        }


        public bool Wishlist
        {
            get
            {
                return MainControl.User.Wishlist.Contains(this);
            }
            set
            {
                if (value)
                {
                    MainControl.User.Wishlist.Add(this);
                    Console.WriteLine("Amount of movies in wishlist is now: " + MainControl.User.Wishlist.Count);
                }
                else
                {
                    MainControl.User.Wishlist.Remove(this);
                }
            }
        }




        // Just in testing phase, probs not needed
        public ObservableCollection<IReview> Reviews { get; set; }      // Create new instance of Review model (from Providers)

        public Movie(string JsonString)
        {
            Console.WriteLine(JsonString);      // Add objects from Providers.
            JsonObject root = Windows.Data.Json.JsonValue.Parse(JsonString).GetObject();    // Get the first layer
            Name = root["original_title"].GetString();      // Get second layer for every object
            Id = (int)(root["id"].GetNumber());             // Sets all values from class Movie
            Year = root["release_date"].GetString();
            Year = Year.Split('-')[0];
            Image = "https://image.tmdb.org/t/p/w500/" + root["backdrop_path"].GetString();
            Overview = root["overview"].GetString();

            /*
            Reviews.Add(new RottenRomatoes(JsonString));         // Prototype for reviews. Pass values to Review model. Do this in reviews
            Reviews.Add(new Imdb(JsonString));
            */

            Reviews = reviewProvider.GetReviews(Name);
        }

        public Movie(int a)
        {
            Id = -1;
            Name = "Movie Name";
            Age = "age here";
            Year = "00-00-0000";
            Runtime = "0s";
            Image = "https://i.redd.it/1yoqu2n58yy11.png";
            Reviews.Add(new RottenRomatoes(""));
        }


        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Movie other = (Movie)obj;
            if (Id.Equals(other.Id))
            {
                return true;
            }
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }

    }



}

