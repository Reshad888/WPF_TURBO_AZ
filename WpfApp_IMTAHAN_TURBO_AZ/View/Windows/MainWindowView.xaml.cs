﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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


namespace WpfApp_IMTAHAN_TURBO_AZ.View.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : NavigationWindow
    {
        public MainWindowView()
        {


            File.WriteAllText("../../../DataBaseJson/index.json", JsonSerializer.Serialize(-1));
            InitializeComponent();
        }

        
    }
}
