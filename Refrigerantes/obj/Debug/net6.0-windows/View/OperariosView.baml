   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Refrigerantes.ValidationsRefrigerantes.Validations  5      &     Refrigerantes.View.OperariosView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a<
interactiv+http://schemas.microsoft.com/xaml/behaviors  5      :validaciones'clr-namespace:Refrigerantes.Validations  5        � 	Resources  5         ValidationErrorTemplate ��Name �� Padding��%�  &	        �� 5   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� $ AdornedElement��60   5      �� 5      
�������
���  ��$ 4q�5      $��1,0,1,1q�5      $
��Left=�5      ._�5      �� $
��Left=�6;   ��6#   �� ��5      �� 5      .R�5   "   �� 
���  ����6,   �� *ErrorContent+6J   5      5      5      5       5!      5"      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5$      +  %Microsoft.Xaml.Behaviors.EventTrigger  5%   
      	EventName$ Loaded��6"   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5&      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6-   �� *CargarCommand+5'      .��5*      �� 
������ .+�5-   
   �� -   5        $��Buscador��5-      $��0��6#   $��Buscador��5.      $��10q�6%     
colorFondo#��[ 5/        colorTextosBotones#��[ 50      .��52      �� -   5        $��
tbBuscador��52      $��Right=�6(   $	��300��53      $��5q�54      $��27��55      ��56      �� *
Busqueda+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 58        59      $ KeyUp��6*   . 5:         65   �� *FiltrarCommand+5;      5=      �� 5@   
   -   5        	 ��Name$	 	Operarios��5@      $��	Operarios��6'   $��10q�6;   #��[ 6G   #��[ 6p   .��5A      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridOperarios��5A         AutoGenerateColumns$ False��62      CanUserDeleteRows$ false��5C         CanUserAddRows$ False��5D         CanUserResizeRows$ False��5E         CanUserResizeColumns$
 True��5F      $	��200��5G      $��10q�5H         
IsReadOnly$
 True��5J      $   HorizontalScrollBarVisibility$
 Auto=�5K         SelectionMode$ Single=�5L      ��5B      �� *TablaOperarios+ �� SelectedItem 5I      �� *FilaSeleccionada+ 5N        5O      $ SelectionChanged��6.   . 5P         69   �� *SelectedItemChangedCommand+   CommandParameter 6i   ��  �� ElementName$ DataGridOperarios�� �� Path$ SelectedItem�5Q         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6Y      
IsReadOnly$
 True��6f      
Visibility$ Hidden=�6x   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 65   �� $ 
OperarioId�6x     5V      $ Nombre��6)   $	 200 6Y   $
 True��6e    69   �� $ Nombre�6e     5W      $ Primer Apellido��6)   $	 200 6e   $
 True��6q    6B   �� $ 	Apellido1�6q     5X      $ Segundo Apellido��6)   $	 200 6g   $
 True��6s    6C   �� $ 	Apellido2�6s     5Y      $ Email��6)   $	 200 6X   $
 True��6d   $ Hidden=�6v    68   �� $ Email�6v     5Z      $ Password��6)   $	 200 6^   $
 True��6j   $ Hidden=�6|    6;   �� $ Password�6|     5[      $	 Dni��6)   $	 200 6S   $
 True��6_    66   �� $	 Dni�6_     5\      $ Puesto��6)   $
 auto 6h   $
 True��6u    69   �� $ CategoriaProfesional�6u     5]      $ CategoriaId��6)   $
 auto 6c   $
 True��6p    6>   �� $ CategoriaId�6p   4
  .System.Windows.Controls.DataGridTemplateColumn
  5a      $	 100 6-      CanUserResize$ False��69    
  CellTemplate 5b      �� 5c      .R�5d   "   ��  ��Name$ 
ButtonEdit��6)     actionButton#��[ 5e   )   ��5f   )   �� $" DataContext.ModificarCommand�  �� RelativeSource  �� *FindAncestor+! �� AncestorType! UserControl.��5h   &   �� " �� Orientation$" 
Horizontal=�61   .+�5i   *   �� $��	Modificar��64   $��8(�6E   5l   '   5m   #   5n      5p      
  5s      $	 100 6-   $ False��69    5t      �� 5u      .R�5v   "   �� $ ButtonDelete��6)   #��[ 5w   )   ��5x   )   �� $ DataContext.BorrarCommand�  �� *FindAncestor+! UserControl.��5y   &   �� $" 
Horizontal=�61   .+�5z   *   �� $��Eliminar��64   $��8(�6D   5|   '   5}   #   5~      5�      5�      5�      �� 5�   
   -   5        $	 operarioSeleccionado��5�      $��Operario Seleccionado��5�      $��10q�5�      #��[ 6   #��[ 5�      .��5�      � $	��250��6   # � RowDefinitions# 5�      �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   $ � ColumnDefinitions$ 5�      �� 5�      $	��325 �6'   �� 5�      $��* �6'   .+�5�      �� $	��Dni��6   $
��Left=�5�      $��Center=�5�      $��1��5�      $��0��6(   �� 5�      -   5        % ��Name$% tbDni��5�      $��0��5�      $��0��5�      $��27��5�      $��5q�6&   $	��300��5�      $
��Left=�6&   & =� ErrorTemplate#& [  5�      .��6^   ��5�      �� 5�      $	 Dni�6"   $ PropertyChanged=�6-   ' �� ValidationRules' 5�      0   *Refrigerantes.Validations.NombreValidation  5�   "   
(   Min$( 3��6@   
)   Max$) 50��6H   5�      .��5�   $   5�      �� 5�      $��Nombre��6   $
��Left=�5�      $��Center=�5�      $��1��5�      $��1��6%   �� 5�      -   5        $% tbNombre��5�      $��1��5�      $��0��5�      $��27��5�      $��5,6,0,5q�6&   $	��300��5�      $
��Left=�6&   #& [  5�      .��6^   ��5�      �� 5�      $ Nombre�6"   $ PropertyChanged=�60   ' 5�        5�   "   $( 3��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Primer Apellido��6   $
��Left=�5�      $��Center=�5�      $��2��5�      $��1��6%   �� 5�      -   5        $% 
tbApellido��5�      $��2��5�      $��0��6'   $��27��5�   .   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ 	Apellido1�6"   $ PropertyChanged=�63   ' 5�        5�   "   $( 3��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Segundo Apellido��6   $
��Left=�5�      $��Center=�5�      $��3��5�      $��1��6%   �� 5�      -	   5        $% tbApellido2��5�      $��3��5�      $��0��6'   $��27��5�   /   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ 	Apellido2�6"   $ PropertyChanged=�63   ' 5�        5�   "   $( 3��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Email��6   $
��Left=�5�      $��Center=�5�      $��4��5�      $��1��6%   �� 5�      -
   5        $% tbEmail��5�      $��4��5�      $��0��6'   $��27��5�   +   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ Email�6"   $ PropertyChanged=�6/   ' 5�        5�   "   $( 3��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Categoria Profesional��6   $
��Left=�68   $��Center=�6S   $��5��6u   $��1��6�   �� 5�      -   5        * ��Name$* cbCategoriaProfesional��5�      $��5��5�      $��0��5�      $��5q�5�      $	��300��5�      $
��Left=�5�      $��27��5�      + �� DisplayMemberPath$+ CategoriaProfesional1��5     ��5�      �� $ 
Categorias� 5      �� $ CategoriaSeleccionada�5     5     5     �� 5  
   $��30��6   $" 
Horizontal=�6!   $��Right=�6:   .+�5     �� -   5        $ ButtonInsert��5  ;   #��[ 6   $��30��6Q   $��80��6]   ��6h   �� *GuardarCommand+.��5	     �� $" 
Horizontal=�6   .+�5
     �� $��Insertar��6      actionButtonText#��[ 5      $��5q�5      5     5     �� 5     -   5        $ ButtonCancel��5  ;   #��[ 6   $��30��6Q   $��80��6]   $��5,0,10,0q�6�   ��6h   �� *LimpiarCommand+.��5     �� $" 
Horizontal=�6   .+�5     �� $��Borrar campos��6    #��[ 65   $��5q�5      5     5     5     5     5     