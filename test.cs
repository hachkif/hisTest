using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mistral.Util.Log;

namespace LOCTool
{
    class Program
    {

        // added a comment...

        private static readonly ITypeMethodLog Logger = TypeMethodLogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            
            
            Logger.Info( "Main", "Started");


            string periodStart = string.Empty;
            string periodEnd = string.Empty;
            string configFile  = string.Empty;
            string outputFolder = string.Empty; 
            string output = "Invalid command line arguments\r\nUsage:\r\n'Coniguration filename'\r\nor\r\n'Coniguration filename' 'periodStart (format yyyy-mm-dd) periodEnd(format yyyy-mm-dd)' 'output filename'";
            bool start = false;

            
            if (args.Length == 2 || args.Length == 99)       // called with a config file only
            {
                configFile      = args[0];
                outputFolder    = args[1]; 
                start = true;
            }

            if (args.Length == 4)       // called with a configfile, start date, end date and ooutput file, ad hoc call
            {

                configFile      = args[0];
                outputFolder    = args[1];
                periodStart     = args[2];
                periodEnd       = args[3];
                
                start = true;
            }

            start = true;
            if (start)
            {
                Processor.Process(periodStart, periodEnd);
            }
            else
            {
                Console.Out.WriteLine(output);
            }
        
           

        }
    }
}
