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

namespace SimplyUnlock
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // press button sequence
        private readonly int[] code = new int[7] {
            1, 1, 2, 3, 3, 3, 2
        };

        private bool permission = false;
        private int codeStep = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = ((Button)e.Source).Name;

            switch (text)
            {
                case "Button1":
                    if(!(code[codeStep] == 1))
                        codeStep = 0;
                   if(permission)
                    {
                        MessageBox.Show(string.Format("Clicked: {0}", text));
                    }
                    break;
                case "Button2":
                    if (!(code[codeStep] == 2))
                        codeStep = 0;
                    if (permission)
                    {
                        MessageBox.Show(string.Format("Clicked: {0}", text));
                    }
                    break;
                case "Button3":
                    if (!(code[codeStep] == 3))
                        codeStep = 0;
                    if (permission)
                    {
                        MessageBox.Show(string.Format("Clicked: {0}", text));
                    }
                    break;
                default:
                    break;
            }

            

            if (codeStep == code.GetUpperBound(0))
            {
                TextBlock1.Text = "unlocked";
                TextBlock1.Foreground = Brushes.Green;
                permission = true;
            }

            
            if (permission)
                codeStep = 0;
            else
                ++codeStep;
        }
    }
}
