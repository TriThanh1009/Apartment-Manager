   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5      E'clr-namespace:AM.UI.View.RentalContractAM.UI.View.RentalContract  5      3clr-namespace:AM.UI.ConvertersAM.UI.Converters  6�   1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  6�   2    ,AM.UI.View.RentalContract.RentalContractHome   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4nav$clr-namespace:AM.UI.State.Navigators     5      9local'clr-namespace:AM.UI.View.RentalContract     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6D   1
convertersclr-namespace:AM.UI.Converters   6�   ,customclr-namespace:AM.UI.Utilities   6�   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � 	Resources  5         	BoolToVis:   4AM.UI.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	        &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��9* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5       $	��13* �6   �� 5!      $	��13* �6   .+�5#   
   �� $��0��6   $��4��6"   $��	0,0,104,0q�66   .+�5$      ��   DetailsButton#��[ 6   %   AM.UI.State.Navigators.ViewType   RentalContractAdd#��Z 5&      $	��Add��5'      $
��Left=�6#   $��	27,57,0,0q�6>   $	��Top=�6Q   ��5%      �� *	RentalNav+5'   Q   5(      �� 5)   
   $��1��6   $��4��6"   .+�5*      �� $��Search here :��6   $
��Left=�6-   $��15(�6H   $��10 2 0 0q�6V   ���#b0b9c66h   � 5+      $	��300��6   $
��Left=�6   $��10 2 0 0q�6:    5,      �� 5-      $	��20* �6'   �� 5.      $	��39* �6'   �� 5/      $
��241* �6'   .+�51      �� -   5         ��Name$ 	textblock��52   H   $��0,0,20,0q�51      $��Center=�6.   ���#b0b9c6 J� IsHitTestVisible$ False��6^    K� ZIndex$ 1��52      $��search by id......��6.   $��2��53   `   $��1��6t   y�6   �� *IsText+ �� 	Converter# [  6t   �� 55      -   5         ��Name$ 	txtSearch��55        textboxSearch#��[ 6-   
���   �$��35��6�   $	��300��6�   $��3��6�   $
��Left=�6�   ��6T   �� *search+	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   56      57      �� 58   
   -   5        
 ��Name$

 main��58   G   $��2��6   $��8��6"   $��4��66   .+�59      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5;         	Thickness$ 5Q�5=         Color
 �   �   	IsLoading 5<      �� *	IsLoading+5>      �� 5?      
���  ����5A      �� *ErrorMessage+y�5B      �� *HasMessageError+# [  &   System.Windows.Controls.DataGrid  5C      -   5          Name$ homedata��5F   �   $	��350��5E        DataGridStyle1#���  6$     DataGridCellStyle1   	CellStyle# �  5F        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6H     DataGridRowStyle1   RowStyle# �  6�   $��0 0 0 0q�6�   ��5C      �� *Rental+ �� SelectedItem 67   �� *SelectRentalContract+$	 PropertyChanged=�y�5D      �� *	HasData+# [     Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *ID+  5I      $
 Room��6)   $
 True��67   $ False��6I   $ * 6_    6j   �� *
RoomName+  5J      $ Leader��6)   $
 True��69   $ False��6K   $ * 6a    6l   �� *
LeaderName+  5K      $ Receive��6)   $
 True��6:   $ False��6L   $ * 6b    6m   �� *ReceiveDate+  5L      $	 Out��6)   $
 True��66   $ False��6H   $ * 6^    6i   �� *CheckOutDate+  5M      $ RoomM��6)   $
 True��68   $ False��6J   $ * 6`    6k   �� *	RoomMoney+  5N      $ Elect��6)   $
 True��68   $ False��6J   $ * 6`    6k   �� *ElectricMoney+  5O      $ Water��6)   $
 True��68   $ False��6J   $ * 6`    6k   �� *
WaterMoney+  5P      $
 SerM��6)   $
 True��67   $ False��6I   $ * 6_    6j   �� *ServiceMoney+  5Q      $ Active��6)   $
 True��69   $ False��6K   $ * 6a    6l   �� *Active+4	  .System.Windows.Controls.DataGridTemplateColumn	  5R      $ 	Operation��6-   $
 True��6@   $
 auto 6R    	  CellTemplate 5S      �� 5T      .R�5U   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5V   &   ��   
EditButton#��[ 6-   ��5W   .   �� *$"DataContext.RentalUpdateNavCommand+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5X   *   .
  (MahApps.Metro.IconPacks.PackIconMaterial
   
  Kind$ PencilOutline=�6E    	 
ButtonIcon#��[	 6Z   5Y   '   �� 5[   &   #��[ 6-   ��5\   .   �� *!DataContext.RentalDeleteConFirm+ ��  DataGrid��6�   �� .��5^   *   
  $
 Home=�6E   #��[	 6Q   5_   '   �� 5a   &   #��[ 6-   ��5b   .   �� *!DataContext.RentalDeleteConFirm+ ��  DataGrid��6�   �� .��5d   *   
  $ DeleteOutline=�6E   #��[	 6Z   5e   '   �� 5g   &   #��[ 6-   ��5h   .   �� *!DataContext.RentalDeleteConFirm+ ��  DataGrid��6�   �� .��5j   *   
  $ DeleteOutline=�6E   #��[	 6Z   5k   '   5l   #   5m      5o      5q      5r      5s      5t      