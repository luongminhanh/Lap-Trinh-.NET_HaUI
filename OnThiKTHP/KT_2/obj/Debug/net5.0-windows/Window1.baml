   M S B A M L   `   `   `  ����?  ;KT_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KT_2KT_2  5   	       KT_2.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:KT_2     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $	��24* �6   .+�5   
   �� $��THỐNG KÊ��6   $
��Left=�6#   $��52��6>   $��
276,43,0,0q�6J   $	��Top=�6^   $	��224��6v   $��22(�6�   $
��Bold"�6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 dtTK��5         AutoGenerateColumns$ False��6!   $
��Left=�6=   $	��226��6X   $��
50,125,0,0q�6e   $	��Top=�6y   $	��643��6�   $��1��6�   $��15(�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%T   '        �� 5      "  6   .�5      ��  � ��$
 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã Tác giả��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *MaTG+ �� Mode$ OneWay=�6_     5      $	 Tên Tác giả��6%   $	
 200 6a    6:   �� *TenTG+$ OneWay=�6a     5      $	 Tổng tiền��6%    68   �� *
TongTien+$ OneWay=�5      5      5      