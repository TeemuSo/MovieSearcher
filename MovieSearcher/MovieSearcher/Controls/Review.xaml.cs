using MovieSearcher.Models;
using System.Windows.Controls;

namespace MovieSearcher.Controls
{
    /// <summary>
    /// Interaction logic for ReviewControl.xaml
    /// </summary>
    public partial class ReviewControl : UserControl
    {
        public ReviewControl()
        {
            InitializeComponent();
        }

        public ReviewControl(IReview reviews)
        {
            InitializeComponent();
            DataContext = reviews;
        }
    }
}
