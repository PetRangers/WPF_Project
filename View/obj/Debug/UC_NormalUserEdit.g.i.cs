﻿#pragma checksum "..\..\UC_NormalUserEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E1BE7BDC01381C058BF398CC838D51A"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
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
using View;


namespace View {
    
    
    /// <summary>
    /// UC_NormalUserEdit
    /// </summary>
    public partial class UC_NormalUserEdit : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLastname;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFirstname;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMobile;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UC_NormalUserEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbUpdateUserProfile;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/uc_normaluseredit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UC_NormalUserEdit.xaml"
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
            this.imgProfilePicture = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnAddProfilePicture = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\UC_NormalUserEdit.xaml"
            this.btnAddProfilePicture.Click += new System.Windows.RoutedEventHandler(this.btnAddProfilePicture_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbLastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbFirstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbMobile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbUpdateUserProfile = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\UC_NormalUserEdit.xaml"
            this.tbUpdateUserProfile.Click += new System.Windows.RoutedEventHandler(this.tbUpdateUserProfile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

