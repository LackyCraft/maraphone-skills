   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.ResultRunner   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5        N� Title$  ResultRunner��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   .+�5   
   �� $��0��6      DarkGrey#��[  6!   �� 5   
   $��2��6   
�������6!   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      .+�5      �� $��MARATHON SKILLS 2022��6   $��1��65   
������� �� TextAlignment$
 Left=�6X   $
��Bold"�6m   $��36(�6   $��0,15,0,0q�6�   �� 5      -   5        $��
Назад��5   (   $��0��68     Grey#��[ 6H   $��30��6l   $	��Top=�6x   $��5,19,5,0q�6�   5      � 5   
   $��1��6    5      �� 5      $
��0.3* �6    �� 5      $��* �6    �� 5      $
��0.3* �6    �� 5       $
��3.5* �6    .+�5#      � $��1��6   .+�5$      �� $
��Wrap=�6   $����Это - список всех ваших прошлых результатов гонки для Maraphon Skills. Общее место сранвивает всех бегунов . Место по категориии compares runners in the same gender and age categories��60   $ Center=�5%   O   $��Center=�6f   $��Center=�6�   $��	40,0,40,0q�6�   5'      �� 5(      $��3��6   .��5)      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridOldResults��5)   �   ��. $
��Auto=�6A   $
��Auto=�6q   
�������$��3��6�      AutoGenerateColumns .  {�.  $��Center=�6  $��Center=�6,  
�������   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ Марафон��68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6I   �� 
 �� Path$
 MarathonName�  5,      $ * 6-   $ Дистанция��68   	 6K   �� $
 EventTypeName�  5-      $
 0.4* 6-   $ Время (мин)��6;   	 6P   �� $
 RaceTime�  5.      $
 0.4* 6-   $ Общее место��6;   	 6P   �� $
 place�50      51      �� 52      $M��GИнформация марофонах предыдущих гонок��6   $��0��6F   $��0��6S   $��3��6c   $��18��6w   $
��Bold"�6�   $��14(�6�   $ Center=�6�   53      54      57      