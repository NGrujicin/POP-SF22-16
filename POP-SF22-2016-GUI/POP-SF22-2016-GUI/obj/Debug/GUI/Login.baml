   M S B A M L   `   `   `  ����L  HPOP-SF22-2016-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:POP_SF22_2016_GUI.GUIPOP_SF22_2016_GUI.GUI  5   	   !    POP_SF22_2016_GUI.GUI.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:POP_SF22_2016_GUI.GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ Login��5
   	   $	��400��6   $	��450��6$   .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��2* �6   6,   .+�5   
   �� -   5        $��lblUsername��5      $��	Username:��6#   $��0��67   $��0��6D   $��30��6T   $��80��6`   $��58,80,10,186q�6k   6�   �� 5   
   -   5        $��lblPassword��5      $��	Password:��6#   $��0��67   $��0��6D   $��30��6T   $��80��6`   $��58,164,10,102q�6k   6�   �� 5    
   -   5        $��
tbUsername��5       $��0��6$   $��1��61   $��10,80,26.2,176q�6A   G� 5!   
   -   5        $��
pbPassword��5!      $��0��6(   $��1��65   $��10,164,26.2,91q�6E   �� 5"   
   -   5        $��btnLogin��5"   )   $��Login��69   $��1��6I   $��0��6V   $��28,22,10,10.4q�6f   �� 5#   
   -   5        $��btnIzlaz��5#   (   $��Izlaz��68   $��1��6H   $��1��6U   $��98,22,87.2,10.4q�6e   5%      5&      