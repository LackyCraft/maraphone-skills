   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.Page2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5        N� Title$-  'Спонсировать бегунов��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   .+�5   
   �� $��0��6      DarkGrey#��[  6!   �� 5   
   $��2��6   
�������6!   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      .+�5      �� $��MARATHON SKILLS 2022��6   $��1��65   
������� �� TextAlignment$
 Left=�6X   $
��Bold"�6m   $��36(�6   $��0,15,0,0q�6�   �� 5      -   5        $��
Назад��5   (   $��0��68     Grey#��[ 6H   $��30��6l   $	��Top=�6x   $��5,19,5,0q�6�   5      � 5   
   $��1��6    5      �� 5       $��* �6    �� 5!      $��77 �6    �� 5"      $��4* �6    .+�5%      �� $��0��6   #��[  6&   $ Center=�6M   $��Center=�6d   $��0,15,0,0q�6   $��23(�6�   Спонсор бегуна6�   �� 5&      $��1��6   #��[  6&   $ Center=�6M   $��
50,15,50,0q�6d   $��18(�6x   ��Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму,�� 5'      6   ��которую вы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их�� 5(      6   97благотворительных учреждений6B   � 5+      $��2��6    5,      �� 5-      $
��0.1* �6$   �� 5.      $��* �6$    50      �� 51      �� 52      .+�55      �� $.��(Информация о Спонсоре��6   #��[ 69   $��0��6\   $
��Bold"�6i   $��18(�6{   $ Center=�6�   �� 56      $1��+Благотворительный фонд��6   #��[ 6:   $��0��6]   $��1��6j   $
��Bold"�6z   $��18(�6�   $ Center=�6�   � 58      $��1��6   $��1��6$   $��0,5,0,0q�64    59      �� 5:      $	��23* �6(   �� 5;      $	��24* �6(   �� 5<      $	��94* �6(   �� 5=      $	��29* �6(   �� 5>      $	��41* �6(   .+�5@      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5A      �� -   5         ��Name$
 fond��5A   �   #��[  6%   $1��+Благотворительный фонд��6L   $��Center=�6j   $��18(�6�   6�   �� 5B      -   5         ��Name$ 
InfoCharty��5B   !   $��5,0,0,0q�66   $��18��6G   $��Center=�6T   $��20��6o   .��5C      �� $)��#Image\icon\map-icon-information.png��6$   5D      5E      �� 5G      $+��%Сумма пожертвования��6    #��[ 6;   $��1��6^   $
��Bold"�6k   $��18(�6}   $ Center=�6�   �� 5I      -   5        $ payTextBlock��5I   *   $��$0��6    #��[ 6@   $��2��6c   $��90(�6p   $ Center=�6~   � 5K      $��3��6    5L      �� 5M      �� 5N      �� 5O      .+�5Q      �� -   5        $��-��5Q   !     	LightGrey#��[ 6-   $��Right=�6U   $��29��6q   $	��Top=�6}   $��83��6�   6�   �� 5R      -   5         ��Name$ payBox��5R   K   $��0��6"    �� TextAlignment$ Center=�6[   $��1��6r   
�������$��Center=�6�   $��29��6�   $	��Top=�6�   $��83��6�   �� 5S      -   5        $��2��5S   4   $��+��6D   #��[ 6P   $
��Left=�6x   $��29��6�   $	��Top=�6�   $��83��6�   5T      � 5V      $��4��6    5W      �� 5X      $	��91* �6/   �� 5Y      $	��11* �6/   �� 5Z      $��7* �6/   �� 5[      $	��91* �6/   .+�5]      �� -   5        $��Заполнить��5]   !   #��[ 65   $��Right=�6]   $��29��6y   $	��Top=�6�   $	��132��6�   $��0,5,0,0q�6�   6�   �� 5^      -	   5        $��3��5^   !   $��отмена��61   #��[ 6B   $
��Left=�6j   $��29��6�   $	��Top=�6�   $	��134��6�   $��0,5,0,0q�6�   6�   5_      5`      � 5b      $��1��6   $��0��6$   $��0,5,0,0q�64    5c      �� 5d      $
��0.6* �6+   �� 5e      $��* �6+   .+�5g      �� $��0��6!   .+�5h      �� #��[  6$   $��Ваше имя:��6K   $ Right=�6\   $��0,6,0,0q�6r   $��18(�6�   �� 5i      -
   5        $ 
textRunner��5i   $   #��[  69   $��Бегун:��6`   $ Right=�6n   $��0,6,0,0q�6�   $��18(�6�   �� 5j      #��[  6$   $��Карта:��6K   $ Right=�6Y   $��0,6,0,0q�6o   $��18(�6�   �� 5k      #��[  6$   $��Номер карты#:��6K   $ Right=�6`   $��0,6,0,0q�6v   $��18(�6�   �� 5l      #��[  6$   $ ��Срок действия:��6K   $ Right=�6a   $��0,6,0,0q�6w   $��18(�6�   �� 5m      #��[  6$   $
��CVC:��6K   $ Right=�6W   $��0,6,0,0q�6m   $��18(�6~   5n      �� 5p      $��1��6!   .+�5q      �� -   5        $ textName��5q   "   $��5,5,0,0q�64   �� 5r      -   5        	 ��Name$	 runner��5r   #   $��5,5,0,0q�64   
 �� SelectedValuePath$
 RegistrationId.��6E   ��5s      �� 5t   "   .R�5u   &   �� ��5v   *   `� 5w   .    �� StringFormat$ {0} - {1} - {2} ( {3} )��6;   .1�5x   2   ��  �� Path$ Runner.User.FirstName�6:   �� 5y   2   $ Runner.User.LastName�6:   �� 5z   2   $  Runner.Country.CountryName�6:   �� 5{   2   $ Runner.CountryCode�6:   5|   /   5~   '   5   #   5�      �� 5�      -   5        $ textCard��5�   "   $��5,5,0,0q�64   �� 5�      -   5        $ textCardNumber��5�   "   $��5,5,0,0q�6:   �� 5�      -   5        $ 
textPeriod��5�   "   $��5,5,0,0q�67   �� 5�      -   5        $ textCodeCVC��5�   "   $��5,5,0,0q�67   �� 5�      -   5        $ ErrorMessage��5�   $   
���  ��$�� ��6L   $ Center=�6T   $��0,6,0,0q�6k   $��10(�6|   5�      5�      5�      5�      5�      5�      