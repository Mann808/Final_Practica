﻿#pragma checksum "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86ED741C985EBAED52FAAD9AB7F270FF07B6C2588EF97C49D1BC2BAEA2835DCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_5.Tables_Window.Adult_passengers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace Practica_5.Tables_Window.Adult_passengers {
    
    
    /// <summary>
    /// Adult_Pas
    /// </summary>
    public partial class Adult_Pas : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del_Button;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Button;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chn_Button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Ad_Pas_Grid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Add;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Practica_5;component/tables_window/adult%20passengers/adult_pas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Del_Button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
            this.Del_Button.Click += new System.Windows.RoutedEventHandler(this.Del_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
            this.Add_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Chn_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Ad_Pas_Grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\Tables_Window\Adult passengers\Adult_Pas.xaml"
            this.Ad_Pas_Grid.CurrentCellChanged += new System.EventHandler<System.EventArgs>(this.Grid_CurrentCellChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

