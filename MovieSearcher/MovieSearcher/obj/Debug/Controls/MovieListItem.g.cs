﻿#pragma checksum "..\..\..\Controls\MovieListItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "156B4FF558F1A8C1C60842AC145C6687FCB9F654"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MovieSearcher.Controls;
using MovieSearcher.Models;
using MovieSearcher.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MovieSearcher.Controls {
    
    
    /// <summary>
    /// MovieControl
    /// </summary>
    public partial class MovieControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\..\Controls\MovieListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Wishlist;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Controls\MovieListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WatchedMoviesButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Controls\MovieListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FavoriteButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Controls\MovieListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FavoriteIcon;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Controls\MovieListItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ReviewList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MovieSearcher;component/controls/movielistitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\MovieListItem.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 79 "..\..\..\Controls\MovieListItem.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 89 "..\..\..\Controls\MovieListItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Wishlist = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.WatchedMoviesButton = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Controls\MovieListItem.xaml"
            this.WatchedMoviesButton.Click += new System.Windows.RoutedEventHandler(this.AddWatched);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FavoriteButton = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Controls\MovieListItem.xaml"
            this.FavoriteButton.Click += new System.Windows.RoutedEventHandler(this.FavoriteButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FavoriteIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.ReviewList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
