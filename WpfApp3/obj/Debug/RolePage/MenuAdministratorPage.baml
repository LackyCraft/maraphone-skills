   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp3.RolePageWpfApp3.RolePage  5           WpfApp3.RolePage.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfApp3.RolePage     5        N� Title$  	AdminPage��5	      .��5      � 
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
   -   5         �Name$ Column1��5      $��1��6   .+�5      � $��2��6    5      �� 5      �� 5      �� 5       �� 5!       5#      �� 5$      �� 5%      .+�5'      �� $+��%Меню администратора��6   $��0��67   $��0��6D   $��2��6T   $��Center=�6h   $��Center=�6�   $��18(�6�   �� 5(      -   5         ��Name$ remoteUsers��5(   k   $��Пользователи��6   $��20q�60   $��1��6<   $��0��6I   6k   �� 5)      -   5        $ chartity��5)   |   $?��9Благотворительные организации��6   $��20q�6A   $��2��6M   $��0��6Z   6|   �� 5*      -   5        $ remoteVolonters��5*   W   $��Волонтерпы��6   $��20q�6.   $��1��6:   $��1��6G   6p   �� 5+      -   5        $ ListCompany��5+   h   $��Инвентарь��6   $��20q�6-   $��2��69   $��2��6F   6h   5,      5-      5.      5/      