   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    View   View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   9Custom,http://metro.mahapps.com/winfx/xaml/controls   5   	   4xctk)http://schemas.xceed.com/wpf/xaml/toolkit   5   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	      ShowIconOnTitleBar .  � Icon$ images/paw.png��5   #    � Title$- 'Captain Mao 毛孩隊長寵物資訊站��5   	   $	��900��6'   $
��1600��64    � WindowStartupLocation$ CenterScreen=�6A   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� 
���   � �� Orientation$ 
Horizontal=�6(   .+�5      9� $��使用者註冊��6    9� ExpandDirection$ Right=�6&   $��14(�6>   $��5q�6L   .��5      �� $ 
Horizontal=�6   .+�5      �� -   5        $��btnNormalUserRegistration��5      $��註冊一般使用者��6>   $��14(�6P   $��0,0,5,0q�6^   6o   �� 5      -   5        $��btnStoreUserRegistration��5      $��註冊商家使用者��6=   $��14(�6O   $��0,0,5,0q�6]   $y�Hidden=�6n   5      5      �� 5      -   5        $��	回首頁��5      $��14(�6#   $��5q�61   6<   5      �� 5   
   
���   �$ 
Horizontal=�6(   $��Right=�6A   .+�5      �� 
�������$��14(�6'   $��使用者帳號:��65   $��Right=�6F   $��Center=�6b   $��Center=�6}   $��Center=�6�   �� 5      -   5         ��Name$ 
tbUsername��5      $��Center=�6*   $��Center=�6G   $��Center=�6b   $��20��6�   $	��100��6�   $��5q�6�   *   $MahApps.Metro.Controls.TextBoxHelper	   ClearTextButton	 . 6�   �� 5       
�������$��14(�6'   $��密碼:��65   $��Center=�6C   $��Center=�6`   G� 5!      -   5        
 G�Name$
 
tbPassword��5!      $��Center=�6.   $��Center=�6K   $��Center=�6f   $	��100��6�   $��20��6�   $��5q�6�   	 . 6�   �� 5"      -   5         ��Name$ btnLogin��5"      $��登入��6'   $��Center=�64   $��Center=�6Q   $��5q�6l   $��14(�6w   6�   5#      � 5$   
   -   5        $��grdShow��5$      $��2��6   $	��800��6+   $
��1600��68   5&      5'      5(      