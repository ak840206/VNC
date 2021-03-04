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
            Log.Info("In bar()", "CLASS1");
        }
    }
}
