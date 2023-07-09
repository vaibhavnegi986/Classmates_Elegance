﻿using MaterialDesignThemes.Wpf;
using Project_Prism_Modules.ViewModels;
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

namespace Project_Prism_Modules.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        //public bool IsDarkTheme { get; set; }
        //private readonly PaletteHelper paletteHelper = new PaletteHelper();

        //private void toggleTheme(object sender, RoutedEventArgs e)
        //{
        //    ITheme theme = paletteHelper.GetTheme();

        //    if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
        //    {
        //        IsDarkTheme = false;
        //        theme.SetBaseTheme(Theme.Light);
        //    }
        //    else
        //    {
        //        IsDarkTheme = true;
        //        theme.SetBaseTheme(Theme.Dark);
        //    }
        //    paletteHelper.SetTheme(theme);
        //}

        //private void exitApp(object sender, EventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        //protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        //{
        //    base.OnMouseLeftButtonDown(e);
        //    DragMove();
        //}

        //private void SignupBtn(object sender, RoutedEventArgs e)
        //{
        //    var sgnbtn = new Signup();
        //    sgnbtn.Show();
        //    Close();
        //}
    }
}
