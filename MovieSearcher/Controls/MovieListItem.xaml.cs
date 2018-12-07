using MovieSearcher.Models;
using System.Net;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MovieSearcher.Controls
{

    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MovieControl : UserControl         // This is second view to iterate
    {
        FavoriteCommand favoriteCommand;
        public FavoriteCommand favCom { get; set; }
        public MovieControl()
        {
            InitializeComponent();
            favCom = new FavoriteCommand(this);
            InitializeIcons();

        }
        public MovieControl(Movie movie)
        {
            InitializeComponent();
            DataContext = movie;
        }

        // Button events are not working correctly without doing it like this.
        // Way of implementing will be changed out of click even style after button content binding actually works
        private void InitializeIcons()
        {
            FavoriteIcon.Source = (ImageSource)FindResource("NotFavorited");
            Wishlist.Source = (ImageSource)FindResource("NotInWatchlist");
            WatchedMoviesButton.Content = "Add as watched";
        }
        
        // Here's control for switching between MoviePage and MovieListItem
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            MessageBox.Show("Hyperlink - it's here.");
        }

        // Here's control for favorite button
        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {

            if (FavoriteIcon.Source == (ImageSource)FindResource("NotFavorited"))
            {
                
                FavoriteIcon.Source = (ImageSource)FindResource("Favorited");
            }
            else
                FavoriteIcon.Source = (ImageSource)FindResource("NotFavorited");

        }

        // Here's control for Watchlist and wishlist button
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Wishlist.Source == (ImageSource)FindResource("NotInWishlist"))
            {
                WishlistLabel.Content = "In wishlist";
                Wishlist.Source = (ImageSource)FindResource("InWishlist");
            }
            else
            {
                WishlistLabel.Content = "Add to wishlist";
                Wishlist.Source = (ImageSource)FindResource("NotInWishlist");
            }
         }

        private void AddWatched(object sender, RoutedEventArgs e)
        {
            
            if (WatchedMoviesButton.Content == "Add as watched")
            {
                WatchedMoviesButton.Content = "Remove from watched";
                WatchedMoviesLabel.Content = "You have watched this movie";
            }
            else
            {
                WatchedMoviesLabel.Content = "You have not watched this movie";
                WatchedMoviesButton.Content = "Add as watched";
            }
        }
    }

    public class FavoriteCommand : ICommand     // Here I will work with data
    {

        //    ObservableCollection<Movie> _favorites = new ObservableCollection<Movie>();
        public event EventHandler CanExecuteChanged;        // This event is fired if there's change in CanExecute

        MovieControl mc;     // Used for accessing the function in MainControl

        /*  public FavoriteCommand(Users favorite)      // Users acts as method
          {
              Favorite = favorite;
          }
          */
        public FavoriteCommand(MovieControl mc)              // With this I can access functions??
        {
            this.mc = mc;
        }

        public bool CanExecute(object parameter)        // Can the interface execute?
        {
            return true;
        }

        public void Execute(object parameter)        // Execute this when CanExecute returns true
        {
            MessageBox.Show("works");
            MainControl.User.Favorites.Add((Movie)parameter);
        }
    }

}
