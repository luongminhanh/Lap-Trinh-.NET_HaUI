   M S B A M L   `   `   `  ����?  ;KT_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KT_1KT_1  5   	       KT_1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:KT_1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��	Mã sách��6   $
��Left=�6"   $��
198,16,0,0q�6=   $	��Top=�6Q   $��14(�6i   �� 5   
   -   5         ��Name$ txtMa��5      $
��Left=�6!   $��26��6<   $��
273,16,0,0q�6H   $�� ��6\    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��362��6�   �� 5   
   $��
Tên sách��6   $
��Left=�6#   $��
197,47,0,0q�6>   $	��Top=�6R   $��14(�6j   �� 5   
   $��Năm xuất bản��6   $
��Left=�6'   $��
173,78,0,0q�6B   $	��Top=�6V   $��14(�6n   �� 5   
   $��
Số trang��6   $
��Left=�6#   $��188,115,0,0q�6>   $	��Top=�6S   $��14(�6k   �� 5   
   $��
Tác giả��6   $
��Left=�6"   $��192,150,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.596,-1.556&�6j   $��14(�6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��27��6>   $��
273,47,0,0q�6J   $�� ��6^   $
 Wrap=�6f   $	��Top=�6z   $	��362��6�   �� 5   
   -   5        $ txtNamXB��5      $
��Left=�6$   $��
273,79,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��362��6�   $��31��6�   �� 5   
   -   5        $ 
txtSoTrang��5      $
��Left=�6&   $��273,115,0,0q�6A   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��362��6�   $��27��6�   �� 5   
   -   5         ��Name$ cbTacGia��5      $
��Left=�6%   $��273,147,0,0q�6@   $	��Top=�6U   $	��362��6m   $��29��6y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgSach��5      $��36,197,37,85q�6#   $��14(�69      AutoGenerateColumns$ False��6G    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value��%T   '        �� 5      "  6   .�5      �� 	 � ��$

 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *MaSach+ �� Mode$ OneWay=�  5      $ 
Tên sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6`    67   �� *	TenSach+$ OneWay=�6`     5      $ Mã tác giả��6%    69   �� *MaTG+$ OneWay=�  5      $ Năm xuất bản��6%    6;   �� *NamXB+$ OneWay=�  5       $ 
Số trang��6%    67   �� *	SoTrang+$ OneWay=�  5!      $ Thành tiền��6%      
Foreground
 �  ��   	FontStyle$ Italic$�6t   $ * 6�    69   �� *
TongTien+$ OneWay=�6�   5#      �� 5%   
   -   5         ��Name$ 	btnUpdate��5%      $��Sửa��6$   $
��Left=�62   $��252,363,0,0q�6M   $	��Top=�6b   $��41��6z   $	��111��6�   $��14(�6�   �� 5&   
   -	   5        $��Thêm��5&      $
��Left=�6    $��
82,362,0,0q�6;   $	��Top=�6O   $��41��6g   $	��111��6s   $��14(�6�   �� 5'   
   -
   5        $ btnStatistic��5'      $��Thống kê��6'   $
��Left=�6:   $��596,362,0,0q�6U   $	��Top=�6j   $��41��6�   $	��106��6�   $��14(�6�   �� 5(   
   -   5        $ 	btnDelete��5(      $
��Xóa��6$   $
��Left=�62   $��424,362,0,0q�6M   $	��Top=�6b   $��42��6z   $	��110��6�   $��14(�6�   5*      5+      