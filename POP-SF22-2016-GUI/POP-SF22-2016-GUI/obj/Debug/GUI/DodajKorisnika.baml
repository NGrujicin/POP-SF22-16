   M S B A M L   `   `   `  ����L  HPOP-SF22-2016-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:POP_SF22_2016_GUI.GUIPOP_SF22_2016_GUI.GUI  5   	   *    $POP_SF22_2016_GUI.GUI.DodajKorisnika   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:POP_SF22_2016_GUI.GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ DodajKorisnika��5
   	   $	��400��6    $	��450��6-   .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��lblDodajIme��5      $��Right=�6#   $��0��6F   $
��Ime:��6S   $��30��6b   $��10,18,322.2,248q�6n   �� 5   
   -   5        $��lblDodajPrezime��5      $��Right=�6'   $��0��6J   $��Prezime:��6W   $��30��6j   $��40,63,322.2,203q�6v    J� RenderTransformOrigin$ -0.712,1.879&�6�   �� 5   
   -   5        $��lblDodajUsername��5      $��Right=�6(   $��0��6K   $��	Username:��6X   $��30��6l   $��70��6x   $ -2.42,-3.532&�6�   $��51,116,322.2,150q�6�   6�   �� 5   
   -   5        $��lblDodajPassword��5      $��Right=�6(   $��0��6K   $��	Password:��6X   $��30��6l   $��61��6x   $��60,163,322.2,103q�6�   $ -0.07,0.575&�6�   6�   �� 5   
   -   5        $��lblDodajTipKorisnika��5      $��Right=�6,   $��0��6O   $
��Tip:��6\   $��30��6k   $��40��6w   $��81,218,322.2,48q�6�   6�   �� 5   
   -   5        $��tbIme��5      $��0��69   $��167,18,67.2,238q�6F   ��6   ��  �� Path$	 Ime�6F   �� 5   
   -   5        $��	tbPrezime��5      $��0��6A   $��167,63,67.2,192q�6N   ��6#   �� $ Prezime�6N   �� 5   
   -   5        $��
tbUsername��5      $��0��6D   $��167,109,67.2,143q�6Q   ��6%   �� $ Username�6Q   �� 5   
   -	   5        $��
tbPassword��5      $��0��6C   $��167,163,67.2,91q�6P   ��6$   �� $ Password�6P   �� 5   
   -
   5        $��cbTip��5      $��0��6L   $��167,210,67.2,48q�6Y    �� SelectedItem 6    �� $ Tip_Korisnika�6Y   �� 5   
   -   5        $��
btnSacuvaj��5   *   $��1��6<   $��Sacuvaj��6I   $��40,10,292.2,26.4q�6[   �� 5   
   -   5        $��btnNazad��5   )   $��1��69   $��Nazad��6F   $��267,10,67.2,26.4q�6V   5       5!      