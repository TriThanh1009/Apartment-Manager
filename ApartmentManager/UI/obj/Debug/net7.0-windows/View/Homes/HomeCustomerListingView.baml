   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AM.UI.ViewModelUIAM.UI.ViewModelUI  5      ?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5	      1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  5
      3clr-namespace:AM.UI.View.HomesAM.UI.View.Homes  5      .    (AM.UI.View.Homes.HomeCustomerListingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      ?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      +navclr-namespace:AM.UI.ViewModelUI   5      6	navDeosit$clr-namespace:AM.UI.State.Navigators   5	      ,customclr-namespace:AM.UI.Utilities   5
      ,localclr-namespace:AM.UI.View.Homes   5         PageHome_Style#��[  5        � 	Resources  5        	BoolToVis��%   &	       �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��   	AddButton#��[ 6   $	��100��5      $   AM.UI.ViewModelUI.ViewHomeType   Bill#��Z 5      ��5      �� *ReturnBillHomeVM+.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ 	Backspace=�61   $��15��6B   $��Center=�6M   $��25��6h   �� 5      $�� Go Back��6    $��Center=�60   $��Center=�6L   5       5!      5"      � 5#   
   $��1��6   .+�5$      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5%         	Thickness$ 5Q�5'         Color
 �   �   	IsLoading 5&      �� *	IsLoading+5(      &   System.Windows.Controls.DataGrid  5)      -   5        	  Name$	 homedata��5*   �   $	��350��6     DataGridStyle1#���  6$     DataGridCellStyle1
   	CellStyle#
 �  6M     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6~     DataGridRowStyle1   RowStyle# �  6�   $��0 0 0 0q�6�   ��5)      �� *ListCustomer+y�6<   �� *	HasData+ �� 	Converter# [    Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6h   �� *ID+  5-      $ RoomName��6)   $
 True��6;   $ False��6M   $ * 6c    6m   �� *
RoomName+  5.      $
 Name��6)   $
 True��67   $ False��6I   $ * 6_    6i   �� *Name+  5/      $	 Sex��6)   $
 True��66   $ False��6H   $ * 6^    6h   �� *Sex+  50      $ Birthday��6)   $
 True��6;   $ False��6M   $ * 6c    6m   �� *
Birthday+  51      $ PhoneNumber��6)   $
 True��6>   $ False��6P   $ * 6f    6p   �� *PhoneNumber+  52      $ Email��6)   $
 True��68   $ False��6J   $ * 6`    6j   �� *Email+  53      $ IDCard��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *IDCard+  54      $ Address��6)   $
 True��6:   $ False��6L   $ * 6b    6l   �� *	Address+4	  .System.Windows.Controls.DataGridTemplateColumn	  56      $ 	Operation��6-   $
 True��6@   $
 auto 6R    	  CellTemplate 57      �� 58      .R�59   "   �� $ 
Horizontal=�6-   .+�5:   &   ��   
EditButton#��[ 6-   ��5;   )   �� *#!DataContext.DeleteCustomerCommand+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5<   *     $ DeleteOutline=�6E     
ButtonIcon#��[ 6Z   5=   '   5>   #   5?      5A      5C      5D      5E      5F      