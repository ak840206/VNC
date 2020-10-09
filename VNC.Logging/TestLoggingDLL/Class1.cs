using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNC;

namespace TestLoggingDLL
{
    public class Class1
    {
        public void foo()
        {
            Log.Info("In foo()", "TESTLOGGINGDLL");
        }
        public void bar()
        {
            Log.Info("In foo()", "CLASS1");
        }
    }
}
