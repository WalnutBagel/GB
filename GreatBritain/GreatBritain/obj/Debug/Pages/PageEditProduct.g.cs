﻿#pragma checksum "..\..\..\Pages\PageEditProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9B8258D2EDCC8812EFD2B9903FE23DB3350906F573B5267310D81CF57491379"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GreatBritain.Pages;
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


namespace GreatBritain.Pages {
    
    
    /// <summary>
    /// PageEditProduct
    /// </summary>
    public partial class PageEditProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbID;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCost;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbManufacturer;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDescription;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtCancel;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Pages\PageEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtSave;
        
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
            System.Uri resourceLocater = new System.Uri("/GreatBritain;component/pages/pageeditproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageEditProduct.xaml"
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
            this.TbID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbManufacturer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtCancel = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Pages\PageEditProduct.xaml"
            this.BtCancel.Click += new System.Windows.RoutedEventHandler(this.BtCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtSave = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Pages\PageEditProduct.xaml"
            this.BtSave.Click += new System.Windows.RoutedEventHandler(this.BtSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

