   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShoppingShopping  5   	       Shopping.shoppinginbus   5   	   T PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f5my,http://metro.mahapps.com/winfx/xaml/controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Shopping     5   	     � Title$  Window1��5	      $
��1050��6   $
��1680��6+    � WindowState$ 	Maximized=�68    � 	Resources 5
         u �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��$ Bradley Hand ITC)�6+   6F   �� 5       � ��$ 18(�6)   66   �� 5       � ��$
 Bold"�6+   6:   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��55* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   .+�5"   
   � $��2��6    5#      �� 5$      $��2* �6    �� 5%      $��* �6    �� 5&      $��2* �6    �� 5'      $��* �6     5)      �� 5*      $
��126* �6#   �� 5+      $
��593* �6#   �� 5,      $
��117* �6#   .+�5/      0  *MahApps.Metro.Controls.MetroContentControl  $��2��6%   .��50      �� $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�51      �� $��25��62   ��6   Z� ��52      �� 53      	 �� EndPoint$	 0.5,1&�62   
 � MappingMode$
 RelativeToBoundingBox=�6C    �� 
StartPoint$ 0.5,0&�6g    �� RelativeTransform 54   "   V� 55   &   .~�56   *   ��  �� CenterY$	 0.5Q�69    �� CenterX$	 0.5Q�6G   �� 57   *    �� CenterY$	 0.5Q�68    �� CenterX$	 0.5Q�6F   �� 58   *    �� Angle$	 -90Q�6:    �� CenterY$	 0.5Q�6F    �� CenterX$	 0.5Q�6T   T� 59   *   5:   '   .��5<   "   �  � Color$ Black��6/    � Offset$ 1Q�6=   � 5=   "   $ White��6/   5>      5@      �� 5A      -   5        $��goback ��5A      
���   �
�������$��Bradley Hand ITC)�6l   $��18(�6�   $
��Bold"�6�   
���   �6�   5B      5C      �� 5G      $��4��6   $��images/logo.png��6'   6C   5H      � 5P   
   $��1��6   $��1��6    5Q      �� 5R      $��4* �6#   �� 5S      $��* �6#   .+�5U      � -   5        $
��main��5U      $��Disabled=�6     5V      �� 5W      $��7* �6$   �� 5X      $��* �6$   .+�5Z      �  5[      �� 5\      $��9* �6(   �� 5]      $
��259* �6(    5_      �� 5`      $��7* �6+   �� 5a      $��1* �6+   .+�5c      �� $ 
Horizontal=�6!   .+�5e      �� $��ID��6    $	��100��6-   #��[  69   $��Center=�6V   6|   �� 5f      $��Photo��6    $	��100��60   #��[  6<   $��Center=�6Y   6   �� 5g      $
��Name��6    $	��550��6/   #��[  6;   $��50,0,0,0q�6W   �� 5h      $��Price��6    $	��100��60   #��[  6<   $��Right=�6Y   6~   5i      �� 5j      -   5        $��main_total_Left��5j      $��1��6b   ��65   Z� ��6L   Z� ��5k      �� 5l      .R�5m   "   �  � Orientation$ Vertical=�6,   6E   5n      ��5p      �� 5q      .R�5r   "   �� $��50��6C   $��5q�6P   $ 
Horizontal=�6[   ��6-   Z� .+�5s   &   �� $	��100��6,   $��Center=�6[   $��Center=�6   $��Stretch=�6�   ��68   �� *merchandise_ID+6�   �� 5t   &   $	��100��6,   $
��Fill=�69   $��50��6m   ��6H   �� *merchandise_Photo+6{   �� 5u   &   $	��600��6,   $��50,0,0,0q�6]   $��Stretch=�6o   $��Stretch=�6�   $
��Left=�6�   $��Center=�6�   ��68   �� *merchandise_Name+6�   �� 5v   &   $	��100��6,   $��Stretch=�6R   $��Stretch=�6p   $
��Left=�6�   $��Center=�6�   ��68   �� *price+6�   5w   #   5x      5z      �� 5{      $��1��6!   $ 
Horizontal=�61   .+�5|      �� $��Volume��6    $	��100��61   #��[  6=   6Z   �� 5}      $��Delet��6    #��[  60   6M   5~      �� 5      -   5        $��main_total_Right��5      $��1��66   $��1��6s   ��6F   Z� ��6]   Z� ��5�      �� 5�      .R�5�   "   � $ Vertical=�6,   6E   5�      ��5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��50��6\   $��5q�6h   ��6F   Z� .+�5�   &   �� $��50��6/   $��Right=�6^   $��Center=�6z   ��6:   �� *merchandise_Volume+��6�   Z� 6�   �� 5�   &   -   5        $��50,0,0,0q�5�   -   $��30��6?   $��X��6K   ��6k   Z� ��6�   Z� 6�   5�   #   5�      5�      5�      �� 5�      $��1��6   $ Vertical=�6*   $��Right=�6A   $	��178��6]   .+�5�      � .+�5�      �� $��總計:��6    61   �� 5�      -   5        $��
totalmoney��5�       $��Right=�62   6X   5�      � 5�      $��30��6   $��30��6&   $��Right=�62   .+�5�      A�  �� Stretch$ Uniform=�6"   ��5�      
� 5�   "   .��5�   &   � $ Black��63   $ 1Q�6A   � 5�   &   $ White��63   5�   #   5�      �� 5�      -   5        $��OK��5�       
�������$��Center=�6@   $��Center=�6]   ��6�   Z� 5�      5�      5�      5�      �� 5�   
   
���  ��$��2��6%   $��2��62   6H   5�      5�      