﻿#pragma checksum "..\..\CNCConfigurationApply.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56FB1B0780322706681CB661EF3593D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
using FireWall;
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


namespace FireWall {
    
    
    /// <summary>
    /// CNCConfigurationApply
    /// </summary>
    public partial class CNCConfigurationApply : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewCNCRulebutton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CNCApplybutton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FWCNClabel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MACCNClabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CNCIPlabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CNCRuleslabel1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CNCdataGrid;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CNCConfigurationApply.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Closebutton;
        
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
            System.Uri resourceLocater = new System.Uri("/FireWall;component/cncconfigurationapply.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CNCConfigurationApply.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 9 "..\..\CNCConfigurationApply.xaml"
            ((FireWall.CNCConfigurationApply)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\CNCConfigurationApply.xaml"
            ((FireWall.CNCConfigurationApply)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NewCNCRulebutton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\CNCConfigurationApply.xaml"
            this.NewCNCRulebutton.Click += new System.Windows.RoutedEventHandler(this.NewCNCRulebutton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CNCApplybutton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CNCConfigurationApply.xaml"
            this.CNCApplybutton.Click += new System.Windows.RoutedEventHandler(this.CNCApplybutton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FWCNClabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MACCNClabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CNCIPlabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.CNCRuleslabel1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.CNCdataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.Closebutton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\CNCConfigurationApply.xaml"
            this.Closebutton.Click += new System.Windows.RoutedEventHandler(this.Closebutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 41 "..\..\CNCConfigurationApply.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CNCeditclick);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 42 "..\..\CNCConfigurationApply.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CNCdeleteclick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

