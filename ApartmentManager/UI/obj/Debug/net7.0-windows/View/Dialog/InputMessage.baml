   M S B A M L   `   `   `  ����	  AM.UI$    AM.UI.View.Dialog.InputMessage   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxWindow��5   	   $	��270��5   	   $	��500��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   
������� � 
ResizeMode$ 	CanResize=�5   	    � Topmost$
 True��5   	    � ShowInTaskbar$ False��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   #  MaterialDesignThemes.Wpf.Card  -   5        
  Name$
 
cardHeader��5       $��0��5!      $��10q�5"      $��0q�5#      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�5$        PrimaryHueDarkBrush#���  5%       ! PrimaryHueDarkForegroundBrush#���  5&      $y�Visible=�5'      $��2��5(      .��5)      �� .+�5*      �� -   5         ��Name$ txtTitle��5*      $��Center=�5+      $��Stretch=�5,         MaterialDesignTitleTextBlock#���  5-      $��20(�5.      Message Title69   5/      50      �� 51   
   $��Right=�6   $��0,5,5,0q�52      $	��Top=�53      $��1��54      .+�55      �� -   5         ��Name$ btnClose��55      $��35��57      $��35��58      
�������#���  5:       * &MaterialDesignFloatingActionDarkButton#��[ 5;      .��5<      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   5=      5>      � 5?   
   $��1��6   $��2��5@      .+�5A      � $��20q�6   	 5B      �� 5C      $
��auto �6$   �� 5D      $
��auto �6$   .+�5G      � $��0��6   	 5H      �� 5I      $
��auto �6(   �� 5J      $��* �6(   .+�5M      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5N      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5O         Kind$ FadeIn=�6>     5P      $ SlideInFromBottom=�6>   .��5R      �� -   5         ��Name$ 
txtMessage��5R       $��Center=�5S       $��Choose your Date:��5T       $��0��5U       $��5q�5V       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5W       $��18(�5X       $��Medium"�5Y       $
��auto��5Z       $
��auto��5[       5\      � 5]      $��1��6   $��0 10 0 0q�6(   .+�5^      (	  "System.Windows.Controls.DatePicker	  -   5         	 Name$	 day��5^   1   $	��200��6%   5_      5`      5a      � 5c      $��1��6   $��0,20,0,5q�5d       5e      �� 5f      $��* �6+   �� 5g      $
��auto �6+   �� 5h      $
��auto �6+   �� 5i      $��* �6+   .+�5l      �� -   5        $ 	btnCancel��5l      $��2��5n        MaterialDesignRaisedButton#��[ 5o      $��5q�5p      $	��100��5q      $��Cancel��5r       � ToolTip$ Cancel��5s      �� 5t      -   5        $ btnYes��5t      $��1��5v      #��[ 5w      $��5q�5x      $	��100��5y      $	��Yes��5z      $	 Yes��5{      5|      5}      5~      5      5�      