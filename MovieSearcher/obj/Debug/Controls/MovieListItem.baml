   M S B A M L   `   `   `  ����H  DMovieSearcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MovieSearcher.ControlsMovieSearcher.Controls  5      ;"clr-namespace:MovieSearcher.ModelsMovieSearcher.Models  5      C&clr-namespace:MovieSearcher.PropertiesMovieSearcher.Properties  5      ;"clr-namespace:MovieSearcher.ModelsMovieSearcher.Models  5      )    #MovieSearcher.Controls.MovieControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	      @d2http://schemas.microsoft.com/expression/blend/2008     5
      6local$clr-namespace:MovieSearcher.Controls     5      5models"clr-namespace:MovieSearcher.Models     5      =
Properties&clr-namespace:MovieSearcher.Properties     5      1vm"clr-namespace:MovieSearcher.Models     5        � 	Resources  5          MovieSearcher.Models.Users 	  vmObj �� 
TargetType  labelControl �� Property �� Value  NotInWishlist  
InWishlist  	Favorited  NotFavorited��%�  &	        &	      &	 �     &	 �     &	     &	 b      5   
   6   �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Bahnschrift SemiBold)�6+   5      ��5*   
   40/MovieSearcher;component/Icons/NotInWishlist.png��6^   ��5+   
   1-/MovieSearcher;component/Icons/InWishlist.png��6X   ��5,   
   0,/MovieSearcher;component/Icons/Favorited.png��6V   ��5-   
   3//MovieSearcher;component/Icons/NotFavorited.png��6\   51      .��52      �� ._�53   
   � $
��Left=�6   $	��800��6*    � ColumnDefinitions 54      �� 55      $	��150��6#   �� 56      �� 57      �� 58      $��50 �6#    � RowDefinitions 5:      �� 5;      �� 5<      .+�5@      �� $	��150��6-   $	��Top=�69   $��Right=�6Q   ��6   �� *Image+6Q   �� 5A      $��Center=�6   $��3��64   $��1��6A   .+�5B      �� �� 5C      -   5        
�������$	��wat?�5C   0    �� 	IsEnabled . .�6   .�5D      �� #��[ 6c    �� Target 6   ��  �� ElementName$ MovieListItem����6J   �� *Name+6c   5E      5F      �� 5G      $��14(�61   $��Arial)�6?   ��6   �� *Year+6?   �� 5H      $
��Wrap=�6   ��60   �� *
Overview+5I      �� 5L      	 �� Orientation$	 
Horizontal=�6   $��0��62   $��2��6?   $	��Top=�6O   .+�5M      �� -   5        
 �� 	ClickMode$
 Press=�5M      
������ $��0q�6Y   $��30��6m   .��5N      �� -   5        $��Wishlist��5N      5O      �� 5P      -   5        $��WishlistLabel��5P      $��Add to wishlist��6-   $��10(�6G   $��Center=�6U   
����� �6p   �� 5Q      $	 Vertical=�6   .+�5R      �� -   5        $��WatchedMoviesLabel��5R      $%��You have not watched this movie��66   �� 5S      -   5        $��WatchedMoviesButton��5S   /   $
 Press=�6   $��Stretch=�6]   5T      5U      �� 5Y      -   5        $��FavoriteButton��5[      $��3��5Y      
�������$��Bottom=�5Z   -   
�����w�$��2q�5[   e   ��5\      �� ��62   ��  �� RelativeSource �� *Self+.��5]      �� -   5        $��FavoriteIcon��5]      5^      �� 5a      $��1��6   $��1��6&   .+�5b      �� -	   5        $��
ReviewList��5b      ��61   �� *	Reviews+��5c      �� 5d       �� DataType$" x:Type={local:ReviewControl}��6'   .R�5e      *   $MovieSearcher.Controls.ReviewControl  $��Center=�62   $��Disabled=�6T   ��. 6�   5f      5h      5i      5j      5k      5l      