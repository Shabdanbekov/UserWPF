   M S B A M L   `   `   `  ����  WPF    WPF.AddUserWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  AddUserWindow��5   	   $	��200��6   $	��400��6,   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��ФИО:��6   $��0��6   $��0��6,   $��Center=�6<   �� 5   
   -   5         ��Name$ fullNameTextBox��5      $��0��6+   $��1��68   $��5q�6H   �� 5   
   $ ��Дата рождения:��6   $��1��6)   $��0��66   $��Center=�6F   $��0,5,0,0q�6a   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ birthDatePicker��5      $��1��6.   $��1��6;   $��5q�6K   �� 5   
   -   5        $��Добавить��5      $��2��6$   $��1��61   $��5,10,5,0q�6A   6S   5      5      