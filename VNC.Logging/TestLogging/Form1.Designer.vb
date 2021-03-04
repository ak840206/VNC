<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTestAll = New System.Windows.Forms.Button()
        Me.cbIsHighResolution = New System.Windows.Forms.CheckBox()
        Me.txtElapsedTime = New System.Windows.Forms.TextBox()
        Me.txtStartTicks = New System.Windows.Forms.TextBox()
        Me.txtEndTicks = New System.Windows.Forms.TextBox()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtElapsedTime_LogInfo = New System.Windows.Forms.TextBox()
        Me.txtElapsedTime_LogInfoStack = New System.Windows.Forms.TextBox()
        Me.txtElapsedTime_LogWrite = New System.Windows.Forms.TextBox()
        Me.txtElapsedTime_GetTimeStamp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtElapsedTime_LogWriteLight = New System.Windows.Forms.TextBox()
        Me.btnTimeLogging = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtElapsedTime_LogTraceE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtElapsedTime_LogTrace = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTestBatchNotification = New System.Windows.Forms.Button()
        Me.txtElapsedTime_Trace = New System.Windows.Forms.TextBox()
        Me.btnTestTrace = New System.Windows.Forms.Button()
        Me.btnTestException = New System.Windows.Forms.Button()
        Me.btnTestFailure = New System.Windows.Forms.Button()
        Me.btnTestDebug = New System.Windows.Forms.Button()
        Me.btnTestInfo = New System.Windows.Forms.Button()
        Me.btnTestWarning = New System.Windows.Forms.Button()
        Me.btnTestError = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLogEventID = New System.Windows.Forms.Button()
        Me.txtEventID = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnBar = New System.Windows.Forms.Button()
        Me.btnFoo = New System.Windows.Forms.Button()
        Me.txtLoops = New System.Windows.Forms.TextBox()
        Me.lblLoops = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTestAll
        '
        Me.btnTestAll.Location = New System.Drawing.Point(14, 36)
        Me.btnTestAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestAll.Name = "btnTestAll"
        Me.btnTestAll.Size = New System.Drawing.Size(246, 35)
        Me.btnTestAll.TabIndex = 0
        Me.btnTestAll.Text = "Test All Logging Methods"
        Me.btnTestAll.UseVisualStyleBackColor = True
        '
        'cbIsHighResolution
        '
        Me.cbIsHighResolution.AutoSize = True
        Me.cbIsHighResolution.Location = New System.Drawing.Point(215, 28)
        Me.cbIsHighResolution.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbIsHighResolution.Name = "cbIsHighResolution"
        Me.cbIsHighResolution.Size = New System.Drawing.Size(165, 24)
        Me.cbIsHighResolution.TabIndex = 1
        Me.cbIsHighResolution.Text = "Is High Resolution"
        Me.cbIsHighResolution.UseVisualStyleBackColor = True
        '
        'txtElapsedTime
        '
        Me.txtElapsedTime.Location = New System.Drawing.Point(14, 108)
        Me.txtElapsedTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime.Name = "txtElapsedTime"
        Me.txtElapsedTime.Size = New System.Drawing.Size(148, 26)
        Me.txtElapsedTime.TabIndex = 2
        '
        'txtStartTicks
        '
        Me.txtStartTicks.Location = New System.Drawing.Point(14, 30)
        Me.txtStartTicks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStartTicks.Name = "txtStartTicks"
        Me.txtStartTicks.Size = New System.Drawing.Size(148, 26)
        Me.txtStartTicks.TabIndex = 3
        '
        'txtEndTicks
        '
        Me.txtEndTicks.Location = New System.Drawing.Point(14, 70)
        Me.txtEndTicks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEndTicks.Name = "txtEndTicks"
        Me.txtEndTicks.Size = New System.Drawing.Size(148, 26)
        Me.txtEndTicks.TabIndex = 4
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(14, 64)
        Me.txtFrequency.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(187, 26)
        Me.txtFrequency.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Frequency"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Start Ticks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "End Ticks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Elapsed Time"
        '
        'txtElapsedTime_LogInfo
        '
        Me.txtElapsedTime_LogInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogInfo.Location = New System.Drawing.Point(17, 101)
        Me.txtElapsedTime_LogInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogInfo.Name = "txtElapsedTime_LogInfo"
        Me.txtElapsedTime_LogInfo.Size = New System.Drawing.Size(259, 30)
        Me.txtElapsedTime_LogInfo.TabIndex = 15
        '
        'txtElapsedTime_LogInfoStack
        '
        Me.txtElapsedTime_LogInfoStack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogInfoStack.Location = New System.Drawing.Point(17, 168)
        Me.txtElapsedTime_LogInfoStack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogInfoStack.Name = "txtElapsedTime_LogInfoStack"
        Me.txtElapsedTime_LogInfoStack.Size = New System.Drawing.Size(259, 30)
        Me.txtElapsedTime_LogInfoStack.TabIndex = 17
        '
        'txtElapsedTime_LogWrite
        '
        Me.txtElapsedTime_LogWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogWrite.Location = New System.Drawing.Point(17, 235)
        Me.txtElapsedTime_LogWrite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogWrite.Name = "txtElapsedTime_LogWrite"
        Me.txtElapsedTime_LogWrite.Size = New System.Drawing.Size(259, 30)
        Me.txtElapsedTime_LogWrite.TabIndex = 19
        '
        'txtElapsedTime_GetTimeStamp
        '
        Me.txtElapsedTime_GetTimeStamp.Location = New System.Drawing.Point(14, 104)
        Me.txtElapsedTime_GetTimeStamp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_GetTimeStamp.Name = "txtElapsedTime_GetTimeStamp"
        Me.txtElapsedTime_GetTimeStamp.Size = New System.Drawing.Size(185, 26)
        Me.txtElapsedTime_GetTimeStamp.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "GetTimeStamp elapsed time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Log.Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Log.Write"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 275)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Log.WriteLight"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 144)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Log.Info+Stack"
        '
        'txtElapsedTime_LogWriteLight
        '
        Me.txtElapsedTime_LogWriteLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogWriteLight.Location = New System.Drawing.Point(15, 300)
        Me.txtElapsedTime_LogWriteLight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogWriteLight.Name = "txtElapsedTime_LogWriteLight"
        Me.txtElapsedTime_LogWriteLight.Size = New System.Drawing.Size(260, 30)
        Me.txtElapsedTime_LogWriteLight.TabIndex = 26
        '
        'btnTimeLogging
        '
        Me.btnTimeLogging.Location = New System.Drawing.Point(140, 29)
        Me.btnTimeLogging.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimeLogging.Name = "btnTimeLogging"
        Me.btnTimeLogging.Size = New System.Drawing.Size(136, 35)
        Me.btnTimeLogging.TabIndex = 28
        Me.btnTimeLogging.Text = "Time Logging"
        Me.btnTimeLogging.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtElapsedTime_GetTimeStamp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFrequency)
        Me.GroupBox1.Controls.Add(Me.cbIsHighResolution)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(438, 150)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System.Diagnostics.Stopwatch"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStop)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Controls.Add(Me.txtStartTicks)
        Me.GroupBox2.Controls.Add(Me.txtEndTicks)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtElapsedTime)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(388, 152)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Demonstrate Timing"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(296, 74)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(82, 35)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(296, 26)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(82, 35)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLoops)
        Me.GroupBox3.Controls.Add(Me.txtLoops)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogTraceE)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogTrace)
        Me.GroupBox3.Controls.Add(Me.btnTimeLogging)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogWriteLight)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogWrite)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogInfoStack)
        Me.GroupBox3.Controls.Add(Me.txtElapsedTime_LogInfo)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 180)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(438, 516)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time Logging Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 445)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Log.TraceE"
        '
        'txtElapsedTime_LogTraceE
        '
        Me.txtElapsedTime_LogTraceE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogTraceE.Location = New System.Drawing.Point(17, 470)
        Me.txtElapsedTime_LogTraceE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogTraceE.Name = "txtElapsedTime_LogTraceE"
        Me.txtElapsedTime_LogTraceE.Size = New System.Drawing.Size(259, 30)
        Me.txtElapsedTime_LogTraceE.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 374)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Log.Trace"
        '
        'txtElapsedTime_LogTrace
        '
        Me.txtElapsedTime_LogTrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapsedTime_LogTrace.Location = New System.Drawing.Point(17, 399)
        Me.txtElapsedTime_LogTrace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_LogTrace.Name = "txtElapsedTime_LogTrace"
        Me.txtElapsedTime_LogTrace.Size = New System.Drawing.Size(259, 30)
        Me.txtElapsedTime_LogTrace.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTestBatchNotification)
        Me.GroupBox4.Controls.Add(Me.txtElapsedTime_Trace)
        Me.GroupBox4.Controls.Add(Me.btnTestTrace)
        Me.GroupBox4.Controls.Add(Me.btnTestException)
        Me.GroupBox4.Controls.Add(Me.btnTestFailure)
        Me.GroupBox4.Controls.Add(Me.btnTestDebug)
        Me.GroupBox4.Controls.Add(Me.btnTestInfo)
        Me.GroupBox4.Controls.Add(Me.btnTestWarning)
        Me.GroupBox4.Controls.Add(Me.btnTestError)
        Me.GroupBox4.Controls.Add(Me.btnTestAll)
        Me.GroupBox4.Location = New System.Drawing.Point(460, 180)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(387, 394)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Test Logging"
        '
        'btnTestBatchNotification
        '
        Me.btnTestBatchNotification.Location = New System.Drawing.Point(14, 321)
        Me.btnTestBatchNotification.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestBatchNotification.Name = "btnTestBatchNotification"
        Me.btnTestBatchNotification.Size = New System.Drawing.Size(360, 35)
        Me.btnTestBatchNotification.TabIndex = 9
        Me.btnTestBatchNotification.Text = "Test Batch Notification Custom Trace Listener"
        Me.btnTestBatchNotification.UseVisualStyleBackColor = True
        '
        'txtElapsedTime_Trace
        '
        Me.txtElapsedTime_Trace.Location = New System.Drawing.Point(199, 232)
        Me.txtElapsedTime_Trace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtElapsedTime_Trace.Name = "txtElapsedTime_Trace"
        Me.txtElapsedTime_Trace.Size = New System.Drawing.Size(176, 26)
        Me.txtElapsedTime_Trace.TabIndex = 8
        '
        'btnTestTrace
        '
        Me.btnTestTrace.Location = New System.Drawing.Point(201, 188)
        Me.btnTestTrace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestTrace.Name = "btnTestTrace"
        Me.btnTestTrace.Size = New System.Drawing.Size(179, 35)
        Me.btnTestTrace.TabIndex = 7
        Me.btnTestTrace.Text = "Test Trace Methods"
        Me.btnTestTrace.UseVisualStyleBackColor = True
        '
        'btnTestException
        '
        Me.btnTestException.Location = New System.Drawing.Point(14, 275)
        Me.btnTestException.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestException.Name = "btnTestException"
        Me.btnTestException.Size = New System.Drawing.Size(246, 35)
        Me.btnTestException.TabIndex = 6
        Me.btnTestException.Text = "Test Exception Methods"
        Me.btnTestException.UseVisualStyleBackColor = True
        '
        'btnTestFailure
        '
        Me.btnTestFailure.Location = New System.Drawing.Point(14, 96)
        Me.btnTestFailure.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestFailure.Name = "btnTestFailure"
        Me.btnTestFailure.Size = New System.Drawing.Size(179, 35)
        Me.btnTestFailure.TabIndex = 5
        Me.btnTestFailure.Text = "Test Failure Methods"
        Me.btnTestFailure.UseVisualStyleBackColor = True
        '
        'btnTestDebug
        '
        Me.btnTestDebug.Location = New System.Drawing.Point(14, 188)
        Me.btnTestDebug.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestDebug.Name = "btnTestDebug"
        Me.btnTestDebug.Size = New System.Drawing.Size(179, 35)
        Me.btnTestDebug.TabIndex = 4
        Me.btnTestDebug.Text = "Test Debug Methods"
        Me.btnTestDebug.UseVisualStyleBackColor = True
        '
        'btnTestInfo
        '
        Me.btnTestInfo.Location = New System.Drawing.Point(199, 141)
        Me.btnTestInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestInfo.Name = "btnTestInfo"
        Me.btnTestInfo.Size = New System.Drawing.Size(179, 35)
        Me.btnTestInfo.TabIndex = 3
        Me.btnTestInfo.Text = "Test Info Methods"
        Me.btnTestInfo.UseVisualStyleBackColor = True
        '
        'btnTestWarning
        '
        Me.btnTestWarning.Location = New System.Drawing.Point(14, 141)
        Me.btnTestWarning.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestWarning.Name = "btnTestWarning"
        Me.btnTestWarning.Size = New System.Drawing.Size(179, 35)
        Me.btnTestWarning.TabIndex = 2
        Me.btnTestWarning.Text = "Test Warning Methods"
        Me.btnTestWarning.UseVisualStyleBackColor = True
        '
        'btnTestError
        '
        Me.btnTestError.Location = New System.Drawing.Point(199, 96)
        Me.btnTestError.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestError.Name = "btnTestError"
        Me.btnTestError.Size = New System.Drawing.Size(179, 35)
        Me.btnTestError.TabIndex = 1
        Me.btnTestError.Text = "Test Error Methods"
        Me.btnTestError.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnLogEventID)
        Me.GroupBox5.Controls.Add(Me.txtEventID)
        Me.GroupBox5.Location = New System.Drawing.Point(460, 599)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(375, 121)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "EventID"
        '
        'btnLogEventID
        '
        Me.btnLogEventID.Location = New System.Drawing.Point(213, 35)
        Me.btnLogEventID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogEventID.Name = "btnLogEventID"
        Me.btnLogEventID.Size = New System.Drawing.Size(82, 35)
        Me.btnLogEventID.TabIndex = 9
        Me.btnLogEventID.Text = "Log"
        Me.btnLogEventID.UseVisualStyleBackColor = True
        '
        'txtEventID
        '
        Me.txtEventID.Location = New System.Drawing.Point(7, 35)
        Me.txtEventID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.Size = New System.Drawing.Size(187, 26)
        Me.txtEventID.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnBar)
        Me.GroupBox6.Controls.Add(Me.btnFoo)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 704)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(422, 121)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Call DLL"
        '
        'btnBar
        '
        Me.btnBar.Location = New System.Drawing.Point(7, 79)
        Me.btnBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBar.Name = "btnBar"
        Me.btnBar.Size = New System.Drawing.Size(189, 35)
        Me.btnBar.TabIndex = 10
        Me.btnBar.Text = "TestLoggingDLL-bar()"
        Me.btnBar.UseVisualStyleBackColor = True
        '
        'btnFoo
        '
        Me.btnFoo.Location = New System.Drawing.Point(7, 30)
        Me.btnFoo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFoo.Name = "btnFoo"
        Me.btnFoo.Size = New System.Drawing.Size(189, 35)
        Me.btnFoo.TabIndex = 9
        Me.btnFoo.Text = "TestLoggingDLL-foo()"
        Me.btnFoo.UseVisualStyleBackColor = True
        '
        'txtLoops
        '
        Me.txtLoops.Location = New System.Drawing.Point(69, 33)
        Me.txtLoops.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoops.Name = "txtLoops"
        Me.txtLoops.Size = New System.Drawing.Size(61, 26)
        Me.txtLoops.TabIndex = 22
        Me.txtLoops.Text = "500"
        '
        'lblLoops
        '
        Me.lblLoops.AutoSize = True
        Me.lblLoops.Location = New System.Drawing.Point(8, 36)
        Me.lblLoops.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoops.Name = "lblLoops"
        Me.lblLoops.Size = New System.Drawing.Size(53, 20)
        Me.lblLoops.TabIndex = 33
        Me.lblLoops.Text = "Loops"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 850)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox5.PerformLayout
        Me.GroupBox6.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnTestAll As System.Windows.Forms.Button
    Friend WithEvents cbIsHighResolution As System.Windows.Forms.CheckBox
    Friend WithEvents txtElapsedTime As System.Windows.Forms.TextBox
    Friend WithEvents txtStartTicks As System.Windows.Forms.TextBox
    Friend WithEvents txtEndTicks As System.Windows.Forms.TextBox
    Friend WithEvents txtFrequency As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtElapsedTime_LogInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtElapsedTime_LogInfoStack As System.Windows.Forms.TextBox
    Friend WithEvents txtElapsedTime_LogWrite As System.Windows.Forms.TextBox
    Friend WithEvents txtElapsedTime_GetTimeStamp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtElapsedTime_LogWriteLight As System.Windows.Forms.TextBox
    Friend WithEvents btnTimeLogging As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTestFailure As System.Windows.Forms.Button
    Friend WithEvents btnTestDebug As System.Windows.Forms.Button
    Friend WithEvents btnTestInfo As System.Windows.Forms.Button
    Friend WithEvents btnTestWarning As System.Windows.Forms.Button
    Friend WithEvents btnTestError As System.Windows.Forms.Button
    Friend WithEvents btnTestTrace As System.Windows.Forms.Button
    Friend WithEvents btnTestException As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtElapsedTime_Trace As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtElapsedTime_LogTrace As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtElapsedTime_LogTraceE As System.Windows.Forms.TextBox
    Friend WithEvents btnTestBatchNotification As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnLogEventID As Button
    Friend WithEvents txtEventID As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnBar As Button
    Friend WithEvents btnFoo As Button
    Friend WithEvents lblLoops As Label
    Friend WithEvents txtLoops As TextBox
End Class
