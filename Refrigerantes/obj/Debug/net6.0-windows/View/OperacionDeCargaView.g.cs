﻿#pragma checksum "..\..\..\..\View\OperacionDeCargaView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C9DD412B60E173BFD7802A0DE73ABEC01F8D6D19"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Refrigerantes.Validations;
using Refrigerantes.View;
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
    /// OperacionDeCargaView
    /// </summary>
    public partial class OperacionDeCargaView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Buscador;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBuscador;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Operaciones;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridOperaciones;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox operacionSeleccionada;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescripcion;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTipo;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaOperacionDatePicker;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRefrigeranteManipulado;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEquipos;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOperarios;
        
        #line default
        #line hidden
        
        
        #line 288 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonInsert;
        
        #line default
        #line hidden
        
        
        #line 298 "..\..\..\..\View\OperacionDeCargaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Refrigerantes;component/view/operaciondecargaview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\OperacionDeCargaView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Buscador = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.tbBuscador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Operaciones = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 4:
            this.DataGridOperaciones = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.operacionSeleccionada = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.tbDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbTipo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.FechaOperacionDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.tbRefrigeranteManipulado = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.cbEquipos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.cbOperarios = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.ButtonInsert = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

