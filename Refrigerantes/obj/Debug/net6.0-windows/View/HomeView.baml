   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Refrigerantes.CustomControlRefrigerantes.CustomControl  5      U QLiveCharts.Wpf, Version=0.9.8.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5      !    Refrigerantes.View.HomeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ccustomcontrol)clr-namespace:Refrigerantes.CustomControl     5      K
livecharts4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      2local clr-namespace:Refrigerantes.View     5      .��5      �    
colorFondo#��[  6     � RowDefinitions  5   
   �� 5      -   5         ��Name$
 row0��5      $	��125 �6*   �� 5      -   5        $
 row1��5      $	��500 �6*   �� 5      -   5        $
 row2��5      $��50 �6*   .+�5   
   �� 
������ 6   � 5   
   $��0��6   
������ $��Center=�5      $��	10,0,10,0q�5       � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5"      .   (Refrigerantes.CustomControl.DatosMuestra  -   5          Name$
 kpi1��5"   )   $��0��67   $	��100��5#   )   $	��5,0q�66      Texto1$ Instalaciones en riesgo��5$   )      Color1$	 Red��5'   )      Color2$ Orange��5(   )      Texto2 5%   )   �� *N_instalacionesEnRiesgo+ �� StringFormat$ {0} instalaciones��	   Texto3	 5&   )   �� *FechaFormateada+5(   )     5+      -   5        $
 kpi2��5+   )   $��1��67   $	��100��5,   )   $	��5,0q�66   $ Instalaciones mas Eco��5-   )   $ 	DarkGreen��50   )   $
 Lime��51   )    5.   )   �� *N_InstalacionesMasEco+$ {0} instalaciones ECO��	 5/   )   �� *FechaFormateada+51   )     54      -   5        $
 kpi3��54   )   $��2��67   $	��100��55   )   $	��5,0q�66   $ Media de CO2��56   )   $
 Blue��59   )   $ 	LightBlue��5:   )    57   )   �� *
MediaCo2+$ {0} Ton de CO2eq��	 58   )   �� *FechaFormateada+5:   )     5=      -   5        $
 kpi4��5=   )   $��3��67   $	��100��5>   )   $	��5,0q�66   $ Operario mas activo��5?   )   $ Purple��5B   )   $ LightSkyBlue��5C   )    5@   )   �� *S_OperarioMasActivo+	 5A   )   �� *FechaFormateada+5C   )   5E      �� 5H   
   -   5        $��	StackName��5H      $��1��6&   $��Stretch=�63   .+�5J      �� -	   5        $��BorderName3��5J      $��1��6(     colorFondo1#��[ 65   � 5M      
������ $��1��6,   $��Stretch=�69    5N      �� 5O      $��* �6'   �� 5P      $��* �6'   .+�5T      �� -
   5        $��	BorderPie��5T      
�������$��0��6=   $��10q�6M   
����  �$��2q�5U   0   $��Stretch=�5V      ._�5W        LiveCharts.Wpf.PieChart  $��10q�5X   *   $	��350��5Y   *   $	��380��5Z   *   &   LiveCharts.Wpf.Charts.Base.Chart
   AnimationsSpeed$
 00:00:00.600h�5[   *      LegendLocation$ Bottom=�5\   *   $��Stretch=�5]   *      Series 5W   *   �� *PieSeriesCollection+5^      5_      �� 5b      -   5        $��BorderName2��5b      
�������$��1��6?   $��10q�6O   
����  �$��2q�5c   0   $��Stretch=�5d      ._�5e      #  LiveCharts.Wpf.CartesianChart  
������ $��10q�5g   0   $	��350��5h   0   $	��380��5i   0   $
 00:00:00.600h�5j   0   $ Bottom=�5k   0   $��Stretch=�5l   0    5e   0   �� *CartesianSeriesCollection+   AxisX 5n        LiveCharts.Wpf.Axis     Title$ Operario��6.      LabelsRotation$ 15Q�5o   .      AxisY 5r        $ Operaciones��6.   $ 15Q�5s   .   5u      5w      5x      5y      �� 5|   
   $��30��5}      $��2��5~       �� Orientation$ 
Horizontal=�5      $��Right=�5�      .+�5�      �� -   5         ��Name$ btNotificar��5�        actionButton#��[ 5�      $��30��5�      $��80��5�      $��5,0,10,0q�5�   9   ��6   �� *NotificarComand+.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��	Notificar��6      actionButtonText#��[ 5�       $��5q�5�       5�      5�      5�      5�      5�      