   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5      G(clr-namespace:AM.UI.View.DepositContractAM.UI.View.DepositContract  5      3clr-namespace:AM.UI.ConvertersAM.UI.Converters  6�   1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  6�   4    .AM.UI.View.DepositContract.DepositContractHome   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4nav$clr-namespace:AM.UI.State.Navigators     5      :local(clr-namespace:AM.UI.View.DepositContract     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6E   1
convertersclr-namespace:AM.UI.Converters   6�   ,customclr-namespace:AM.UI.Utilities   6�     � 	Resources  5
         	BoolToVis:   4AM.UI.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	        &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��9* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   .+�5!   
   �� $��0��6   $��4��6"   $��	0,0,104,0q�66   .+�5"      ��   DetailsButton#��[ 6   $	��Add��5$      $
��Left=�6#   $��	27,57,0,0q�6>   $	��Top=�6Q   ��5#      �� *
DepositNav+5$   Q   5%      �� 5'   
   -   5         ��Name$
 main��5'   G   $��2��6   $��8��6"   $��4��66   .+�5(      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5*         	Thickness$ 5Q�5,         Color
 �   �   	IsLoading 5+      �� *	IsLoading+5-      �� 5.      
���  ����50      �� *MessageError+y�51      �� *HasMessageError+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  52      -   5        	  Name$	 homedata��54   �   $	��350��6     DataGridStyle1#���  6$     DataGridCellStyle1
   	CellStyle#
 �  6M     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6~     DataGridRowStyle1   RowStyle# �  6�   $��0 0 0 0q�6�   ��52      �� *	Deposit+ �� SelectedItem 68   �� *SelectDeposits+y�53      �� *	HasData+# [     Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *ID+  57      $
 Room��6)   $
 True��67   $ False��6I   $ * 6_    6j   �� *
RoomName+  58      $ Leader��6)   $
 True��69   $ False��6K   $ * 6a    6l   �� *
LeaderName+  59      $ Deposits��6)   $
 True��6;   $ False��6M   $ * 6c    6n   �� *DepositsDate+  5:      $ Receive��6)   $
 True��6:   $ False��6L   $ * 6b    6m   �� *ReceiveDate+  5;      $ CheckOut��6)   $
 True��6;   $ False��6M   $ * 6c    6n   �� *CheckOutDate+  5<      $ Money��6)   $
 True��68   $ False��6J   $ * 6`    6k   �� *Money+4  .System.Windows.Controls.DataGridTemplateColumn  5=      $ 	Operation��6-   $
 True��6@   $
 auto 6R      CellTemplate 5>      �� 5?      .R�5@   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5A   &   ��   
EditButton#��[ 6-   ��5B   .   �� *&$DataContext.DepositContractUpdateNav+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5C   *   .	  (MahApps.Metro.IconPacks.PackIconMaterial	   	  Kind$ PencilOutline=�6E     
ButtonIcon#��[ 6Z   5D   '   �� 5E   &   #��[ 6-   ��5F   .   �� *DataContext.DeleteConFirm+ ��  DataGrid��6�   �� .��5G   *   	  $ DeleteOutline=�6E   #��[ 6Z   5H   '   5I   #   5J      5L      5N      5O      5P      5Q      