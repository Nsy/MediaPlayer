﻿#pragma checksum "..\..\..\View\ucPlaylist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42A964CEC93E82F4EA42E0FFCE8771BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace TestUserControl {
    
    
    /// <summary>
    /// ucPlaylist
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ucPlaylist : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TestUserControl.ucPlaylist UserControl;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard OnMouseEnter2_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView Playlist;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem itemPlaylist;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem itemMusics;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem itemsPictures;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\ucPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem itemsVideos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestUserControl;component/view/ucplaylist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ucPlaylist.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((TestUserControl.ucPlaylist)(target));
            return;
            case 2:
            this.OnMouseEnter2_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.Playlist = ((System.Windows.Controls.TreeView)(target));
            return;
            case 6:
            this.itemPlaylist = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 53 "..\..\..\View\ucPlaylist.xaml"
            this.itemPlaylist.GotFocus += new System.Windows.RoutedEventHandler(this.PlaylistFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.itemMusics = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 56 "..\..\..\View\ucPlaylist.xaml"
            this.itemMusics.GotFocus += new System.Windows.RoutedEventHandler(this.MusicsFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 57 "..\..\..\View\ucPlaylist.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.ArtistFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 58 "..\..\..\View\ucPlaylist.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.AlbumFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 59 "..\..\..\View\ucPlaylist.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.GenreFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.itemsPictures = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 61 "..\..\..\View\ucPlaylist.xaml"
            this.itemsPictures.GotFocus += new System.Windows.RoutedEventHandler(this.PicturesFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            this.itemsVideos = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 62 "..\..\..\View\ucPlaylist.xaml"
            this.itemsVideos.GotFocus += new System.Windows.RoutedEventHandler(this.VideosFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

