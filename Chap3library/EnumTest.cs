using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class EnumTest
    {
        enum DaialogResult {YES, NO, CANCEL, CONFIRM, OK};
        public void exam()
        {
            Console.WriteLine((int)DaialogResult.YES);
            Console.WriteLine((int)DaialogResult.NO);
            Console.WriteLine((int)DaialogResult.CANCEL);
            Console.WriteLine((int)DaialogResult.CONFIRM);
            Console.WriteLine((int)DaialogResult.OK);
            
            
        }
    }
}
