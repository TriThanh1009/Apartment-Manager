﻿#pragma checksum "..\..\..\..\..\View\People\Home.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8BED11B86899078D81AA8835D6E8D0D16EA0D550"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AM.UI.Converters;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using System.Windows.Interactivity;
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


namespace AM.UI.View.People {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblock;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel main;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid homedata;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pagingLeft;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pagingbutton;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\..\View\People\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pagingRight;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AM.UI;component/view/people/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\People\Home.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\..\..\View\People\Home.xaml"
            this.txtSearch.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtSearch_MouseEnter);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\..\..\View\People\Home.xaml"
            this.txtSearch.MouseLeave += new System.Windows.Input.MouseEventHandler(this.txtSearch_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.main = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.homedata = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.pagingLeft = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\..\View\People\Home.xaml"
            this.pagingLeft.Click += new System.Windows.RoutedEventHandler(this.Button_page);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pagingbutton = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.pagingRight = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\..\View\People\Home.xaml"
            this.pagingRight.Click += new System.Windows.RoutedEventHandler(this.Button_page);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

