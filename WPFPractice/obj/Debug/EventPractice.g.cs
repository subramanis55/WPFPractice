﻿#pragma checksum "..\..\EventPractice.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1FDB33C3FBC32850DB6E2596E5A47171AB54E2DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPFPractice;


namespace WPFPractice {
    
    
    /// <summary>
    /// EventPractice
    /// </summary>
    public partial class EventPractice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/WPFPractice;component/eventpractice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EventPractice.xaml"
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
            
            #line 10 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter_4);
            
            #line default
            #line hidden
            
            #line 10 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BorderOne);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter_3);
            
            #line default
            #line hidden
            
            #line 11 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BorderTwo);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter_2);
            
            #line default
            #line hidden
            
            #line 12 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BorderThree);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 13 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BorderFour);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BorderFive);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 15 "..\..\EventPractice.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

