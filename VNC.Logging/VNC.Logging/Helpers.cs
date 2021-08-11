using System;
using System.Diagnostics;
using System.Reflection;

namespace VNC.Logging
{

    #region Helper Class (From Dojie)

    public static class Helpers
    {
        [DebuggerStepThrough]
        public static T ExecuteLogHandledOp<T>(Func<T> action, LoggingPriority loggingPriority, string applicationCategory, string additionalStartMessage = null, string additionalEndMessage = null)
        {
            //StackTrace trace = new StackTrace();
            MethodBase method = new StackFrame(1).GetMethod();
            var startMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(MethodBase) });
            long dbTicks = 0;
            if (startMethod != null)
            {
                try
                {
                    dbTicks = (long)startMethod.Invoke(null, new object[] { string.Format("Enter: {0}", additionalStartMessage), applicationCategory, method });
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Exception: {0}", additionalStartMessage), applicationCategory);
                    Log.Error(ex, applicationCategory);
                }
            }

            var result = action();

            var endMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(long), typeof(MethodBase) });
            if (endMethod != null)
            {
                try
                {
                    endMethod.Invoke(null, new object[] { string.Format("Exit: result:({0}) {1}", result, additionalEndMessage), applicationCategory, dbTicks, method });
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Exception: {0}", additionalEndMessage), applicationCategory);
                    Log.Error(ex, applicationCategory);
                }
            }

            return result;
        }

        [DebuggerStepThrough]
        public static void ExecuteLogHandledOp(Action action, LoggingPriority loggingPriority, string applicationCategory, string additionalStartMessage = null, string additionalEndMessage = null)
        {
            //StackTrace trace = new StackTrace();
            MethodBase method = new StackFrame(1).GetMethod();
            var startMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(MethodBase) });
            long dbTicks = 0;
            if (startMethod != null)
            {
                try
                {
                    dbTicks = (long)startMethod.Invoke(null, new object[] { string.Format("Enter: {0}", additionalStartMessage), applicationCategory, method });
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Exception: {0}", additionalStartMessage), applicationCategory);
                    Log.Error(ex, applicationCategory);
                }
            }

            action();

            var endMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(long), typeof(MethodBase) });
            if (endMethod != null)
            {
                try
                {
                    endMethod.Invoke(null, new object[] { string.Format("Exit: {0}", additionalEndMessage), applicationCategory, dbTicks, method });
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Exception: {0}", additionalEndMessage), applicationCategory);
                    Log.Error(ex, applicationCategory);
                }
            }
        }
    }

    #endregion
}
