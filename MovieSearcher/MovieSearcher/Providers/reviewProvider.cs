using System;
using MovieSearcher.Models;
using System.Net;
using Windows.Data.Json;
using System.Collections.ObjectModel;

// Teemu

namespace MovieSearcher.Providers
{

    public class ReviewProvider
    {
        private WebClient webClient = new WebClient();
        // public Imdb List { get; private set; }

        // Get webclient, make it JsonObject.
        // Get all 
        public ReviewProvider()
        {

        }

        public ObservableCollection<IReview> GetReviews(string title)
        {
            ObservableCollection<IReview> List = new ObservableCollection<IReview>();
            try
            {
                string jsonString = webClient.DownloadString("http://www.omdbapi.com/?apikey=48cdf07&t=" + title);

                JsonObject root = Windows.Data.Json.JsonValue.Parse(jsonString).GetObject();

                JsonArray result = root.GetNamedArray("Ratings");
                foreach (var j in result)
                {
                    JsonObject obj = j.GetObject();
                    Console.WriteLine(obj.ToString());
                    switch (obj.GetNamedString("Source"))
                    {
                        case "Rotten Tomatoes":
                            List.Add(new RottenRomatoes(obj.GetNamedString("Value"), root.GetNamedString("imdbID")));
                            break;
                        case "Internet Movie Database":
                            List.Add(new Imdb(obj.GetNamedString("Value"), root.GetNamedString("imdbID")));
                            break;
                        case "Metacritic":
                            List.Add(new Metacritic(obj.GetNamedString("Value"), root.GetNamedString("imdbID")));
                            break;
                        default:
                            break;
                    }
                       
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }

            return List;


        }
    }
}
        

