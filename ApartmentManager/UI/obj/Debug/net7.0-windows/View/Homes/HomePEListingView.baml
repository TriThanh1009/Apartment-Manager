   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AM.UI.ViewModelUIAM.UI.ViewModelUI  5      3clr-namespace:AM.UI.View.HomesAM.UI.View.Homes  5      1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  6;   (    "AM.UI.View.Homes.HomePEListingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      +navclr-namespace:AM.UI.ViewModelUI   5      ,localclr-namespace:AM.UI.View.Homes   5      ,customclr-namespace:AM.UI.Utilities   6;      PageHome_Style#��[  5        � 	Resources  5        	BoolToVis��%   &	       �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��   	AddButton#��[ 6   $	��100��5      $��0 0 20 0q�5      $   AM.UI.ViewModelUI.ViewHomeType   Bill#��Z 5      ��5      �� *ReturnBillHomeVM+.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ 	Backspace=�61   $��15��6B   $��Center=�6M   $��25��6h   �� 5      $�� Go Back��6    $��Center=�60   $��Center=�6L   5      5      5      � 5    
   $��1��6   .+�5!      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5"         	Thickness$ 5Q�5$         Color
 �   �   	IsLoading 5#      �� *	IsLoading+5%      &   System.Windows.Controls.DataGrid  5&      -   5        	  Name$	 homedata��5&   �    DataGridStyle1#���  6�     DataGridCellStyle1
   	CellStyle#
 �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6    DataGridRowStyle1   RowStyle# �  6^  $��0 20 0 0q�6�  ��6   �� *ListPE+ �� SelectedItem 66   �� *
SelectedPE+ �� UpdateSourceTrigger$ PropertyChanged=�y�6~   �� *	HasData+ �� 	Converter# [    Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6h   �� *ID+  5)      $ IDBill��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *IDBill+  5*      $ 	Room Name��6)   $
 True��6<   $ False��6N   $ * 6d    6n   �� *
NameRoom+  5+      $ Leader Name��6)   $
 True��6>   $ False��6P   $ * 6f    6p   �� *
NameLeader+  5,      $ 
TotalMoney��6)   $
 True��6=   $ False��6O   $ * 6e    6o   �� *
TotalMoney+  5-      $ Extension Date��6)   $
 True��6A   $ False��6S   $ * 6i    6s   �� *Days+4	  .System.Windows.Controls.DataGridTemplateColumn	  5.      $ 	Operation��6-   $
 True��6@   $
 auto 6R    	  CellTemplate 5/      �� 50      .R�51   "   �� $ 
Horizontal=�6-   .+�52   &   ��   
EditButton#��[ 6-   ��53   )   �� *DataContext.DeletePECommnad+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��54   *     $ DeleteOutline=�6E     
ButtonIcon#��[ 6Z   55   '   56   #   57      59      5;      5<      5=      5>      