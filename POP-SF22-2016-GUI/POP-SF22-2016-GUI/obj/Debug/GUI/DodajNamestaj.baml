   M S B A M L   `   `   `  ����L  HPOP-SF22-2016-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:POP_SF22_2016_GUI.GUIPOP_SF22_2016_GUI.GUI  5   	   )    #POP_SF22_2016_GUI.GUI.DodajNamestaj   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:POP_SF22_2016_GUI.GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ DodajNamestaj��5
   	   $	��400��6   $	��450��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��lblDodajNazivNamestaja��5      $��Right=�6.   $��0��6Q   $��Naziv:��6^   $��30��6o   $��10,18,322.2,248q�6{   �� 5   
   -   5        $��lblDodajCenaNamestaja��5      $��Right=�6-   $��0��6P   $��Cena:��6]   $��30��6m   $��40,86,322.2,180q�6y    J� RenderTransformOrigin$ -0.712,1.879&�6�   �� 5   
   -   5        $��lblDodajKolicinaNamestaja��5      $��Right=�61   $��0��6T   $��	Kolicina:��6a   $��30��6u   $��70��6�   $ -2.42,-3.532&�6�   $��51,150,322.2,116q�6�   6�   �� 5   
   -   5        $��lblDodajTipNamestaja��5      $��Right=�6,   $��0��6O   $
��Tip:��6\   $��30��6k   $��40��6w   $��81,218,322.2,48q�6�   6�   �� 5   
   -   5        $��tbNaziv��5      $��0��6=   $��167,10,67.2,248q�6J   ��6!   ��  �� Path$ Naziv�6J   �� 5   
   -   5        $��tbCena��5      $��0��6;   $��167,86,67.2,173q�6H   ��6    �� $
 Cena�6H   �� 5   
   -   5        $��
tbKolicina��5      $��0��6C   $��167,142,67.2,116q�6P   ��6$   �� $ Kolicina�6P   �� 5   
   -   5        $��cbTip��5      $��0��6K   $��167,218,67.2,48q�6X    �� SelectedItem 6    �� $ TipNamestaja�6X   �� 5   
   -	   5        $��
btnSacuvaj��5   *   $��1��6<   $��Sacuvaj��6I   $��40,10,292.2,26.4q�6[   �� 5   
   -
   5        $��btnNazad��5   (   $��1��68   $��Nazad��6E   $��267,10,67.2,26.4q�6U   5      5      