﻿#pragma checksum "..\..\..\..\View\TeacherOption.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01683802DC9A72D308C05F8734AAEF45ECADE4C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login_Screen.View;
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


namespace Login_Screen.View {
    
    
    /// <summary>
    /// TeacherOption
    /// </summary>
    public partial class TeacherOption : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Login_Screen.View.TeacherOption AppWindow;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registerbtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resultbtn;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutbtn;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView InformationList;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updatebtn;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\View\TeacherOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletebtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Login Screen;component/view/teacheroption.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\TeacherOption.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AppWindow = ((Login_Screen.View.TeacherOption)(target));
            return;
            case 2:
            this.registerbtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\View\TeacherOption.xaml"
            this.registerbtn.Click += new System.Windows.RoutedEventHandler(this.registerbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.resultbtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\View\TeacherOption.xaml"
            this.resultbtn.Click += new System.Windows.RoutedEventHandler(this.resultbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.logoutbtn = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\View\TeacherOption.xaml"
            this.logoutbtn.Click += new System.Windows.RoutedEventHandler(this.logoutbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 163 "..\..\..\..\View\TeacherOption.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InformationList = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 184 "..\..\..\..\View\TeacherOption.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 185 "..\..\..\..\View\TeacherOption.xaml"
            this.updatebtn.Click += new System.Windows.RoutedEventHandler(this.updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.deletebtn = ((System.Windows.Controls.Button)(target));
            
            #line 186 "..\..\..\..\View\TeacherOption.xaml"
            this.deletebtn.Click += new System.Windows.RoutedEventHandler(this.deletebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

