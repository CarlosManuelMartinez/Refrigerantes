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
������ .+�5+   
   �� $��	OPERARIOS��6   
�������$��15,0,0,0q�5-      $
��Left=�5.      $��Center=�5/      �� 51   
   -   5        $��Buscador��51      $��0��6#   $��Buscador��52      $��10q�6%     
colorFondo#��[ 53        colorTextosBotones#��[ 54      .��56      �� -   5        $��
tbBuscador��56      $��Right=�6(   $	��300��57      $��5q�58      $��27��59      ��5:      �� *
Busqueda+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 5<        5=      $ KeyUp��6*   . 5>         65   �� *FiltrarCommand+5?      5A      �� 5D   
   -   5        	 ��Name$	 	Operarios��5D      $��	Operarios��6'   $��10q�6;   #��[ 6G   #��[ 6p   .��5E      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridOperarios��5E         AutoGenerateColumns$ False��62      CanUserDeleteRows$ false��5G         CanUserAddRows$ False��5H         CanUserResizeRows$ False��5I         CanUserResizeColumns$
 True��5J      $	��200��5K      $��10q�5L         
IsReadOnly$
 True��5N      $   HorizontalScrollBarVisibility$
 Auto=�5O         SelectionMode$ Single=�5P      ��5F      �� *TablaOperarios+ �� SelectedItem 5M      �� *FilaSeleccionada+ 5R        5S      $ SelectionChanged��6.   . 5T         69   �� *SelectedItemChangedCommand+   CommandParameter 6i   ��  �� ElementName$ DataGridOperarios�� �� Path$ SelectedItem�5U         Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Y      
IsReadOnly$
 True��6f      
Visibility$ Hidden=�6x   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 65   �� $ 
OperarioId�6x     5Z      $ Email��6)   $	 150 6X   $
 True��6d   $ Hidden=�6v    68   �� $ Email�6v     5[      $ Password��6)   $	 150 6^   $
 True��6j   $ Hidden=�6|    6;   �� $ Password�6|     5\      $	 Dni��6)   $	 110 6S   $
 True��6_   $ Hidden=�6q    66   �� $	 Dni�6q     5`      $ Nombre��6)   $ * 6Y   $
 True��6c    69   �� $ Nombre�6c     5a      $ Primer Apellido��6)   $ * 6e   $
 True��6o    6B   �� $ 	Apellido1�6o     5b      $ Segundo Apellido��6)   $ * 6g   $
 True��6q    6C   �� $ 	Apellido2�6q     5c      $ Puesto��6)   $ * 6h   $
 True��6r    69   �� $ CategoriaProfesional�6r     5d      $ CategoriaId��6)   $ * 6l   $
 True��6v    6>   �� $ CategoriaProfesional�6v   4
  .System.Windows.Controls.DataGridTemplateColumn
  5h      $	 100 6-      CanUserResize$ False��69    
  CellTemplate 5i      �� 5j      .R�5k   "   ��  ��Name$ 
ButtonEdit��6)     actionButton#��[ 5l   )   ��5m   )   �� $" DataContext.ModificarCommand�  �� RelativeSource  �� *FindAncestor+! �� AncestorType! UserControl.��5o   &   �� " �� Orientation$" 
Horizontal=�61   .+�5p   *   �� $��	Modificar��64   $��8(�6E   5s   '   5t   #   5u      5w      
  5z      $	 100 6-   $ False��69    5{      �� 5|      .R�5}   "   �� $ ButtonDelete��6)   #��[ 5~   )   ��5   )   �� $ DataContext.BorrarCommand�  �� *FindAncestor+! UserControl.��5�   &   �� $" 
Horizontal=�61   .+�5�   *   �� $��Eliminar��64   $��8(�6D   5�   '   5�   #   5�      5�      5�      5�      �� 5�   
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
��Left=�68   $��Center=�6S   $��5��6u   $��1��6�   �� 5�      -   5        * ��Name$* cbCategoriaProfesional��5�      $��5��5      $��0��5     $��5q�5     $	��300��5     $
��Left=�5     $��27��5     + �� DisplayMemberPath$+ CategoriaProfesional1��5     ��5     �� $ 
Categorias� 5     �� $ CategoriaSeleccionada�5	     5
     5     �� 5  
   $��30��6   $" 
Horizontal=�6!   $��Right=�6:   .+�5     �� -   5        $ ButtonInsert��5  ;   #��[ 6   $��30��6Q   $��80��6]   ��6h   �� *GuardarCommand+.��5     �� $" 
Horizontal=�6   .+�5     �� $��Insertar��6      actionButtonText#��[ 5      $��5q�5      5     5     �� 5     -   5        $ ButtonCancel��5  ;   #��[ 6   $��30��6Q   $��80��6]   $��5,0,10,0q�6�   ��6h   �� *LimpiarCommand+.��5     �� $" 
Horizontal=�6   .+�5     �� $��Borrar campos��6    #��[ 65   $��5q�5      5     5     5     5     5     