using Atomus.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Atomus.Windows.Controls.WebBrowser
{
    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DefaultWebBrowser : UserControl, IAction
    {
        private AtomusControlEventHandler beforeActionEventHandler;
        private AtomusControlEventHandler afterActionEventHandler;

        #region Init
        public DefaultWebBrowser()
        {
            InitializeComponent();

            this.DataContext = new ViewModel.DefaultWebBrowserViewModel(this);
        }
        #endregion

        #region Dictionary
        #endregion

        #region Spread
        #endregion

        #region IO
        object IAction.ControlAction(ICore sender, AtomusControlArgs e)
        {
            try
            {
                this.beforeActionEventHandler?.Invoke(this, e);

                //switch (e.Action)
                //{
                //    case "Join.Cancel":
                //        return true;

                //    case "Form.Size":
                //        if (this.Background == null)//이미지를 늦게 불러오는 경우에 다시 반영
                //            this.Background = (this.DataContext as ViewModel.DefaultJoinViewModel).BackgroundImage;

                //        //this.afterActionEventHandler?.Invoke(this, e);
                //        return true;

                //    case "Join.ClearPassword":
                //        this.AccessNumberOld.Password = "";
                //        this.AccessNumber.Password = "";
                //        this.AccessNumberRetry.Password = "";
                //        return true;

                //    default:
                //        throw new AtomusException("'{0}'은 처리할 수 없는 Action 입니다.".Translate(e.Action));
                //}

                return null;
            }
            finally
            {
                this.afterActionEventHandler?.Invoke(this, e);
            }
        }
        #endregion

        #region Event
        event AtomusControlEventHandler IAction.BeforeActionEventHandler
        {
            add
            {
                this.beforeActionEventHandler += value;
            }
            remove
            {
                this.beforeActionEventHandler -= value;
            }
        }
        event AtomusControlEventHandler IAction.AfterActionEventHandler
        {
            add
            {
                this.afterActionEventHandler += value;
            }
            remove
            {
                this.afterActionEventHandler -= value;
            }
        }

        private void DefaultWebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
        }
        #endregion

        #region ETC
        private void AddControl()
        {
        }
        #endregion
    }

    public class Helper : WebBrowserHelper { }
}