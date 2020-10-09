/// <summary>
/// Low level routines used by client and web applications
/// This file produces the NAMED Log.NAMED_METHOD calls that are defined in
/// Log.LoggingPriority
/// 
/// </summary>
namespace VNC
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;

    using Microsoft.Practices.EnterpriseLibrary.Logging;
    
    public partial class Log
    {
		#region APPLICATION_START

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_END

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LOADEASE

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SQL_CALL

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PAGE_LOAD

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FORM_LOAD

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT_HANDLER

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region STATUS

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region REDIRECT_TRANSFER

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region POLLING

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE_LOW

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_MED

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_LOW

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_MED

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_LOW

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_MED

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_LOW

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION_LOW

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION_LOW

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG_LOW

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO_LOW

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO_LOW

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY_LOW

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region CLEAR_INITIALIZE

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DEFAULT

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            StackTrace trace = new StackTrace();
            if (method == null) method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, long startTicks)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            StackTrace trace = new StackTrace();
            MethodBase method = trace.GetFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		}
}