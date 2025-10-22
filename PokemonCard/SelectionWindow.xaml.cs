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
using System.Windows.Shapes;

namespace PokemonCard
{
    /// <summary>
    /// Interaction logic for SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        public PokemonCardModel SelectedPokemon { get; set; }
        public SelectionWindow(PokemonCardModel kadabra, PokemonCardModel squirtle, PokemonCardModel charmander)
        {
            InitializeComponent();

            KadabraButton.Tag = kadabra;
            SquirtleButton.Tag = squirtle;
            CharmanderButton.Tag = charmander;
        }

        private void Choose_Click(Object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            SelectedPokemon = (PokemonCardModel)btn.Tag;
            DialogResult = true;
        }
    }
}
