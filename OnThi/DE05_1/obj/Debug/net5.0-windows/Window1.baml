   M S B A M L   `   `   `  ����A  =DE05_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE05_1DE05_1  5   	       DE05_1.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:DE05_1     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgSP��5
         AutoGenerateColumns$ False��5      $��Center=�5      $	��147��6*   $��Center=�67   $	��748��6R    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�63   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Category ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6a   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *CatId+ �� Mode$ Oneway=�6a     5      $ Category Name��6%   $		 150 6e   
 6<   �� *	CatName+$ Oneway=�6e     5      $ Amount��6%   $		 150 6v   
 65   �� *
TongTien+$ Oneway=� �� StringFormat$ {0:n0}��   ElementStyle 5      �� 5      " ��6    .�5      ��  �@��TextAlignment$ Right=�6H   �� 5       � ��
 ��  �6;   �� 5       � ��$ Italic$�6:   �� 5       � ��$
 Bold"�6;   5      5      5!      5#      5$      