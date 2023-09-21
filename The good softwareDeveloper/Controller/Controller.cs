using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_good_softwareDeveloper.Controller
{
    internal class Controller
    {
        public void Ctrl()
        {
            View.Gui gui = new View.Gui();
            try
            {
                StreamReader reader = new StreamReader("C:\\Users\\zbc23mwly\\Desktop\\Data.txt");
                string line; while ((line = reader.ReadLine()) != null)
                { 
                    if (line.Any(char.IsDigit))
                    {
                        string hours = string.Concat(line.Where(char.IsDigit));
                        gui.WriteData("it has been running for: " + hours + " Hours");
                    }
                }
                reader.Close();

            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
        }
    }
}
