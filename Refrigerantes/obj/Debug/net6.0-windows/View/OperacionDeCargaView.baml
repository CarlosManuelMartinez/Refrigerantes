   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Refrigerantes.ValidationsRefrigerantes.Validations  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5	      -    'Refrigerantes.View.OperacionDeCargaView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a<
interactiv+http://schemas.microsoft.com/xaml/behaviors  5      :validaciones'clr-namespace:Refrigerantes.Validations  5      0sys&clr-namespace:System;assembly=mscorlib  5      ,local clr-namespace:Refrigerantes.View  5	        � 	Resources  5         ValidationErrorTemplate ��Name �� Padding��%�  &	        �� 5   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� $ AdornedElement��60   5      �� 5      
�������
���  ��$ 4q�5      $��1,0,1,1q�5      $
��Left=�5      ._�5      �� $
��Left=�6;   ��6#   �� ��5      �� 5      .R�5   "   �� 
���  ����6,   �� *ErrorContent+6J   5      5       5!      5"      5#      5$      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5&      +  %Microsoft.Xaml.Behaviors.EventTrigger  5'   
      	EventName$ Loaded��6"   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5(      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6-   �� *CargarCommand+5)      .��5,      �� 
������ .+�5-   
   �� $��OPERACIONES��6   
�������$��15,0,0,0q�5/      $
��Left=�50      $��Center=�51      �� 53   
   -   5        $��Buscador��53      $��0��6#   $��Buscador��54      $��10q�6%     
colorFondo#��[ 55        colorTextosBotones#��[ 56      .��58      �� -   5        $��
tbBuscador��58      $��Right=�6(   $	��300��59      $��5q�5:      $��27��5;      ��5<      �� *PalabraClave+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 5>        5?      $ KeyUp��6*   . 5@         65   �� *FiltrarCommand+5A      5C      �� 5F   
   -   5        	 ��Name$	 Operaciones��5F      $��Operaciones��6)   $��10q�6?   #��[ 6K   #��[ 6t   .��5G      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridOperaciones��5G         AutoGenerateColumns$ False��64      CanUserDeleteRows$ false��5I         CanUserAddRows$ False��5J         CanUserResizeRows$ False��5K         CanUserResizeColumns$
 True��5L      $	��200��5M      $��10q�5N         
IsReadOnly$
 True��5P      $   HorizontalScrollBarVisibility$
 Auto=�5Q         SelectionMode$ Single=�5R      ��5H      �� *TablaOperaciones+ �� SelectedItem 5O      �� *FilaSeleccionada+ 5T        5U      $ SelectionChanged��6.   . 5V         69   �� *SelectedItemChangedCommand+   CommandParameter 6i   ��  �� ElementName$ DataGridOperaciones�� �� Path$ SelectedItem�5W         Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Operación��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6d      
IsReadOnly$
 True��6q      
Visibility$ Hidden=�6�   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6?   �� $ OperacionId�6�     5\      $ ID Operario��6)   $	 100 6b   $
 True��6n   $ Hidden=�6�    6>   �� $ 
OperarioId�6�     5]      $ 	ID Equipo��6)   $	 100 6^   $
 True��6j   $ Hidden=�6|    6<   �� $ EquipoId�6|     5^      $ Descripción��6)   $	 100 6d   $
 True��6p   $ Hidden=�6�    6>   �� $ Descripcion�6�     5_      $ 
Tipo carga��6)   $	 100 6a   $
 True��6m   $ Hidden=�6    6=   �� $ 	TipoCarga�6     5a      $ NºSerie equipo��6)   $ * 6a   $
 True��6k    6A   �� $ Modelo�6k     5b      $ Operario��6)   $ * 6]   $
 True��6g    6;   �� $ Operario�6g     5c      $ Fecha��6)   $ * 6a   $
 True��6k    68   �� $ FechaOperacion�6k     5d      $ Refrigerante Manipulado��6)   $ * 6{   $
 True��6�    6J   �� $ RefrigeranteManipulado�6�     5e      $ Recuperación��6)   $ * 6g   $
 True��6q    6?   �� $ IsRecuperacion�6q   4
  .System.Windows.Controls.DataGridTemplateColumn
  5j      $	 100 6-      CanUserResize$ False��69    
  CellTemplate 5k      �� 5l      .R�5m   "   ��  ��Name$ 
ButtonEdit��6)     actionButton#��[ 5n   )   ��5o   )   �� $" DataContext.ModificarCommand�  �� RelativeSource  �� *FindAncestor+! �� AncestorType! UserControl.��5q   &   �� " �� Orientation$" 
Horizontal=�61   .+�5r   *   �� $��	Modificar��64   $��8(�6E   5u   '   5v   #   5w      5y      5�      5�      �� 5�   
   -   5        $	 operacionSeleccionada��5�      $��Operacion Seleccionada��5�      $��10q�5�      #��[ 6   #��[ 5�      .��5�      � $	��250��6   # � RowDefinitions# 5�      �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   �� 5�      $��1* �6$   $ � ColumnDefinitions$ 5�      �� 5�      $	��325 �6'   �� 5�      $��* �6'   .+�5�      �� $��Breve Descripcion��6   $
��Left=�5�      $��Center=�5�      $��1��5�      $��0��6(   �� 5�      -   5        % ��Name$% tbDescripcion��5�      $��0��5�      $��0��5�      $��27��5�      $��5q�6&   $	��300��5�      $
��Left=�6&   & =� ErrorTemplate#& [  5�      .��6^   ��5�      �� 5�      $ Descripcion�6"   $ PropertyChanged=�65   ' �� ValidationRules' 5�      0   *Refrigerantes.Validations.NombreValidation  5�   "   
(   Min$( 3��6@   
)   Max$) 50��6H   5�      .��5�   $   5�      �� 5�      $��Tipo de Operacion��6   $
��Left=�64   $��Center=�6O   $��1��6q   $��1��6~   �� 5�      -   5        * ��Name$* cbTipo��5�      $��1��5�      $��0��5�      $��5q�5�      $	��300��5�      $
��Left=�5�      $��27��5�      + �� DisplayMemberPath$+ Value��5�      ��5�      �� $ TiposDeCarga� 5�      �� $ TipoSeleccionado�$ TwoWay=�5�      �� 5�      $��Fecha��6   $
��Left=�5�      $��Center=�5�      $��2��5�      $��1��6%   (  "System.Windows.Controls.DatePicker  5�      -   5        $��FechaOperacionDatePicker��5�      $��5,6,0,5q�5�      $	��300��6&   $
��Left=�5�      $��Center=�5�      $��2��5�      $��0��6"   ,   DisplayDateEnd, 
12/31/20255�      - �� Today.   DisplayDateStart#. Z- 5�      /   IsTodayHighlighted$
/ True��5�      0   SelectedDate0 5�      �� *FechaOperacion+$ TwoWay=�5�      �� 5�      $��Refrigerante Manipulado��6   $
��Left=�5�      $��Center=�5�      $��3��5�      $��1��6%   �� 5�      -	   5        $% tbRefrigeranteManipulado��5�      $��3��5�      $��0��6'   $��27��5�   <   $��5,6,0,5q�5�      $	��300��6+   $
��Left=�5�      #& [  5�      .��6^   ��5�      �� 5�      $ RefrigeranteManipulado�6"   $ PropertyChanged=�6@   ' 5�      /   )Refrigerantes.Validations.CargaValidation  5�   "   5�      .��5�   $   5�      �� 5�      $��Equipo��6   $
��Left=�6)   $��Center=�6D   $��4��6f   $��1��6s   �� 5�      -
   5        $* 	cbEquipos��5�      $��4��5      $��0��5     $��5q�5     $	��300��5     $
��Left=�5     $��27��5     $+ Modelo��5     ��5     �� $ Equipos� 5     �� $ EquipoSeleccionado�5	     �� 5     $��Operario��6   $
��Left=�6+   $��Center=�6F   $��5��6h   $��1��6u   �� 5     -   5        $* cbOperarios��5     $��5��5     $��0��5     $��5q�5     $	��300��5     $
��Left=�5     $��27��5     $+ 
Nombre_DTO��5     ��5     �� $ 	Operarios� 5     �� $ OperarioSeleccionado�5     5     5     �� 5  
   $��30��6   $" 
Horizontal=�5     $��Right=�5     .+�5     �� -   5        $ ButtonInsert��5      #��[ 5     $��30��5!     $��80��6!   ��5"     �� *GuardarCommand+.��5#     �� $" 
Horizontal=�6   .+�5$     �� $��Insertar��6      actionButtonText#��[ 5%      $��5q�5&      5'     5(     �� 5)     -   5        $ ButtonCancel��5*     #��[ 5)     $��30��5+     $��80��5,     $��5,0,10,0q�5-  8   ��6   �� *LimpiarCommand+.��5.     �� $" 
Horizontal=�6   .+�5/     �� $��Borrar campos��6    #��[ 50      $��5q�51      52     53     54     56     58     