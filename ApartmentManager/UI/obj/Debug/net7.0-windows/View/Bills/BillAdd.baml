   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AM.UI.State.RulesAM.UI.State.Rules  5   K       AM.UI.View.Bills.BillAdd   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1rulesclr-namespace:AM.UI.State.Rules     6K   .��5      � .+�5	   
   ��    DetailsButton#��[  60   $��Add Confirm��6W   $
��Left=�6m   $��178,386,0,0q�6�   $	��Top=�6�   ��6   �� *
AddConFirm+6�   �� 5
   
   #��[  6   $��Cancel��68   $
��Left=�6I   $��409,386,0,0q�6d   $	��Top=�6y   �� 5   
   $
��Left=�6   $��
35,221,0,0q�6/   $
��Wrap=�6C   $��ElectricQuantity��6W   $	��Top=�6o   ���	#FFEEEEEE$��25(�6�   �� 5   
   -   5        $
��Elec��5   �   $
��Left=�6     errorTemplate  =� ErrorTemplate#  [ 6-   $��216,223,0,0q�6g   ���	#FFEEEEEE �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��25��6�   .��6  ��5      �� 5       �� Path$ ElectricQuantity�6    �� ValidatesOnDataErrors$
 True��62    �� UpdateSourceTrigger$ PropertyChanged=�6O    �� ValidationRules 5      #  AM.UI.State.Rules.WrongNumber  5         
NameofRule$ Electric Quantity ��6-   5      .��5      5      �� 5   
   $
��Left=�6   $��216,253,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��3��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5      5      .��5   '   5      �� 5   
   $
��Left=�6   $��391,218,0,0q�6/   $
��Wrap=�6D   $��PayDate��6X   $	��Top=�6g   ���	#FFEEEEEE$��25(�6�   (  "System.Windows.Controls.DatePicker  5    
   $
��Left=�6   $��544,219,0,0q�60   ���	#FFEEEEEE$	��Top=�6}   $	��150��6�   $��24��6�   	   SelectedDate	 6E   �� *	PayDate+6�   �� 5!   
   $
��Left=�6   $��544,249,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��2��6�   $ 0.5,0.5&�6�   .��6�   z�5"      V� 5#      .~�5$      �� $ -1Q�6%   �� 5%      �� 5&      T� 5'      5(      .��5)   '   5*      �� 5+   
   $
��Left=�6   $��
37,156,0,0q�6/   $
��Wrap=�6C   $��	ID Rental��6W   $	��Top=�6h   ���	#FFEEEEEE$��25(�6�   �� 5,   
   $
��Left=�6   $��216,190,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��3��6�   $ 0.5,0.5&�6�   .��6�   z�5-      V� 5.      .~�5/      �� $ -1Q�6%   �� 50      �� 51      T� 52      53      .��54   '   55      �� 56   
   
 �� DisplayMemberPath$
 IDRental��6�   $
��Left=�6�   $��216,160,0,0q�6�   $	��Top=�6�   $	��150��6�   ��6   �� *comboboxforRental+ �� SelectedItem 6=   �� *SelectRental+$ PropertyChanged=�6�   �� 57   
   $
��Left=�6   $��392,156,0,0q�6/   $
��Wrap=�6D   $��Active��6X   $	��Top=�6f   ���	#FFEEEEEE$��25(�6�   �� 58   
   $
��Left=�6�   $��544,156,0,0q�6�   $	��Top=�6�   $	��150��6�   ��6   �� *comboboxActive+ 6:   �� *Active+$ PropertyChanged=�6�   �� 59   
   $
��Left=�6   $��544,188,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��2��6�   $ 0.5,0.5&�6�   .��6�   z�5:      V� 5;      .~�5<      �� $ -1Q�6%   �� 5=      �� 5>      T� 5?      5@      .��5A   '   5B      5C      5D      