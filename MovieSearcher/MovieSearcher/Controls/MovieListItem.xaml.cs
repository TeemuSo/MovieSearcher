using MovieSearcher.Models;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System;
using System.Windows.Input;

namespace MovieSearcher.Controls
{

    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MovieControl : UserControl         // This is second view to iterate
    {
        // Used for storing the movies in static place
        private Movie _movie;
        private Movie Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = (Movie)DataContext;
                }
                return _movie;
            }
        }

     

        public MovieControl()
        {
            InitializeComponent();
            DataContextChanged += new DependencyPropertyChangedEventHandler(MovieControl_DataContextChanged);
        }
        public MovieControl(Movie movie) : this()
        {
            DataContext = movie;
        }

        void MovieControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            InitializeIcons();
        }

        // Initializing icons according to data that is saved. 
        private void InitializeIcons()
        {
            if (Movie.Favorited) markFavorite(true);
            else markFavorite(false);

            if (Movie.Wishlist) markWishlist(true);
            else markWishlist(false);

            if (Movie.Watched) markWatched(true);
            else markWatched(false);

    }

        // Here's control for switching between MoviePage and MovieListItem
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            MessageBox.Show(Movie.Name);
        }

        // Here's control for favorite button. Sets favorite status and also image status
        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {

            if (FavoriteIcon.Source == (ImageSource)FindResource("NotFavorited"))
            {
                Movie.Favorited = true;
                markFavorite(true);
            }
            else
            {
                markFavorite(false);
                Movie.Favorited = false;
            }

        }

        // Here's control for wishlist button. Sets also the status of wishlist
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Wishlist.Source == (ImageSource)FindResource("NotInWishlist"))
            {
                //WishlistLabel.Content = "In wishlist";
                Movie.Wishlist = true;
                markWishlist(true);
            }
            else
            {
                //WishlistLabel.Content = "Add to wishlist";
                Movie.Wishlist = false;
                markWishlist(false);
            }
        }

        // Here's control for watched button. Sets also the status of watched
        private void AddWatched(object sender, RoutedEventArgs e)
        {

            if (WatchedMoviesButton.Content == "Add as watched")
            {
                Movie.Watched = true;
                markWatched(true);
                //WatchedMoviesLabel.Content = "You have watched this movie";
            }
            else
            {
                //WatchedMoviesLabel.Content = "You have not watched this movie";
                Movie.Watched = false;
                markWatched(false);
            }
        }

        // Checks if movie is favorited or not, changes image appropietly
        private void markFavorite(bool favorited)
        {
            if (favorited)
            {
                FavoriteIcon.Source = (ImageSource)FindResource("Favorited");
            }
            else
            {
                FavoriteIcon.Source = (ImageSource)FindResource("NotFavorited");
            }
        }

        // Checks if movie is watched or not, changes image appropietly
        private void markWatched(bool watched)
        {
            if (watched)
            {
                WatchedMoviesButton.Content = "In watched";
            }
            else
            {
                WatchedMoviesButton.Content = "Add as watched";
            }
        }

        // Checks if movie is in wishlist or not, changes image appropietly
        private void markWishlist(bool wishlist)
        {
            if (wishlist)
            {
                Wishlist.Source = (ImageSource)FindResource("InWishlist");
            }
            else
            {
                Wishlist.Source = (ImageSource)FindResource("NotInWishlist");
            }
        }

    }
}