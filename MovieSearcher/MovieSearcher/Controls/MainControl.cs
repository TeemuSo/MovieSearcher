using MovieSearcher.Providers;
using MovieSearcher.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
// Aytac
namespace MovieSearcher.Controls
{
    public class MainControl
    {
        public ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();
        public ICommand NextPageCommand { get; set; }
        public ICommand FavoriteCommand { get; set; }
        public ICommand WatchedCommand { get; set; }
        public IProvider ApiProvider { get; } = new TmdbProvider();
        public static Users User=new Users();

      
        public MainControl()
        {
            NextPageCommand = new NextPageCommand(this);
            SetMovies(ApiProvider.GetTrending(1));      // Get info from provider

        }


        public ObservableCollection<Movie> Movies
        {
            get
            {
                return _movies;                                         // Returns the list created in step under this
            }
        }
            
    //-----------------------------------------------------------------------------------------------

        private void SetMovies(ObservableCollection<Movie> List)        // Goes through the previously created list of Movie objects
        {
            _movies.Clear();                                            // Adds it to parameter _movies
            foreach(Movie m in List)
            {
                _movies.Add(m);
            }
        }

   

        public void NextPage(int increment)
        {
            SetMovies(ApiProvider.GetTrending(ApiProvider.CurrentPageNo + increment));
        }
        
    }


    //=================================================================================================

    class NextPageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainControl mc;

        public NextPageCommand(MainControl mc)
        {
            this.mc = mc;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.Out.WriteLine(parameter.GetType());
            mc.NextPage((Int16)parameter);
        }
    }

}
