   M S B A M L   `   `   `  ����A  =DE03_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE03_2DE03_2  5   	       DE03_2.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:DE03_2     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgNV��5
         AutoGenerateColumns$ False��5      $
��Left=�5      $	��144��6(   $��10,0,0,0q�65   $��Center=�6G   $	��785��6b    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã Phòng��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 80 6S   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *	MaPhong+6S     5      $ 	Họ tên��6%   $		 190 6R   
 65   �� *
TenPhong+6R     5      $ Tổng số nhân viên��6%   $		 190 6Y   
 6@   �� *SoNV+6Y     5      $ Tổng Lương��6%   $		 150 6m   
 69   �� *
TongTien+ �� StringFormat$ {0:n0}��   ElementStyle 5      �� 5      " ��6    .�5      ��  �@��TextAlignment$ Right=�6H   �� 5       � ��
 ��  �6;   5      5      5       5"      5#      