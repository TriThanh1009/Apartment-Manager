   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AM.UI.UtilitiesAM.UI.Utilities  5      ?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5	      3clr-namespace:AM.UI.ConvertersAM.UI.Converters  6?       AM.UI.View.PEHomeView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      ?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      ,customclr-namespace:AM.UI.Utilities   5      0nav$clr-namespace:AM.UI.State.Navigators   5	      1
convertersclr-namespace:AM.UI.Converters   6?      
Page_Style#��[  5        � 	Resources  5        	BoolToVis:   4AM.UI.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	       &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   .+�5"   
   �� $��0��6   $��3��6"   .+�5#      �� $��Payment ��6     	TextTitle#��[ 6(   $��36(�6L   $��
 10 10 0 0q�6Z   $
��Left=�6n   $
��Bold"�6�   �� 5$      $��
 Extension��6   #��[ 6*   $��36(�6N   $��	40 10 0 0q�6\   $
��Bold"�6o   5%      �� 5&   
   $��1��6   $��4��6"   .+�5'      �� $��Search here :��6   $
��Left=�6-   $��15(�6H   $��10 2 0 0q�6V   ���#b0b9c66h   � 5(      $	��300��6   $
��Left=�6   $��10 2 0 0q�6:    5)      �� 5*      �� 5+      $	��14* �6'   .+�5-      �� -   5         ��Name$ 	textblock��5.   H   $��	20,0,20,0q�5-      $��Center=�6/   ���#b0b9c6 J� IsHitTestVisible$ False��6_    K� ZIndex$ 1��5.      $��search by id......��6.   $��2��5/   `   y�6   �� *IsText+ �� 	Converter# [ 6`   �� 51      -   5         ��Name$ 	txtSearch��51        textboxSearch#��[ 6-   $��35��6�   $	��300��6�   $��2��6�   $
��Left=�6�   ��6T   �� *search+ �� UpdateSourceTrigger$ PropertyChanged=�6�   .  (MahApps.Metro.IconPacks.PackIconMaterial  53      	   Kind$	 Magnify=�6(   $��15��67   $��15��6B   $��Center=�6N   $��	250,0,0,0q�54   (   ���#b0b9c6$��1��6P   55      56      �� 57   
   $��1��6   $��4��6"   $��3��62   .+�58      ��   	AddButton#��[ 6   %   AM.UI.State.Navigators.ViewType
   CustomerAdd#��Z
 5:      ��59      �� *AddNavCustomer+.��5;      ��  �� Orientation$ 
Horizontal=�6   .+�5<        $
	 Plus=�6,   $��Center=�68   $��11��6S   $��11��6^   $��0 1 8 0q�6j   �� 5=      $��Add New Payment��6    5>      5?      5@      �� 5A   
   -   5         ��Name$
 main��5A   G   $��2��6   $��7��6"   $��4��66   .+�5B      $   AM.UI.Utilities.LoadingSpinner     Diameter$	 100Q�5D         	Thickness$ 5Q�5F         Color
 �   �   	IsLoading 5E      �� *	IsLoading+5G      �� 5H      
���  ����5J      �� *ErrorMessage+y�5K      �� *HasErrorMessage+# [ &   System.Windows.Controls.DataGrid  5M      -   5          Name$ homedata��5M   W    DataGridStyle1#���  6{     DataGridCellStyle1   	CellStyle# �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�    	 DataGridRowStyle1   RowStyle# � 	 6  $��0 20 0 0q�6E  ��6   �� *ListPE+y�66   �� *	HasData+# [    Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
IsReadOnly$
 True��65      CanUserResize$ False��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6h   �� *ID+  5P      $ IDBill��6)   $
 True��69   $ False��6K   $ * 6a    6k   �� *IDBill+  5Q      $ 	Room Name��6)   $
 True��6<   $ False��6N   $ * 6d    6n   �� *
NameRoom+  5R      $ Leader Name��6)   $
 True��6>   $ False��6P   $ * 6f    6p   �� *
NameLeader+  5S      $ Extension Date��6)   $
 True��6A   $ False��6S   $ * 6i    6s   �� *Days+4
  .System.Windows.Controls.DataGridTemplateColumn
  5T      $ 	Operation��6-   $
 True��6@   $
 auto 6R    
  CellTemplate 5U      �� 5V      .R�5W   "   �� $ 
Horizontal=�6-   .+�5X   &   ��  
 
EditButton#��[
 6-   ��5Y   -   �� *DataContext.UpdateNavCustomer+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5Z   *     $	 PencilOutline=�6E     
ButtonIcon#��[ 6Z   5[   '   �� 5\   &   #��[
 6-   ��5]   )   �� *#!DataContext.DeleteCustomerCommand+ ��  DataGrid��6�   �� .��5^   *     $	 DeleteOutline=�6E   #��[ 6Z   5_   '   5`   #   5a      5c      5e      5f      5g      5h      