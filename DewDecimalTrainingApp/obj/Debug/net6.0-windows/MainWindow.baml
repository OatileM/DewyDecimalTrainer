   M S B A M L   `   `   `  ����P  LDewDecimalTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DewDecimalTrainingAppDewDecimalTrainingApp  5   	   &     DewDecimalTrainingApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DewDecimalTrainingApp     5   	     � Title$  Dewey Decimal Trainer��5   	   $	��450��6'   $	��800��64   .��5	      � 
������� � ColumnDefinitions 5   
   �� 5      $	��32* �6   �� 5      $
��177* �6   �� 5      $
��591* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� ���	#FF00295F$��5q�6)   $��0��6=   $��2��6M   $��0��6a   $��3��6n    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��1��6   $��0��6!   $��Welcome��6/   $��35(�6A   $
��Bold"�6O   $��	10,10,0,0q�6a   $
��Left=�6t   $	��Top=�6�   $��57��6�   $	��162��6�   �� 5   
   $��1��6   $��0��6!   $��To��6/   $��35(�6<   $
��Bold"�6J   $��	10,51,0,0q�6\   $	��Top=�6o   $
��Left=�6�   $��57��6�   $��49��6�   �� 5   
   $��1��6   $��0��6!   $	��The��6/   $��35(�6=   $
��Bold"�6K   $��	10,94,0,0q�6]   $	��Top=�6p   $
��Left=�6�   $��2��6�   $��57��6�   $��71��6�   �� 5   
   $��1��6   $��Dewey��6"   $��35(�62   $
��Bold"�6@   $	��Top=�6R   $
��Left=�6j   $��
13,137,0,0q�6�   $��2��6�   ���	#FF00295F$��57��6�   $	��120��6�    5         5!      5#      �� 5$   
   $��1��6   $��1��6!   $��Decimal��6/   $��35(�6A   $
��Bold"�6O   $��Center=�6a   $��Center=�6|    J� RenderTransformOrigin$ 0.507,-0.075&�6�   ���	#FF00295F$��56��6�   $	��143��6�    5%        5&      5(      �� 5)   
   $��1��6   $��1��6!   $��Trainer��6/   $��35(�6A   $
��Bold"�6O   $��Bottom=�6a   $
��Left=�6|   $ 0.507,-0.075&�6�   $��13,0,0,0q�6�   ���	#FF00295F$��56��6�   $	��125��6�    5*        5+      5-      �� 5.   
   -   5         ��Name$ 
imgLibrary��5.      $��1��6%   $��1��65   $��
0,144,10,0q�6B   $��2��6V   ��5/      �� 50       �� 	UriSource$n hD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\library.png?�6   52      �� 54   
   -   5         ��Name$ lblChooseTask��54      $ ��WHAT WOULD YOU LIKE TO DO?��6'   $��2��6L   $��0��6\   $��Bahnschrift)�6i   $
��Bold"�6�   $��30(�6�   $��Center=�6�   $��Center=�6�   ���	#FF00295F$��46��6�   $	��431��6�    55        56      58      �� 59   
   -   5        $ lblReplaceBook��59      $��1. Replace Book��6(   $��30(�6B   $��2��6P   $��138,137,0,100q�6`   ���	#FF00295F$
��Bold"�6�   $��Ebrima)�6�   $��2��6�   $
��Left=�6�   $	��235��6�    5:        5;      5=      �� 5>   
   -   5        $ imgReplaceBook��5>      $��2��6)   $��373,4,175,96q�69   $ 0.511,0.589&�6O   $��1��6s   z�5?      V� 5@      .~�5A      ��  �� ScaleY$ -1Q�6%   �� 5B      �� 5C      T� 5D      	 T� Y$	 -10.979Q�6)   5E      ��5G      �� 5H      $r lD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\replacebook.png?�6   5J      �� 5L   
   -   5        $ lblIdentifyAreas��5L      $��2. Identify Areas��6*   $��30(�6F   $��2��6T   $��138,64,0,28q�6d   ���	#FF00295F$
��Bold"�6�   $��Ebrima)�6�   $
��Left=�6�   $	��287��6�   $��1��6�    5M        5N      5P      �� 5Q   
   -   5        $ imgIdentifyAreas��5Q      $��2��6+   $��421,83,124,20q�6;   $��1��6R   z�5R      V� 5S      .~�5T      �� $ -1Q�6%   �� 5U      �� 5V      
 �� Angle$
 -179.447Q�6&   T� 5W      $	 -10.979Q�6)   5X      ��5Z      �� 5[      $q kD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\binoculors.png?�6   5]      �� 5a   
   -   5        $ lblFindCallNumbers��5a      $��3. Find Call Numbers��6,   $��30(�6K   $��2��6Y   $��1��6i   $��138,121,0,120q�6v   ���	#FF00295F$
��Bold"�6�   $��Ebrima)�6�   $
��Left=�6�   $	��305��6�   $��2��6�    5b        5c      5e      �� 5f   
   -   5        $ imgFindCallNumbers��5f      $��2��6-   $��477,1,78,116q�6=   $��2��6S   z�5g      V� 5h      .~�5i      �� $ -1Q�6%   �� 5j      �� 5k      $
 -179.447Q�6&   T� 5l      $	 -10.979Q�6)   5m      ��5o      �� 5p      $t nD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\identifyareas.png?�6   5r      �� 5t   
   -	   5        $ imgOpenBook��5t      $��2��6&   $��2��67   $
��Left=�6E   $	��Top=�6`   $��
161,30,0,0q�6x   $	��277��6�   $	��115��6�   ��5u      �� 5v      $o iD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\openbook.png?�6   5x      5{      5~      