using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchedBetViewer
{
    public class BetAccount
    {
        public string id { get; set; }

        public string betUser { get; set; }

        public string betPass { get; set; }

        public string domain { get; set; }

        public string proxy { get; set; }
        public BetAccount()
        {
            betUser = string.Empty;
            betPass = string.Empty;
        }

        public BetAccount(string _username, string _password)
        {
            betUser = _username;
            betPass = _password;
        }
    }



}
