   M S B A M L   `   `   `  ����E  APractica_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Practica_5
Practica_5  5   	       Practica_5.Buyer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Practica_5     5   	     � Title$  Buyer��5   	   $	��450��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��0.1* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��8* �6   .+�5   
   �� $#��Покупка билетов��6   $��0��6*   $��0��67   $��3��6G   $��Center=�6[   $��Center=�6v   $��20(�6�   �� 5   
   -   5         ��Name$ Login_in��5      $��
Выйти��6#   $
��Left=�63   $	��Top=�6N   $��18(�6f   $��5q�6t   �� 5   
   -   5         ��Name$ Tovary��5      $��1��6$   $��Товары��61   $��Center=�6?   $��Center=�6Z   $��20(�6w   $��0��6�   �� 5   
   -   5        $ Check��5      $��1��6#   $��К оплате: ��60   $��Center=�6B   $��Center=�6]   $��20(�6z   $��2��6�   �� 5   
   -   5        $ Add_list��5      $��1��6#   $��2��63   $	��Top=�6@   $��Center=�6X   $��34��6u   $��34��6�   
������ $��0 50 0 0q�6�   .��5      �� $C��=C:\Users\Mann\source\repos\Practica_5\Practica_5\img\plus.png��6   5      �� 5   
   -   5        $ Del_list��5      $��1��6#   $��2��63   $��Bottom=�6@   $��Center=�6[   $��34��6x   $��34��6�   
������ $��0 0 0 50q�6�   .��5      �� $B��<C:\Users\Mann\source\repos\Practica_5\Practica_5\img\del.png��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Buying_grid��5      $��2��6(   $��0��65     5   
   -   5        $ 
Check_grid��5      $��2��6'   $��2��64   �� 5    
   -   5        $ create_check��5       $��1��6'   $��2��67   $��34��6D   $��34��6P   $
��Left=�6v   $��2,156,0,157q�6�   5!      5"      