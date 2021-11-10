using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.Linq;
using MatchedBetViewer;

namespace BetBot7
{
    public partial class frmOdds : Form
    {
        SkyBetWebScraper skyBetScraper;
        public frmOdds()
        {
            InitializeComponent();
            skyBetScraper = new SkyBetWebScraper();
        }



        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings formSettings = new frmSettings();
            formSettings.ShowDialog();

           

        }
      

        private void frmOdds_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            if (processes != null)
            {
                foreach (Process process in processes)
                {
                    if (process.ProcessName.Equals("chromedriver"))
                        process.Kill();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String SkyBetHorseRacing = "https://www.bet365.com/#/AS/B2/";
            skyBetScraper.SkyBetScrapeRaceLink(SkyBetHorseRacing);


           
            for (int i = 0; i < skyBetScraper.Links.Count; i++)
            {
                rtbxLog.AppendText(skyBetScraper.Links[i]);
            }
            
            


        }
    }
}
