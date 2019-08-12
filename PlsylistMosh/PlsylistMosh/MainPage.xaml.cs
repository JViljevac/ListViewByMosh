using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlsylistMosh
{
    public class Category
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public IList<string> Terms { get; set; }

        public string Title { get; set; }
    }
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    { 
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Category> _categories;

        public MainPage()
        {
            InitializeComponent();
        }
        
        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var categories = JsonConvert.DeserializeObject<List<Category>>(content);
            _categories = new ObservableCollection<Category>(categories);
            postsListView.ItemsSource = _categories;
            base.OnAppearing();
            
        }

        private void OnAdd(object sender, EventArgs e)
        {

        }
        private void OnUpdate(object sender, EventArgs e)
        {

        }
        private void OnDelete(object sender, EventArgs e)
        {

        }
    }
}
