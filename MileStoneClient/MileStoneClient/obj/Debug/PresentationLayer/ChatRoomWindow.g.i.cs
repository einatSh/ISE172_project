﻿#pragma checksum "..\..\..\PresentationLayer\ChatRoomWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DAED2D1D6642AAFB7ED55A424CE97189DB54139A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MileStoneClient;
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
using WpfAnimatedGif;


namespace MileStoneClient.PresentationLayer {
    
    
    /// <summary>
    /// ChatRoomWindow
    /// </summary>
    public partial class ChatRoomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MileStoneClient.PresentationLayer.ChatRoomWindow ChatRoomWin;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCR;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtChat;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOptions;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProfile;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogOut;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/MileStoneClient;component/presentationlayer/chatroomwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
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
            this.ChatRoomWin = ((MileStoneClient.PresentationLayer.ChatRoomWindow)(target));
            return;
            case 2:
            this.GridCR = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.TxtChat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnOptions = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.BtnProfile = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.BtnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
            this.BtnLogOut.Click += new System.Windows.RoutedEventHandler(this.BtnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\PresentationLayer\ChatRoomWindow.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

