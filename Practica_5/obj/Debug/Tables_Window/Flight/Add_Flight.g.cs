﻿#pragma checksum "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A57BDBF7E275AF91EE4D6F72F81D0C62E73D0CF8E3174C43A6564CB94C95A8B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_5.Tables_Window.Flight;
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


namespace Practica_5.Tables_Window.Flight {
    
    
    /// <summary>
    /// Add_Flight
    /// </summary>
    public partial class Add_Flight : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox add4;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Adding;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica_5;component/tables_window/flight/add_flight.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
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
            this.add1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.add2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.add3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.add4 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Adding = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
            this.Adding.Click += new System.Windows.RoutedEventHandler(this.Adding_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Tables_Window\Flight\Add_Flight.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

