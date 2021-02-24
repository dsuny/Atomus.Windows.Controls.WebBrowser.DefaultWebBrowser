using Atomus.Control;
using Atomus.Diagnostics;
using Atomus.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Atomus.Windows.Controls.WebBrowser.ViewModel
{
    public class DefaultWebBrowserViewModel : Atomus.MVVM.ViewModel
    {
        #region Declare
        private Uri webBrowserUri;
        #endregion

        #region Property
        public ICore Core { get; set; }

        public Uri WebBrowserUri
        {
            get
            {
                return this.webBrowserUri;
            }
            set
            {
                if (this.webBrowserUri != value)
                {
                    this.webBrowserUri = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region INIT
        public DefaultWebBrowserViewModel() { }
        public DefaultWebBrowserViewModel(ICore core) : this()
        {
            this.Core = core;

            try
            {
                this.webBrowserUri = new Uri(this.Core.GetAttribute("DefaultUri"));
            }
            catch (Exception ex)
            {
                DiagnosticsTool.MyTrace(ex);
                //(this).WindowsMessageBoxShow(Application.Current.Windows[0], ex);
            }
        }
        #endregion

        #region IO
        #endregion

        #region ETC
        #endregion
    }
}