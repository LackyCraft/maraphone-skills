   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WpfApp3.RolePage.Coordinaor.runner"WpfApp3.RolePage.Coordinaor.runner  5      5    /WpfApp3.RolePage.Coordinaor.runner.RemoteRunner   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:WpfApp3.RolePage.Coordinaor.runner     5        N� Title$  RemoteRunner��5	      .��5      � 
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
Назад��5   (   $��0��68     Grey#��[ 6H   $��30��6l   $	��Top=�6x   $��5,19,5,0q�6�   5      � 5   
   $��1��6    5      �� 5      $��20 �6    �� 5      $��* �6    �� 5       $��20 �6    �� 5!      $��2* �6    .+�5#      � $��1��6    5$      �� 5%      �� 5&      �� 5'      .+�5)      � $��0��6    5*      �� 5+      �� 5,      .+�5.      �� $��0��6!   .+�5/      �� $��Right=�6$   $
��Wrap=�6@   $��Статус:��6T   $	��Top=�6c   $
��Bold"�6{   $��0,11,6,0q�6�   �� 50      $��Right=�6$   $
��Wrap=�6@   $��Дистанция:��6T   $	��Top=�6f   $
��Bold"�6~   $��0,18,6,0q�6�   �� 51      $��Right=�6$   $
��Wrap=�6@   $��Сортировать:��6T   $	��Top=�6h   $
��Bold"�6�   $��0,20,6,0q�6�   52      �� 53      $��1��6!   .+�54      �� -   5         ��Name$ comboBoxStatus��54   F   $	��Top=�6#   $��6q�6;    �� DisplayMemberPath$ RegistrationStatus1��6^    �� SelectedValuePath$ RegistrationStatusId��6�   �� 55      -   5        $ comboBoxEventType��55   F   $	��Top=�6#   $��6q�6;   $ EventTypeName��6a   $ EventTypeId��6�   �� 56      -   5        $ comboBoxFilterSort��56   F   $	��Top=�6#   $��6q�6;   6F   57      58      � 59      $��1��6    5:      �� 5;      �� 5<      .+�5>      �� $��0��6!   �� 5?      $��1��6!   5@      � 5A      $��1��6   .+�5B      �� -   5        $��Обновить��5B      $��Bottom=�60   $
��Left=�6K   $��6q�6f   $	��150��6�   $��28��6�   5C      �� 5E       �� Orientation$ Vertical=�6   $��2��64   $��Bottom=�6D   $��0,0,0,5q�6_   .+�5F      �� -   5        $)��#Детальная выгрузка��5F      $	��150��5G      $��28��6)   $
��Left=�5H      5I      �� 5J      -   5        $��Выгрузка Email��5J      $	��150��5K      $��28��6)   $
��Left=�5L      $��0,5,0,0q�5N      5O      5Q      �� 5S      -   5         ��Name$ textBlockCount��5S      $��2��5T      $ ��Всего бегунов:��6   $��Center=�64   $��Center=�6Q   �� 5V      $��3��6   .��5W      &   System.Windows.Controls.DataGrid  -	   5        	  Name$	 dataGridResults��5X      ��. $
��Auto=�5W   @   $
��Auto=�6p   
�������$��3��5X   4   
   AutoGenerateColumns
 .  {�. $��Center=�6o   $��Center=�6�   
�������   Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      
IsReadOnly .    Header$ Имя��6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   ��  �� Path$ LastName�  5\      $ 2* 6-    . $ Фамилия��6K    6\   �� $ 	FirstName�  5]      $ * 6-    . $ Email��6J    6Y   �� $ Email�  5^      $ * 6-    . $ Статус��6J    6Z   �� $ RegistrationStatus�4  .System.Windows.Controls.DataGridTemplateColumn  5_      $	 100 61   $" Редактирование��6=      CellTemplate 5`      �� 5a   "   .R�5b   &   �� -
   5        $
��Edit��5b   -   $��30��6`   $	��100��6l   
 J� Uid 6<   �� *RegistrationEventId+6x   5c   #   5e      5g      5h      �� 5i      $U��OУчастники зарегистрировившиеся на марафон��6   $��0��6J   $��0��6W   $��3��6g   $��18��6{   $
��Bold"�6�   $��14(�6�   $ Center=�6�   5j      5k      5l      