   M S B A M L   `   `   `  ����J  FExamJanvier2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ExamJanvier2023ExamJanvier2023  5   	        ExamJanvier2023.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ExamJanvier2023     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         listTemplate��%�   &	        �� 5
   
   .R�5      �� $��0 5 0 5q�6   .+�5      �� $
��Left=�66   $��Center=�6Q   ��6   �� *	ProductId+6Q   �� 5      $��Right=�68   $��Center=�6T   ��6   �� *ProductName+6T   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ combo��5      $
��Left=�6&   $��	87,75,0,0q�6A   $	��Top=�6T   $	��120��6l   #��[  5      ��5   x   �� *ProductsList+ �� SelectedItem 5   :   �� *SelectedProduct+�� 5      $��	ProductId��6   $
��Left=�6(   $��
51,161,0,0q�6C   $	��Top=�6W   �� 5      $��ProductName��6   $
��Left=�6*   $��
51,192,0,0q�6E   $	��Top=�6Y   �� 5      $��Category��6   $
��Left=�6'   $��
51,220,0,0q�6B   $	��Top=�6V   �� 5      $��Fournisseur��6   $
��Left=�6*   $��
51,250,0,0q�6E   $	��Top=�6Y   �� 5      $
��Left=�6   $��23��61   $��200,161,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�5   D   $	��120��6\   ��5   f   �� *	ProductId+ �� Mode$ OneWay=� � DataContext 5      �� *SelectedItem+ �� ElementName$ combo��6\   �� 5      $
��Left=�6   $��23��61   $��200,194,0,0q�6=   $
 Wrap=�6R   $	��Top=�5    D   $	��120��6\   ��5   f   �� *ProductName+$ OneWay=� 5       �� *SelectedItem+$ combo��6\   �� 5!      $
��Left=�6   $��23��61   $��200,220,0,0q�6=   $
 Wrap=�6R   $	��Top=�5"   D   $	��120��6\   ��5!   f   �� *ProductCategory+$ OneWay=� 5"      �� *SelectedItem+$ combo��6\   �� 5#      $
��Left=�6   $��23��61   $��200,250,0,0q�6=   $
 Wrap=�6R   $	��Top=�5$   D   $	��120��6\   ��5#   f   �� *ProductSupplier+$ OneWay=� 5$      �� *SelectedItem+$ combo��6\   �� 5%      $)��#Abandonner le produit sélectionné��6   $
��Left=�6d   $��100,300,0,0q�6   $	��Top=�6�   $	��200��6�   $��40��6�   ��6A   �� *AbandonCommand+6�   5&      &   System.Windows.Controls.DataGrid  5'   
   $��1��6   	   AutoGenerateColumns$	 False��6#   ��5(      �� *ProductsCountList+
   Columns
 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Country��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Country+6R     5+      $ ProductCount��6F   $ * 6\    6%   �� *ProductCount+6\   5-      5/      50      