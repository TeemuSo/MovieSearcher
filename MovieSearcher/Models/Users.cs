using MovieSearcher.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// Teemu -> create a user for the settings
namespace MovieSearcher.Models
{
    public class Users
    {
        public List<Movie> Watched = new List<Movie>();
        public List<Movie> Favorites = new List<Movie>();
        //public List<Movie> Favorited = new List<Movie>();
        public FavoriteCommand DisplayFavoriteCommand { get; set; }

        //public WatchedCommand DisplayWatchedCommand { get; set; }

        public Users()
        {
             
        }
        }
    }
