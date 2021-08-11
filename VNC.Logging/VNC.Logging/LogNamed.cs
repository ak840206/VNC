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
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_END

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LOADEASE

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SQL_CALL

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PAGE_LOAD

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FORM_LOAD

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT_HANDLER

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region STATUS

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region REDIRECT_TRANSFER

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region POLLING

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE_LOW

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_MED

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_LOW

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_MED

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_LOW

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_MED

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_LOW

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION_LOW

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION_LOW

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG_LOW

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO_LOW

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO_LOW

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY_LOW

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region CLEAR_INITIALIZE

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_INITIALIZE

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region MODULE

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region MODULE_INITIALIZE

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATIONSERVICES

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAIN

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAINSERVICES

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region CORE

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PERSISTENCE

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PRESENTATION

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEW

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEW_LOW

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEWMODEL

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEWMODEL_LOW

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LEXER

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PARSER

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region BINDER

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYNTAX

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVALUATOR

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region COMPILER

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DIAGNOSTIC

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DEFAULT

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, long startTicks, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, Convert.ToBoolean(0), EventId, startTicks, props);
            return Stopwatch.GetTimestamp();
        }

        #endregion

	        // NOTE(crhodes)
        //
        // Special handling for LOG.CONSTRUCTOR
        //
        // This is for the case where Release Builds and Dependency Injection use lambdas.
        // Lambda's have a null ReflectedType.  The ReflectedType gets the name of the Type containing the method
        // Go up one level on the stack to see if we find a proper methods.
        //
        // N.B. For now, only support these two.  Later may decide to just put this in the general routines.

        [DebuggerStepThrough]
        public static long CONSTRUCTOR(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            if (method.ReflectedType is null)
            {
                method = new StackFrame(2).GetMethod();
                // Leave a mark we got fancy.
                message = $"{message}-lambda caller";
            }

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CONSTRUCTOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CONSTRUCTOR(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            if (method.ReflectedType is null)
            {
                method = new StackFrame(2).GetMethod();
                // Leave a mark we got fancy.
                message = $"{message}-lambda caller";
            }

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CONSTRUCTOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }
	}
}