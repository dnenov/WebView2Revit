using Microsoft.Web.WebView2.Core;
using System.Windows;
using System.Windows.Input;

namespace TestWV2
{
    /// <summary>
    /// Interaction logic for Page.xaml
    /// </summary>
    public partial class Page : Window
    {
        bool _isNavigating = false;

        public Page()
        {
            InitializeComponent();
        }

        void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            _isNavigating = true;
            RequeryCommands();
        }

        void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            _isNavigating = false;
            RequeryCommands();
        }


        void RequeryCommands()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
