﻿#pragma checksum "C:\Users\Laura\Desktop\RulesOfBball\RulesOfBball\Options.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C07F8D5675B9A5AB726369772419E36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RulesOfBball
{
    partial class Options : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.positionsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.positionsBtn).Click += this.positionsBtn_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.foulsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.foulsBtn).Click += this.foulsBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.violationsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.violationsBtn).Click += this.violationsBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.signalsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.signalsBtn).Click += this.signalsBtn_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

