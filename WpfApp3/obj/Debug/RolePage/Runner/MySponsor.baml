   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp3.RolePage.RunnerWpfApp3.RolePage.Runner  5      '    !WpfApp3.RolePage.Runner.MySponsor   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WpfApp3.RolePage.Runner     5        N� Title$  	MySponsor��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   .+�5   
   �� $��0��6      DarkGrey#��[  6!   �� 5   
   $��2��6   
�������6!   �� 5   
   $-��'Подробная информация��6    �� TextAlignment$ Center=�60   $��1��6G   $��Center=�6T   $��18(�6o   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      .+�5      �� $��MARATHON SKILLS 2022��6   $��1��65   
�������$
 Left=�6X   $
��Bold"�6m   $��36(�6   $��0,15,0,0q�6�   �� 5      -   5        $��
Назад��5   (   $��0��68     Grey#��[ 6H   $��30��6l   $	��Top=�6x   $��5,19,5,0q�6�   5      � 5    
   $��2��6    5!      �� 5"      $��50 �6    �� 5#      �� 5$      $��5 �6    �� 5%       5'      �� 5(      �� 5)      $	��150 �6#   �� 5*      .+�5-      �� -   5         ��Name$ textBlockChartityName��50      $X��RНаименование благотворительной организации��5-      $��0��5.      $��0��6%   #��[  65   $ Center=�5/      $��Center=�6/   $��18(�6J   $
��Wrap=�6X   50      �� 51      $��
Взнос��6   $��0��6%   $��2��62   #��[  6B   $ Right=�6i   $��Center=�6   $��18(�6�   $
��Wrap=�6�   $��0,0,50,0q�6�   �� 52      $��Спонсор��6   $��0��6'   $��2��64   #��[  6D   $
 Left=�6k   $��Center=�6�   $��18(�6�   $
��Wrap=�6�   � 54      $��2��6   $��2��6    #��[ 60   �� 56      -   5         ��Name$ imageSource��56   !   $��1��6   $��20,0,0,0q�66   �� 57      $��3��6   .��58      �� -   5        $" textBlockChartityDescription��5:      $����Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание Длинное описание��58      $
��Wrap=�59      $��20,0,0,0q�5;      5<      �� 5>      -   5        $ textBlockCount��5A      $��Всего:��5>      $��3��6&   $��2��63   $��0,0,50,0q�5?      #��[  6*   $	��Top=�5@      $��18(�60   $��Right=�6>   5A      �� 5C      $��1��6   $��2��6(   .��5D      ��  �� Orientation$ Vertical=�6   .+�5E      &   System.Windows.Controls.DataGrid  -   5        $��listBoxSponsor��5E         HeadersVisibility$
 None=�65   {�.     AutoGenerateColumns .  	   Columns	 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 2* 61      
Foreground# [  6\      FontSize$ 18Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *SponsorName+6�     5H      $

 0.8* 61   # [  6Z   $ 18Q�6�    6?   �� *Amount+6�   5J      5K      5L      5O      5R      5S      