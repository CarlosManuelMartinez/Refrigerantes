   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Refrigerantes.ValidationsRefrigerantes.Validations  5      7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5      -    'Refrigerantes.View.OperacionDeCargaView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a<
interactiv+http://schemas.microsoft.com/xaml/behaviors  5      :validaciones'clr-namespace:Refrigerantes.Validations  5      ,local clr-namespace:Refrigerantes.View  5        � 	Resources  5         ValidationErrorTemplate ��Name �� Padding��%�  &	        �� 5   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� $ AdornedElement��60   5      �� 5      
�������
���  ��$ 4q�5      $��1,0,1,1q�5      $
��Left=�5      ._�5      �� $
��Left=�6;   ��6#   �� ��5      �� 5      .R�5   "   �� 
���  ����6,   �� *ErrorContent+6J   5      5      5       5!      5"      5#      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5%      +  %Microsoft.Xaml.Behaviors.EventTrigger  5&   
      	EventName$ Loaded��6"   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5'      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6-   �� *CargarCommand+5(      .��5+      �� 
������ .+�5-   
   �� -   5        $��Buscador��5-      $��0��6#   $��Buscador��5.      $��10q�6%     
colorFondo#��[ 5/        colorTextosBotones#��[ 50      .��52      �� -   5        $��
tbBuscador��52      $��Right=�6(   $	��300��53      $��5q�54      $��27��55      ��56      �� *
Busqueda+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 58        59      $ KeyUp��6*   . 5:         65   �� *FiltrarCommand+5;      5=      �� 5@   
   -   5        	 ��Name$	 Operaciones��5@      $��Operaciones��6)   $��10q�6?   #��[ 6K   #��[ 6t   .��5A      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridOperaciones��5A         AutoGenerateColumns$ False��64      CanUserDeleteRows$ false��5C         CanUserAddRows$ False��5D         CanUserResizeRows$ False��5E         CanUserResizeColumns$
 True��5F      $	��200��5G      $��10q�5H         
IsReadOnly$
 True��5J      $   HorizontalScrollBarVisibility$
 Auto=�5K         SelectionMode$ Single=�5L      ��5B      �� *TablaOperaciones+ �� SelectedItem 5I      �� *FilaSeleccionada+ 5N        5O      $ SelectionChanged��6.   . 5P         69   �� *SelectedItemChangedCommand+   CommandParameter 6i   ��  �� ElementName$ DataGridOperaciones�� �� Path$ SelectedItem�5Q         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Operación��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6d      
IsReadOnly$
 True��6q      
Visibility$ Hidden=�6�   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6?   �� $ OperacionId�6�     5V      $ ID Operario��6)   $	 100 6b   $
 True��6n   $ Hidden=�6�    6>   �� $ 
OperarioId�6�     5W      $ 	ID Equipo��6)   $	 100 6^   $
 True��6j   $ Hidden=�6|    6<   �� $ EquipoId�6|     5X      $ Descripción��6)   $	 100 6d   $
 True��6p   $ Hidden=�6�    6>   �� $ Descripcion�6�     5Y      $ 
Tipo carga��6)   $	 100 6a   $
 True��6m   $ Hidden=�6    6=   �� $ 	TipoCarga�6     5[      $ NºSerie equipo��6)   $	 100 6a   $
 True��6m    6A   �� $ Modelo�6m     5\      $ Operario��6)   $	 100 6]   $
 True��6i    6;   �� $ Operario�6i     5]      $ Fecha��6)   $	 100 6a   $
 True��6m    68   �� $ FechaOperacion�6m     5^      $ Refrigerante Manipulado��6)   $	 200 6{   $
 True��6�    6J   �� $ RefrigeranteManipulado�6�     5_      $ Recuperación��6)   $	 100 6g   $
 True��6s    6?   �� $ IsRecuperacion�6s   4
  .System.Windows.Controls.DataGridTemplateColumn
  5d      $	 100 6-      CanUserResize$ False��69    
  CellTemplate 5e      �� 5f      .R�5g   "   ��  ��Name$ 
ButtonEdit��6)     actionButton#��[ 5h   )   ��5i   )   �� $" DataContext.ModificarCommand�  �� RelativeSource  �� *FindAncestor+! �� AncestorType! UserControl.��5k   &   �� " �� Orientation$" 
Horizontal=�61   .+�5l   *   �� $��	Modificar��64   $��8(�6E   5o   '   5p   #   5q      5s      
  5v      $	 100 6-   $ False��69    5w      �� 5x      .R�5y   "   �� $ ButtonDelete��6)   #��[ 5z   )   ��5{   )   �� $ DataContext.BorrarCommand�  �� *FindAncestor+! UserControl.��5|   &   �� $" 
Horizontal=�61   .+�5}   *   �� $��Eliminar��64   $��8(�6D   5   '   5�   #   5�      5�      5�      5�      5�      5�      