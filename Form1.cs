using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebText
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            /*孔孟文化遗产*/
            this.lab.Text = "Ip：114.55.248.19\n\n孔孟文化遗产";
            this.lab.ForeColor = Color.Red;
            this.lab.BackColor = Color.Transparent;
            webBrowser1.Url = new Uri("http://www.sdcmch.com/");

            /*润滑油*/
            this.label1.Text = "Ip：114.55.248.19\n\n润滑油";
            this.label1.ForeColor = Color.Red;
            this.label1.BackColor = Color.Transparent;
            webBrowser2.Url = new Uri("http://114.55.248.19:9091/yiheyou/login.do");

            /*艾特网络官网*/
            this.label2.Text = "Ip：115.28.65.110n\n艾特网络官网";
            this.label2.ForeColor = Color.Red;
            this.label2.BackColor = Color.Transparent;
            webBrowser3.Url = new Uri("http://www.willgood.cn/index.html");

            /*保利*/
            this.label3.Text = "Ip：115.28.65.110\n\n保利";
            this.label3.ForeColor = Color.Red;
            this.label3.BackColor = Color.Transparent;
            webBrowser4.Url = new Uri("http://www.polysdmb.com.cn/");

            /*教育法家协会*/
            this.label4.Text = "Ip：114.215.116.86\n\n教育法家协会";
            this.label4.ForeColor = Color.Red;
            this.label4.BackColor = Color.Transparent;
            webBrowser5.Url = new Uri("http://www.sdjysx.net/");

            /*方联官网*/
            this.label5.Text = "Ip：115.28.65.110n\n方联官网";
            this.label5.ForeColor = Color.Red;
            this.label5.BackColor = Color.Transparent;
            webBrowser6.Url = new Uri("http://www.fanglinktec.com/index.html");



        }
    }
}
