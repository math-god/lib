﻿#pragma checksum "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6BEDB70C0C5BB3B35B918C0AA9C278B70C4176D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.UI.LibrarianWindows.BookListWindows;
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


namespace Library.UI.LibrarianWindows.BookListWindows {
    
    
    /// <summary>
    /// BookDescriptionWindow
    /// </summary>
    public partial class BookDescriptionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CoverImage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenreTextBlock;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AuthorTextBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PublicationDateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IsbnTextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library.UI;component/librarianwindows/booklistwindows/bookdescriptionwindow.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\LibrarianWindows\BookListWindows\BookDescriptionWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CoverImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.TitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.GenreTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.AuthorTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PublicationDateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.IsbnTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.DescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

