   M S B A M L   `   `   `  ����?  ;Bai1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai1Bai1  5   	       Bai1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bai1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��	Mã sách��6   $
��Left=�6"   $��
107,10,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ txtMa��5      $
��Left=�6!   $��26��6<   $��
182,10,0,0q�6H   $�� ��6\    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��362��6�   �� 5   
   $��
Tên sách��6   $
��Left=�6#   $��
106,41,0,0q�6>   $	��Top=�6R   �� 5   
   $��Năm xuất bản��6   $
��Left=�6'   $��	82,72,0,0q�6B   $	��Top=�6U   �� 5   
   $��
Số trang��6   $
��Left=�6#   $��
97,109,0,0q�6>   $	��Top=�6R   �� 5   
   $��
Tác giả��6   $
��Left=�6"   $��101,144,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.596,-1.556&�6j   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��27��6>   $��
182,41,0,0q�6J   $�� ��6^   $
 Wrap=�6f   $	��Top=�6z   $	��362��6�   �� 5   
   -   5        $ txtNamXB��5      $
��Left=�6$   $��
182,73,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��362��6�   $��31��6�   �� 5   
   -   5        $ 
txtSoTrang��5      $
��Left=�6&   $��182,109,0,0q�6A   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��362��6�   $��27��6�   �� 5   
   -   5         ��Name$ cbTacGia��5      $
��Left=�6%   $��182,141,0,0q�6@   $	��Top=�6U   $	��362��6m   $��29��6y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgSach��5      $��18,195,79,87q�6#   $��14(�69      AutoGenerateColumns$ False��6G      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� *MaSach+
 �� Mode$
 OneWay=�6`     5      $ 
Tên sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6`   	 67   �� *	TenSach+$
 OneWay=�6n     5      $ Mã tác giả��6%   	 69   �� *MaTG+$
 OneWay=�6a     5      $ Năm xuất bản��6%   	 6;   �� *
NamXuatBan+$
 OneWay=�6i     5      $ 
Số trang��6%   	 67   �� *	SoTrang+$
 OneWay=�6b     5      $ Thành tiền��6%      
Foreground
 �  ��   	FontStyle$ Italic$�6t   $ * 6�   	 69   �� *
TongTien+$
 OneWay=�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%Y   '        �� 5      "  6   .�5       ��  � ��$
 Bold"�63   6B   5!      5"      5#      �� 5%   
   -   5         ��Name$ 	btnUpdate��5%      $��Sửa��6$   $
��Left=�62   $��209,368,0,0q�6M   $	��Top=�6b   $��41��6z   $	��111��6�   $��2��6�   6�   �� 5&   
   -	   5        $��Thêm��5&      $
��Left=�6    $��
55,368,0,0q�6;   $	��Top=�6O   $��41��6g   $	��111��6s   $��2��6   6�   �� 5'   
   -
   5        $ btnStatistic��5'      $��Thống kê��6'   $
��Left=�6:   $��513,368,0,0q�6U   $	��Top=�6j   $��41��6�   $	��106��6�   $��2��6�   6�   �� 5(   
   -   5        $ 	btnDelete��5(      $
��Xóa��6$   $
��Left=�62   $��363,367,0,0q�6M   $	��Top=�6b   $��42��6z   $	��110��6�   $��2��6�   6�   5)      5*      