﻿#pragma checksum "..\..\SignUpPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B35BE99891F82CFBB0289359A849EF69891F1653"
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
    /// SignUpPage
    /// </summary>
    public partial class SignUpPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmailTextBoxPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewPasswordBoxPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ConfirmPasswordBoxPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\SignUpPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid left;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFPractice;component/signuppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SignUpPage.xaml"
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
            
            #line 29 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EmailBorderMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\SignUpPage.xaml"
            this.EmailTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.EmailTextBoxLostFocus);
            
            #line default
            #line hidden
            
            #line 31 "..\..\SignUpPage.xaml"
            this.EmailTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.EmailTextBoxGotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmailTextBoxPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 48 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NewPasswordBorderMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NewPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 50 "..\..\SignUpPage.xaml"
            this.NewPasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.NewPasswordBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 50 "..\..\SignUpPage.xaml"
            this.NewPasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.NewPasswordBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NewPasswordBoxPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 67 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ConfirmBorderMouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ConfirmPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 69 "..\..\SignUpPage.xaml"
            this.ConfirmPasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.ConfirmPasswordGotFocus);
            
            #line default
            #line hidden
            
            #line 69 "..\..\SignUpPage.xaml"
            this.ConfirmPasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.ConfirmPasswordLostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ConfirmPasswordBoxPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 76 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.left = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            
            #line 91 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseBtnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 103 "..\..\SignUpPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

