   M S B A M L   `   `   `  ����H  DRefrigerantes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Refrigerantes.ViewRefrigerantes.View  5           Refrigerantes.View.PcaView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a<
interactiv+http://schemas.microsoft.com/xaml/behaviors  5      ,local clr-namespace:Refrigerantes.View  5      .��5      �� .+�5   
   �� $��15(�5      $
��Bold"�5      $
��Left=�5      $��
10,100,0,0q�5         
colorFondo#��[  6)     colorTextosBotones#��[ 6R   ��5      �� *FechaFormateada+5   R   �� 5   
   -   5          ��Name$	  PCA��5      $��PCA e Impuestos��6!   $��10q�6<   #��[  6H   #��[ 6q   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridOperarios��5         AutoGenerateColumns$ False��62      CanUserDeleteRows$ false��5         CanUserAddRows$ False��5         CanUserResizeRows$ False��5         CanUserResizeColumns$ False��5      $��10q�5         
IsReadOnly$
 True��5      $   HorizontalScrollBarVisibility$
 Auto=�5      	   SelectionMode$	 Single=�5      ��5      �� *TablaImpuestos+
   Columns
 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ IdRefrigerante��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5"   E      
IsReadOnly$
 True��6O      
Visibility$ Hidden=�6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ id�6a     5#      $ Gas Refrigerante��6)   $ * 5$   I   $
 True��6S    6)   �� $ nombre�6S     5%      $3 -PCA (Potencial de Calentamiento Atmosférico)��6)   $ * 5&   F   $
 True��6P    6)   �� $	 pca�6P     5'      $ Impuesto por Kg��6)   $ * 5(   K   $
 True��6U    6)   �� $ impuesto�6U   5+      5,      5-      5.      