   M S B A M L   `   `   `  ����P  LDewDecimalTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DewDecimalTrainingAppDewDecimalTrainingApp  5   	   *    $DewDecimalTrainingApp.FindCallNumber   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DewDecimalTrainingApp     5   	     � Title$  FindCallNumber��5   	   $	��450��6    $	��800��6-   .��5	      � 
�������.+�5
   
   �  � ColumnDefinitions 5      �� 5      $	��59* �6#   �� 5      $
��141* �6#    � RowDefinitions 5      �� 5      $	��150 �6    �� 5      $	��300 �6    .+�5      �� ���	#FF00295F$��5q�6-   $��0��6A   $��1��6Q   $��0��6e   $��2��6r    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      $��Dewey��6   $��25(�6%   $
��Bold"�63   $
��Left=�6E   ���	#FF00295F$��88��6w   $��0��6�   $��	11,10,0,6q�6�    5        5      5      �� 5       $��Decimal��6   $��25(�6'   $
��Bold"�65   $	��Top=�6G   $
��Left=�6_    J� RenderTransformOrigin$ 0.507,-0.075&�6z   ���	#FF00295F$��45��6�   $	��108��6�   $��	11,67,0,0q�6�   $��2��6�   $��2��6�    5!        5"      5$      �� 5%      $��Trainer��6   $��25(�6'   $
��Bold"�65   $	��Top=�6G   $
��Left=�6_   $ 0.507,-0.075&�6z   ���	#FF00295F$��39��6�   $��98��6�   $��
11,135,0,0q�6�   $��2��6�    5&        5'      5)      �� 5*      -   5         ��Name$ 
imgLibrary��5*      $��0��6)   $��1��69   $��	0,96,8,10q�6F   ��5+      �� 5,       �� 	UriSource$n hD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\library.png?�6"   5.      �� 52      ���	#FF00295F$��2q�6-   $��1��6A   $��226,48,10,44q�6Q    53        54      ._�56      �� -   5         ��Name$  txtbRandomCallDescriptions��56      $
��Wrap=�6@   
�������$��Oblique$�6l   $��15(�6�   $
��Bold"�6�   $��
10,10,8,10q�6�   57      �� 5;      $��1��6   $��1��6)    �� Orientation$ Vertical=�66   $��10,58,10,58q�6M   .+�5<      �� -   5        	 ��Name$	 
btnOption1��5<      $��Option 1��6-   $	��0,5q�6@   
����������	#FF00295F$��3q�6}   $��18(�6�   $
��Bold"�6�   6�   �� 5=      -   5        $	 
btnOption2��5=      $��Option 2��6-   $	��0,5q�6@   
����������	#FF00295F$��3q�6}   $��18(�6�   $
��Bold"�6�   6�   �� 5>      -   5        $	 
btnOption3��5>      $��Option 3��6-   $	��0,5q�6@   
����������	#FF00295F$��3q�6}   $��18(�6�   $
��Bold"�6�   6�   �� 5?      -   5        $	 
btnOption4��5?      $��Option 4��6-   $	��0,5q�6@   
����������	#FF00295F$��3q�6}   $��18(�6�   $
��Bold"�6�   6�   5@      �� 5B      -   5        $��tbScore��5B   )   $��1��6   $��
Score: 0/0��68   $��Center=�6J   $	��Top=�6g   $��	0,10,0,74q�6   $
��Bold"�6�   $��25(�6�   $	��144��6�   �� 5C      -   5        $	 btnGenerate��5C      $��Generate Description��6*   
����������	#FF00295F$��3q�6y   $��18(�6�   $
��Bold"�6�   $��10,48,359,38q�6�   $��1��6�   5E      5F      5G      