   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5      E'clr-namespace:Refrigerantes.ValidationsRefrigerantes.Validations  5      *    $Refrigerantes.View.RefrigerantesView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a<
interactiv+http://schemas.microsoft.com/xaml/behaviors  5      ,local clr-namespace:Refrigerantes.View  5      :validaciones'clr-namespace:Refrigerantes.Validations  5        � 	Resources  5         ValidationErrorTemplate ��Name �� Padding��%�  &	        �� 5   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� $ AdornedElement��60   5      �� 5      
�������
���  ��$ 4q�5      $��1,0,1,1q�5      $
��Left=�5      ._�5      �� $
��Left=�6;   ��6#   �� ��5      �� 5      .R�5   "   �� 
���  ����6,   �� *ErrorContent+6J   5      5      5      5       5!      5"      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5$      +  %Microsoft.Xaml.Behaviors.EventTrigger  5%   
      	EventName$ Loaded��6"   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5&      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6-   �� *CargarCommand+5'      .��5*      �� 
������ .+�5+   
   �� $��REFRIGERANTES��6   
�������$��15,0,0,0q�5-      $
��Left=�5.      $��Center=�5/      �� 51   
   -   5        $��Buscador��51      $��0��6#   $��Buscador��52      $��10q�6%     
colorFondo#��[ 53        colorTextosBotones#��[ 54      .��57      �� -   5        $��
tbBuscador��57      $��Right=�6(   $	��300��58      $��5q�59      $��27��5:      ��5;      �� *PalabraClave+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 5=        5>      $ KeyUp��6*   . 5?         65   �� *FiltrarCommand+5@      5B      �� 5E   
   -   5        	 ��Name$	 Refrigerantes��5E      $��Refrigerantes��6+   $��10q�6C   #��[ 6O   #��[ 6x   .��5F      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridRefrigerantes��5F         AutoGenerateColumns$ False��66      CanUserDeleteRows$ false��5H         CanUserAddRows$ False��5I         CanUserResizeRows$ False��5J         CanUserResizeColumns$
 True��5K      $	��200��5L      $��10q�5M         
IsReadOnly$
 True��5O      $   HorizontalScrollBarVisibility$
 Auto=�5P         SelectionMode$ Single=�5Q      ��5G      �� *TablaRefrigerantes+ �� SelectedItem 5N      �� *FilaSeleccionada+ 5S        5T      $ SelectionChanged��6.   . 5U         69   �� *SelectedItemChangedCommand+   CommandParameter 6i   ��  �� ElementName$ DataGridRefrigerantes�� �� Path$ SelectedItem�5V         Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6]      
IsReadOnly$
 True��6j      
Visibility$ Hidden=�6|   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 65   �� $ RefrigeranteId�6|     5\      $ Nombre��6*   $ * 6Z   $
 True��6d    6:   �� $ Nombre�6d     5]      $ Co2Eq��6)   $ * 6W   $
 True��6a    68   �� $ Co2Eq�6a     5^      $ Clase��6)   $ * 6X   $
 True��6b    68   �� $ Clase�6b     5_      $ Grupo��6)   $ * 6X   $
 True��6b    68   �� $ Grupo�6b   4
  .System.Windows.Controls.DataGridTemplateColumn
  5b      $	 100 6-      CanUserResize$ False��69    
  CellTemplate 5c      �� 5d      .R�5e   "   ��  ��Name$ 
ButtonEdit��6)     actionButton#��[ 5f   )   ��5g   )   �� $" DataContext.ModificarCommand�  �� RelativeSource  �� *FindAncestor+! �� AncestorType! UserControl.��5i   &   �� " �� Orientation$" 
Horizontal=�61   .+�5j   *   �� $��	Modificar��64   $��8(�6E   5k   '   5l   #   5m      5o      
  5r      $	 100 6-   $ False��69    5s      �� 5t      .R�5u   "   �� $ ButtonDelete��6)   #��[ 5v   )   ��5w   )   �� $ DataContext.BorrarCommand�  �� *FindAncestor+! UserControl.��5x   &   �� $" 
Horizontal=�61   .+�5y   *   �� $��Eliminar��64   $��8(�6D   5z   '   5{   #   5|      5~      5�      5�      �� 5�   
   -   5        $	 refrigeranteSeleccionado��5�      $��Refrigerante Seleccionado��5�      $��10q�5�      #��[ 6   #��[ 5�      .��5�      � $	��150��6   # � RowDefinitions# 5�      �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   $ � ColumnDefinitions$ 5�      �� 5�      $	��325 �6'   �� 5�      $��* �6'   .+�5�      �� $��Nombre��6   $
��Left=�5�      $��Center=�5�      $��1��5�      $��0��6(   �� 5�      -   5        % ��Name$% tbNombre��5�      $��0��5�      $��0��5�      $��27��5�      $��5q�6&   $	��300��5�      $
��Left=�6&   & =� ErrorTemplate#& [  5�      .��6^   ��5�      �� 5�      $ Nombre�6"   $ PropertyChanged=�60   ' �� ValidationRules' 5�      0   *Refrigerantes.Validations.NombreValidation  5�   "   
(   Min$( 2��6@   
)   Max$) 50��6H   5�      .��5�   $   5�      �� 5�      $��Co2Eq��6   $
��Left=�5�      $��Center=�5�      $��1��5�      $��1��6%   �� 5�      -   5        $% tbCo2Eq��5�      $��1��5�      $��0��5�      $��27��5�      $��5,6,0,5q�6&   $	��300��5�      $
��Left=�6&   #& [  5�      .��6^   ��5�      �� 5�      $ Co2Eq�6"   $ PropertyChanged=�6/   ' 5�        5�   "   $( 3��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Clase��6   $
��Left=�5�      $��Center=�5�      $��2��5�      $��1��6%   �� 5�      -   5        $% tbClase��5�      $��2��5�      $��0��6'   $��27��5�   +   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ Clase�6"   $ PropertyChanged=�6/   ' 5�        5�   "   $( 2��6@   $) 50��6H   5�      .��5�   $   5�      �� 5�      $��Grupo��6   $
��Left=�5�      $��Center=�5�      $��3��5�      $��1��6%   �� 5�      -	   5        $% tbGrupo��5�      $��3��5�      $��0��6'   $��27��5�   +   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ Grupo�6"   $ PropertyChanged=�6/   ' 5�        5�   "   $( 2��6@   $) 50��6H   5�      .��5�   $   5�      5�      5�      �� 5�   
   $��30��6   $" 
Horizontal=�6!   $��Right=�6:   .+�5�      �� -
   5        $ ButtonInsert��5�   ;   #��[ 6   $��30��6Q   $��80��6]   ��6h   �� *GuardarCommand+.��5�      �� $" 
Horizontal=�6   .+�5�      �� $��Insertar��6      actionButtonText#��[ 5�       $��5q�5�       5�      5�      �� 5�      -   5        $ ButtonCancel��5�   ;   #��[ 6   $��30��6Q   $��80��6]   $��5,0,10,0q�6�   ��6h   �� *LimpiarCommand+.��5�      �� $" 
Horizontal=�6   .+�5�      �� $��Borrar campos��6    #��[ 65   $��5q�5�       5�      5�      5�      5�      5�      