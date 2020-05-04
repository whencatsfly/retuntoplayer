using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface ProgressForm
    {
        void UpdateProgress(Configurations config, int progress);
    }
}
