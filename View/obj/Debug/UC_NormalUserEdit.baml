   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5          View.UC_NormalUserEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:View     5      .��5      (�   (� Stretch$  Uniform=�6   .��5	   
   �� $��5q�6   
���   �
������� �� CornerRadius$ 10��6Q   $	��350��6c   $��Center=�6p   ._�5
      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��頭像��6   $��Center=�6%   $��Right=�6G   $��Right=�6j   $��Center=�6�   �� 5      $	��姓��6   $��Right=�6$   $��Center=�6@   $��1��6[   $��Right=�6h   $��Center=�6�   �� 5      $	��名��6   $��Right=�6$   $��Center=�6@   $��2��6[   $��Center=�6h   $��Center=�6�   �� 5      $��行動電話��6   $��Right=�6'   $��Center=�6C   $��3��6^   �� 5      $��電子信箱��6   $��Right=�6'   $��Center=�6C   $��4��6^   �� 5      $��1��6   $	��130��6-   .+�5      �� $��2q�6   $��Center=�61   $��Center=�6N   $	��100��6i   $	��100��6v   $��5q�6�   
���   �._�5      �� -   5         ��Name$ imgProfilePicture��5       $��Center=�6;   $��Center=�6X   $��Uniform=�6s   ��6�   �� *Photo+5      �� 5       -   5         ��Name$ btnAddProfilePicture��5       $��瀏覽檔案��6;   $��Center=�6J   $��Center=�6e   $��5q�6�   $��14(�6�   5!      �� 5"      -   5         ��Name$ 
tbLastname��5"       �� TextWrapping$
 Wrap=�6.   $��Center=�6B   $��Center=�6]   $	��180��6z   $��20��6�   $��5q�6�   $��1��6�   $��1��6�    � UseLayoutRounding .  ��6�   �� *
Lastname+6�   �� 5#      -   5        $ tbFirstname��5#      $
 Wrap=�6/   $��Center=�6C   $��Center=�6^   $	��180��6{   $��20��6�   $��5q�6�   $��2��6�   $��1��6�   ��6�   �� *	Firstname+�� 5$      -   5        $ tbMobile��5$      $
 Wrap=�6,   $��Center=�6@   $��Center=�6[   $	��180��6x   $��20��6�   $��5q�6�   $��3��6�   $��1��6�   ��6�   �� *mobile+�� 5%      -   5        $ tbEmail��5%      $
 Wrap=�6+   $��Center=�6?   $��Center=�6Z   $	��180��6w   $��20��6�   $��5q�6�   $��4��6�   $��1��6�   ��6�   �� *email+�� 5&      -   5        $ tbUpdateUserProfile��5&      $��修改基本資料��66   $��2��6G   $��5��6[   $��Center=�6h   $��Center=�6�   $��5q�6�   $��14(�6�   5'      5(      5)      5*      