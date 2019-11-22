using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LiggingService
    {
        public static void WriteToFile (List<Object> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item);
            }
        }
    }
}
