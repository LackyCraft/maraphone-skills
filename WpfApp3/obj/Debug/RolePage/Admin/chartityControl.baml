   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfApp3.RolePage.AdminWpfApp3.RolePage.Admin  5      "    WpfApp3.RolePage.Admin.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfApp3.RolePage.Admin     5        N� Title$  Page1��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� $��0��6      DarkGrey#��[  6!   �� 5   
   $��2��6   
�������6!   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      .+�5      �� $��MARATHON SKILLS 2022��6   $��1��65   
������� �� TextAlignment$
 Left=�6X   $
��Bold"�6m   $��36(�6   $��0,15,0,0q�6�   �� 5      -   5        $��
Назад��5   (   $��0��68     Grey#��[ 6H   $��30��6l   $	��Top=�6x   $��5,19,5,0q�6�   5      �� 5   
   $Z��TУправление благотворительными организациями��6   $��1��6G   $��20(�6T   $
��Bold"�6b   $ Center=�6t   $��Center=�6�   �� 5    
   -   5        $%��+ Добавить нового��5       $	��130��5!      $��30��6   $��2��5"      $
��Left=�5$      $��20,0,0,0q�6,   � 5&   
   -   5         �Name$ Column1��5&      $��3��6   .+�5'      �� .��5(      ��  �� Orientation$ Vertical=�6   .+�5)      &   System.Windows.Controls.DataGrid  -   5          Name$ Chartity��5)         AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5*      4  .System.Windows.Controls.DataGridTemplateColumn  5+      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 0.5* 65      Header$
 Logo��6B      CellTemplate 5,   "   �� 5-   &   .R�5.   *   �� ��60   �� *CharityLogo+5/   '   51      0  *System.Windows.Controls.DataGridTextColumn  53      $

 0.4* 61      
IsReadOnly . $ Наименование��6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   ��  �� Path$ CharityName�  54      $
 * 61    . $ Описание��6N    6`   �� $ CharityDescription�  55      $	
 100 65   $
 Edit��6A    56   "   �� 57   &   .R�58   *   �� -   5        $
��Edit��58   1   $��30��6Z   $	��100��6f   
 J� Uid 6@   �� *	CharityId+6r   59   '   5;      5=      5>      5?      5@      5A      5B      