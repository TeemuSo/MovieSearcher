   M S B A M L   `   `   `  ����H  DMovieSearcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MovieSearcher.ControlsMovieSearcher.Controls  5      ;"clr-namespace:MovieSearcher.ModelsMovieSearcher.Models  5      C&clr-namespace:MovieSearcher.PropertiesMovieSearcher.Properties  5      ;"clr-namespace:MovieSearcher.ModelsMovieSearcher.Models  5      )    #MovieSearcher.Controls.MovieControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	      @d2http://schemas.microsoft.com/expression/blend/2008     5
      6local$clr-namespace:MovieSearcher.Controls     5      5models"clr-namespace:MovieSearcher.Models     5      =
Properties&clr-namespace:MovieSearcher.Properties     5      1vm"clr-namespace:MovieSearcher.Models     5        � 	Resources  5          MovieSearcher.Models.Users 	  vmObj �� 
TargetType  labelControl �� Property �� Value �� Triggers P� Property P� Value  
ListWindow �� 
StartPoint �� EndPoint	 � Color
 � Offset  NotInWishlist  
InWishlist  	Favorited  NotFavorited��%�  &	        &	      '�� �     &	 g    &	 W    &	 �    &	 �    &	 (      5   
   6   �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Bahnschrift SemiBold)�6+   5      �� 5   
   " ��6    5      P� 5        �@��IsMouseOver . . �5!      ��  � ��
 �����63   5"      .�5$      ��  � ��
 �����6+   �� 5%       � �� 6:   Z� 5&      �� 5)   
   " ��6   .�5*      ��  � �� 5+      �� 5,      $ 0.5,0&�6*   $ 0.5,1&�6=   .��5-      � $	 	#FF231352��6'   $	
 0.0Q�69   � 5.      $	 	#FF0C0631��6'   $	
 1.0Q�69   5/      51      52      ��55   
   40/MovieSearcher;component/Icons/NotInWishlist.png��6^   ��56   
   1-/MovieSearcher;component/Icons/InWishlist.png��6X   ��57   
   0,/MovieSearcher;component/Icons/Favorited.png��6V   ��58   
   3//MovieSearcher;component/Icons/NotFavorited.png��6\   5<      .��5=      �� #��[ 6   ._�5>   
   �  � ColumnDefinitions 5?      �� 5@      $��1* �6#   �� 5A      $��3* �6#   �� 5B      $	��150��6#   $��0* �62   $	��100��6=    � RowDefinitions 5D      �� 5E      $	��15* �6    �� 5F      $	��61* �6    �� 5G      $��0* �6    .+�5K      �� $	��Top=�6-   $��Right=�6E   $��2��6a   ��6   �� *Image+6a   �� 5M      $	��Top=�6   $��3��61   $��1��6>   .+�5N      �� �� 5O      -   5        
�������$	��wat?�5O   -    �� 	IsEnabled . .�6|   .�5P      �� 
�������#��[ 6s    �� Target 6-   ��  �� ElementName$ MovieListItem����6Z   �� *Name+6s   5Q      5R      �� 5S      
�������$��14(�6D   $��Arial)�6R   ��6+   �� *Year+6R   �� 5T      
�������$
��Wrap=�6/    �� Padding$ 5,0,0,0q�6]   ��6C   �� *
Overview+6]   5U      �� 5X       �� Orientation$ Vertical=�6   $��2��60   $	��Top=�6@   $��2��6X   .+�5Y      �� -   5         �� 	ClickMode$ Press=�5Y      
������ $��0q�6Y   $��30��6m   .��5Z      �� -   5        $��Wishlist��5Z      5[      �� 5_      -   5        $��WatchedMoviesButton��5_   >   
�������$ Press=�6,   $��Stretch=�6l   ���	#FF261750$��0q�6�   �� 5b      -   5        $��FavoriteButton��5d      $��Bottom=�5c      ���	#FF120C3A$��0q�5d   ]   $��1��5e   h   ��6   �� ��6/   ��  �� RelativeSource �� *Self+��5f      �� 5g      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5h      � $	 	#FF24164D��6+   � 5i      $	 	#FF150E3E��6+   $
 1Q�6=   5j      .��5l      �� -   5        $��FavoriteIcon��5l      5m      5n      �� 5s      $��2��6   $��1��6&   $ 
Horizontal=�66   .+�5t      �� -   5        $��
ReviewList��5t      ��61   �� *	Reviews+��5u      �� 5v      .R�5w      �� $ 
Horizontal=�6)   5x      ��5{      �� 5|       �� DataType$" x:Type={local:ReviewControl}��6'   .R�5}      *   $MovieSearcher.Controls.ReviewControl  $��Center=�62   6V   5~      5�      5�      5�      5�      5�      