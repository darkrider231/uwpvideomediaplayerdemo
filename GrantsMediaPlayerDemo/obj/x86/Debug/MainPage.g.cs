#pragma checksum "C:\Users\grant\source\repos\GrantsMediaPlayerDemo\GrantsMediaPlayerDemo\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6316CDB02068ACC0E1D1CEF3CD56EE2C30785497984CDF410B7AFD6A0BD8903A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrantsMediaPlayerDemo
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.mediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.openFile = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.openFile).Click += this.openFile_Click;
                }
                break;
            case 4: // MainPage.xaml line 19
                {
                    this.playFile = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.playFile).Click += this.playFile_Click;
                }
                break;
            case 5: // MainPage.xaml line 20
                {
                    this.pauseFile = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.pauseFile).Click += this.pauseFile_Click;
                }
                break;
            case 6: // MainPage.xaml line 21
                {
                    this.stopFile = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.stopFile).Click += this.stopFile_Click;
                }
                break;
            case 7: // MainPage.xaml line 22
                {
                    this.pictureSize = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.pictureSize).Click += this.pictureSize_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

