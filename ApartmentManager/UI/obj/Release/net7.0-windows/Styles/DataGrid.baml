   M S B A M L   `   `   `  ���� b  ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a   
EditButton  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding �� Triggers P� Property P� Value  RemoveButton  
ButtonIcon.   (MahApps.Metro.IconPacks.PackIconMaterial  ButtonStyle1  TableRowStyle)  #System.Windows.Controls.DataGridRow	 ��Name
 J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!   HeadersVisibilityConverter ]� 
Conditions �� Property �� Value  ColumnHeaderGripperStyle �� Color �� 
ResourceId �� TypeInTargetAssembly ��Name �Name  J� Opacity! � Points" �� Stretch# �� Triggers$ �� 
TargetName  
TableStyle5	  /System.Windows.Controls.DataGridLengthConverter% ��Name&   SelectAllCommand
'   AllG
  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter( 
 Name)   Column* ��Name+ �� CanContentScroll, ��Name- �� ScrollableHeight. � Maximum/ �� Orientation0 �� ViewportHeight1 �� ViewportSize*2 �� #ComputedVerticalScrollBarVisibility3 � Value4 �� Mode5 �� ScrollableWidth6 �� ViewportWidth,7 �� %ComputedHorizontalScrollBarVisibility  TableCellStyle*  $System.Windows.Controls.DataGridCell  TableColumnHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader3   -Microsoft.Windows.Themes.DataGridHeaderBorder8   	IsPressed9 J� IsMouseOver:   	IsHovered;   CanUserSort<   IsClickable=   SortDirection>   SortDirection?   SeparatorVisibility@   SeparatorVisibilityA   SeparatorBrushB   SeparatorBrushC n�Name�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     :Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   UthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  %�  &	        &	 T    &	 �    &	 �    &	 {    &	 =    (�� �    *DataGrid.FocusBorderBrushKey+)(�� �    $" DataGridSelectAllButtonStyle��"  )&	 ~	    &	 �    &	 |    7  7  �� "  ��.���  � �� �#512da8��  � �� �#4a148c��  � �� �#ffffff��  �@�FocusVisualStyle Z� ��  � ��$ Center=���  � �� �� " ��.R��� #��z��$ 5��$ 5q�$��1q�#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#673ab7�� "  ��.���  � �� �#512da8��  � �� �#4a148c��  � �� �#ffffff��  �@�FocusVisualStyle Z� ��  � ��$ Center=���  � �� �� " ��.R��� #��z��$ 5��$ 5q�$��1q�#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#673ab7�� "    .���  � ��$ 12����  � ��$ 12����  � ��$ Center=��� "  �� P�  � ��$
 True��. ���  � ��
 �  ��P�  �@J�IsMouseOver$
 True��. ���  � ��
 ��  ��� "   .���  � ��
 �������  � ��$ 0 4 0 0q���  �@J�SnapsToDevicePixels$
 true����  �@�Cursor$
 Hand����  �@=�ErrorTemplate Z� ��  �@ ValidationErrorTemplate �� .R��� 
���  ��$��2,0,0,0q�$��!��$��Center=���  � �� �� "  .R��� $	 
DGR_Border��$	 0 8q�#��z��$��0q�$

 True��$ 5��._�   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z #
 z
   $��1��$��1��#y�z  �� *AreRowDetailsFrozen+# Z # Z  �� "    $��2��$ Vertical=�y��� *HeadersVisibility+# Z # Z  �� "   P�  �@J�IsMouseOver$
 True��. ���  � �� �#623ed0��  � �� �#ffffffP�  �@ 
IsSelected$
 True��. ���  � �� �#623ed0��  � �� �#ffffff]�  ��  �@ 
IsSelected$
 true����  �@��IsSelectionActive$ false��./���  � �� �#dfdfdf�� "  n�.���  � ��$ 8����  � ��
 ���� ��  �@�Cursor$ SizeWE����  � �� �� " n�.R��� #��z��# z���� $ 	#FF000000���� "  ��.���  � �� �� " ��.R�� .+��� $ Border��#��� ��$

 True��� $ Arrow��
���   �$��Right=�$��8,8,3,3q�$
  0.15Q�! �   ��� ��� ��� ��� $" Uniform=�$��Bottom=�# P�  �@J�IsMouseOver$
 True��. ��� $$ Border��# � �� � ��P�  � ��$
 True��. ��� $$ Border��# � �� � ��P�  � {�$ False��. ��� $$ Arrow�� � y�$ 	Collapsed=��� "   .���  � ��
 ���� ��  � �� �#222528��  � ��$ 0q���   �@ RowDetailsVisibilityMode$ VisibleWhenSelected=���  � ��$
 true����  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled$ False����  �@ AutoGenerateColumns$ False����  �@ HeadersVisibility$ Column=���  � ��$ 0 10 0 0q���  �@ SelectionMode$ Single=���  �@ SelectionUnit$ FullRow=���  �@ CanUserAddRows$ False����  �@ CanUserDeleteRows$ False����  �@ CanUserResizeColumns$ False����  � ��$ 13(���  �@ ColumnWidth$ *	 ��  �@ GridLinesVisibility$
 None=���  � �� �� "  .R��� #��z��#��z��#��z��# z��$

 True��._��� $% DG_ScrollViewer��$|�false������ " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto � �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z& $|�false����C� *�� $" DataGridSelectAllButtonStyle��"  +y��� *HeadersVisibility+# Z' # Z  �� "  ���� *CellsPanelHorizontalOffset+ �� "  
  $!( PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z) # Z  �� "  �� $!* PART_ScrollContentPresenter��#+ z��$��2��$��1���� $, PART_VerticalScrollBar��$��2��#. z- $/ Vertical=�$��1��#1 z0 #y�z2 3 �� *VerticalOffset+$4 OneWay=� �� *TemplatedParent+� $��1��$��2�� �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� $��* �.+��� $, PART_HorizontalScrollBar��$��1��#. z5 $/ 
Horizontal=�#1 z6 #y�z7 3 �� *HorizontalOffset+$4 OneWay=� �� *TemplatedParent+.���� #
 z
  ]�  ��  �@��
IsGrouping$
 true���� " �@%�IsVirtualizingWhenGrouping$ false��./���  � ��$ false���� "   .���  � ��
 ���� ��  � ��$ Center=���  �@�FocusVisualStyle Z� ��  � ��$
 15 0q���  � �� �� "  .R��� #��z��$��0q�$

 True��._��� #
 z
 �� "   .���  � ��$ Center=���  � ��
 ���� ��  � �� �#69717d��  � ��$ 
20 0 15 10q���  � �� �� "  .R�� .+�  #��z��#��z��#��z��#8 z��#: z9 #< z; # z��#> z= #@ z? #B zA ._��� #��z��$
��True��#
 z
 #��z��n� $C PART_LeftHeaderGripper��$
��Left=�8��  n� $C PART_RightHeaderGripper��$��Right=�8�� 