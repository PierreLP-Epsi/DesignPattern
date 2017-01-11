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

namespace DesignPattern
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.listBox.SelectionChanged += new SelectionChangedEventHandler(listBox_SelectedIndexChanged);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxItem selection = (ListBoxItem)listBox.SelectedItem;
            string curItem = selection.Content.ToString();

            if (curItem == "Empire")
            {
                IThemeFactory Theme = new EmpireTheme();
                button.Background = new BrushConverter().ConvertFromString(Theme.ChangeTheme()) as SolidColorBrush;
            }

            else if (curItem == "Rebelle")
            {
                IThemeFactory Theme = new RebelleTheme();
                button.Background = new BrushConverter().ConvertFromString(Theme.ChangeTheme()) as SolidColorBrush;
            }
        }
    }
}
