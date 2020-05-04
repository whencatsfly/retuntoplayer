using ConsoleApp1.ResultDTO;
using ConsoleApp1.Utils;
using System;

namespace ConsoleApp1.Requests
{
    public class BonusRequest : Client
    {

        public void BRequest(Configurations config, int bonusId)
        {
            ExportCsv exportValues = new ExportCsv();
            //String bonusParams = $"game={Configurations.gameName}&key={Configurations.TokenKey}" +
            //   $"&bonus={Configurations.BonusKey}&param=0&ts={Configurations.TimeStamp}&platform=web";

            String bonusParams = "";

            var bonusCompleted = false;


            int counter = 1;
            String bonusValue;
            int type = Convert.ToInt32(config.GameType);
            do
            {
                switch (type)
                {

                    case 0: // cascading
                        bonusValue = "0";
                        bonusParams = $"game={config.gameName}&key={config.TokenKey}" +
                     $"&bonus={bonusValue}&param={bonusValue}&ts={config.TimeStamp}&platform=web";
                      

                    break;

                    case 1:

                        var param = counter.ToString();
                        var mode = counter.ToString();

                        if (bonusId == 3 || bonusId == 4)
                        {
                            counter++;
                          
                        }

                        bonusParams = $"game={config.gameName}&key={config.TokenKey}" +
                      $"&bonus={config.TokenKey}&param={param}&mode={mode}&ts={config.TimeStamp}&platform=web";
                      
                    break;

                    case 2:
                        bonusParams = $"game={config.gameName}&key={config.TokenKey}" +
                     $"&bonus={config.TokenKey}&param=0&&ts={config.TimeStamp}&platform=web";

                    break;


                }

                var actualResult = SlotRequest<BonusResult>(Configurations.BonusEndpoint, bonusParams);
                if (config.Export)
                {
                      exportValues.ExportCSV(config, actualResult.TxnId.ToString(), "Bonus Request",
                        config.Bet, actualResult.TotalBet.ToString(), actualResult.TotalWin.ToString());
                }
                    Console.WriteLine("Bonus Ongoing");

                bonusCompleted = actualResult.BonusCompleted;

            } while (!bonusCompleted);

        }

    }
}
