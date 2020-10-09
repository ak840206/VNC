Option Strict On

Imports System.Reflection
Imports VNC
Public Class TestLogging
    Public Const iEventNumber As Integer = 16004

    Public Sub Log_All()
        Log_Failure()
        Log_Error()
        Log_Warning()
        Log_Info()
        Log_Debug()
        Log_Trace()

        TestExceptionHandling()
    End Sub

    Public Sub Log_Failure()
        Log.Failure("FailMessage with Category", "MyFailCategory")
        Log.Failure("FailMessage with Category with Stack", "MyFailCategory", True)
        Log.Failure("FailMessage", "OnTrac")
        Log.Failure("FailMessage", "OnTracK2")
        Log.Failure("FailMessage", "OnTracUI")
        Log.Failure("FailMessage", "OnTracWP")
        Log.Failure("FailMessage", "OnTracWS")
        Log.Failure("FailMessage", "OnTracWS", iEventNumber)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")

        Log.Failure("FailMessage", "OnTrac", dictionary)
        Log.Failure("FailMessage", "OnTrac", iEventNumber, dictionary)


    End Sub

    Public Sub Log_Error()
        Log.Error("ErrorMessage with Category", "MyErrorCategory")
        Log.Error("ErrorMessage with Category with Stack", "MyErrorCategory", True)
        Log.Error("ErrorMessage", "OnTrac")
        Log.Error("ErrorMessage", "OnTracK2")
        Log.Error("ErrorMessage", "OnTracUI")
        Log.Error("ErrorMessage", "OnTracWP")
        Log.Error("ErrorMessage", "OnTracWS")
        Log.Error("ErrorMessage", "OnTracWS", iEventNumber)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")
        Log.Error("ErrorMessage", "OnTrac", dictionary)
        Log.Error("ErrorMessage", "OnTrac", iEventNumber, dictionary)

    End Sub

    Public Sub Log_Warning()
        Log.Warning("WarnMessage with Category", "MyWarnCategory")
        Log.Warning("WarnMessage with Category with Stack", "MyWarnCategory", True)
        Log.Warning("WarnMessage", "OnTrac")
        Log.Warning("WarnMessage", "OnTracK2")
        Log.Warning("WarnMessage", "OnTracUI")
        Log.Warning("WarnMessage", "OnTracWP")
        Log.Warning("WarnMessage", "OnTracWS")
        Log.Warning("WarnMessage", "OnTracWS", iEventNumber)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")
        Log.Warning("WarnMessage", "OnTrac", dictionary)
        Log.Warning("WarnMessage", "OnTrac", iEventNumber, dictionary)

    End Sub

    Public Sub Log_Info()
        Dim startTicks As Long


        startTicks = Log.Info("Enter", "MyInfoCategory")

        Log.Info("InfoMessage with Category", "MyInfoCategory")
        Log.Info("InfoMessage", "OnTrac")
        Log.Info("InfoMessage", "OnTracK2")
        Log.Info("InfoMessage", "OnTracUI")
        Log.Info("InfoMessage", "OnTracWP")
        Log.Info("InfoMessage", "OnTracWS")
        Log.Info("InfoMessage", "OnTracWS", iEventNumber)

        Log.Info("Exit", "MyInfoCategory", startTicks)
        Log.Info("Exit", "MyInfoCategory", iEventNumber, startTicks)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")
        Log.Info("InfoMessage", "OnTrac", dictionary)
        Log.Info("InfoMessage", "OnTrac", iEventNumber, dictionary)
        Log.Info("InfoMessage", "OnTrac", startTicks, dictionary)
        Log.Info("InfoMessage", "OnTrac", iEventNumber, startTicks, dictionary)

    End Sub

    Public Sub Log_Debug()
        Dim startTicks As Long

        startTicks = Log.Debug("Enter", "MyDebugCategory")

        Log.Debug("DebugMessage with Category", "MyDebugCategory")
        Log.Debug("DebugMessage", "OnTrac")
        Log.Debug("DebugMessage", "OnTracK2")
        Log.Debug("DebugMessage", "OnTracUI")
        Log.Debug("DebugMessage", "OnTracWP")
        Log.Debug("DebugMessage", "OnTracWS")
        Log.Debug("DebugMessage", "OnTracWS", iEventNumber)

        Log.Debug("Exit", "MyDebugCategory", startTicks)
        Log.Debug("Exit", "MyDebugCategory", iEventNumber, startTicks)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")
        Log.Debug("DebugMessage", "OnTrac", dictionary)
        Log.Debug("DebugMessage", "OnTrac", iEventNumber, dictionary)
        Log.Debug("DebugMessage", "OnTrac", startTicks, dictionary)
        Log.Debug("DebugMessage", "OnTrac", iEventNumber, startTicks, dictionary)

    End Sub

    Public Sub Log_Trace()
        Dim startTicks As Long

        startTicks = Log.Trace("Enter", "MyTraceCategory")

        Log.Trace("TraceMessage with Category", "MyTraceCategory")
        Log.Trace("TraceMessage", "OnTrac")
        Log.Trace("TraceMessage", "OnTracK2")
        Log.Trace("TraceMessage", "OnTracUI")
        Log.Trace("TraceMessage", "OnTracWP")
        Log.Trace("TraceMessage", "OnTracWS")
        Log.Trace("TraceMessage", "OnTracWS", iEventNumber)

        Log.Trace1("Trace 1 Message", "MyTraceCategory")
        Log.Trace2("Trace 2 Message", "MyTraceCategory")
        Log.Trace3("Trace 3 Message", "MyTraceCategory")
        Log.Trace4("Trace 4 Message", "MyTraceCategory")
        Log.Trace5("Trace 5 Message", "MyTraceCategory")

        Log.Trace("Exit", "MyTraceCategory", startTicks)
        Log.Trace("Exit", "MyTraceCategory", iEventNumber, startTicks)

        'Populate Dictionary for extended properties
        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("Application", "EAI_PS58Process")
        dictionary.Add("PolicyNumber", "VP12345678")
        dictionary.Add("WorksheetID", "35378")
        Log.Trace("TraceMessage", "OnTrac", dictionary)
        Log.Trace("TraceMessage", "OnTrac", iEventNumber, dictionary)
        Log.Trace("TraceMessage", "OnTrac", startTicks, dictionary)
        Log.Trace("TraceMessage", "OnTrac", iEventNumber, startTicks, dictionary)

        Log.Trace1("Trace 1 Message", "OnTrac", dictionary)
        Log.Trace1("Trace 1 Message", "OnTrac", iEventNumber, dictionary)
        Log.Trace1("Trace 1 Message", "OnTrac", startTicks, dictionary)
        Log.Trace1("Trace 1 Message", "OnTrac", iEventNumber, startTicks, dictionary)

        Log.Trace2("Trace 2 Message", "OnTrac", dictionary)
        Log.Trace2("Trace 2 Message", "OnTrac", iEventNumber, dictionary)
        Log.Trace2("Trace 2 Message", "OnTrac", startTicks, dictionary)
        Log.Trace2("Trace 2 Message", "OnTrac", iEventNumber, startTicks, dictionary)

        Log.Trace3("Trace 3 Message", "OnTrac", dictionary)
        Log.Trace3("Trace 3 Message", "OnTrac", iEventNumber, dictionary)
        Log.Trace3("Trace 3 Message", "OnTrac", startTicks, dictionary)
        Log.Trace3("Trace 3 Message", "OnTrac", iEventNumber, startTicks, dictionary)

        Log.Trace4("Trace 4 Message", "OnTrac", dictionary)
        Log.Trace4("Trace 4 Message", "OnTrac", iEventNumber, dictionary)
        Log.Trace4("Trace 4 Message", "OnTrac", startTicks, dictionary)
        Log.Trace4("Trace 4 Message", "OnTrac", iEventNumber, startTicks, dictionary)

        Log.Trace5("Trace 5 Message", "OnTrac", dictionary)
        Log.Trace5("Trace 5 Message", "OnTrac", iEventNumber, dictionary)
        Log.Trace5("Trace 5 Message", "OnTrac", startTicks, dictionary)
        Log.Trace5("Trace 5 Message", "OnTrac", iEventNumber, startTicks, dictionary)

    End Sub

    Public Sub TestExceptionHandling()
        Try
            Throw (New System.Exception)
        Catch ex As Exception
            Log.Failure(ex, "ExceptionCategory")
            Log.Error(ex, "ExceptionCategory")
            Log.Warning(ex, "ExceptionCategory")
        End Try

    End Sub
    Public Sub TestBatchNotificationCustomListner()
        Dim i As Integer
        Try
            'Throw Exception by trying to convert string to int.
            i = Convert.ToInt32("abc")

        Catch ex As Exception

            Dim dictionary As New Dictionary(Of String, String)
            dictionary.Add("NotificationMode", "Batch")
            dictionary.Add("ApplicationName", "TestLogging")
            dictionary.Add("TransactionField1", "PolicyNumber:VP12345678")
            dictionary.Add("TransactionField2", "EffDt:08012011")
            dictionary.Add("DetailedDesc", ex.ToString())
            dictionary.Add("CurrentIterationCount", "1")
            dictionary.Add("MaxRetryCount", "5")
            Log.Error(ex.Message, "BatchNotification", dictionary)
            'C# Code sample
            'Dictionary<String, String> dictionary = new Dictionary<String, String>();
            'dictionary.Add("NotificationMode", "Batch");
            'dictionary.Add("ApplicationName", "TestLogging");
            'dictionary.Add("TransactionField1", "PolicyNumber:VP12345678");
            'dictionary.Add("TransactionField2", "EffDt:08012011");
            'dictionary.Add("DetailedDesc", ex.ToString());
            'dictionary.Add("CurrentIterationCount", "1");
            'dictionary.Add("MaxRetryCount", "5");
            'PacificLife.Life.Log.Error(ex.Message, "BatchNotification", dictionary);
        End Try
    End Sub
End Class
