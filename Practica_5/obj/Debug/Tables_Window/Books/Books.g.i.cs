﻿#pragma checksum "..\..\..\..\Tables_Window\Books\Books.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C0101CC1159F930A6CD23F74834F04CDB65E0E2914CB0241A682E5DA8ED36111"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_5.Tables_Window.Books;
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


namespace Practica_5.Tables_Window.Books {
    
    
    /// <summary>
    /// Books
    /// </summary>
    public partial class Books : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Tables_Window\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del_Button;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Tables_Window\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Button;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Tables_Window\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chn_Button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Tables_Window\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Book_Grid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Tables_Window\Books\Books.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Practica_5;component/tables_window/books/books.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Tables_Window\Books\Books.xaml"
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
            
            #line 21 "..\..\..\..\Tables_Window\Books\Books.xaml"
            this.Del_Button.Click += new System.Windows.RoutedEventHandler(this.Del_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Tables_Window\Books\Books.xaml"
            this.Add_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Chn_Button = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Tables_Window\Books\Books.xaml"
            this.Chn_Button.Click += new System.Windows.RoutedEventHandler(this.Chn_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Book_Grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\Tables_Window\Books\Books.xaml"
            this.Book_Grid.CurrentCellChanged += new System.EventHandler<System.EventArgs>(this.Book_Grid_CurrentCellChanged);
            
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

