   M S B A M L   `   `   `  ����G  CLogin Screen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Login_Screen.ViewLogin_Screen.View  5   	   !    Login_Screen.View.LoginView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Login_Screen.View     5   	   -   5          � Title$  	LoginView��5   	   $	��550��6   $	��800��6(    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 50��6   ��5   
   �� 5       �� ImageSource$ /Images/Background.jpg��6   ._�5   
   �� $ 5��6   $��1q�6"    J� Opacity$
 0.80Q�66   ��5      �� 5       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5      � 
 � Color$
 #462AD8��6#    � Offset$ 0Q�63   � 5      $
 #DA34AE��6#   $
 0.75Q�63   � 5      $
 #8A16C1��6#   $ 1Q�63   5      ��5      �� 5      $	 0,1&�6&   $		 1,0&�67   .��5      � $
 #060531��6#   $ 0Q�63   � 5      $
 #181448��6#   $
 0.85Q�63   5!      ._�5#      �  � RowDefinitions 5$      �� 5%      $��20 �6$   .+�5)      �  � ColumnDefinitions 5*      �� 5+      �� 5,      $��25 �6+   �� 5-      $��25 �6+   �� 5.      $��5 �6+   .+�50      �� $�� LOG IN��6    
�������$��10(�6B   $��	Montsrrat)�6P   $��0��6g   $��Center=�51       $��	30,10,0,0q�6;   �� 52      -   5         ��Name$ btnMinimize��52      ���#2BAEED$��0q�53   2   $��-��6F   
�������$��16(�6e   $��
Montserrat)�6s    � Cursor$
 Hand��54      $��1��6+   $��22��6U   $��Center=�6a   �� 55      -   5        $ btnClose��55      
���  ��$��0q�56   .   $��x��6B   
�������$��12(�6a   $��
Montserrat)�6o   $
 Hand��57      $��2��6+   6;   58      �� 59      $	��250��6    �� Orientation$ Vertical=�6)   $��274,35,274,-464q�6@   .+�5:      �� $��/Images/xxxx.png��6   $��86��66   $��77��6A    J� RenderTransformOrigin$ 0.892,3.012&�6M   �� 5;      $��SITEC INSTITUTE��6    
�������$��25(�6J   $
��Bold"�6X   $��
Montserrat)�6j   $��Center=�6�   �� 5<      $��Username��6    
�������$��14(�6B   $��Medium"�6P   $��
Montserrat)�6d   $��0,35,0,0q�6|   �� 5>      -   5         ��Name$ txtUser��5>      $��14(�6.   $��Medium"�6<   
������ $��
Montserrat)�6i   
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5?   K   $��34��6e   $��0,5,0,0q�6q   $	��250��6�   .��6�   5@      �� 5C      $��Password��6    
�������$��14(�6B   $��Medium"�6P   $��
Montserrat)�6d   $��0,15,0,0q�6|   G� 5D      -   5         G�Name$ txtPassword��5D   "   $��13(�67   $��Medium"�6E   
������ $��
Montserrat)�6r   
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5E   L   $��28��6f   $��0,5,0,0q�6r   $	��250��6�   5G      �� 5H      $��Role:��6    
�������$��14(�6?   $��Medium"�6M   $��
Montserrat)�6a   $��0,15,0,0q�6y   �� 5I      -   5         ��Name$ roleListBox��5I       .@�5J      �� $��Admin��6'   6:   �� 5K      $��Teacher��6'   6;   5L      �� 5M      -   5        $ btnLogin��5M      $��0q�5N      $��LOG IN��6/   
���   �$��18(�6S   $��
Montserrat)�6a   $
 Hand��5O      $��2��6+   $��0,40,0,0q�6;   $
��Bold"�6d   ��5P      �� 5Q       �� 
TargetType" ��6$   .�5R   "   ��  �� Property � �� �� Value
 ��� �6?    �� Triggers 5S   "   P� 5T   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5U   *   ��  � �� �#462AD86G   5W   '   5Y      ��5[      �� 5\       �� 
TargetType" ��6.   .R�5]   "   �� $	��150��6)   $��40��65   $ 20��6A   #��z��6S   ._�5^   &   �� $��Center=�67   $��Center=�6R   5_   #   5`      5b      5d      5e      5f      5g      5k      