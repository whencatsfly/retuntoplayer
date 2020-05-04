using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Utils.Enums;

namespace ConsoleApp1
{
    public class Configurations
    {
        public static String SpinEndpoint = "";
        public static String BonusEndpoint = "";
        public static String GetBetsEndpoint = "";
        public static String GetTokenEndpoint = "";
        public static String GetAuthenticationEndpoint = "";
        public static string password = "";
        //Spin Request Parameters
        public String gameName { get; set; }
        public bool Export { get; set; }
        public String currency { get; set; }
        public String TokenKey { get; set; }
        public string Bet { get; set; }
        public String TimeStamp { get; set; }
        public int RunTimes { get; set; }
        public String multiplier { get; set; }
        public String param { get; set; }
        public String mode { get; set; }
        public String GameType { get; set; }
        public List<string> keyArray = new List<string>();
        public List<string> ListOftokens = new List<string>();
        public String [] TokenNames= { };

        //Bonus Parameters

        //Client

        public Verbs Method
        {
            get;
            set;
        }
        public string ContentType
        {
            get;
            set;
        }
        public string PostData
        {
            get;
            set;
        }

        // Export Values

        //getBets 
        public static int BetCount { get; set; }
        public static String [] BetList { get; set; }
    }
}
