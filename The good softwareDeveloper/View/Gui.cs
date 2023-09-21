using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_good_softwareDeveloper.View
{
    internal class Gui
    {


        internal void WriteData(string hour, params Model.LogData[] data) 
        {
            Console.WriteLine(hour);
        }
    }
}
