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

namespace AM.UI.View.RoomDetails
{
    /// <summary>
    /// Interaction logic for RoomDetailsDelete.xaml
    /// </summary>
    public partial class RoomDetailsDelete : UserControl
    {

        class Image
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string PathImage { get; set; }
        }
        public RoomDetailsDelete()
        {
            InitializeComponent();
            List<Image> images = new List<Image>();
            images.Add(new Image
            {
                ID = 1,
                Name = "a",
                PathImage = "img_home.png"
            });
            listbox1.ItemsSource= images;
        }
    }
}