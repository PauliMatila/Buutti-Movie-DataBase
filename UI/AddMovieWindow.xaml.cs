using Buutti_Movie_DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Buutti_Movie_DataBase.Controllers;
using System.Globalization;

namespace UI
{
    /// <summary>
    /// Interaction logic for AddMovieWindow.xaml
    /// </summary>
    public partial class AddMovieWindow : Window
    {
        MovieController mc = new MovieController();

        public AddMovieWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            int descriptionMaxLenght = 45;
            double number;
            if (movieName.Text != "" &&
                movieDescription.Text.Length <= descriptionMaxLenght &&
                double.TryParse(movieLength.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out number) &&
                moviePosterUrl.Text.Contains(".jpg"))
            {
                mc.AddMovie(movieName.Text, movieDescription.Text, number, moviePosterUrl.Text);
                ((MainWindow)this.Owner).BindListBox();
                MessageBox.Show("Movie added to list!");
            }
            else
            {
                MessageBox.Show("You didn't fill correctly!");
            }
            movieName.Clear();
            movieDescription.Clear();
            movieLength.Clear();
            moviePosterUrl.Clear();
        }
    }
}
