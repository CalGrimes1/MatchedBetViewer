using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using MatchedBetViewer;
using ValueBetViewer;

namespace BetBot7
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private void setValues()
        {
            //Setting.instance.B365Domain = this.txtProxyUrl.Text;
            Setting.instance.leaderName = this.txtLeader.Text;
            Setting.instance.license = this.txtLicense.Text;
            //Setting.instance.bLeaderStake = this.chkStakeWay.Checked;
            //Setting.instance.socketEndpoint = this.txtSocketEndpoint.Text;
            //Setting.instance.basicStake = (double)this.numStake.Value;
            Setting.instance.betUser = this.txtUsername.Text;
            Setting.instance.betPin = this.txtPassword.Text;
            //Setting.instance.proxyUrl = this.txtProxyUrl.Text;
            //Setting.instance.socketEndpoint = this.txtSocketEndpoint.Text;
            BetAccount user = new BetAccount(this.txtUsername.Text, this.txtPassword.Text);
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            setValues();
            LoginProcess LoginUser = new LoginProcess();
            LoginUser.LoginClick();


            this.Close();

        }
       

    }
}
