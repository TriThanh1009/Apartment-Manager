   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AM.UI.ViewModelUIAM.UI.ViewModelUI  5      1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  5	      ?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5
      3clr-namespace:AM.UI.ConvertersAM.UI.Converters  5          AM.UI.View.People.Home   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      ?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      *vmclr-namespace:AM.UI.ViewModelUI   5      ,customclr-namespace:AM.UI.Utilities   5	      0nav$clr-namespace:AM.UI.State.Navigators   5
      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      /
convertersclr-namespace:AM.UI.Converters  5         
Page_Style#��[  5        � 	Resources  5        	BoolToVis:   4AM.UI.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	       &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��1* �6   �� 5"      $��1* �6   �� 5#      $��1* �6   �� 5$      $��1* �6   .+�5&   
   �� $��0��6   $��3��6"   .+�5'      �� $��Customer��6     	TextTitle#��[ 6(   $��38(�6L   $��
 0 30 50 0q�6Z   $
��Bold"�6n   5(      �� 5)   
   $��1��6   $��4��6"   .+�5*      �� $��Search here :��6   $
��Left=�6-   $��15(�6H   $��10 2 0 0q�6V   ���#b0b9c66h   � 5+      $	��300��6   $
��Left=�6   $��10 2 0 0q�6:    5,      �� 5-      �� 5.      $	��14* �6'   .+�50      �� -   5         ��Name$ 	textblock��51   H   $��	20,0,20,0q�50      $��Center=�6/   ���#b0b9c6 J� IsHitTestVisible$ False��6_    K� ZIndex$ 1��51      $��search by id......��6.   $��2��52   `   y�6   �� *IsText+ �� 	Converter# [ 6`   �� 54      -   5         ��Name$ 	txtSearch��54        textboxSearch#��[ 6-   $��35��6�   $	��300��6�   $��2��6�   $
��Left=�6�   ��6T   �� *search+ �� UpdateSourceTrigger$ PropertyChanged=�6�   .  (MahApps.Metro.IconPacks.PackIconMaterial  56      	   Kind$	 Magnify=�6(   $��15��67   $��15��6B   $��Center=�6N   $��	250,0,0,0q�57   (   ���#b0b9c6$��1��6P   58      59      �� 5:   
   $��1��6   $��4��6"   $��3��62   .+�5;      ��   	AddButton#��[ 6   %   AM.UI.State.Navigators.ViewType
   CustomerAdd#��Z
 5=      ��5<      �� *AddNavCustomer+.��5>      ��  �� Orientation$ 
Horizontal=�6   .+�5?        $
	 Plus=�6,   $��Center=�68   $��11��6S   $��11��6^   $��0 1 8 0q�6j   �� 5@      $��Add New Customer��6    5A      5B      5C      �� 5D   
   -   5         ��Name$
 main��5D   G   $��2��6   $��7��6"   $��4��66   .+�5E      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5G         	Thickness$ 5Q�5I         Color
 �   �   	IsLoading 5H      �� *	IsLoading+5J      �� 5K      
���  ����5M      �� *ErrorMessage+y�5N      �� *HasErrorMessage+# [ &   System.Windows.Controls.DataGrid  5P      -   5          Name$ homedata��5Q   !  $	��350��6     DataGridStyle1#���  6$     DataGridCellStyle1   	CellStyle# �  6o     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�    	 DataGridRowStyle1   RowStyle# � 	 6�   $��0 0 0 0q�6  ��5P      �� *test+y�64   �� *	HasData+# [  �� SelectedItem 5Q   M   �� *
Customer+   Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6h   �� *ID+  5T      $ 	Room Name��6)   $
 True��6<   $ False��6N   $ * 6d    6n   �� *
RoomName+  5U      $
 Name��6)   $
 True��67   $ False��6I   $ * 6_    6i   �� *Name+  5V      $	 Sex��6)   $
 True��66   $ False��6H   $ * 6^    6h   �� *Sex+  5W      $ Birthday��6)   $
 True��6;   $ False��6M   $ * 6c    6m   �� *
Birthday+  5X      $ PhoneNumber��6)   $
 True��6>   $ False��6P   $ * 6f    6p   �� *PhoneNumber+  5Y      $ Email��6)   $
 True��68   $ False��6J   $ * 6`    6j   �� *Email+  5Z      $ IDCard��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *IDCard+  5[      $ Address��6)   $
 True��6:   $ False��6L   $ * 6b    6l   �� *	Address+4
  .System.Windows.Controls.DataGridTemplateColumn
  5\      $ 	Operation��6-   $
 True��6@   $
 auto 6R    
  CellTemplate 5]      �� 5^      .R�5_   "   �� $ 
Horizontal=�6-   .+�5`   &   ��  
 
EditButton#��[
 6-   ��5a   -   �� *DataContext.UpdateNavCustomer+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5b   *     $	 PencilOutline=�6E     
ButtonIcon#��[ 6Z   5c   '   �� 5d   &   #��[
 6-   ��5e   )   �� *#!DataContext.DeleteCustomerCommand+ ��  DataGrid��6�   �� .��5f   *     $	 DeleteOutline=�6E   #��[ 6Z   5g   '   5h   #   5i      5k      5m      �� 5n      $��40��6   $��Right=�6"   ���#dee4ec$��1q�6T    �� CornerRadius$ 5��6h     �� Padding$  5q�5o      
�������$��
0 10 10 10q�65   ._�5p      �� $ 
Horizontal=�6   .+�5q      �� -   5        ! ��Name$! 
pagingLeft��5q        pagingButton#��[ 61   
" � Tag$
" left��6k   .��5r        $	 ChevronLeft=�60     pagingButtonIcon#��[ 6C   5s      �� 5t      $��1��6    ���#dee4ec$	��3 7q�69   �� 5u      -   5        $ pagingbutton��5u   !   $ 
Horizontal=�67   5v      �� 5w      $��1��6    ���#dee4ec$	��3 7q�69   �� 5x      -   5        $! pagingRight��5x      #��[ 62   $" right��6l   .��5y        $	 ChevronRight=�60   #��[ 6D   5z      5{      5|      5}      5~      5      