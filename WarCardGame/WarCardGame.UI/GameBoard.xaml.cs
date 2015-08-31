using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WarCardGame.UI.Resources;
using WarCardGame;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.IO.IsolatedStorage;

namespace WarCardGame.UI
{
    public partial class MainPage : PhoneApplicationPage
    {
        //TODO Add card animations
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        WarGame game;
        bool MoveMade = false;
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            base.OnNavigatedTo(e);
            //get names form name page
            tbNameP1.Text = NavigationContext.QueryString["player1"];
            tbNameP2.Text = NavigationContext.QueryString["player2"];
            //Set Card styles
            Deck.CardBackStyle SelectedBack = Deck.CardBackStyle.standard;
            Deck.CardFrontStyle SelectedFront = Deck.CardFrontStyle.blue;
            IsolatedStorageSettings currentSettings = IsolatedStorageSettings.ApplicationSettings;
            if (currentSettings.TryGetValue("FrontCard", out SelectedFront))
            {
                switch (SelectedFront)
                {
                    case Deck.CardFrontStyle.black:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back black_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back black_0.png", UriKind.Relative));
                        break;
                    case Deck.CardFrontStyle.blue:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back blue_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back blue_0.png", UriKind.Relative));
                        break;
                    case Deck.CardFrontStyle.green:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back green_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back green_0.png", UriKind.Relative));
                        break;
                    case Deck.CardFrontStyle.orange:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back orange_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back orange_0.png", UriKind.Relative));
                        break;
                    case Deck.CardFrontStyle.purple:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back purple_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back purple_0.png", UriKind.Relative));
                        break;
                    case Deck.CardFrontStyle.red:
                        imgPlayer1Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back red_0.png", UriKind.Relative));
                        imgPlayer2Deck.Source = new BitmapImage(new Uri("/Resources/CardDecks/CardFront/card back red_0.png", UriKind.Relative));
                        break;
                    default:
                        break;
                }

            }
            currentSettings.TryGetValue("BackCard", out SelectedBack);
                
            game = new WarGame(SelectedBack,tbNameP1.Text, tbNameP2.Text);
            game.Deal();
           
            tbRemainingCardsP1.Text = game.Player1.RemainingCards.ToString();
            tbRemainingCardsP2.Text = game.Player2.RemainingCards.ToString();
            tbPlayer1Results.Text = string.Empty;
            tbPlayer2Results.Text = string.Empty;
            
        }

        private void imgPlayer1Deck_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            game.PlayCards(game.Player1);
            imgPlayer1PlayedCard.Source = new BitmapImage ( new Uri(game.Player1.FlippedCard.BackImageSource, UriKind.Relative));
            Image im = (Image)sender;
            imgPlayer1Deck.IsHitTestVisible = false;
            SetMoveFlag();
        }

       

        private void SetMoveFlag()
        {
            
            if (MoveMade == true)
            {
                DisplayResults();
            }
            else
            {
                MoveMade = true;
            }
        }
        private void DisplayResults()
        {//TODO research if Dispatcher timer is the best to use
            if(game.WinningPlayer != "WAR")
            {
                tbPlayer1Results.Text = game.WinningPlayer + " Wins";
                tbPlayer2Results.Text = game.WinningPlayer + " Wins";
            }
            else
            {
                tbPlayer1Results.Text = game.WinningPlayer;
                tbPlayer2Results.Text = game.WinningPlayer;
            }
            DispatcherTimer resultsTimer = new DispatcherTimer();
            resultsTimer.Tick += delegate {
                //Display results and update board
                if (game.WinningPlayer != "WAR")
                {
                    tbPlayer1Results.Text = string.Empty;
                    tbPlayer2Results.Text = string.Empty;
                    tbRemainingCardsP1.Text = game.Player1.RemainingCards.ToString();
                    tbRemainingCardsP2.Text = game.Player2.RemainingCards.ToString();
                    imgPlayer1PlayedCard.Source = new BitmapImage(new Uri("Resources/cardBackGround.png", UriKind.Relative));
                    imgPlayer2PlayedCard.Source = new BitmapImage(new Uri("Resources/cardBackGround.png", UriKind.Relative));
                    //TODO add better endgame menu allowing to restart or return to main menu
                    if (game.Player1.RemainingCards <= 0)
                    {
                        MessageBoxResult result = MessageBox.Show(game.Player2.Name + " Wins", "Press OK to go back to the main menu", MessageBoxButton.OK);
                        if (result == MessageBoxResult.OK)
                        {
                            NavigationService.Navigate(new Uri("/MainMenu.xaml", UriKind.Relative));
                        }
                    }
                    else if (game.Player2.RemainingCards <= 0)
                    { 
                        
                    }
                    
                }
                MoveMade = false;
                imgPlayer1Deck.IsHitTestVisible = true;
                imgPlayer2Deck.IsHitTestVisible = true;
                resultsTimer.Stop();
                resultsTimer = null;

            };
            resultsTimer.Interval = new TimeSpan(0,0,0,0,1500);
            resultsTimer.Start();

            
        }

        private void imgPlayer2Deck_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            game.PlayCards(game.Player2);
            imgPlayer2PlayedCard.Source = new BitmapImage(new Uri(game.Player2.FlippedCard.BackImageSource, UriKind.Relative));
            Image im = (Image)sender;
            im.IsHitTestVisible = false;
            SetMoveFlag(); 
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}