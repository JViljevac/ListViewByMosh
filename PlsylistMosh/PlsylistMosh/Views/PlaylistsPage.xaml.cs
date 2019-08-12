using PlsylistMosh.Models;
using PlsylistMosh.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlsylistMosh.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {
        
        public PlaylistsPage()
        {
            BindingContext = new PlaylistsViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnAddPlaylist (object sender, EventArgs e)
        {
            (BindingContext as PlaylistsViewModel).AddPlaylist();
        }

        void OnPlaylistSelected (object sender, SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as PlaylistViewModel);
        }
    }
}