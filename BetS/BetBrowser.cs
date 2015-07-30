using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BetS
{
    public partial class BetBrowser : UserControl
    {
        public BetBrowser()
        {
            InitializeComponent();
            initBrowser();
            tbUrl.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            browser.Navigate(tbUrl.Text);
        }

        private void initBrowser()
        {
            browser = new Gecko.GeckoWebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.DomClick += onDomClick;
            splitContainer.Panel2.Controls.Add(browser);
        }
        private void onDomClick(object sender, Gecko.DomEventArgs e)
        {
            if (sender == null || e == null || e.Target == null)
                return;
            Gecko.GeckoHtmlElement element = (Gecko.GeckoHtmlElement)e.Target.CastToGeckoElement();
            if (element == null)
                return;
            string pattern = @"\d+([.,]\d{1,3})?\s*$";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            // collect numbers A
            Match match = rgx.Match(element.TextContent);
            double number;
            if (Double.TryParse(match.Value.Replace(',','.'), out number))
            {
                OnTextCaptured(new TextCapturedEventArgs() { Odd = number });
            }
        }

        private void tbUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Navigate(tbUrl.Text);
            }
        }

        protected virtual void OnTextCaptured(TextCapturedEventArgs e)
        {
            EventHandler<TextCapturedEventArgs> handler = TextCaptured;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<TextCapturedEventArgs> TextCaptured;
    }
}
