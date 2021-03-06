#pragma checksum "..\..\EditUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D985DB9C038E1EE0D0AE08910ECE1ED6526E272F54661544F946DE7BD1DC1C12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JewelleryStore;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace JewelleryStore {
    
    
    /// <summary>
    /// EditUser
    /// </summary>
    public partial class EditUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameField;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastnameField;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameField;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordField;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox salaryField;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateSince;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton adminCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/JewelleryStore;component/edituser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditUser.xaml"
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
            this.userLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.nameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lastnameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.usernameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.passwordField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.salaryField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dateSince = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\EditUser.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditUserInfo);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\EditUser.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddUser);
            
            #line default
            #line hidden
            return;
            case 10:
            this.adminCheckBox = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            
            #line 74 "..\..\EditUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

