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
using System.Text.RegularExpressions;

namespace TextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }

        private void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
                var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
                var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

                
                if ((!Regex.Match(textBox.Text, _usZipRegEx).Success) && (!Regex.Match(textBox.Text, _caZipRegEx).Success))
                {
                    uxSubmit.IsEnabled = false;
                }
                else
                    uxSubmit.IsEnabled = true;
            

            }
        }
    }

