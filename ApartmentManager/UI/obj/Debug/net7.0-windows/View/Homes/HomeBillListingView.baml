   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  5      3clr-namespace:AM.UI.View.HomesAM.UI.View.Homes  5      *    $AM.UI.View.Homes.HomeBillListingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      ,customclr-namespace:AM.UI.Utilities   5      ,localclr-namespace:AM.UI.View.Homes   5         PageHome_Style#��[  5        � 	Resources  5        	BoolToVis��%   &	       �� 5   
   6'   5      .��5      � .   (AM.UI.Utilities.EventToCommandExtensions!   MouseLeftButtonDownCommand 6   �� *	TestClick+.+�5   
   �  � RowDefinitions 5      �� 5      $��75 �6    �� 5      $��* �6    .+�5      � .+�5      �� $��ADD BILL��6   $	��162��6,   $
��Left=�6\   $��
 20 10 0 0q�6w   ��68   �� *AutoAddCommand+6w   �� 5      $��Add Payment Extension��5      $	��162��61   $��Right=�6X   $��
 0 10 20 0q�6t   y�5      �� *flag+ �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [ ��5   =   �� *AddPE+6t   5      � 5      $��1��6   .+�5      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5         	Thickness$ 5Q�5!         Color
 �   �   	IsLoading 5       �� *	IsLoading+5"      &   System.Windows.Controls.DataGrid  5#      -   5        	  Name$	 homedata��5$   Z    DataGridStyle1#���  6~     DataGridCellStyle1
   	CellStyle#
 �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridRowStyle1   RowStyle# �  6  $��0 20 0 0q�6H  y�5#      �� *	HasData+# [ ��5$      �� *
listhome+ �� SelectedItem 66   �� *
selectItem+$ PropertyChanged=�   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      
IsReadOnly$
 True��69      CanUserResize$ False��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6l   �� *ID+  5'      $
 Room��6-   $
 True��6;   $ False��6M   $ * 6c    6m   �� *
NameRoom+  5(      $ ElecQuality��6-   $
 True��6B   $ False��6T   $ * 6j    6t   �� *ElecQuality+  5)      $ 	RoomMoney��6-   $
 True��6@   $ False��6R   $ * 6h    6r   �� *	RoomMoney+  5*      $ ElectricMoney��6-   $
 True��6D   $ False��6V   $ * 6l    6v   �� *ElectricMoney+  5+      $ 
WaterMoney��6-   $
 True��6A   $ False��6S   $ * 6i    6s   �� *
WaterMoney+  5,      $ ServiceMoney��6-   $
 True��6C   $ False��6U   $ * 6k    6u   �� *ServiceMoney+  5-      $ PayDate��6-   $
 True��6>   $ False��6P   $ * 6f    6p   �� *	PayDate+  5.      $ 
TotalMoney��6-   $
 True��6A   $ False��6S   $ * 6i    6s   �� *
TotalMoney+4  .System.Windows.Controls.DataGridTemplateColumn  5/      $ Active��61   $
 True��6A   $ False��6S   $ * 6i      CellTemplate 50      �� 51   "   .R�52   &   ��  �� Orientation$ 
Horizontal=�61   .+�53   *   d�   ActiveToggl1e#��[ 67    d� 	IsChecked 6^   �� *
IsActive+$ PropertyChanged=���54   6   �� *DataContext.ActiveCommand+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� 55   '   56   #   58        5:      $ 	Operation��61   $
 True��6D   $
 auto 6V    5;      �� 5<   "   .R�5=   &   �� $ 
Horizontal=�61   .+�5>   *   ��   
EditButton#��[ 61   ��5?   1   �� *DataContext.EditElectric+ ��  DataGrid��6�   �� .��5@   .   .	  (MahApps.Metro.IconPacks.PackIconMaterial	   	  Kind$ PencilOutline=�6D     
ButtonIcon#��[ 6Y   5A   +   5B   '   5C   #   5E      5G      5H      5I      5J      5K      