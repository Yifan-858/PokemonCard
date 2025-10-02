using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonCard;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private PokemonCardModel _kadabra;
    private PokemonCardModel _charmander;
    private PokemonCardModel _squirtle;
    public MainWindow()
    {
        InitializeComponent();

        _kadabra= new PokemonCardModel
        {
            Name = "Kadabra",
            Hp ="80",
            SubInfo = "NO. 0064 Psi Pokemon HT: WT:",
            ElementType = ElementType.Psychic,
            Attacks =
            {
                new PokemonAttack
                {
                    Name = "New Teleportation Attack",
                    Damage = "300",
                    Description = "Pbzzzz",
                    ElementType = ElementType.Psychic
                },
                new PokemonAttack
                {
                    Name = "New Psychic",
                    Damage = "200",
                    Description= "Super super quick",
                    ElementType = ElementType.Psychic
                }
            },
            //Weakness = ElementType.Rock
            Weakness = "x 2",
            Resistance = "Water",
            Retreat = "Go home",
            SetNumber = "19/151",
            FooterText = "When it is angry, it discharges all the energy stored in its cheeks.",
            Rarity = "◆"
        };

        _charmander = new PokemonCardModel
        {
            Name = "charmander",
            Hp = "80",
            SubInfo = "Lizard Pokemon",
            ElementType = ElementType.Fire,
            Attacks =
            {
                new PokemonAttack
                {
                    Name = "Scratch",
                    Damage = "10",
                    Description = "shaaaaaa",
                    ElementType = ElementType.Colorless,
                },

                new PokemonAttack
                {
                    Name = "Ember",
                    Damage = "30",
                    Description = "veryvery hot hot",
                    ElementType = ElementType.Fire
                }
            },
            Weakness = "Water",
            Resistance = "Grass",
            Retreat = "Go home",
            SetNumber = "7/156",
            FooterText = "Prefer hot places.",
            Rarity = "◆"
        };

        _squirtle = new PokemonCardModel
        {
            Name = "squirtle",
            Hp= "80",
            SubInfo= "Turtle Pokemon",
            ElementType = ElementType.Water,
            Attacks =
            {
                new PokemonAttack
                {
                    Name= "Bubble",
                    Damage= "20",
                    Description = "Flip a coin, if heads, the opponent is paralyzed.",
                    ElementType = ElementType.Water,
                },

                new PokemonAttack
                {
                    Name = "Withdraw",
                    Damage = "10",
                    Description = "Flip a coin, if heads, the opponent's attack"
                }
            },
            Weakness = "Grass",
            Resistance = "Fire",
            Retreat = "Go home",
            SetNumber = "10/155",
            FooterText = "When it feels threatened, it will hide in the shell.",
            Rarity = "◆"
        };

        //DataContext = pokemonCardModel;
        SetUpWindow(_kadabra);
    }
    public void SetUpWindow(PokemonCardModel pokemonCardModel)
    {
        NameTextBlock.Text = pokemonCardModel.Name;
        HpValueBlock.Text = pokemonCardModel.Hp;
        SubInfoTextBlock.Text = pokemonCardModel.SubInfo;

        Move1NameTextBlock.Text = pokemonCardModel.Attacks[0].Name;
        Move1DMGBlock.Text = pokemonCardModel.Attacks[0].Damage;
        Move1DesciptionBlock.Text = pokemonCardModel.Attacks[0].Description;

        Move2NameBlock.Text = pokemonCardModel.Attacks[1].Name;
        Move2DMGBlock.Text = pokemonCardModel.Attacks[1].Damage;
        Move2DescriptionBlock.Text = pokemonCardModel.Attacks[1].Description;

        WeaknessValue.Text = pokemonCardModel.Weakness;
        RarityText.Text = pokemonCardModel.SetNumber;
        RarityIcon.Text = pokemonCardModel.Rarity;

        PokemonDescription.Text = pokemonCardModel.FooterText;
    }

    public void OpenSelectionWindowClick(Object sender, RoutedEventArgs e)
    {
        var picker = new SelectionWindow(_kadabra, _squirtle, _charmander) { Owner = this };
        if(picker.ShowDialog() == true)
        {
            SetUpWindow(picker.SelectedPokemon);
        }
    }
   
}