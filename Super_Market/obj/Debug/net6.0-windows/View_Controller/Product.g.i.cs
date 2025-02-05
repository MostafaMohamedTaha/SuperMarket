﻿#pragma checksum "..\..\..\..\View_Controller\Product.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F06F8A17DA6B71D3C776CFA3B2C85C099DF3B74"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Super_Market;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Super_Market {
    
    
    /// <summary>
    /// Product
    /// </summary>
    public partial class Product : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CateogryCB;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SupplierCB;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker prodDate;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker expireDate;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPurchasing;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtselling;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\View_Controller\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Super_Market;component/view_controller/product.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View_Controller\Product.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CateogryCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\View_Controller\Product.xaml"
            this.CateogryCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SupplierCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.prodDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.expireDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            
            #line 77 "..\..\..\..\View_Controller\Product.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 78 "..\..\..\..\View_Controller\Product.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\..\..\View_Controller\Product.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtPurchasing = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\..\..\View_Controller\Product.xaml"
            this.txtPurchasing.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtPurchasing_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtselling = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\..\View_Controller\Product.xaml"
            this.txtselling.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtselling_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 11:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 94 "..\..\..\..\View_Controller\Product.xaml"
            this.datagrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

