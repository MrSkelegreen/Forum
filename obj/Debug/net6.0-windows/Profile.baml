   M S B A M L   `   `   `  ����@  <Forum, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ForumForum  5   	       Forum.Profile   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Forum     5   	     � Title$  Profile��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��400 �6   �� 5      $��190.849 �6   �� 5      $��209.151 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��BackBtn��5      $��
Назад��6    $��2��6F   $��6��6V   �� 5   
   -   5        $��
HistoryBtn��5      $)��#Выполненные задачи��6#   $��1��6Y   $��6��6i   �� 5   
   $��Логин:��6   $��1��6"   $��Right=�62   �� 5   
   $��2��6+   $��Center=�6;   ��6   �� *Login+6;   �� 5!   
   $��Имя:��6   $��1��6    $��1��60   $��Right=�6=   �� 5"   
   $��2��6/   $��1��6?   $��Center=�6L   ��6   �� *	FirstName+6L   �� 5$   
   $��Фамилия:��6   $��1��6$   $��2��64   $��Right=�6A   �� 5%   
   $��2��60   $��2��6@   $��Center=�6M   ��6   �� *
SecondName+6M   �� 5'   
   $��Отчество:��6   $��1��6%   $��3��65   $��Right=�6B   �� 5(   
   $��2��6.   $��3��6>   $��Center=�6K   ��6   �� *
LastName+6K   �� 5*   
   $��Телефон:��6   $��1��6$   $��4��64   $��Right=�6A   �� 5+   
   $��2��6+   $��4��6;   $��Center=�6H   ��6   �� *Phone+6H   &   System.Windows.Controls.DataGrid  5-   
   -   5        $��	UserTasks��5-      $��1��6$   $��6��61      AutoGenerateColumns$ False��6B      CanUserAddRows$ False��6^      
IsReadOnly$
 True��6u      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 25 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *Id+  50      $ Название��6%   $	 200 67   	 6C   �� *Tittle+  51      $ Статус��6%   $ 90 65   	 6@   �� *StatusNavigation.Tittle+  52      $ Дата��6%   $ 90 63   	 6>   �� *Date+54      55      56      