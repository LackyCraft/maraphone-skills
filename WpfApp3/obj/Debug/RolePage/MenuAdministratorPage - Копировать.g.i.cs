#pragma checksum "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A3AEA7C5AEDB5A792406BF92D7149BD4F8858A4E440D979CBDABFF14EF3678A"
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
using WpfApp3.RolePage;


namespace WpfApp3.RolePage {
    
    
    /// <summary>
    /// RunnerPage
    /// </summary>
    public partial class RunnerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Column1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button infoWorldSkills;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button oldResult;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListCompany;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/rolepage/menuadministratorpage%20-%20%d0%9a%d0%be%d0%bf%d0%b8%" +
                    "d1%80%d0%be%d0%b2%d0%b0%d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
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
            
            #line 25 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Column1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.infoWorldSkills = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
            this.infoWorldSkills.Click += new System.Windows.RoutedEventHandler(this.ScrolPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.oldResult = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
            this.oldResult.Click += new System.Windows.RoutedEventHandler(this.ScrolPage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListCompany = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\RolePage\MenuAdministratorPage - Копировать.xaml"
            this.ListCompany.Click += new System.Windows.RoutedEventHandler(this.ScrolPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

