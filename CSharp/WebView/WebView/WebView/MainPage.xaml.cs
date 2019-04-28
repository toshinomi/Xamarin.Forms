using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private const string m_strUri = "https://www.bing.com/";

        private Button m_btnBack;
        private Button m_btnForward;
        private Button m_btnReload;
        private Entry m_textUri;
        private Xamarin.Forms.WebView m_webView;

        public MainPage()
        {
            InitializeComponent();

            InitLayout();

            HomeWebView();
        }

        public void OnClickBack(object sender, EventArgs e)
        {
            BackWebView();

            return;
        }

        public void OnClickFoward(object sender, EventArgs e)
        {
            FowardWebView();

            return;
        }

        public void OnClickReload(object sender, EventArgs e)
        {
            ReloadWebView();

            return;
        }

        public void OnKeyPressTextUri(object sender, EventArgs e)
        {
            string strUri = m_textUri.Text;
            ShowWebView(ref strUri);

            return;
        }

        public void InitLayout()
        {
            m_btnBack = buttonBack;
            m_btnBack.Clicked += OnClickBack;

            m_btnForward = buttonForward;
            m_btnForward.Clicked += OnClickFoward;

            m_btnReload = buttonReload;
            m_btnReload.Clicked += OnClickReload;

            m_textUri = editTextUri;
            m_textUri.Completed += OnKeyPressTextUri;

            m_webView = webWiew;
        }

        public bool BackWebView()
        {
            bool bRst = true;
            try
            {
                m_webView.GoBack();
            }
            catch (Exception)
            {
                bRst = false;
            }

            return bRst;
        }

        public bool FowardWebView()
        {
            bool bRst = true;
            try
            {
                m_webView.GoForward();
            }
            catch (Exception)
            {
                bRst = false;
            }

            return bRst;
        }

        public bool ReloadWebView()
        {
            bool bRst = true;
            try
            {
                m_webView.Reload();
            }
            catch (Exception)
            {
                bRst = false;
            }

            return bRst;
        }

        public bool HomeWebView()
        {
            m_textUri.Text = m_strUri;
            string strUri = m_strUri;
            return ShowWebView(ref strUri);
        }

        public bool ShowWebView(ref String _strUri)
        {
            bool bRst = true;
            try
            {
                //m_webView.LoadUrl(_strUri);
                m_webView.Source = _strUri;
                m_textUri.Text = _strUri;
            }
            catch (Exception)
            {
                bRst = false;
            }

            return bRst;
        }
    }
}