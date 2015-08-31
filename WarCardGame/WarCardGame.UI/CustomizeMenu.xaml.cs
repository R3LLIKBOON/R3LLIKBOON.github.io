using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;


namespace WarCardGame.UI
{
    public partial class CustomizeMenu : PhoneApplicationPage
    {
        public CustomizeMenu()
        {
            InitializeComponent();
        }
        //TODO change select arrow image names
        WarCardGame.Deck.CardFrontStyle SelectedFront;
        WarCardGame.Deck.CardBackStyle SelectedBack;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Get saved style data
            HideFrontSelect();
            HideBackSelect();
            IsolatedStorageSettings currentSettings = IsolatedStorageSettings.ApplicationSettings;
            if (currentSettings.TryGetValue("FrontCard", out SelectedFront))
            {
                switch (SelectedFront)
                {
                    case Deck.CardFrontStyle.black:
                        imgCardFSelect0.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case Deck.CardFrontStyle.blue:
                        imgCardFSelect1.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case Deck.CardFrontStyle.green:
                        imgCardFSelect2.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case Deck.CardFrontStyle.orange:
                        imgCardFSelect3.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case Deck.CardFrontStyle.purple:
                        imgCardFSelect4.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case Deck.CardFrontStyle.red:
                        imgCardFSelect5.Visibility = System.Windows.Visibility.Visible;
                        break;
                    default:
                        break;
                }
                if (currentSettings.TryGetValue("BackCard", out SelectedBack))
                {
                    switch (SelectedBack)
                    {
                        case Deck.CardBackStyle.standard:
                            imgCardBSelect0.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case Deck.CardBackStyle.ocean:
                            imgCardBSelect1.Visibility = System.Windows.Visibility.Visible;
                            break;
                        default:
                            break;

                    }
                }
            }
            
            currentSettings = null;
        }

        private void HideBackSelect()
        {//Hide all arrows
            imgCardBSelect0.Visibility = System.Windows.Visibility.Collapsed;
            imgCardBSelect1.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void HideFrontSelect()
        {//Hide all arrows
            imgCardFSelect0.Visibility = System.Windows.Visibility.Collapsed;
            imgCardFSelect1.Visibility = System.Windows.Visibility.Collapsed;
            imgCardFSelect2.Visibility = System.Windows.Visibility.Collapsed;
            imgCardFSelect3.Visibility = System.Windows.Visibility.Collapsed;
            imgCardFSelect4.Visibility = System.Windows.Visibility.Collapsed;
            imgCardFSelect5.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void imgFrontChoice0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect0.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.black;

        }

        private void imgFrontChoice1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect1.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.blue;
        }

        private void imgFrontChoice2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect2.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.green;
        }

        private void imgFrontChoice3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect3.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.orange;
        }

        private void imgFrontChoice4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect4.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.purple;
        }

        private void imgFrontChoice5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideFrontSelect();
            imgCardFSelect5.Visibility = System.Windows.Visibility.Visible;
            SelectedFront = Deck.CardFrontStyle.red;
        }

        private void imgBackChoice0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideBackSelect();
            imgCardBSelect0.Visibility = System.Windows.Visibility.Visible;
            SelectedBack = Deck.CardBackStyle.standard;
        }

        private void imgBackChoice1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HideBackSelect();
            imgCardBSelect1.Visibility = System.Windows.Visibility.Visible;
            SelectedBack = Deck.CardBackStyle.ocean;
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //Save selections
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            settings["FrontCard"] = SelectedFront;
            settings["BackCard"] = SelectedBack;
            settings.Save();
            base.OnBackKeyPress(e);
        }
    }
}