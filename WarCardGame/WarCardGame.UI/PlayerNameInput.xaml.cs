using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WarCardGame.UI
{
    public partial class PlayerNameInput : PhoneApplicationPage
    {
        public PlayerNameInput()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            string uri = string.Format("/GameBoard.xaml?player1=" +txtPlayer1.Text+"&&player2="+txtPlayer2.Text); 
            NavigationService.Navigate(new Uri(uri, UriKind.Relative));
        }

        private void txtPlayer1_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPlayer1.Text = string.Empty;
        }

        private void txtPlayer2_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPlayer2.Text = string.Empty;
        }

       
    }
}