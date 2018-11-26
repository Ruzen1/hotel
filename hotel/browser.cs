using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hotel
{
    public partial class browser : Form
    {
        bool IsShown = false;
        public browser()
        {
            InitializeComponent();
            toolTip1.ShowAlways = true;
        }
        //I downloaded the CelSharp for the chromium browser in the app
        ChromiumWebBrowser chrome;
        private void browser_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            chrome = new ChromiumWebBrowser("www.google.com");
            this.panel1.Controls.Add(chrome);
            chrome.AddressChanged += Chrome_AddressChanged;
        }
        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(()=>{textBox1.Text = e.Address;}));
        }
        private void temairazuBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.temairazu.com/");
        }

        private void tabelogBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("https://tabelog.com/");
        }

        private void takyubinBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.kuronekoyamato.co.jp/ytc/search/estimate/all_est.html");
        }

        private void weather_Click(object sender, EventArgs e)
        {
            chrome.Load("https://weather.yahoo.co.jp/weather/27/6200.html");
        }

        private void trainStateBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("https://transit.yahoo.co.jp/traininfo/area/6/");
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.google.co.jp/maps/");
        }

        private void goBTn_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        chrome.Load("https://web.travel.rakuten.co.jp/portal/my/m_afy_pre.main?f_no=68188");
                        break;
                    case 1:
                        chrome.Load("https://wwws.jalan.net/yw/ywp0100/ywt0100LoginTop.do");
                        break;
                    case 2:
                        chrome.Load("https://www.expediapartnercentral.com/Account/Logon?returnUrl=https%3A%2F%2Fwww.expediapartnercentral.com%2F&langId=1041");
                        break;
                    case 3:
                        chrome.Load("https://shop.ikyu.com/shTkOwnLogin.htm");
                        break;
                    case 4:
                        chrome.Load("https://ycs.agoda.com/ja-jp/kipp/public/login");
                        break;
                    case 5:
                        chrome.Load("https://jp.trip.com/account/signin?locale=ja_jp");
                        break;
                    case 6:
                        chrome.LoadHtml("<h1 style='color:red;text-align:center;margin-top:25%;'> The WebPage is Under Construction.</h1>");
                        break;
                }
            }
            else
            {
                chrome.Load(textBox1.Text);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Enabled = true;
                textBox1.Enabled = true;
                textBox1.ReadOnly = true;
            }
            else
            {
                comboBox1.Enabled = false;
                textBox1.ReadOnly = false;
            }

        }

        private void browser_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = this.GetChildAtPoint(e.Location);

            if (ctrl != null)
            {
                if (ctrl == this.comboBox1 && !IsShown)
                {
                    string tipstring = this.toolTip1.GetToolTip(this.comboBox1);
                    this.toolTip1.Show(tipstring, this.comboBox1,this.comboBox1.Width / 2, this.comboBox1.Height / 2);
                    IsShown = true;
                }
            }
            else
            {
                this.toolTip1.Hide(this.comboBox1);
                IsShown = false;
            }
        }

        private void googleBtn_Click(object sender, EventArgs e)
        {
            chrome.Load("www.google.com");
            
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoBack)
            {
                chrome.Back();
            }
        }

        private void goForwardBtn_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                chrome.Load(textBox1.Text);
            }
            
        }
    }
}
