﻿#pragma checksum "..\..\LangWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3AA5BCD5D440A4D2CEFCF1A67F2F757F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MySchool_v2;
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


namespace MySchool_v2 {
    
    
    /// <summary>
    /// LangWnd
    /// </summary>
    public partial class LangWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\LangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUA;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\LangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRU;
        
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
            System.Uri resourceLocater = new System.Uri("/MySchool_v2;component/langwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LangWnd.xaml"
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
            this.imgUA = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\LangWnd.xaml"
            this.imgUA.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\LangWnd.xaml"
            this.imgUA.MouseLeave += new System.Windows.Input.MouseEventHandler(this.imgUA_MouseLeave);
            
            #line default
            #line hidden
            
            #line 25 "..\..\LangWnd.xaml"
            this.imgUA.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgUA_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgRU = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\LangWnd.xaml"
            this.imgRU.MouseEnter += new System.Windows.Input.MouseEventHandler(this.imgRU_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\LangWnd.xaml"
            this.imgRU.MouseLeave += new System.Windows.Input.MouseEventHandler(this.imgRU_MouseLeave);
            
            #line default
            #line hidden
            
            #line 26 "..\..\LangWnd.xaml"
            this.imgRU.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgRU_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

