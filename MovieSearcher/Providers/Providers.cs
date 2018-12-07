using MovieSearcher.Models;
using System.Collections.ObjectModel;
using System.Net;
using Windows.Data.Json;

namespace MovieSearcher.Providers
{
    public interface IProvider
    {
        int CurrentPageNo { get; set; }
        ObservableCollection<Movie> GetTrending(int pageNo);
    }

    public class TmdbProvider : IProvider
    {
        public int CurrentPageNo { get; set; }

        public ObservableCollection<Movie> GetTrending(int pageNo)
        {
            ObservableCollection<Movie> list = new ObservableCollection<Movie>();
            WebClient webClient = new WebClient();
            try
            {
                string jsonString = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/week?api_key=48c54986a7b40b65862e9a141d1cfaee&page=" + pageNo);

                    JsonObject root = Windows.Data.Json.JsonValue.Parse(jsonString).GetObject();    // Get first array of objects. Contains everything

                JsonArray result = root.GetNamedArray("results");       // Get results a.k.a second layer
                foreach (JsonValue j in result)                         // Parse values from results
                {
                    list.Add(new Movie(j.ToString()));                  // pass the values to Movie model
                }
                CurrentPageNo = pageNo;
            }
            catch (WebException)
            {

            }
            finally
            {

            }
            return list;        // List of all possible objects created as a list to Movie
        }
    }
}
