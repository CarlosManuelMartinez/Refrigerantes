﻿#pragma checksum "..\..\..\..\View\VentanaPrincipalView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3BDF08CE0CFCCBCBB4D730EF0A64D87E4411F49E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Refrigerantes.View;
using Refrigerantes.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Refrigerantes.View {
    
    
    /// <summary>
    /// VentanaPrincipalView
    /// </summary>
    public partial class VentanaPrincipalView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BordeParaImagen;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BordeLineal;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Logo;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel control;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CerrarVentana;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Maximizar;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\View\VentanaPrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimizar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Refrigerantes;component/view/ventanaprincipalview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\VentanaPrincipalView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\View\VentanaPrincipalView.xaml"
            ((Refrigerantes.View.VentanaPrincipalView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BordeParaImagen = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.BordeLineal = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.Logo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.control = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.CerrarVentana = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\View\VentanaPrincipalView.xaml"
            this.CerrarVentana.Click += new System.Windows.RoutedEventHandler(this.btnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Maximizar = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\..\View\VentanaPrincipalView.xaml"
            this.Maximizar.Click += new System.Windows.RoutedEventHandler(this.Maximizar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Minimizar = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\..\..\View\VentanaPrincipalView.xaml"
            this.Minimizar.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

