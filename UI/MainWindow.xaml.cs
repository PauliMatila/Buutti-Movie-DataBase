using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.XPath;
using Buutti_Movie_DataBase.Controllers;
using Buutti_Movie_DataBase.Entities;
using Newtonsoft.Json;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MovieController mc = new MovieController();
        public string ImagePath { get; set; }

        public MainWindow()
        {           
            InitializeComponent();
            if (File.Exists(mc.GetPath()))
            {
                BindListBox();
            }          
        }

        public void BindListBox()
        {            
            listBox1.Items.Clear();
            List<Movie> movies = mc.GetMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                listBox1.Items.Add(movies[i]);
            }
        }

        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;
            
            foreach (Window w in Application.Current.Windows)
            {
                if (w is AddMovieWindow)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }
            if (!isWindowOpen)
            {
                AddMovieWindow addMovieWindow = new AddMovieWindow();
                addMovieWindow.Owner = this;
                addMovieWindow.Show();
            }
        }

        private void DeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            List<Movie> movies = mc.GetMovies();
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("You didn't select movie to delete");
            }
            else
            {
                movies.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
                listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
                string jsonUpdateMovies = JsonConvert.SerializeObject(movies);
                File.WriteAllText(mc.GetPath(), jsonUpdateMovies);
            }
        }

        private void AddTestMovies_Click(object sender, RoutedEventArgs e)
        {
            mc.AddDummyMovies();
            BindListBox();            
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                List<Movie> movies = mc.GetMovies();
                string searchTerm = textForSearchinInList.Text;
                var searchResult = movies
                    .Where(m => m.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                string combineSearchResults = string.Join(", ", searchResult.Select(r => r.Name));
                MessageBox.Show(combineSearchResults);
                (sender as TextBox).Text = string.Empty;
            }          
        }
    }
}
