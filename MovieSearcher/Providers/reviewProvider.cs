using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSearcher.Models;
using MovieSearcher.Providers;
using System.Net;
using Windows.Data.Json;
using System.Collections.ObjectModel;

// Teemu

namespace MovieSearcher.Providers
{

    public interface IRProvider
    {
        int CurrentPageNo { get; set; }
        ObservableCollection<Imdb> GetImdbReview(int pageNo);     // Get review score
    }

    public class ReviewProvider : IRProvider
    {
        // public Imdb List { get; private set; }

        // Get webclient, make it JsonObject.
        // Get all 

        public int CurrentPageNo { get; set; }

        public ObservableCollection<Imdb> GetImdbReview(int pageNo)             // OMDB RESTRICTS AMOUNT OF REQUESTS, TRY THIS
        {
            ObservableCollection<Imdb> List = new ObservableCollection<Imdb>();
            WebClient webClient = new WebClient();
            try
            {
                string jsonString = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/week?api_key=48c54986a7b40b65862e9a141d1cfaee&page=" + pageNo);

                JsonObject root = Windows.Data.Json.JsonValue.Parse(jsonString).GetObject();

                JsonArray result = root.GetNamedArray("results");
                foreach (JsonValue j in result)
                {
                    List.Add(new Imdb(j.ToString()));
                }
                CurrentPageNo = pageNo;
            }
            catch (WebException)
            {

            }
            finally
            {

            }

            return List;


        }
    }
}
        

