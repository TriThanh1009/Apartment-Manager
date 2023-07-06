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
using System.Collections.ObjectModel;

using UI.Utilities;
using Unity.Policy;

namespace AM.UI.View.People
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        private Button current = null;

        public Home()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                Button button = new Button();
                if (i == 1)
                {
                    button.Content = i.ToString();
                    button.Name = "button"+ i.ToString();
                    button.Style = (Style)FindResource("pagingButtonchange");
                    button.Click += Button_Click;
                    current = button;
                }

                button.Content = i.ToString();
                button.Name = "button"+ i.ToString();
                button.Style = (Style)FindResource("pagingButton");
                button.Click += Button_Click;

                pagingbutton.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (current != null)
            {
                current.Style = (Style)FindResource("pagingButton");
            }
            Button clickedButton = sender as Button;
            MessageBox.Show(current.Name);
            clickedButton.Style =(Style)FindResource("pagingButtonchange");
            current = clickedButton;
            /*Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Content.ToString();
                MessageBox.Show("Clicked button: " + buttonText);
            }*/
        }

        private void Button_page(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonValue = clickedButton.Tag as string;
            if (buttonValue.Equals("right"))
            {
            }
        }
    }
}