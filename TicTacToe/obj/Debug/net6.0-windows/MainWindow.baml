   M S B A M L   `   `   `  ����D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Tic Tac Toe��5	   	   $	��500��6   $	��500��6*    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 0.8q�60   �� 5       � ��$ 70(�6)   �� 5       � ��$ Arial)�6+   5      5      .��5      � -   5         �Name$ 	Container��5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5!   
   �� -   5        	 ��Name$	 button1��5!   &   $��0��67   $��0��6G   $��X��6T   �� 5"   
   -   5        $	 button2��5"   &   $��1��67   $��0��6G   $��O��6T   �� 5#   
   -   5        $	 button3��5#   &   $��2��67   $��0��6G   �� 5%   
   -   5        $	 button4��5%   &   $��0��67   $��1��6G   �� 5&   
   -   5        $	 button5��5&   &   $��1��67   $��1��6G   �� 5'   
   -   5        $	 button6��5'   &   $��2��67   $��1��6G   �� 5)   
   -   5        $	 button7��5)   &   $��0��67   $��2��6G   �� 5*   
   -	   5        $	 button8��5*   &   $��1��67   $��2��6G   �� 5+   
   -
   5        $	 button9��5+   &   $��2��67   $��2��6G   5-      5.      