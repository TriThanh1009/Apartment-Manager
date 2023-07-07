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
using AM.UI.Utilities;

namespace AM.UI.View.People
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        private Button current = null;
        private ControlObject co = new ControlObject();

        public Home()
        {
            InitializeComponent();
            Button button = new Button();
            button.Content = 1;
            button.Name = "button1";
            button.Style = (Style)FindResource("pagingButtonchange");
            button.Click += Button_Click;
            pagingbutton.Children.Add(button);
            pagingLeft.IsEnabled = false;
            current = button;
            for (int i = 2; i <= 10; i++)
            {
                if (i<5)
                {
                    button = new Button();
                    button.Content = i.ToString();
                    button.Name = "button"+ i.ToString();
                    button.Style = (Style)FindResource("pagingButton");
                    button.Click += Button_Click;
                }
                if (i<10) { }
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
            pagingLeft.IsEnabled = co.EnableLeft(clickedButton);
            pagingRight.IsEnabled = co.EnableRight(clickedButton);
            clickedButton.Style =(Style)FindResource("pagingButtonchange");
            current = clickedButton;
            // code  trang

            //code trang
        }

        private void Button_page(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonValue = clickedButton.Tag as string;

            if (buttonValue.Equals("right"))
            {
                if (!current.Name.Equals("button5"))
                {
                    string temp = "button"+ (Convert.ToInt32(current.Content)+1).ToString();
                    Button button = co.FindChildButton(this, temp);
                    if (button != null)
                    {
                        pagingLeft.IsEnabled = co.EnableLeft(button);
                        pagingRight.IsEnabled = co.EnableRight(button);
                        button.Style =(Style)FindResource("pagingButtonchange");
                        current.Style = (Style)FindResource("pagingButton");
                        current = button;
                        // code  trang

                        //code trang
                    }
                }
            }
            else if (buttonValue.Equals("left"))
            {
                if (!current.Name.Equals("button1"))
                {
                    string temp = "button"+ (Convert.ToInt32(current.Content)-1).ToString();
                    Button button = co.FindChildButton(this, temp);
                    if (button != null)
                    {
                        pagingLeft.IsEnabled = co.EnableLeft(button);
                        pagingRight.IsEnabled = co.EnableRight(button);
                        button.Style =(Style)FindResource("pagingButtonchange");
                        current.Style = (Style)FindResource("pagingButton");
                        current = button;
                        // code  trang

                        //code trang
                    }
                }
            }
        }
    }
}