using MatchedBetViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetBot7
{
    public class Setting
    {
        private static Setting _instance;

        public static Setting instance
        {
            get
            {
                if (Setting._instance == null)
                    Setting._instance = new Setting();
                return Setting._instance;
            }
        }
        public string license { get; set; }

        public string proxyUrl { get; set; }

        public BetAccount account { get; set; }

        public string betUser { get; set; }

        public string betPin { get; set; }

        public string leaderName { get; set; }

        public string B365Domain { get; set; }

        public double basicStake { get; set; }

        public string socketEndpoint { get; set; }

        public int botIndex { get; set; }

        public bool isOnline { get; set; }

        public bool bLeaderStake { get; set; }

        public string version { get; set; }

        public Setting()
        {
            this.proxyUrl = string.Empty;
            this.betUser = string.Empty;
            this.betPin = string.Empty;
            this.B365Domain = string.Empty;
            this.socketEndpoint = string.Empty;
            this.leaderName = "Monster";
            this.botIndex = 0;
            this.bLeaderStake = true;
            this.version = "1.0";
        }




    }
}
