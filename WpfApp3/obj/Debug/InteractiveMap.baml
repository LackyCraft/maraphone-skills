   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.InteractiveMap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  InteractiveMap��5      $	��800��5	      $	��450��6   $	��800��5
      $	��450��6   $	��450��5   	   $	��800��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��420 �6   �� 5      $��* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $
��0.2* �6    �� 5      $��* �6    �� 5      $��20 �6    �� 5      $
��1.5* �6    .+�5      �� -   5         ��Name$ labelInfoMaraphon��5      $��LABEL��63   $��0��6@   $��Center=�6M   $
��Bold"�6h    �� TextAlignment$ Center=�6z   $��24(�6�   �� 5      -   5        $ textInfoPoint��5      $��TextInfo��6/   $��1��6?   $
��Wrap=�6L   $��30,0,0,0q�6`   �� 5      $(��"Доступные сервисы:��6   $
��Bold"�62   $��18(�6D   $��2��6R   �� 5      $��3��6   .��5       �� -   5         ��Name$ 
stackPanel��5       5!      5"      5%      � 5'   
   
�������$	��420��6"   $	��431��6/   $
��Left=�6;   $��0��6V   .+�5(      �� $6��0/Image/Map/marathon-skills-2016-marathon-map.jpg��6   �� 5*      -   5         ��Name$ fullMaraphon��5*   +   ���	#FDFFFFCB$��	232,7,0,0q�6X   $
��Left=�6k   $��34��6�   $	��Top=�6�   $��34��6�   .��5+      �� $$��/Image/icon/map-icon-start.png��6   5,      �� 5.      -   5        $ funRunMaraphon��5.   +   ���	#FDFFFFCB$��162,376,0,0q�6Z   $
��Left=�6o   $��34��6�   $	��Top=�6�   $��34��6�   .��5/      �� $#��Image/icon/map-icon-start.png��6   50      �� 52      -   5        $ halfRunMaraphon��52   +   ���	#FDFFFFCB$��
78,141,0,0q�6[   $
��Left=�6o   $��34��6�   $	��Top=�6�   $��34��6�   .��53      �� $#��Image/icon/map-icon-start.png��6   54      �� 56      -   5        $ point1��56   '   $��1��67   ���	#FDFFFFCB$��	379,7,0,0q�6Z   $
��Left=�6m   $��34��6�   $	��Top=�6�   $��34��6�   �� 57      -   5        $ point2��57   '   $��2��67   ���	#FDFFFFCB$��370,296,0,0q�6Z   $
��Left=�6o   $��33��6�   $	��Top=�6�   $��33��6�    J� RenderTransformOrigin$ 4.964,3.286&�6�   �� 58      -	   5        $ point3��58   '   $��3��67   ���	#FDFFFFCB$��218,182,0,0q�6Z   $
��Left=�6o   $��34��6�   $	��Top=�6�   $��34��6�   �� 59      -
   5        $ point4��59   '   $��4��67   ���	#FDFFFFCB$��218,304,0,0q�6Z   $
��Left=�6o   $��34��6�   $	��Top=�6�   $��34��6�   �� 5;      -   5        $ point5��5;   '   $��5��67   ���	#FDFFFFCB$��126,281,0,0q�6Z   $
��Left=�6o   $��36��6�   $	��Top=�6�   $��36��6�   �� 5<      -   5        $ point6��5<   '   $��6��67   ���	#FDFFFFCB$��
28,282,0,0q�6Z   $
��Left=�6n   $��34��6�   $	��Top=�6�   $��34��6�   �� 5=      -   5        $ point7��5=   '   $��7��67   ���	#FDFFFFCB$��
127,90,0,0q�6Z   $
��Left=�6n   $��35��6�   $	��Top=�6�   $��35��6�   �� 5>      -   5        $ point8��5>   '   $��8��67   ���	#FDFFFFCB$��45,7,0,0q�6Z   $
��Left=�6l   $��34��6�   $	��Top=�6�   $��34��6�   5?      5A      5B      