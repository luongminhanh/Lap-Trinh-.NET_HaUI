   M S B A M L   `   `   `  ����?  ;DE04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE04DE04  5   	       DE04.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE04     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgSP��5
         AutoGenerateColumns$ False��5      $��Center=�5      $	��204��6*   $��	0,110,0,0q�67   $	��Top=�6J   $	��660��6b    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *MaSp+ �� Mode$ Oneway=�6Z     5      $ Tên SP��6%   $		 180 6\   
 65   �� *TenSp+$ Oneway=�6\     5      $ Tên Loại��6%   $		 100 6`   
 67   �� *	TenLoai+$ Oneway=�6`     5      $ Tổng sl đã bán��6%   $		 100 6h   
 6=   �� *	SoLuongCo+$ Oneway=�6h     5      $ Tổng số tiền bán��6%   $		 120 6i   
 6?   �� *
TongTien+$ Oneway=�6i   5      5      5      