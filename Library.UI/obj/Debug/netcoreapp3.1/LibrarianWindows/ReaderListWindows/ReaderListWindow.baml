   M S B A M L   `   `   `  ����E  ALibrary.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Library.UI.LibrarianWindowsLibrary.UI.LibrarianWindows  5   	   D    >Library.UI.LibrarianWindows.ReaderListWindows.ReaderListWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ;local)clr-namespace:Library.UI.LibrarianWindows     5   	     � Title$%  Список читателей��5   	   $	��350��6"   $	��700��6/   .��5
      �  � RowDefinitions 5   
   �� 5      $	��220 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
ReaderGrid��5      $��0��6'   $��10q�64      AutoGenerateColumns$ False��6@   $	��200��5         CanUserAddRows$ False��6       CanUserDeleteRows$ False��67      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 62   	   
IsReadOnly$
	 True��6W   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� *Name+6W     5      $ Фамилия��6%   $ 70 66   $
	 True��6]   
 6A   �� *	Surname+6]     5      $ Отчество��6%   $	 100 67   $
	 True��6b   
 6C   �� *
MiddleName+6b     5      $ Email��6%   $	 105 64   $
	 True��6Z   
 6@   �� *Email+6Z     5      $ Рейтинг��6%   $ 85 66   $
	 True��6\   
 6A   �� *Rating+6\     5      $ Блокировка��6%   $ 85 69   $
	 True��6a   
 6D   �� *
IsBanned+6a   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $��
EditButton��6%   -   5        $ ��Редактировать��5   7   6O   5      5      5!      �� 5"   
   -   5        $��DataFiltrationTextBox��5"      $��1��6   $	��100��6<   $��20��6H   $
��Left=�6T   $��10 10q�5#      6!   �� 5$   
   -   5        $��FiltrationColumnComboBox��5$       $��1��6   $	��100��6@   $��20��6L   $
��Left=�6X   $��	150 0 0 0q�5%      .@�5&      �� Имя6   �� 5'      Фамилия6!   �� 5(      Отчество6"   �� 5)      Email6   �� 5*      Рейтинг6!   5+      �� 5,   
   -   5        $��	AddButton��5,      $��2��6"   $��Добавить��6/   $	��100��6B   $��30��6N   $��Right=�6Z   $��0 0 10 0q�5-      6#   �� 5.   
   -   5        $��AddFromCsvButton��5.      $��2��6)   $*��$Добавить из CSV файла��66   $	��180��6V   $��30��6b   $��Right=�5/      $��	0 0 150 0q�50      6$   �� 51   
   -   5        $��SignOutButton��51      $��2��6&   $��
Выйти��63   $	��120��6C   $��30��6O   $��Right=�6[   $��	0 0 555 0q�52      6$   53      54      