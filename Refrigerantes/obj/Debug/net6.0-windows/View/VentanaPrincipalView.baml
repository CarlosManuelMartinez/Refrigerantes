   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5   	   A%clr-namespace:Refrigerantes.ViewModelRefrigerantes.ViewModel  5   	   -    'Refrigerantes.View.VentanaPrincipalView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Refrigerantes.View     5   	   ;	viewModel%clr-namespace:Refrigerantes.ViewModel     5   	   -   5          � Title$  VentanaPrincipalView��5	   	   $	��850��6&   $
��1200��63    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � DataContext 5      7   1Refrigerantes.ViewModel.VentanaPrincipalViewModel  5   
    � 	Resources 5       �� DataType0   *Refrigerantes.ViewModel.OperariosViewModel&    Refrigerantes.View.OperariosView4   .Refrigerantes.ViewModel.RefrigerantesViewModel*   $Refrigerantes.View.RefrigerantesView7   1Refrigerantes.ViewModel.OperacionDeCargaViewModel-   'Refrigerantes.View.OperacionDeCargaView+   %Refrigerantes.ViewModel.HomeViewModel!	   Refrigerantes.View.HomeView0
   *Refrigerantes.ViewModel.ImpuestosViewModel    Refrigerantes.View.PcaView��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5!      *,
 +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5       �� 5!   
   " 
 6   .R�5"        5#      5$      .��5'      �� -   5         ��Name$ BordeParaImagen��5'       �� CornerRadius$ 25��6&   ��5(   
   �� 5)      	 �� ImageSource$	 /Resources/gas-icon2.png��6   
 j� Stretch$
 UniformToFill=�5*      ._�5-   
   �� -   5        $ BordeLineal��5-      $ 25��5.         
colorFondo#��[  5/        colorBordes#��[ 50       J� Opacity$
 0.90Q�51      $��4q�52      ._�53      �  � ColumnDefinitions 55      �� 57      $	��250 �6'   �� 59      $��* �6'   .+�5=      �� $ 	25,0,0,25��6   $��0��5>        colorTextosBotones#��[ 5?      5@      �� 5C      .+�5D      �� -   5         ��Name$
 Logo��5D   !    �� Orientation$ 
Horizontal=�5E   !   $��35��5F   !   $��
15,25,0,40q�5G   !   .+�5H      �� $��/Resources/gas-icon2.png��6    $��30��5I       �� 5J      $��GESTOR DE REFRIGERANTES��6$    �� TextAlignment$
 Left=�5K   $   #��[  5L   $   $��15(�5M   $   $��Medium"�5N   $   $��Century Gothic)�5O   $   $��18��6@   5Q      �� 5U        botonesMenu#��[ 6   
 � Tag# [ 5V      ��5W      �� *MostrarHomeViewCommand+.��5Y      �� $ 
Horizontal=�6%   .+�5Z      �� $��/Resources/icon_casa.png��6$     menuBotonIcono#��[ 6F   �� 5[      $
��HOME��6(     menuBotonTexto#��[ 64   5\      5]      �� 5`      #��[ 6   # [ 5a      ��5b      �� *MostrarOperariosViewCommand+.��5d      �� $ 
Horizontal=�6%   .+�5e      �� $"��/Resources/icon_operario.png��6$   #��[ 6J   �� 5f      $��	OPERARIOS��6(   #��[ 69   5g      5h      �� 5k      #��[ 6   # [ 5l      ��5m      �� *MostrarOperacionesViewCommand+.��5o      �� $ 
Horizontal=�6%   .+�5p      �� $!��/Resources/gas-cylinder.png��6$   #��[ 6I   �� 5q      $��OPERACIONES��6(   #��[ 6;   5r      5s      �� 5v      #��[ 6   # [ 5w      ��5x      �� *!MostrarRefrigerantesViewCommand+.��5z      �� $ 
Horizontal=�6%   .+�5{      �� $!��/Resources/molecule-co2.png��6$   #��[ 6I   �� 5|      $��REFRIGERANTES��6(   #��[ 6=   5}      5~      �� 5�      #��[ 6   # [ 5�      ��5�      �� *MostrarImpuestosViewCommand+.��5�      �� $ 
Horizontal=�6%   .+�5�      �� $"��/Resources/icon_informes.png��6$   #��[ 6J   �� 5�      $��PCA ACTUALIZADOS��6(   #��[ 6@   5�      5�      5�      �� 5�      $��1��6   $ 	0,25,25,0��5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6,   �� 5�      $��50 �6,   �� 5�      .+�5�      �� -   5        $ control��5�   %   $��0��5�   %   $ 
Horizontal=�5�   %   $��RightToLeft=�5�   %   
������ $��0,0,25,0q�5�   %   .+�5�      �� -   5         ��Name$ CerrarVentana��5�   %   #��[ 5�   %   $��0q�5�   %   $��20��5�   %   $��X��5�   %   #��[  5�   %   $��18(�5�   %   $��Century Gothic)�5�   %    � Cursor$
 Hand��5�   %   5�   %   �� 5�      -   5        $ 	Maximizar��5�   %   #��[ 5�   %   $��0q�5�   %   $��20��5�   %   $	��▢��5�   %   #��[  5�   %   $��18(�5�   %   $��Century Gothic)�5�   %   $
 Hand��5�   %   5�   %   �� 5�      -   5        $ 	Minimizar��5�   %   #��[ 5�   %   $��0q�5�   %   $��20��5�   %   $��-��5�   %   #��[  5�   %   $��18(�5�   %   $��Century Gothic)�5�   %   $
 Hand��5�   %   5�   %   5�      � 5�      $��1��6    5�      �� 5�   "   �� 5�   "   5�      �� 5�      $��1��5�      $ 
Horizontal=�5�      $��Center=�5�      .+�5�      �� $ 25,25,25,25��6&   $��50��5�   %   $��50��5�   %   5�      �� 5�      #��[ 5�   (   $��20(�5�   (   $��Medium"�5�   (   $��Arial)�5�   (   $��Center=�5�   (   $��Center=�5�   (   ��5�   (   �� *Operario.Nombre_DTO+5�      �� 5�      #��[ 5�   (   $��5q�5�   (   $��20(�5�   (   $��Medium"�5�   (   $��Arial)�5�   (   $��Center=�5�   (   $��Center=�5�   (   ��5�   (   �� *Operario.Apellido1_DTO+5�      5�      �� 5�      $��2��5�   )   $��25q�5�   )   ��5�   )   �� *CurrentChildView+5�      5�      5�      5�      5�      5�      5�      