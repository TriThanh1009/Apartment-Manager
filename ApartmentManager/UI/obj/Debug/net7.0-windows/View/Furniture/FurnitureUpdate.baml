   M S B A M L   `   `   `  ����@  <AM.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AM.UI.View.FurnitureAM.UI.View.Furniture  5      5clr-namespace:AM.UI.State.RulesAM.UI.State.Rules  6?   *    $AM.UI.View.Furniture.FurnitureUpdate   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AM.UI.View.Furniture     5      1rulesclr-namespace:AM.UI.State.Rules     6?   .��5	      � .+�5
   
   ��    DetailsButton#��[  63   $��Update Confirm��6Z   $
��Left=�6s   $��185,329,0,0q�6�   $	��Top=�6�   ��6   �� *UpdateConFirm+6�   �� 5   
   #��[  6   $��Cancel��68   $
��Left=�6I   $��416,329,0,0q�6d   $	��Top=�6y   �� 5   
   $
��Left=�6   $��
58,145,0,0q�6/   $
��Wrap=�6C   $��ID��6W   $	��Top=�6a   ���	#FFEEEEEE$��25(�6�   �� 5   
   $
��Left=�6   $��185,145,0,0q�6-     �� TextWrapping$
  Wrap=�6B   $	��Top=�6t   $	��150��6�   $��25��6�   ��6V   �� *Furniture.ID+6�   �� 5   
   $
��Left=�6   $��185,175,0,0q�6-   $
  Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��3��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5      5      .��5   '   5      �� 5   
   $
��Left=�6   $��393,144,0,0q�6/   $
��Wrap=�6D   $
��Name��6X   $	��Top=�6d   ���	#FFEEEEEE$��25(�6�   �� 5   
   $
��Left=�6     errorTemplate =� ErrorTemplate# [ 6-   $��520,148,0,0q�6g   $
  Wrap=�6|   $	��Top=�6�   $	��150��6�   $��25��6�   .��6�   ��5      �� 5       �� Path$ Furniture.Name�6    �� ValidatesOnDataErrors$
 True��60    �� UpdateSourceTrigger$ PropertyChanged=�6M    �� ValidationRules 5      !   AM.UI.State.Rules.WrongName  5      5      .��5       5!      �� 5"   
   $
��Left=�6   $��520,178,0,0q�6-   $
  Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��150��6v   $��3��6�   $ 0.5,0.5&�6�   .��6�   z�5#      V� 5$      .~�5%      �� $ -1Q�6%   �� 5&      �� 5'      T� 5(      5)      .��5*   '   5+      5,      5-      