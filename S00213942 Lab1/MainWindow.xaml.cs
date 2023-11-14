using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00213942_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Band> allBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //combo box
            string[] genres = { "All", "Rock", "Pop", "Indie" };
            cbxGenre.ItemsSource = genres;


            RockBand b1 = new RockBand() { Bandname = "The Foo Fighters", YearFormed = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear"};
            RockBand b2 = new RockBand() { Bandname = "The Rolling Stones", YearFormed = 1962, Members = "Mick Jagger, Keith Richards, Ronnie Wood"};

            PopBand b3 = new PopBand() { Bandname = "The Beatles", YearFormed = 1960, Members = "John Lennon, Paul McCartney, George Harrison" };
            PopBand b4 = new PopBand() { Bandname = "Green Day", YearFormed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool"};

            IndieBand b5 = new IndieBand() { Bandname = "Arctic Monkeys", YearFormed = 2002, Members = "Alex Turner, Jamie Cool, Matt Helders"};
            IndieBand b6 = new IndieBand() { Bandname = "The Strokes", YearFormed = 1998, Members = "Julian Casablancas, Nick Valensi, Nikolai Fraiture"};

            //add to collection
            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            //create albums
            Random rand = new Random();

            //foo fighters albums
            Album a1 = new Album("Greatest Hits", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a2 = new Album("One By One", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            //RS albums
            Album a3 = new Album("Beggars Banquet", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a4 = new Album("Blue and Lonesome", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            //Beatles albums
            Album a5 = new Album("Let It Be", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a6 = new Album("Sgt. Peppers Lonely Heart Club", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            //Green day albums
            Album a7 = new Album("Dookie", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a8 = new Album("American Idiot", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            //arctic monleys albums
            Album a9 = new Album("Qhatever People Say I Am, Thats What Im Not", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a10 = new Album("Favourite Worst Nightmare", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            //the strokes albums
            Album a11 = new Album("Room On Fire", rand.Next(1960, 2020), rand.Next(1000000, 10000000));
            Album a12 = new Album("The Modern Age", rand.Next(1960, 2020), rand.Next(1000000, 10000000));

            b1.AlbumList.Add(a1);
            b1.AlbumList.Add(a2);

            b2.AlbumList.Add(a3);
            b2.AlbumList.Add(a4);

            b3.AlbumList.Add(a5);
            b3.AlbumList.Add(a6);

            b4.AlbumList.Add(a7);
            b4.AlbumList.Add(a8);

            b5.AlbumList.Add(a9);
            b5.AlbumList.Add(a10);

            b6.AlbumList.Add(a11);
            b6.AlbumList.Add(a12);

            //Sort Bands
            allBands.Sort();

            //Display
            lbxBands.ItemsSource = allBands;

        }

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;

            if (selectedBand != null)
            {
                lbxAlbums.ItemsSource = selectedBand.AlbumList;
                tblkBandInfo.Text = string.Format($"Formed in {selectedBand.YearFormed}" + $"\nMembers: {selectedBand.Members}");
            }
        }

        private void cbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGenre = cbxGenre.SelectedItem as string;

            List<Band> filteredList = new List<Band>();

            switch (selectedGenre)
            {
                case "All":
                    lbxBands.ItemsSource = allBands;
                    break;

                case "Rock":

                    foreach (Band band in allBands)
                    {
                        if (band is RockBand)
                            filteredList.Add(band);
                    }
                    lbxBands.ItemsSource = filteredList;
                    break;

                case "Pop":

                    foreach (Band band in allBands)
                    {
                        if (band is PopBand)
                            filteredList.Add(band);
                    }
                    lbxBands.ItemsSource = filteredList;
                    break;

                case "Indie":

                    foreach (Band band in allBands)
                    {
                        if (band is IndieBand)
                            filteredList.Add(band);
                    }
                    lbxBands.ItemsSource = filteredList;
                    break;
            }
        }

    }

}
