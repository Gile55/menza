﻿#pragma checksum "C:\Users\mm\Desktop\StudentskaMenza\SudentskaMenzaUWP\Stranice\Prijava.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "455810A61E837D3239600E00A3B450D57BBF34C5FE8E6CA97382A5DECE7BA53B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SudentskaMenzaUWP.Stranice
{
    partial class Prijava : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Prijava_obj10_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPrijava_Bindings
        {
            private global::SudentskaMenzaUWP.ViewModel.TipKorisnika dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10TextDisabled = false;

            public Prijava_obj10_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 52 && columnNumber == 44)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Stranice\Prijava.xaml line 52
                        this.obj10 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::SudentskaMenzaUWP.ViewModel.TipKorisnika) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPrijava_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SudentskaMenzaUWP.ViewModel.TipKorisnika)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SudentskaMenzaUWP.ViewModel.TipKorisnika obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Naziv(obj.Naziv, phase);
                    }
                }
            }
            private void Update_Naziv(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Stranice\Prijava.xaml line 52
                    if (!isobj10TextDisabled)
                    {
                        if ((this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text((this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Stranice\Prijava.xaml line 41
                {
                    this.ddbOdabirTipaKorisnika = (global::Windows.UI.Xaml.Controls.DropDownButton)(target);
                }
                break;
            case 3: // Stranice\Prijava.xaml line 59
                {
                    this.lblIdentifikacijskoPolje = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Stranice\Prijava.xaml line 67
                {
                    this.tbIdentifikacijskoPolje = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Stranice\Prijava.xaml line 78
                {
                    this.tbLozinka = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Stranice\Prijava.xaml line 83
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Prijava_Klik;
                }
                break;
            case 7: // Stranice\Prijava.xaml line 90
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Registracija_Klik;
                }
                break;
            case 8: // Stranice\Prijava.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.ListView element8 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)element8).SelectionChanged += this.OdabirTipaKorisnikaPromjenjen;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 10: // Stranice\Prijava.xaml line 52
                {                    
                    global::Windows.UI.Xaml.Controls.TextBlock element10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    Prijava_obj10_Bindings bindings = new Prijava_obj10_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element10.DataContext);
                    element10.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element10, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element10, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

