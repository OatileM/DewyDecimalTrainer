   M S B A M L   `   `   `  ����P  LDewDecimalTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DewDecimalTrainingAppDewDecimalTrainingApp  5   	   '    !DewDecimalTrainingApp.ReplaceBook   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DewDecimalTrainingApp     5   	     � Title$  ReplaceBook��5   	   $	��450��6   $	��800��6*   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��59* �6   �� 5      $
��141* �6    � RowDefinitions 5   
   �� 5      $	��73* �6   �� 5      $
��161* �6   .+�5   
   �� ���	#FF00295F$��5q�6)   $��0��6=   $��1��6M   $��0��6a   $��2��6n    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��Dewey��6   $��25(�6!   $
��Bold"�6/   $
��Left=�6A   ���	#FF00295F$��88��6s   $��0��6~   $��	11,10,0,6q�6�    5        5      5      �� 5   
   $��Decimal��6   $��25(�6#   $
��Bold"�61   $	��Top=�6C   $
��Left=�6[    J� RenderTransformOrigin$ 0.507,-0.075&�6v   ���	#FF00295F$��45��6�   $	��108��6�   $��	11,67,0,0q�6�   $��2��6�   $��2��6�    5        5       5"      �� 5#   
   $��Trainer��6   $��25(�6#   $
��Bold"�61   $	��Top=�6C   $
��Left=�6[   $ 0.507,-0.075&�6v   ���	#FF00295F$��39��6�   $��98��6�   $��
11,135,0,0q�6�   $��2��6�    5$        5%      5'      �� 5(   
   -   5         ��Name$ 
imgLibrary��5(      $��0��6%   $��1��65   $��	0,96,8,10q�6B   ��5)      �� 5*       �� 	UriSource$n hD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\library.png?�6   5,      �� 5.   
   ���	#FF00295F$��2q�6)   $��1��6=   $��72,28,73,10q�6M    5/        50      52      �� 55   
   $��1��6   $��Center=�6%   $	��Top=�6B   $	��427��6Z   $��2��6g   $	��544��6x   .+�56      �� -   5         ��Name$ 	txtbTimer��56      $!��Time Remaining: 120 seconds��6+   $��Center=�6N   $��16(�6k   $
��Bold"�6y   $
��0,10q�6�   �� 57      -   5        $ txtbRandomNumbers��57      $
��Wrap=�63   
�������$��Oblique$�6_   $��15(�6t   $
��Bold"�6�   $	��404��6�   $��75��6�   �� 58      -   5         ��Name$ btnGenerate��58      $��Generate Numbers��6*   
����������	#FF00295F$��3q�6u   $��18(�6�   $
��Bold"�6�   $
��0,10q�6�   $��57��6�   $	��180��6�   �� 5:      -   5        	 ��Name$	 lstCallNumbers��5:      $	��300��6.   $	��146��6:   $
��0,10q�6G   
����������	#FF00295F$��2q�6�   
 �� SelectionMode$
 Extended=�5;      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6&    J� 	AllowDrop$
 True��5>      5@      �� 5E       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5F      �� -   5        $ btnCheckOrder��5F      $��Check Order��60   
����������	#FF00295F$��3q�6v   $��18(�6�   $
��Bold"�6�   $��10q�6�   $��35��6�   $	��184��6�   5G      5H      5I      5J      