   M S B A M L   `   `   `  ����P  LDewDecimalTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DewDecimalTrainingAppDewDecimalTrainingApp  5   	   )    #DewDecimalTrainingApp.IdentifyAreas   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DewDecimalTrainingApp     5   	     � Title$  IdentifyAreas��5   	   $	��450��6   $	��800��6,   .��5	      � ��5
   
   �� 5       �� ImageSource$r lD:\Visual Studio\School Projects\PROG7312\DewDecimalTrainingApp\DewDecimalTrainingApp\Images\background.jpeg��6    j� Stretch$ UniformToFill=�6�    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��350 �6   �� 5      $	��350 �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��296 �6   �� 5      $	��104 �6   .+�5   
   �� ���	#FF00295F$��5q�6)   $��1��6=   $��2��6M   $��0��6b   $��	0,0,306,0q�6o    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5        $��tbScore��5   2   $��2��6   $��0��6%   $��
Score: 0/0��6A   $��Center=�6S   $
��0,10q�6p   $
��Bold"�6~   $��25(�6�   �� 5"   
   $��1��6   $��0��6    $��2��6-   $��Match The Columns��6C   $��25(�6_   $
��Bold"�6m   �� 5$   
   -   5         ��Name$ lstbCallNumber��5$      $��1��6*   $��1��6:   $��0,0,0,10q�6G   �� 5%   
   -   5        $ lstbCallDescriptions��5%      $��2��60   $��1��6@   $��0,0,0,10q�6M   �� 5'   
   -   5        $��	btnSubmit��5'   �   
����������	#FF00295F$��3q�6B   $��18(�6V   $
��Bold"�6d   $��1��6v   $��2��6�   $��Submit��6�   $
��Left=�6�   $��35��6�   $	��184��6�   $��2��6  $��258,34,0,34q�6  �� 5(   
   -   5        $��btnGenerate��5(   �   
����������	#FF00295F$��3q�6B   $��18(�6V   $
��Bold"�6d   $��1��6v   $��2��6�   $��New Call Numbers��6�   $
��Left=�6�   $��35��6�   $	��184��6�   6�   �� 5)   
   -   5        $��	btnFinish��5)   �   
����������	#FF00295F$��3q�6B   $��18(�6V   $
��Bold"�6d   $��2��6v   $��2��6�   $��Finish��6�   $
��Left=�6�   $��35��6�   $	��184��6�   $��2��6  $��191,34,0,34q�6  5,      5-      