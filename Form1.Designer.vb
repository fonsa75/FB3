﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.imgVideo = New System.Windows.Forms.PictureBox()
        Me.imgCapture = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnVideoFormat = New System.Windows.Forms.Button()
        Me.btnVideoSource = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_R_i = New System.Windows.Forms.TextBox()
        Me.tx_G_i = New System.Windows.Forms.TextBox()
        Me.tx_B_i = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tx_B_v = New System.Windows.Forms.TextBox()
        Me.tx_G_v = New System.Windows.Forms.TextBox()
        Me.tx_R_v = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_monit_RGB = New System.Windows.Forms.Button()
        Me.btn_clear_Graph = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_B = New System.Windows.Forms.CheckBox()
        Me.cb_G = New System.Windows.Forms.CheckBox()
        Me.cb_R = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nup_B = New System.Windows.Forms.NumericUpDown()
        Me.nup_G = New System.Windows.Forms.NumericUpDown()
        Me.nup_R = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.IntervalPR = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumCiclos = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.NumNumLeituras = New System.Windows.Forms.NumericUpDown()
        Me.LabelAVISO = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RGBrate = New System.Windows.Forms.NumericUpDown()
        Me.NumXmax = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tx_r = New System.Windows.Forms.TextBox()
        Me.tx_b = New System.Windows.Forms.TextBox()
        Me.tx_m = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.nup_conc = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.imgVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nup_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.IntervalPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCiclos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumNumLeituras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGBrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumXmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_conc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgVideo
        '
        Me.imgVideo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgVideo.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgVideo.Location = New System.Drawing.Point(0, 0)
        Me.imgVideo.Name = "imgVideo"
        Me.imgVideo.Size = New System.Drawing.Size(385, 296)
        Me.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgVideo.TabIndex = 0
        Me.imgVideo.TabStop = False
        '
        'imgCapture
        '
        Me.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCapture.Location = New System.Drawing.Point(12, 468)
        Me.imgCapture.Name = "imgCapture"
        Me.imgCapture.Size = New System.Drawing.Size(247, 170)
        Me.imgCapture.TabIndex = 1
        Me.imgCapture.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Lime
        Me.btnStart.Location = New System.Drawing.Point(56, 326)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(81, 48)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "LIGAR CÂMERA"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(248, 326)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 46)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "PARAR CÂMERA"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(12, 701)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(89, 55)
        Me.btnCapture.TabIndex = 5
        Me.btnCapture.Text = "CAPTURAR FOTO"
        Me.btnCapture.UseVisualStyleBackColor = True
        Me.btnCapture.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(265, 468)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 54)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SALVAR FOTO"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnVideoFormat
        '
        Me.btnVideoFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVideoFormat.Location = New System.Drawing.Point(221, 654)
        Me.btnVideoFormat.Name = "btnVideoFormat"
        Me.btnVideoFormat.Size = New System.Drawing.Size(84, 55)
        Me.btnVideoFormat.TabIndex = 7
        Me.btnVideoFormat.Text = "RESOLUÇÃO DA CÂMERA"
        Me.btnVideoFormat.UseVisualStyleBackColor = False
        Me.btnVideoFormat.Visible = False
        '
        'btnVideoSource
        '
        Me.btnVideoSource.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVideoSource.Location = New System.Drawing.Point(154, 326)
        Me.btnVideoSource.Name = "btnVideoSource"
        Me.btnVideoSource.Size = New System.Drawing.Size(84, 48)
        Me.btnVideoSource.TabIndex = 8
        Me.btnVideoSource.Text = "SELEÇÃO E AJUSTE DA CÂMERA"
        Me.btnVideoSource.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "B"
        '
        'tx_R_i
        '
        Me.tx_R_i.Location = New System.Drawing.Point(35, 21)
        Me.tx_R_i.MaxLength = 3
        Me.tx_R_i.Name = "tx_R_i"
        Me.tx_R_i.ReadOnly = True
        Me.tx_R_i.Size = New System.Drawing.Size(37, 20)
        Me.tx_R_i.TabIndex = 13
        '
        'tx_G_i
        '
        Me.tx_G_i.Location = New System.Drawing.Point(35, 47)
        Me.tx_G_i.MaxLength = 3
        Me.tx_G_i.Name = "tx_G_i"
        Me.tx_G_i.ReadOnly = True
        Me.tx_G_i.Size = New System.Drawing.Size(37, 20)
        Me.tx_G_i.TabIndex = 14
        '
        'tx_B_i
        '
        Me.tx_B_i.Location = New System.Drawing.Point(35, 73)
        Me.tx_B_i.MaxLength = 3
        Me.tx_B_i.Name = "tx_B_i"
        Me.tx_B_i.ReadOnly = True
        Me.tx_B_i.Size = New System.Drawing.Size(37, 20)
        Me.tx_B_i.TabIndex = 15
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineWidth = 2
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.Maximum = 100.0R
        ChartArea1.AxisX.Minimum = 0.0R
        ChartArea1.AxisX.Title = "Leituras"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.Maximum = 255.0R
        ChartArea1.AxisY.Minimum = 0.0R
        ChartArea1.AxisY.Title = "Sinal RGB"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(417, 0)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.Name = "SeriesR"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Lime
        Series2.Legend = "Legend1"
        Series2.Name = "SeriesG"
        Series3.BorderWidth = 3
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Blue
        Series3.Legend = "Legend1"
        Series3.Name = "SeriesB"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(456, 316)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'tx_B_v
        '
        Me.tx_B_v.Location = New System.Drawing.Point(34, 90)
        Me.tx_B_v.MaxLength = 3
        Me.tx_B_v.Name = "tx_B_v"
        Me.tx_B_v.ReadOnly = True
        Me.tx_B_v.Size = New System.Drawing.Size(37, 20)
        Me.tx_B_v.TabIndex = 22
        '
        'tx_G_v
        '
        Me.tx_G_v.Location = New System.Drawing.Point(34, 64)
        Me.tx_G_v.MaxLength = 3
        Me.tx_G_v.Name = "tx_G_v"
        Me.tx_G_v.ReadOnly = True
        Me.tx_G_v.Size = New System.Drawing.Size(37, 20)
        Me.tx_G_v.TabIndex = 21
        '
        'tx_R_v
        '
        Me.tx_R_v.Location = New System.Drawing.Point(34, 38)
        Me.tx_R_v.MaxLength = 3
        Me.tx_R_v.Name = "tx_R_v"
        Me.tx_R_v.ReadOnly = True
        Me.tx_R_v.Size = New System.Drawing.Size(37, 20)
        Me.tx_R_v.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "G"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "R"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_monit_RGB
        '
        Me.btn_monit_RGB.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_monit_RGB.Location = New System.Drawing.Point(12, 772)
        Me.btn_monit_RGB.Name = "btn_monit_RGB"
        Me.btn_monit_RGB.Size = New System.Drawing.Size(125, 40)
        Me.btn_monit_RGB.TabIndex = 23
        Me.btn_monit_RGB.Text = "INICIAR / PARAR SINAL RGB"
        Me.btn_monit_RGB.UseVisualStyleBackColor = False
        Me.btn_monit_RGB.Visible = False
        '
        'btn_clear_Graph
        '
        Me.btn_clear_Graph.BackColor = System.Drawing.Color.Yellow
        Me.btn_clear_Graph.Location = New System.Drawing.Point(12, 654)
        Me.btn_clear_Graph.Name = "btn_clear_Graph"
        Me.btn_clear_Graph.Size = New System.Drawing.Size(101, 40)
        Me.btn_clear_Graph.TabIndex = 24
        Me.btn_clear_Graph.Text = "LIMPAR GRÁFICO"
        Me.btn_clear_Graph.UseVisualStyleBackColor = False
        Me.btn_clear_Graph.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tx_R_i)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tx_G_i)
        Me.GroupBox1.Controls.Add(Me.tx_B_i)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 654)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Foto"
        Me.GroupBox1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_B)
        Me.GroupBox2.Controls.Add(Me.cb_G)
        Me.GroupBox2.Controls.Add(Me.cb_R)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.nup_B)
        Me.GroupBox2.Controls.Add(Me.nup_G)
        Me.GroupBox2.Controls.Add(Me.nup_R)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tx_R_v)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tx_B_v)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tx_G_v)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 141)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video"
        '
        'cb_B
        '
        Me.cb_B.AutoSize = True
        Me.cb_B.Location = New System.Drawing.Point(136, 93)
        Me.cb_B.Name = "cb_B"
        Me.cb_B.Size = New System.Drawing.Size(15, 14)
        Me.cb_B.TabIndex = 31
        Me.cb_B.UseVisualStyleBackColor = True
        '
        'cb_G
        '
        Me.cb_G.AutoSize = True
        Me.cb_G.Location = New System.Drawing.Point(136, 67)
        Me.cb_G.Name = "cb_G"
        Me.cb_G.Size = New System.Drawing.Size(15, 14)
        Me.cb_G.TabIndex = 30
        Me.cb_G.UseVisualStyleBackColor = True
        '
        'cb_R
        '
        Me.cb_R.AutoSize = True
        Me.cb_R.Location = New System.Drawing.Point(136, 40)
        Me.cb_R.Name = "cb_R"
        Me.cb_R.Size = New System.Drawing.Size(15, 14)
        Me.cb_R.TabIndex = 29
        Me.cb_R.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Ativo"
        '
        'nup_B
        '
        Me.nup_B.Location = New System.Drawing.Point(88, 90)
        Me.nup_B.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_B.Name = "nup_B"
        Me.nup_B.Size = New System.Drawing.Size(42, 20)
        Me.nup_B.TabIndex = 27
        Me.nup_B.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nup_G
        '
        Me.nup_G.Location = New System.Drawing.Point(88, 65)
        Me.nup_G.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_G.Name = "nup_G"
        Me.nup_G.Size = New System.Drawing.Size(42, 20)
        Me.nup_G.TabIndex = 26
        Me.nup_G.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nup_R
        '
        Me.nup_R.Location = New System.Drawing.Point(88, 38)
        Me.nup_R.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nup_R.Name = "nup_R"
        Me.nup_R.Size = New System.Drawing.Size(42, 20)
        Me.nup_R.TabIndex = 25
        Me.nup_R.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Limites"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Atual"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(248, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(59, 398)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(116, 20)
        Me.NumericUpDown1.TabIndex = 39
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(59, 437)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(117, 20)
        Me.NumericUpDown2.TabIndex = 40
        Me.NumericUpDown2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Largura do Amostrador:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 422)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Altura do Amostrador:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(97, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 17)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "IMAGEM EM TEMPO REAL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(103, 852)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 17)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "ÚLTIMA FOTO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(696, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 150)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Corrida"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(66, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "PARAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(66, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INICIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(66, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 36)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "DISPARAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(992, 421)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 20)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "N° de SPOTS"
        '
        'IntervalPR
        '
        Me.IntervalPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalPR.Location = New System.Drawing.Point(1113, 378)
        Me.IntervalPR.Name = "IntervalPR"
        Me.IntervalPR.Size = New System.Drawing.Size(87, 26)
        Me.IntervalPR.TabIndex = 51
        Me.IntervalPR.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1039, 382)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "PORTA"
        '
        'NumCiclos
        '
        Me.NumCiclos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCiclos.Location = New System.Drawing.Point(1113, 419)
        Me.NumCiclos.Name = "NumCiclos"
        Me.NumCiclos.Size = New System.Drawing.Size(87, 26)
        Me.NumCiclos.TabIndex = 55
        Me.NumCiclos.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(947, 461)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 20)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Número de leituras"
        '
        'NumNumLeituras
        '
        Me.NumNumLeituras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumNumLeituras.Location = New System.Drawing.Point(1113, 459)
        Me.NumNumLeituras.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumNumLeituras.Name = "NumNumLeituras"
        Me.NumNumLeituras.Size = New System.Drawing.Size(87, 26)
        Me.NumNumLeituras.TabIndex = 58
        Me.NumNumLeituras.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'LabelAVISO
        '
        Me.LabelAVISO.AutoSize = True
        Me.LabelAVISO.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAVISO.ForeColor = System.Drawing.Color.Red
        Me.LabelAVISO.Location = New System.Drawing.Point(712, 647)
        Me.LabelAVISO.Name = "LabelAVISO"
        Me.LabelAVISO.Size = New System.Drawing.Size(195, 39)
        Me.LabelAVISO.TabIndex = 62
        Me.LabelAVISO.Text = "AGUARDE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(921, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Interv. de Leitura (ms)"
        '
        'RGBrate
        '
        Me.RGBrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGBrate.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RGBrate.Location = New System.Drawing.Point(1113, 500)
        Me.RGBrate.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.RGBrate.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RGBrate.Name = "RGBrate"
        Me.RGBrate.Size = New System.Drawing.Size(87, 26)
        Me.RGBrate.TabIndex = 27
        Me.RGBrate.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumXmax
        '
        Me.NumXmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumXmax.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumXmax.Location = New System.Drawing.Point(500, 327)
        Me.NumXmax.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumXmax.Name = "NumXmax"
        Me.NumXmax.Size = New System.Drawing.Size(87, 26)
        Me.NumXmax.TabIndex = 63
        Me.NumXmax.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(545, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 58)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "Ajustar motor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(411, 329)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 20)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "X Máximo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(627, 330)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 20)
        Me.Label26.TabIndex = 74
        Me.Label26.Text = "Y Máximo"
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown7.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown7.Location = New System.Drawing.Point(719, 328)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(87, 26)
        Me.NumericUpDown7.TabIndex = 75
        Me.NumericUpDown7.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(974, 542)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 20)
        Me.Label24.TabIndex = 77
        Me.Label24.Text = "Replicata IMGs"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown5.Location = New System.Drawing.Point(1113, 540)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(87, 26)
        Me.NumericUpDown5.TabIndex = 78
        Me.NumericUpDown5.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(232, 382)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 13)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Coordenada x"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(232, 422)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 13)
        Me.Label27.TabIndex = 85
        Me.Label27.Text = "Coordenada y"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(227, 398)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown6.TabIndex = 86
        Me.NumericUpDown6.Value = New Decimal(New Integer() {166, 0, 0, 0})
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(227, 437)
        Me.NumericUpDown8.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown8.TabIndex = 87
        Me.NumericUpDown8.Value = New Decimal(New Integer() {160, 0, 0, 0})
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.DecimalPlaces = 4
        Me.NumericUpDown9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown9.Increment = New Decimal(New Integer() {1758, 0, 0, 262144})
        Me.NumericUpDown9.Location = New System.Drawing.Point(412, 597)
        Me.NumericUpDown9.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDown9.Minimum = New Decimal(New Integer() {720, 0, 0, -2147483648})
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(121, 26)
        Me.NumericUpDown9.TabIndex = 88
        Me.NumericUpDown9.Value = New Decimal(New Integer() {720, 0, 0, -2147483648})
        '
        'Chart2
        '
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.Title = "Concentração"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea2.AxisY.Title = "Sinal"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(904, 0)
        Me.Chart2.Name = "Chart2"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.MarkerSize = 10
        Series4.Name = "Series1"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(477, 316)
        Me.Chart2.TabIndex = 89
        Me.Chart2.Text = "Chart2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1214, 317)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "R2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1121, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "b"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1027, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "m"
        '
        'tx_r
        '
        Me.tx_r.Location = New System.Drawing.Point(1190, 334)
        Me.tx_r.Name = "tx_r"
        Me.tx_r.Size = New System.Drawing.Size(68, 20)
        Me.tx_r.TabIndex = 92
        '
        'tx_b
        '
        Me.tx_b.Location = New System.Drawing.Point(1091, 334)
        Me.tx_b.Name = "tx_b"
        Me.tx_b.Size = New System.Drawing.Size(68, 20)
        Me.tx_b.TabIndex = 91
        '
        'tx_m
        '
        Me.tx_m.Location = New System.Drawing.Point(994, 333)
        Me.tx_m.Name = "tx_m"
        Me.tx_m.Size = New System.Drawing.Size(72, 20)
        Me.tx_m.TabIndex = 90
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(846, 329)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 23)
        Me.Button5.TabIndex = 96
        Me.Button5.Text = "Fazer Regressão Linear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'nup_conc
        '
        Me.nup_conc.DecimalPlaces = 1
        Me.nup_conc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nup_conc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nup_conc.Location = New System.Drawing.Point(1113, 580)
        Me.nup_conc.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nup_conc.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nup_conc.Name = "nup_conc"
        Me.nup_conc.Size = New System.Drawing.Size(87, 26)
        Me.nup_conc.TabIndex = 98
        Me.nup_conc.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(945, 582)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(162, 20)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Incr. Concentração"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 709)
        Me.Controls.Add(Me.nup_conc)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tx_r)
        Me.Controls.Add(Me.tx_b)
        Me.Controls.Add(Me.tx_m)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.NumericUpDown9)
        Me.Controls.Add(Me.NumericUpDown8)
        Me.Controls.Add(Me.NumericUpDown6)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NumXmax)
        Me.Controls.Add(Me.LabelAVISO)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.NumNumLeituras)
        Me.Controls.Add(Me.NumCiclos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.IntervalPR)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RGBrate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_clear_Graph)
        Me.Controls.Add(Me.btn_monit_RGB)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.btnVideoSource)
        Me.Controls.Add(Me.btnVideoFormat)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.imgCapture)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imgVideo)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nup_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_G, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.IntervalPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCiclos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumNumLeituras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGBrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumXmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_conc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgVideo As System.Windows.Forms.PictureBox
    Friend WithEvents imgCapture As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnVideoFormat As System.Windows.Forms.Button
    Friend WithEvents btnVideoSource As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_R_i As System.Windows.Forms.TextBox
    Friend WithEvents tx_G_i As System.Windows.Forms.TextBox
    Friend WithEvents tx_B_i As System.Windows.Forms.TextBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tx_B_v As System.Windows.Forms.TextBox
    Friend WithEvents tx_G_v As System.Windows.Forms.TextBox
    Friend WithEvents tx_R_v As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_monit_RGB As System.Windows.Forms.Button
    Friend WithEvents btn_clear_Graph As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TimerEspera As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents IntervalPR As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumCiclos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents NumNumLeituras As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelAVISO As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RGBrate As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumXmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown9 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_B As System.Windows.Forms.CheckBox
    Friend WithEvents cb_G As System.Windows.Forms.CheckBox
    Friend WithEvents cb_R As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nup_B As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_G As System.Windows.Forms.NumericUpDown
    Friend WithEvents nup_R As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tx_r As System.Windows.Forms.TextBox
    Friend WithEvents tx_b As System.Windows.Forms.TextBox
    Friend WithEvents tx_m As System.Windows.Forms.TextBox
    Friend WithEvents nup_conc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class