   M S B A M L   `   `   `  ����A  =DE04_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE04_1DE04_1  5   	       DE04_1.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:DE04_1     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgSP��5
      $��Center=�6!   $	��164��6>   $��Center=�6K   $	��760��6f    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *MaSp+	 �� Mode$	 Oneway=�  5      $ Tên SP��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6\    65   �� *TenSp+$	 Oneway=�6\     5      $ Tên Loại��6%   $
 80 6`    67   �� *	TenLoai+$	 Oneway=�6`     5      $ 
Đơn giá��6%   $	
 120 6^    66   �� *DonGia+$	 Oneway=�6^     5      $ Số lượng có��6%   $	
 120 6e    6:   �� *	SoLuongCo+$	 Oneway=�6e     5      $ Thành Tiền��6%   $	
 180 6c    69   �� *
TongTien+$	 Oneway=�   ElementStyle 5      �� 5      " ��6    .�5      ��  �@��TextAlignment$ Center=�6H   �� 5       � ��
 �  ��6;   �� 5       � ��$
 Bold"�6;   5      5      5!      5#      5$      