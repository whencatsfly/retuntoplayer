using ConsoleApp1.Interface;
using ConsoleApp1.ResultDTO;
using ConsoleApp1.Utils;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApp1.Requests
{
    public class SpinRequest : Client
    {
        public SpinRequest(ProgressForm form) : base(form)
        {

        }

       // CoinDenomination cdForm = new CoinDenomination(); 


        public void SRequest(Configurations config)
        {
            //
            ExportCsv exportValues = new ExportCsv();
            int i = 1;
            while (i <=config.RunTimes)
            {
                form.UpdateProgress(config,i);

                // cdForm.label3.Text = i.ToString();  
                var actualResult = SlotRequest<SpinResult>(Configurations.SpinEndpoint, 
                    $"game={config.gameName}&key={config.TokenKey}&bet={config.Bet}&multiplier=1&platform=web&ts={config.TimeStamp}");
                if(actualResult != null)
                {

                    if (config.Export)
                    {

                        exportValues.ExportCSV(config, actualResult.TxnId.ToString(), "Spin Request",
                                            config.Bet, actualResult.TotalBet.ToString(), actualResult.TotalWin.ToString());
                    }

                    Console.WriteLine(i + " Spin Request" + config.Bet);



                    if (actualResult.hasBonus)
                    {
                        int bonusId = Convert.ToInt32(actualResult.Bonus.BonusId);
                        BonusRequest runBonus = new BonusRequest();
                        runBonus.BRequest(config, bonusId);
                    }
                    i++;
                } else
                {
                    MessageBox.Show($"Token {config.TokenKey} is already expired!");
                    break;
                }
            }
        }
    }
}
