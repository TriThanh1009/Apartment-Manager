   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5      3clr-namespace:AM.UI.View.BillsAM.UI.View.Bills  5      3clr-namespace:AM.UI.ConvertersAM.UI.Converters  5   N   1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  6�       AM.UI.View.Bills.BillHome   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4nav$clr-namespace:AM.UI.State.Navigators     5      0localclr-namespace:AM.UI.View.Bills     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      1
convertersclr-namespace:AM.UI.Converters   6N   ,customclr-namespace:AM.UI.Utilities   6�      
Page_Style#��[  5
        � 	Resources  5        	BoolToVis:   4AM.UI.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	       &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   .+�5"   
   �� $��0��6   $��2��6"   .+�5#      ��   DetailsButton#��[ 6   %   AM.UI.State.Navigators.ViewType   BillAdd#��Z 5%      $	��Add��5&      $
��Left=�6#   $��	27,57,0,0q�6>   $	��Top=�6Q   ��5$      �� *	BillNav+5&   Q   5'      �� 5(   
   $��0��6   $��4��6"   �� 5)   
   -   5         ��Name$
 main��5)   G   $��2��6   $��7��6"   $��4��66   .+�5*      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5,         	Thickness$ 5Q�5.         Color
 �   �   	IsLoading 5-      �� *	Isloading+5/      �� 50      
���  ����52      �� *MessageError+y�53      �� *HasMessageError+	 �� 	Converter#	 [ &   System.Windows.Controls.DataGrid  54      -   5        
  Name$
 homedata��56   �   $	��350��54   |     DataGridStyle1#���  6�     DataGridCellStyle1   	CellStyle# �  56        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6H     DataGridRowStyle1   RowStyle# �  6�   $��0 0 0 0q�6�   ��54      �� *Bill+ �� SelectedItem 64   �� *
SelectBill+ �� UpdateSourceTrigger$ PropertyChanged=�y�55      �� *	HasData+#	 [    Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *ID+  59      $ ID RTC��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *IDRTC+  5:      $ 	ElectricQ��6)   $
 True��6<   $ False��6N   $ * 6d    6n   �� *ElectricQuantity+  5;      $ Active��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *Active+  5<      $ PayDate��6)   $
 True��6:   $ False��6L   $ * 6b    6l   �� *	PayDate+  5=      $ 
TotalMoney��6)   $
 True��6=   $ False��6O   $ * 6e    6o   �� *
TotalMoney+4	  .System.Windows.Controls.DataGridTemplateColumn	  5>      $ 	Operation��6-   $
 True��6@   $
 auto 6R    	  CellTemplate 5?      �� 5@      .R�5A   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5B   &   ��   
EditButton#��[ 6-   ��5C   -   �� *DataContext.BillUpdateNav+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5D   *   .
  (MahApps.Metro.IconPacks.PackIconMaterial
   
  Kind$ PencilOutline=�6E    	 
ButtonIcon#��[	 6Z   5E   '   �� 5F   &   #��[ 6-   ��5G   -   �� *DataContext.DeleteConFirm+ ��  DataGrid��6�   �� .��5H   *   
  $ DeleteOutline=�6E   #��[	 6Z   5I   '   5J   #   5K      5M      5O      5P      �� 5R   
   #��[ 6   $��Contract��68   $
��Left=�6K   $��
205,52,0,0q�6f   $	��Top=�6z   �� 5S   
   #��[ 6   $
��Bill��68   $
��Left=�6G   $��
398,52,0,0q�6b   $	��Top=�6v   5T      5U      