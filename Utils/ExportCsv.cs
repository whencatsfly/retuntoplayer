using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class ExportCsv
    {
        String ExportLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public void ExportCSV(Configurations config, String txn, String requestType, String bet, String totalbet, String totalwin)
        {
            String path = $"{ExportLocation }\\{config.gameName}.csv";
            String delimiter = ",";

            if (!File.Exists(path))
            {
                String createColumn = $"currency{delimiter}TXN{delimiter}Request{delimiter}Line Bet{delimiter}Total Bet{delimiter}Total Win{Environment.NewLine}";
                File.WriteAllText(path, createColumn);
            }

            String appendStrings = $"{config.currency}{delimiter}{txn}{delimiter}{requestType}{delimiter}{bet}{delimiter}{totalbet}{delimiter}{totalwin}{Environment.NewLine}";

            File.AppendAllText(path, appendStrings);
        }
    }
}
