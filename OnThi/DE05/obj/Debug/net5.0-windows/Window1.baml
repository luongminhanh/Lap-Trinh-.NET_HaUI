   M S B A M L   `   `   `  ����?  ;DE05, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE05DE05  5   	       DE05.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE05     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgSP��5
         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         AlternatingRowBackground
 �����$��Center=�5      $	��170��6*   $��Center=�67   $	��708��6R    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�63   5      5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Category ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *CatId+6T     5      $
 Category Name��6%   $	 200 6X    6<   �� *	CatName+6X     5      $
 Amount��6%   $	 200 6h    65   �� *Amount+ �� StringFormat$ {0:n0}��   ElementStyle 5      �� 5      " ��6    .�5      ��  � ��$ Right=�6D   �� 5       � ��$
 Bold"�6;   �� 5       � ��
 ��  �6;   �� 5       � ��$ Italic$�6:   5      5!      5#      5%      5&      