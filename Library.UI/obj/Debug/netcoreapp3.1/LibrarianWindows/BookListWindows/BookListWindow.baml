   M S B A M L   `   `   `  ����E  ALibrary.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Library.UI.LibrarianWindowsLibrary.UI.LibrarianWindows  5   	   @    :Library.UI.LibrarianWindows.BookListWindows.BookListWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ;local)clr-namespace:Library.UI.LibrarianWindows     5   	     � Title$  Список книг��5   	   $	��350��6   $	��700��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��220 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ BookGrid��5      $��0��6%   $��10q�62      AutoGenerateColumns$ False��6>   $	��200��5         CanUserAddRows$ False��6       CanUserDeleteRows$ False��67      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 67   	   
IsReadOnly$
	 True��6]   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   �� *Title+6]     5      $ Жанр��6%   $ 70 63   $
	 True��6X   
 6>   �� *Genre+6X     5      $ 
Автор��6%   $	 100 64   $
	 True��6[   
 6@   �� *Author+6[     5      $! Год публикации��6%   $	 105 6=   $
	 True��5   %   
 5   I   �� *PublicationDate+5   %     5      $
 ISBN��6%   $ 85 63   $
	 True��6W   
 6>   �� *Isbn+6W     5      $ Блокировка��6%   $ 85 69   $
	 True��6a   
 6D   �� *
IsBanned+6a   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $��
EditButton��6%   -   5        $ ��Редактировать��5   7   6O   5      5        5        5!      �� 5"      .R�5#      �� $��ShowMoreButton��6%   -   5        $��Подробнее��5#   ;   6O   5$      5&      5)      �� 5*   
   -   5        $��DataFiltrationTextBox��5*      $��1��6   $	��100��6<   $��18��6H   $
��Left=�6T   $��10 10q�5+      �� 5,   
   -   5        $��FiltrationColumnListBox��5,       $��1��6   $	��100��6?   $��18��6K   $
��Left=�6W   $��	150 0 0 0q�5-      .@�5.      �� Название6"   �� 5/      
Жанр6   �� 50      
Автор6   �� 51      Год публикации6(   �� 52      ISBN6   53      �� 54   
   -   5        $��	AddButton��54      $��2��6"   $��Добавить��6/   $	��100��6B   $��30��6N   $��Right=�6Z   $��0 0 10 0q�55      6#   �� 56   
   -   5        $��	AddByIsbn��56      $��2��6"   $ ��Добавить по ISBN��6/   $	��180��6J   $��30��6V   $��Right=�58      $��	0 0 150 0q�59      �� 5:   
   -   5        $��SignOutButton��5:      $��2��6&   $��
Выйти��63   $	��120��6C   $��30��6O   $��Right=�6[   $��	0 0 555 0q�5;      5<      5=      