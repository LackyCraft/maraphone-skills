#pragma checksum "..\..\BMRcalculator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFBC1585FBD9AC390AA7CCFC805A7385460EAE85508B45411447D230256000B8"
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
    /// BMRcalculator
    /// </summary>
    public partial class BMRcalculator : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button female;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button male;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox height;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox weight;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockBMR;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockSit;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockMin;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPol;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockSil;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\BMRcalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockMax;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/bmrcalculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BMRcalculator.xaml"
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
            
            #line 25 "..\..\BMRcalculator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            case 2:
            this.female = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\BMRcalculator.xaml"
            this.female.Click += new System.Windows.RoutedEventHandler(this.ButtonGender);
            
            #line default
            #line hidden
            return;
            case 3:
            this.male = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\BMRcalculator.xaml"
            this.male.Click += new System.Windows.RoutedEventHandler(this.ButtonGender);
            
            #line default
            #line hidden
            return;
            case 4:
            this.height = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 92 "..\..\BMRcalculator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TextBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlockBMR = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 114 "..\..\BMRcalculator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonInfo);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBlockSit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.textBlockMin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.textBlockPol = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.textBlockSil = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.textBlockMax = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

