﻿#pragma checksum "..\..\RegistrationRunner.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505CAE145BDEBFD67998D4517D594D1D94C38548"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// RegisterRunner
    /// </summary>
    public partial class RegisterRunner : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Column1;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pass;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox DoublePass;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox boxGender;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Register;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFotoName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image fotoRunner;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxCountrty;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\RegistrationRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DataOfBrith;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/registrationrunner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegistrationRunner.xaml"
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
            
            #line 26 "..\..\RegistrationRunner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Column1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.DoublePass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.boxGender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\RegistrationRunner.xaml"
            this.boxGender.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Gender_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Register = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\RegistrationRunner.xaml"
            this.Register.Click += new System.Windows.RoutedEventHandler(this.btnRegister);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 73 "..\..\RegistrationRunner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBoxFotoName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 89 "..\..\RegistrationRunner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.selectedFoto);
            
            #line default
            #line hidden
            return;
            case 13:
            this.fotoRunner = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            this.comboBoxCountrty = ((System.Windows.Controls.ComboBox)(target));
            
            #line 95 "..\..\RegistrationRunner.xaml"
            this.comboBoxCountrty.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Countrty_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.DataOfBrith = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

