﻿#pragma checksum "C:\Users\Dave\OneDrive\Intro to mobil projects\WarCardGame\WarCardGame\WarCardGame.UI\PlayerNameInput.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "45E222C91AD16FFAF797D02AF0E18571"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WarCardGame.UI {
    
    
    public partial class PlayerNameInput : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtPlayer1;
        
        internal System.Windows.Controls.TextBox txtPlayer2;
        
        internal System.Windows.Controls.Button btnStartGame;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WarCardGame.UI;component/PlayerNameInput.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtPlayer1 = ((System.Windows.Controls.TextBox)(this.FindName("txtPlayer1")));
            this.txtPlayer2 = ((System.Windows.Controls.TextBox)(this.FindName("txtPlayer2")));
            this.btnStartGame = ((System.Windows.Controls.Button)(this.FindName("btnStartGame")));
        }
    }
}
