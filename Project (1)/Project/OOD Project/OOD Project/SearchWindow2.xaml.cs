using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace OOD_Project
{
    
    /// <summary>
    /// Interaction logic for SearchWindow2.xaml
    /// </summary>
    public partial class SearchWindow2 : Window
    {
        public ObservableCollection<Bar> SearchResults { get; set; }
        public ObservableCollection<Bar> Bars { get; set; }

        public SearchWindow2()
        {
            InitializeComponent();

            // Initialisation de la liste des résultats de recherche
            SearchResults = new ObservableCollection<Bar>();
            Bars = new ObservableCollection<Bar>
            {
                new Bar("Brewery\n   (4.4)", "Bars1/Brewery.jpg","Every tuesday it's the place to be in sligo when you are a student you can see their events each tuesday on their instagram"),
                new Bar("Maeve's\n   (4.4)", "Bars1/Maeves.jpg","A very good bar with every time someone playing music and singing. if it's late you can take the backdoor to continue the night in the garavogue"),
                new Bar("Snug\n   (4.5)", "Bars1/Snug.jpg","Interesting place, good beer, nice place to chill & watch the football. It is pretty old & it’s true that the bathrooms aren’t perfect " +
                "but have another beer & you won’t notice. The bar staff were friendly & a good source of local information."),
                new Bar("Garavogue\n   (4.1)","Bars1/Garavogue.jpg","The Garavogue Sligo is Sligo’s Number One Late Night Entertainment Destination and known as one of the best bars in Sligo." +
                " The Garavogue Bar is situated along the picturesque banks of the Garavogue River in the Heart of Sligo Town."),
                new Bar("Lolas\n   (4.0)","Bars1/Lolas.jpg","Lola Montez is Sligo’s newest most intimate late night bar. Catering to a clientele of over 21’s who like to indulge in that something " +
                "‘extra’ on a night out; Lola Montez alluring interior, classic cocktails and sassy selection of drinks provides that ‘something extra’ experience you are looking for at the weekend…"),
                new Bar("Andersons\n   (4.4)","Bars1/Andersons.jpg","Andersons is a lively bar located in the heart of Sligo. It offers a friendly and welcoming atmosphere, perfect for relaxing with friends." +
                " With a varied selection of drinks and a warm ambiance, Andersons is the perfect place for a great night out. Whether you're looking to enjoy a drink after work or catch live events," +
                " Andersons offers a unique experience to all its visitors"),
                new Bar("Belfry\n   (4.3)","Bars1/Belfry.jpg","The Belfry Bar is a cozy and inviting establishment nestled in the heart of Sligo. With its warm and welcoming atmosphere, it's the perfect" +
                " spot to unwind with friends or enjoy a quiet drink. Known for its excellent selection of beverages and friendly staff, the Belfry Bar promises a memorable experience for all who visit." +
                " Whether you're looking for a refreshing pint or a cozy corner to relax in, the Belfry Bar has something for everyone."),
                new Bar("Bourbon\n   (4.3)","Bars1/Bourbon.jpg","The Bourbon Bar is a popular destination for locals and visitors alike, offering a vibrant atmosphere and a fantastic selection of drinks." +
                " Situated in the heart of Sligo, this lively bar is known for its excellent cocktails, extensive whiskey collection, and friendly staff. Whether you're looking to enjoy a night out with" +
                " friends or simply relax and unwind after a long day, the Bourbon Bar has everything you need for a great time. With regular live music and a lively crowd, it's the perfect spot to experience " +
                "the vibrant nightlife of Sligo."),
                new Bar("Cahenys\n   (4.5)","Bars1/Cahenys.jpg","Caheny's Bar is a charming and cozy pub located in the heart of Sligo. With its traditional Irish atmosphere, friendly staff, and excellent " +
                "selection of drinks, it's the perfect place to unwind and enjoy a drink with friends. Known for its warm hospitality and welcoming ambiance, Caheny's Bar is a favorite among locals and visitors" +
                " alike. Whether you're stopping in for a quick pint or settling in for the evening, you're sure to feel right at home at Caheny's Bar."),
                new Bar("Connolly\n   (4.7)","Bars1/Connolly.jpg","Connolly's Bar is a lively and vibrant pub situated in the heart of Sligo. With its friendly atmosphere, great selection of drinks, and regular " +
                "live music, it's a popular spot for both locals and visitors. Whether you're looking for a place to enjoy a few drinks with friends, catch up on the latest sports action, or listen to some live music," +
                " Connolly's Bar has something for everyone. The cozy interior and welcoming staff make it the perfect place to relax and unwind after a long day."),
                new Bar("Earleys\n   (4.6)","Bars1/Earleys.jpg","Earley's Bar is a traditional Irish pub located in the heart of Sligo. With its cozy atmosphere, friendly staff, and wide selection of drinks, it's a " +
                "favorite among locals and visitors alike. The bar is known for its live music sessions, which feature talented local musicians playing a mix of traditional Irish music and contemporary hits. Whether " +
                "you're stopping by for a pint of Guinness or to enjoy some live music, Earley's Bar offers a warm welcome to all."),
                new Bar("Foleys\n   (4.6)","Bars1/Foleys.jpg","Foley's Bar is a vibrant and welcoming pub situated in the heart of Sligo. With its cozy atmosphere, friendly staff, and traditional Irish decor, it's the" +
                " perfect spot to enjoy a pint of Guinness or catch up with friends. Foley's is known for its lively atmosphere and regular live music sessions, featuring talented local musicians. Whether you're looking" +
                " for a relaxing drink after work or a lively night out, Foley's Bar has something for everyone."),
                new Bar("Jennys\n   (4.5)","Bars1/Jennys.jpg","Jenny's Bar is a popular spot in Sligo, known for its friendly atmosphere and great selection of drinks. Situated in the heart of the town, Jenny's is a " +
                "favorite among locals and visitors alike. With its cozy interior and welcoming staff, it's the perfect place to relax and unwind after a long day. Jenny's Bar also hosts live music events, making it a must-visit" +
                " destination for music lovers. Whether you're stopping by for a quick drink or staying for the evening, you're sure to have a great time at Jenny's Bar."),
                new Bar("Leitrim\n   (4.3)","Bars1/Leitrim.jpg","Leitrim Bar is a traditional Irish pub located in the heart of Sligo. Known for its warm and welcoming atmosphere, it's a favorite among locals and visitors alike." +
                " The bar offers a wide selection of drinks, including traditional Irish beers and spirits. With its cozy interior and friendly staff, Leitrim Bar is the perfect place to relax and enjoy a drink with friends." +
                " Whether you're stopping by for a quick pint or staying for the evening, you're sure to have a great time at Leitrim Bar."),
                new Bar("Lillies\n   (4.7)","Bars1/Lillies.jpg","Lillies is a vibrant and lively bar located in the heart of Sligo. With its stylish decor and friendly atmosphere, it's the perfect place to relax and enjoy a drink " +
                "with friends. Lillies offers a wide selection of beers, wines, and cocktails, as well as delicious bar snacks. The bar also hosts regular live music nights and events, making it a popular choice for both locals and" +
                " visitors to Sligo. Whether you're looking for a fun night out or a relaxed drink after work, Lillies has something for everyone."),
                new Bar("McLynns\n   (4.8)","Bars1/McLynns.jpg","McLynns is a popular bar located in the heart of Sligo. With its cozy atmosphere and friendly staff, it's the perfect place to relax and enjoy a drink with friends." +
                " McLynns offers a wide selection of beers, wines, and cocktails, as well as delicious bar snacks. The bar also hosts regular live music nights and events, making it a popular choice for both locals and visitors to Sligo." +
                " Whether you're looking for a fun night out or a relaxed drink after work, McLynns has something for everyone."),
                new Bar("Oneills\n   (4.7)","Bars1/Oneils.jpg","O'Neills is a vibrant and lively bar located in the heart of Sligo. Known for its friendly atmosphere and welcoming staff, O'Neills is a popular spot for locals and visitors alike." +
                " The bar offers a wide range of drinks, including a great selection of beers, wines, and cocktails. With its cozy interior and traditional Irish decor, O'Neills is the perfect place to relax and enjoy a drink with friends." +
                " The bar also hosts regular live music sessions, making it a popular choice for those looking for some entertainment."),
                new Bar("Rendezvous\n   (4.4)","Bars1/RDV.jpg","The Rendezvous Bar is a cozy and inviting spot located in the heart of Sligo. Known for its warm atmosphere and friendly staff, the Rendezvous Bar is a popular choice for locals and visitors alike. " +
                "The bar offers a wide range of drinks, including a great selection of beers, wines, and cocktails. With its comfortable seating and relaxed vibe, the Rendezvous Bar is the perfect place to meet up with friends for a drink or enjoy a quiet evening out."),
                new Bar("Swagman\n   (4.5)","Bars1/Swagman.jpg","The Swagman Bar in Sligo is a lively and welcoming spot, popular for its vibrant atmosphere and friendly service. It offers a wide selection of drinks, including local and international beers, wines, and " +
                "cocktails. With regular live music and DJ nights, it's the perfect place to unwind and enjoy good company after a day in Sligo."),
                new Bar("The Mill\n   (4.5)","Bars1/TheMillBar.jpg","The Mill Bar in Sligo is a cozy and charming spot known for its warm atmosphere and traditional Irish hospitality. It features a variety of drinks, including local craft beers and spirits. With live music " +
                "performances and a welcoming ambiance, it's a favorite among locals and visitors alike."),
                new Bar("Troubadour\n   (4.7)","Bars1/Troubadour.jpg","The Troubadour Bar in Sligo offers a unique blend of traditional Irish charm and modern sophistication. With its stylish decor, extensive drink selection, and live music events, it's the perfect place to " +
                "unwind and enjoy the vibrant atmosphere. Whether you're looking for a quiet drink or a lively night out, the Troubadour Bar has something for everyone.")



            };
            DataContext = this;
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            // Remplacer cette logique par votre propre logique de recherche
            string searchText = txtSearch.Text.Trim();

            // Exemple de recherche (ajouter les éléments correspondants à la recherche à SearchResults)
            SearchResults.Clear();
            foreach (var bar in Bars)
            {
                if (bar.Name.ToLower().Contains(searchText.ToLower()))
                {
                    SearchResults.Add(bar);
                }
            }
        }
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Home interface (for example, Page1.xaml)
            MainWindow Home = new MainWindow();
            Home.Show();
            this.Close();

        }

        private void ButtonSearchh_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Search interface (for example, Page2.xaml)
            SearchWindow2 Home = new SearchWindow2();
            Home.Show();
            this.Close();
        }

        private void ButtonMap_Click(object sender, RoutedEventArgs e)
        {
            MapWindow Home = new MapWindow();
            Home.Show();
            this.Close();
        }
        private void ButtonFire_Click(object sender, RoutedEventArgs e)
        {
            FireWindow Home = new FireWindow();
            Home.Show();
            this.Close();
        }
        private void txtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Réalisez la recherche à chaque modification du texte de recherche
            ButtonSearch_Click(sender, e);
        }

        private void lstBars_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Bar selectedBar = (sender as ListBox).SelectedItem as Bar;
            if (selectedBar != null)
            {
                txtSelectedBarName.Text = selectedBar.Name;
                txtSelectedBarDescription.Text = selectedBar.Description;
                imgSelectedBar.Source = new BitmapImage(new Uri(selectedBar.ImagePath, UriKind.Relative));
            }
        }

    }
}
