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

    public partial class MainWindow : Window
    {
        IButton droidButton = new ButtonDroid(20, 105, 12);

        public MainWindow()
        {
            InitializeComponent();
            this.listBox.SelectionChanged += new SelectionChangedEventHandler(listBox_SelectedIndexChanged);
        }

        private void Reinitialized()
        {
            Button_Droid.Height = droidButton.GetHeigth();
            Button_Droid.Width = droidButton.GetWidth();
            Button_Droid.FontSize = droidButton.GetFontSize();
        }

        private void BB8_Click(object sender, RoutedEventArgs e)
        {
            droidButton = new ButtonBB8(droidButton);
            Reinitialized();
        }

        private void C3PO_Click(object sender, RoutedEventArgs e)
        {
            droidButton = new ButtonC3PO(droidButton);
            Reinitialized();
        }

        private void R2D2_Click(object sender, RoutedEventArgs e)
        {
            droidButton = new ButtonR2D2(droidButton);
            Reinitialized();
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
