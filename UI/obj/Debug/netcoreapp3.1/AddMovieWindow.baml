   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.AddMovieWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  AddMovieWindow��5   	   $	��400��6    $	��600��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��500 �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��1��61   $��16(�6E   $��10,10,100,10q�5       $��
Movie name��6*   �� 5"   
   -   5         ��Name$ 	movieName��5"      $��1��6%   $��2��65   $��1��6B   �� 5$   
   $��1��6   $��3��6$   $��1��61   $��16(�6E   $��10,10,100,10q�5%      $+��%Movie description (Max 45 characters)��6*   $	��500��6W   �� 5'   
   -   5        $ movieDescription��5'      $��1��6,   $��4��6<   $��1��6I   �� 5)   
   $��1��6   $��5��6$   $��1��61   $��16(�6E   $��10,10,100,10q�5*      $��Movie length��6*   �� 5,   
   -   5        $ movieLength��5,      $��1��6'   $��6��67   $��1��6D   �� 5.   
   $��1��6   $��7��6$   $��1��61   $��16(�6E   $��10,10,100,10q�5/      $*��$Movie poster url (Must contain .jpg)��6*   �� 51   
   -   5        $ moviePosterUrl��51      $��1��6*   $��8��6:   $��1��6G   �� 53   
   -   5        $��Submit��53      $��Submit��6   $��1��54      $��9��6!   $��1��6.   $��10,10,400,10q�55      6'   56      57      