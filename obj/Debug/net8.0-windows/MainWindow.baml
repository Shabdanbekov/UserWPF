   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��249* �6   �� 5      $
��551* �6   .+�5   
   �� $��0��6   $��20q�6"   .+�5      �� -   5        $��Добавить��5   +   $	��183��6>   $��0 0 0 5q�6K   �� 5      -   5        $��
Выход��5   (   $	��184��68   5      �� 5   
   -   5        $��userListView��5      $��77,20,186,0q�6'   $��1��6<    �� View 5      �� 5      .P�5      �� $��ID��6%    �� DisplayMemberBinding 61   �� *Id+�� 5      $��Имя��6%    62   �� *
FullName+�� 5      $��Дата рождения��6%    6<   �� *	BirthDate+5      5      5      5      