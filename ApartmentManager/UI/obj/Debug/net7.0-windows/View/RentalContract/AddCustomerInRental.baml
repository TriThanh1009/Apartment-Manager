   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AM.UI.View.PeopleAM.UI.View.People  5      ?$clr-namespace:AM.UI.State.NavigatorsAM.UI.State.Navigators  5      5clr-namespace:AM.UI.State.RulesAM.UI.State.Rules  6   3    -AM.UI.View.RentalContract.AddCustomerInRental   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:AM.UI.View.People     5      4nav$clr-namespace:AM.UI.State.Navigators     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6?   -rulesclr-namespace:AM.UI.State.Rules   6      
Page_Style#��[  5	        � 	Resources  5
         BooleanToVisibilityConverter��%   &	       �� 5   
   6'   5      .��5      � .+�5   
   �� $��ID RT��6   $
��Left=�6    $��	47,67,0,0q�6;   $	��Top=�6N   $��20(�6f   ���	#FFCEB4B46t   �� 5   
   $��149,67,391,584q�6   $	��192��6*   $��20(�66   $��30��6D   ${�False��6�   ��6P   �� *IDRT+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
47,131,0,0q�6:   $	��Top=�6N   $��20(�6f   ���	#FFCEB4B46t   �� 5   
   $
��Left=�6   $��149,135,0,0q�6.    �� TextWrapping$
 Wrap=�6C   $	��Top=�6X   $	��192��6p   $��20(�6|     errorTemplate =� ErrorTemplate# [ 6�   .��6�   ��5      �� 5       �� Path$
 name�6    �� ValidatesOnDataErrors$
 True��6&   $ PropertyChanged=�6C    �� ValidationRules 5      !   AM.UI.State.Rules.WrongName  5      ,   &AM.UI.State.Rules.MinimumCharacterRule  5         MinimumCharacters$ 25��65      
Characters$ 2��6L   	   
nameofrule$
	 Name��6[   5      .��5      5      �� 5   
   $	��Sex��6   $
��Left=�6   $��
47,205,0,0q�69   $	��Top=�6M   $��20(�6e   ���	#FFCEB4B46s   �� 5   
   $
��Left=�6   $��149,209,0,0q�6/   $	��Top=�6D   $	��192��6\   $��20(�6�   ��6h   �� *
ComboSex+
 �� SelectedItem
 6�   �� *sex+$ PropertyChanged=�6�   �� 5   
   $��Birthday��6   $
��Left=�6#   $��
47,269,0,0q�6>   $	��Top=�6R   $��20(�6j   ���	#FFCEB4B46x   �� 5   
   $��PhoneNumber��6   $
��Left=�6&   $��
399,71,0,0q�6A   $	��Top=�6U   $��20(�6m   ���	#FFCEB4B46{   �� 5   
   $
��Left=�6   # [ 6-   $��
501,75,0,0q�6g   $
 Wrap=�6{   $	��Top=�6�   $	��192��6�   $��20(�6�   .��6�   ��5       �� 5!      $ phoneNumber�6   $
 True��6-   $ PropertyChanged=�6J    5"      (   "AM.UI.State.Rules.WrongPhoneNumber  5#      5%      .��5&      5'      �� 5(   
   $��Email��6   $
��Left=�6    $��399,135,0,0q�6;   $	��Top=�6P   $��20(�6h   ���	#FFCEB4B46v   �� 5*   
   $
��Left=�6   # [ 6-   $��501,139,0,0q�6g   $
 Wrap=�6|   $	��Top=�6�   $	��192��6�   $��20(�6�   .��6�   ��5+      �� 5,      $ email�6   $
 True��6'   $ PropertyChanged=�6D    5-        5.      $ 2��65   $ 60��6D   $	 Enail��6[   "   AM.UI.State.Rules.WrongEmail  5/      51      .��52      53      �� 54   
   $��IDCard��6   $
��Left=�6!   $��399,209,0,0q�6<   $	��Top=�6Q   $��20(�6i   ���	#FFCEB4B46w   �� 55   
   $
��Left=�6   # [ 6-   $��501,213,0,0q�6g   $
 Wrap=�6|   $	��Top=�6�   $	��192��6�   $��20(�6�   .��6�   ��56      �� 57      $ idcard�6   $
 True��6(   $ PropertyChanged=�6E    58        59      $ 2��65   $ 20��6D   $	 ID Card��6[   0  *AM.UI.State.Rules.ContainsSpecialCharacter  5:         
NameOfRule$ ID Card��69   5<      .��5=      5>      �� 5?   
   $��Address��6   $
��Left=�6"   $��399,273,0,0q�6=   $	��Top=�6R   $��20(�6j   ���	#FFCEB4B46x   �� 5@   
   $
��Left=�6   # [ 6-   $��501,277,0,0q�6g   $
 Wrap=�6|   $	��Top=�6�   $	��192��6�   $��20(�6�   .��6�   ��5A      �� 5B      $ address�6   $
 True��6)   $ PropertyChanged=�6F    5C        5D      $ 2��65   $	 100��6D   $	 Address��6\     5E      $ Address��69   5G      .��5H      5I      �� 5J   
   $��confilm��6   $
��Left=�6#   $��
56,340,0,0q�6>   $	��Top=�6R   $��30��6j   $��72��6v    J� RenderTransformOrigin$ -0.042,0.715&�5K   -   ��6   �� *	Confirm+6-   �� 5L   
   $	��Add��6   $
��Left=�6   $��173,340,0,0q�6:   $	��Top=�6O   $��30��6g   $��72��6s   ��5M      �� *	AddList+�� 5N   
   $��cancel��6   $
��Left=�6"   $��427,338,0,0q�6=   $	��Top=�6R   $��52��6j   $��98��6v   %   AM.UI.State.Navigators.ViewType   Customer#��Z 5O   ,   $ 0.526,0.087&�6`   ��6   �� *Cancel+6`   (  "System.Windows.Controls.DatePicker  5P   
   $
��Left=�6   $��149,273,0,0q�60   $	��Top=�6E   $	��192��6�   $��20(�6�      SelectedDate 6]   �� *
birthday+$ PropertyChanged=�6�   �� 5Q   
   $��30��5R      $��
0,36,0,615q�5S      4  .System.Windows.Automation.AutomationProperties   AutomationId$' !MakeReservationSubmitErrorMessage��5T      
���  ����5V      �� *SubmitErrorMessage+y�5W      �� *HasSubmitErrorMessage+ �� 	Converter# [ &	   System.Windows.Controls.DataGrid	  5Y   
   -   5         	 Name$ homedata��5Z   �   $��0,395,10,49q�5Y   4     DataGridStyle1#���  5Z        DataGridCellStyle1 	  	CellStyle# �  6@     DataGridColumnHeaderStyle1 	  ColumnHeaderStyle# �  6q     DataGridRowStyle1 	  RowStyle# �  6�   ��5Y      �� *	peoples+
 6I   �� *SelectedPeople+ 	  Columns 5[      0
  *System.Windows.Controls.DataGridTextColumn
  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
IsReadOnly$
 True��61      CanUserResize$ False��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6d   �� *ID+
  5]      $ RoomName��6%   $
 True��67   $ False��6I   $ * 6_    6i   �� *
RoomName+
  5^      $
 Name��6%   $
 True��63   $ False��6E   $ * 6[    6e   �� *Name+
  5_      $	 Sex��6%   $
 True��62   $ False��6D   $ * 6Z    6d   �� *Sex+
  5`      $ Birthday��6%   $
 True��67   $ False��6I   $ * 6_    6i   �� *
Birthday+
  5a      $ PhoneNumber��6%   $
 True��6:   $ False��6L   $ * 6b    6l   �� *PhoneNumber+
  5b      $ Email��6%   $
 True��64   $ False��6F   $ * 6\    6f   �� *Email+
  5c      $ IDCard��6%   $
 True��65   $ False��6G   $ * 6]    6g   �� *IDCard+
  5d      $ Address��6%   $
 True��66   $ False��6H   $ * 6^    6h   �� *	Address+4  .System.Windows.Controls.DataGridTemplateColumn  5f      $ 	Operation��6)   $
 True��6<   $
 auto 6N      CellTemplate 5g      �� 5h      .R�5i      ��  �� Orientation$ 
Horizontal=�6)   .+�5j   "   ��   
EditButton#��[ 6)   ��5k   )   �� *#!DataContext.DeleteCustomerCommand+ �� RelativeSource ��  �� AncestorType DataGrid��6�   �� .��5l   &   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ DeleteOutline=�6A     
ButtonIcon#��[ 6V   5m   #   5n      5o      5q      5s      5t      5u      