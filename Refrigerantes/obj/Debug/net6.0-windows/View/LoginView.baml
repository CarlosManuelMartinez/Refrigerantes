   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5   	   A%clr-namespace:Refrigerantes.ViewModelRefrigerantes.ViewModel  5   	   I)clr-namespace:Refrigerantes.CustomControlRefrigerantes.CustomControl  5   	   "    Refrigerantes.View.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Refrigerantes.View     5   	   ;	viewModel%clr-namespace:Refrigerantes.ViewModel     5   	   Ccustomcontrol)clr-namespace:Refrigerantes.CustomControl     5   	     � Title$  	LoginView��5
   	   $	��600��6   $	��600��6(    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	   
������  � DataContext 5      ,   &Refrigerantes.ViewModel.LoginViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ Visible�6    �� Mode$ TwoWay=�5       �� 	Converter# [  5      .��5      �� -   5        	 ��Name$	 BordeParaImagen��5      
 �� CornerRadius$
 25��6&   ._�5%   
   �� -   5        $	 BordeLineal��5%      $
 25��5&        
colorFondo#��[ 5'        colorBordes#��[ 5(      $��4q�5)       J� Opacity$
 0.90Q�5*      ._�5,      � -   5         �Name$ GridGeneral��5,       � RowDefinitions 5-      �� 5.      $��30 �6$   �� 5/      .+�51      � -   5        $ BotoneraMinimizaeCerrar��51       � ColumnDefinitions 52      �� 53      �� 54      $��25 �6+   �� 55      $��30 �6+   �� 56      $��25 �6+   .+�58      �� $��LOGIN��6      colorTextosBotones#��[ 59       $��18(�5:       $��Century Gothic)�5;       $��0��5<       $��Center=�5=       $��25,0,0,0q�5>       �� 5?      -   5         ��Name$ 	Minimizar��5?      #��[ 5@      $��0q�5A      $��-��5B      ���#987070$��18(�5D      $��Century Gothic)�5E       � Cursor$
 Hand��5F      $��1��5G      5H      �� 5I      -   5        $ CerrarVentana��5I      #��[ 5J      $��0q�5K      $��X��5L      #��[ 5M      $��18(�5N      $��Century Gothic)�5O      $
 Hand��5P      $��2��5Q      5R      5S      �� 5U      $	��250��6   $��2��5V       �� Orientation$ Vertical=�5W      $��0,35,0,0q�5X      .+�5Y      �� $��GESTOR DE REFRIGERANTES��6    ���#F1E5D1$��18(�5[       $��Century Gothic)�5\       $��Center=�5]       $��Center=�5^       $
��0,10q�5_       �� 5`      $��/Resources/gas-icon2.png��6   $��98��5a      $��97��6'   �� 5b      $
��USER��6    ���#F1E5D1$��18(�5d       $��Century Gothic)�5e       $��Center=�5f       $��
10,10,10,0q�5g       �� 5h      -   5         ��Name$ ComboBoxStaffs��5h      $
��10,0q�5i      $��18(�5j      
��� �����5l      �� $ OperariosObservable� �� SelectedItem 5m      �� $ Operario���5n      �� 5o      .R�5p   "   �� $ 
Horizontal=�6-   .+�5q   &   �  5r   *   �� 5s   .   $��30 �6?   �� 5t   .   �� 5u   .   .+�5x   *   �� $��0,0,5,0q�6Q   $��Center=�6b   $��1��6   ��64   �� *
Nombre_DTO+6   �� 5y   *   $��0,0,5,0q�6T   $��Right=�6e   $��2��6�   ��64   �� *Apellido1_DTO+6�   5z   '   5{   #   5}      5      �� 5�      $��PASSWORD��6    ���#F1E5D1$��18(�5�       $��Century Gothic)�5�       $��Center=�5�       $��
10,20,10,0q�5�       3   -Refrigerantes.CustomControl.PasswordEnlazable  5�         Password	 66   �� *
Password+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�
�� 5�      -   5         ��Name$ tbError��5�       
�������$��18(�5�       $��Century Gothic)�5�       $��Center=�5�       $��
10,20,10,0q�5�       ��5�       �� *MensajeError+$ TwoWay=�$ PropertyChanged=�5�       �� 5�      -	   5        $ btnLogin��5�      $��30��5�      $��10,50q�5�      ���#F1E5D1$��1q�5�      $��LOGIN��5�      ���#987070$��18(�5�      $��Century Gothic)�5�      $
 Hand��5�      ��5�      �� *LoginCommand+5�      5�      5�      5�      5�      5�      