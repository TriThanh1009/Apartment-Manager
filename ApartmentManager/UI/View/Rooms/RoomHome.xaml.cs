﻿using Microsoft.Extensions.Caching.Memory;
using Services.Implement;
using Services.Interface;
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
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using AM.UI.Command;

namespace AM.UI.View.Rooms
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class RoomHome : UserControl
    {
        //string cacheKey = "MyData";
        private readonly ViewModelCommand _view;
        private readonly IRoom services = new RoomServices();
        private PagedResult<RoomVm> paged = new PagedResult<RoomVm>();

        
        public RoomHome()
        {
            InitializeComponent();
            var request = new RequestPaging() { PageIndex = 1, PageSize = 10 };
            paged = services.GetAllPage(request);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}