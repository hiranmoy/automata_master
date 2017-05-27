<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controller
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
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.ApplianceTab = New System.Windows.Forms.TabPage()
        Me.Light0Bt = New System.Windows.Forms.Button()
        Me.Light1Bt = New System.Windows.Forms.Button()
        Me.Light2Bt = New System.Windows.Forms.Button()
        Me.Room0Rb = New System.Windows.Forms.RadioButton()
        Me.Light3 = New System.Windows.Forms.Button()
        Me.Light4 = New System.Windows.Forms.Button()
        Me.Light8 = New System.Windows.Forms.Button()
        Me.Light7 = New System.Windows.Forms.Button()
        Me.Light6 = New System.Windows.Forms.Button()
        Me.Light5 = New System.Windows.Forms.Button()
        Me.Fan0 = New System.Windows.Forms.Button()
        Me.Fan1 = New System.Windows.Forms.Button()
        Me.Fan2 = New System.Windows.Forms.Button()
        Me.GN0 = New System.Windows.Forms.Button()
        Me.GN1 = New System.Windows.Forms.Button()
        Me.Plug0 = New System.Windows.Forms.Button()
        Me.Plug1 = New System.Windows.Forms.Button()
        Me.Plug2 = New System.Windows.Forms.Button()
        Me.Plug3 = New System.Windows.Forms.Button()
        Me.Plug4 = New System.Windows.Forms.Button()
        Me.Plug5 = New System.Windows.Forms.Button()
        Me.Plug6 = New System.Windows.Forms.Button()
        Me.Plug7 = New System.Windows.Forms.Button()
        Me.Plug8 = New System.Windows.Forms.Button()
        Me.TemperatureLb = New System.Windows.Forms.Label()
        Me.HumidityLb = New System.Windows.Forms.Label()
        Me.PressureLb = New System.Windows.Forms.Label()
        Me.SmokeLb = New System.Windows.Forms.Label()
        Me.COLb = New System.Windows.Forms.Label()
        Me.AlcoholLb = New System.Windows.Forms.Label()
        Me.RealTimeLb = New System.Windows.Forms.Label()
        Me.Connection0 = New System.Windows.Forms.ProgressBar()
        Me.ConnectCheck = New System.Windows.Forms.CheckBox()
        Me.StreamDebugIdx = New System.Windows.Forms.NumericUpDown()
        Me.ConfigBt = New System.Windows.Forms.Button()
        Me.Packet = New System.Windows.Forms.TextBox()
        Me.debugButton = New System.Windows.Forms.Button()
        Me.Connect = New System.Windows.Forms.Button()
        Me.DebugGrp = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tabs.SuspendLayout()
        Me.ApplianceTab.SuspendLayout()
        CType(Me.StreamDebugIdx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DebugGrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.ApplianceTab)
        Me.Tabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.Location = New System.Drawing.Point(12, 87)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.Padding = New System.Drawing.Point(10, 10)
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1880, 803)
        Me.Tabs.TabIndex = 0
        '
        'ApplianceTab
        '
        Me.ApplianceTab.BackColor = System.Drawing.Color.Black
        Me.ApplianceTab.Controls.Add(Me.Plug8)
        Me.ApplianceTab.Controls.Add(Me.Plug7)
        Me.ApplianceTab.Controls.Add(Me.Plug6)
        Me.ApplianceTab.Controls.Add(Me.Plug5)
        Me.ApplianceTab.Controls.Add(Me.Plug4)
        Me.ApplianceTab.Controls.Add(Me.Plug3)
        Me.ApplianceTab.Controls.Add(Me.Plug2)
        Me.ApplianceTab.Controls.Add(Me.Plug1)
        Me.ApplianceTab.Controls.Add(Me.Plug0)
        Me.ApplianceTab.Controls.Add(Me.GN1)
        Me.ApplianceTab.Controls.Add(Me.GN0)
        Me.ApplianceTab.Controls.Add(Me.Fan2)
        Me.ApplianceTab.Controls.Add(Me.Fan1)
        Me.ApplianceTab.Controls.Add(Me.Fan0)
        Me.ApplianceTab.Controls.Add(Me.Light8)
        Me.ApplianceTab.Controls.Add(Me.Light7)
        Me.ApplianceTab.Controls.Add(Me.Light6)
        Me.ApplianceTab.Controls.Add(Me.Light5)
        Me.ApplianceTab.Controls.Add(Me.Light4)
        Me.ApplianceTab.Controls.Add(Me.Light3)
        Me.ApplianceTab.Controls.Add(Me.Room0Rb)
        Me.ApplianceTab.Controls.Add(Me.Light2Bt)
        Me.ApplianceTab.Controls.Add(Me.Light1Bt)
        Me.ApplianceTab.Controls.Add(Me.Light0Bt)
        Me.ApplianceTab.Location = New System.Drawing.Point(4, 39)
        Me.ApplianceTab.Name = "ApplianceTab"
        Me.ApplianceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ApplianceTab.Size = New System.Drawing.Size(1872, 760)
        Me.ApplianceTab.TabIndex = 0
        Me.ApplianceTab.Text = "Appliances"
        '
        'Light0Bt
        '
        Me.Light0Bt.BackColor = System.Drawing.Color.White
        Me.Light0Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light0Bt.Location = New System.Drawing.Point(12, 114)
        Me.Light0Bt.Name = "Light0Bt"
        Me.Light0Bt.Size = New System.Drawing.Size(165, 103)
        Me.Light0Bt.TabIndex = 0
        Me.Light0Bt.Text = "Light0"
        Me.Light0Bt.UseVisualStyleBackColor = False
        Me.Light0Bt.Visible = False
        '
        'Light1Bt
        '
        Me.Light1Bt.BackColor = System.Drawing.Color.White
        Me.Light1Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light1Bt.Location = New System.Drawing.Point(219, 114)
        Me.Light1Bt.Name = "Light1Bt"
        Me.Light1Bt.Size = New System.Drawing.Size(165, 103)
        Me.Light1Bt.TabIndex = 1
        Me.Light1Bt.Text = "Light1"
        Me.Light1Bt.UseVisualStyleBackColor = False
        Me.Light1Bt.Visible = False
        '
        'Light2Bt
        '
        Me.Light2Bt.BackColor = System.Drawing.Color.White
        Me.Light2Bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light2Bt.Location = New System.Drawing.Point(433, 114)
        Me.Light2Bt.Name = "Light2Bt"
        Me.Light2Bt.Size = New System.Drawing.Size(165, 103)
        Me.Light2Bt.TabIndex = 2
        Me.Light2Bt.Text = "Light2"
        Me.Light2Bt.UseVisualStyleBackColor = False
        Me.Light2Bt.Visible = False
        '
        'Room0Rb
        '
        Me.Room0Rb.AutoSize = True
        Me.Room0Rb.BackColor = System.Drawing.SystemColors.ControlText
        Me.Room0Rb.Checked = True
        Me.Room0Rb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room0Rb.ForeColor = System.Drawing.Color.White
        Me.Room0Rb.Location = New System.Drawing.Point(295, 27)
        Me.Room0Rb.Name = "Room0Rb"
        Me.Room0Rb.Size = New System.Drawing.Size(94, 28)
        Me.Room0Rb.TabIndex = 3
        Me.Room0Rb.TabStop = True
        Me.Room0Rb.Text = "Room 1"
        Me.Room0Rb.UseVisualStyleBackColor = False
        '
        'Light3
        '
        Me.Light3.BackColor = System.Drawing.Color.White
        Me.Light3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light3.Location = New System.Drawing.Point(642, 114)
        Me.Light3.Name = "Light3"
        Me.Light3.Size = New System.Drawing.Size(165, 103)
        Me.Light3.TabIndex = 4
        Me.Light3.Text = "Light3"
        Me.Light3.UseVisualStyleBackColor = False
        Me.Light3.Visible = False
        '
        'Light4
        '
        Me.Light4.BackColor = System.Drawing.Color.White
        Me.Light4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light4.Location = New System.Drawing.Point(856, 114)
        Me.Light4.Name = "Light4"
        Me.Light4.Size = New System.Drawing.Size(165, 103)
        Me.Light4.TabIndex = 5
        Me.Light4.Text = "Light4"
        Me.Light4.UseVisualStyleBackColor = False
        Me.Light4.Visible = False
        '
        'Light8
        '
        Me.Light8.BackColor = System.Drawing.Color.White
        Me.Light8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light8.Location = New System.Drawing.Point(1696, 114)
        Me.Light8.Name = "Light8"
        Me.Light8.Size = New System.Drawing.Size(165, 103)
        Me.Light8.TabIndex = 9
        Me.Light8.Text = "Light8"
        Me.Light8.UseVisualStyleBackColor = False
        Me.Light8.Visible = False
        '
        'Light7
        '
        Me.Light7.BackColor = System.Drawing.Color.White
        Me.Light7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light7.Location = New System.Drawing.Point(1488, 114)
        Me.Light7.Name = "Light7"
        Me.Light7.Size = New System.Drawing.Size(165, 103)
        Me.Light7.TabIndex = 8
        Me.Light7.Text = "Light7"
        Me.Light7.UseVisualStyleBackColor = False
        Me.Light7.Visible = False
        '
        'Light6
        '
        Me.Light6.BackColor = System.Drawing.Color.White
        Me.Light6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light6.Location = New System.Drawing.Point(1284, 114)
        Me.Light6.Name = "Light6"
        Me.Light6.Size = New System.Drawing.Size(165, 103)
        Me.Light6.TabIndex = 7
        Me.Light6.Text = "Light6"
        Me.Light6.UseVisualStyleBackColor = False
        Me.Light6.Visible = False
        '
        'Light5
        '
        Me.Light5.BackColor = System.Drawing.Color.White
        Me.Light5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Light5.Location = New System.Drawing.Point(1068, 114)
        Me.Light5.Name = "Light5"
        Me.Light5.Size = New System.Drawing.Size(165, 103)
        Me.Light5.TabIndex = 6
        Me.Light5.Text = "Light5"
        Me.Light5.UseVisualStyleBackColor = False
        Me.Light5.Visible = False
        '
        'Fan0
        '
        Me.Fan0.BackColor = System.Drawing.Color.White
        Me.Fan0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Fan0.Location = New System.Drawing.Point(218, 340)
        Me.Fan0.Name = "Fan0"
        Me.Fan0.Size = New System.Drawing.Size(165, 103)
        Me.Fan0.TabIndex = 10
        Me.Fan0.Text = "Fan0"
        Me.Fan0.UseVisualStyleBackColor = False
        Me.Fan0.Visible = False
        '
        'Fan1
        '
        Me.Fan1.BackColor = System.Drawing.Color.White
        Me.Fan1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Fan1.Location = New System.Drawing.Point(432, 340)
        Me.Fan1.Name = "Fan1"
        Me.Fan1.Size = New System.Drawing.Size(165, 103)
        Me.Fan1.TabIndex = 11
        Me.Fan1.Text = "Fan1"
        Me.Fan1.UseVisualStyleBackColor = False
        Me.Fan1.Visible = False
        '
        'Fan2
        '
        Me.Fan2.BackColor = System.Drawing.Color.White
        Me.Fan2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Fan2.Location = New System.Drawing.Point(641, 340)
        Me.Fan2.Name = "Fan2"
        Me.Fan2.Size = New System.Drawing.Size(165, 103)
        Me.Fan2.TabIndex = 12
        Me.Fan2.Text = "Fan2"
        Me.Fan2.UseVisualStyleBackColor = False
        Me.Fan2.Visible = False
        '
        'GN0
        '
        Me.GN0.BackColor = System.Drawing.Color.White
        Me.GN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GN0.Location = New System.Drawing.Point(1283, 340)
        Me.GN0.Name = "GN0"
        Me.GN0.Size = New System.Drawing.Size(165, 103)
        Me.GN0.TabIndex = 13
        Me.GN0.Text = "GN0"
        Me.GN0.UseVisualStyleBackColor = False
        Me.GN0.Visible = False
        '
        'GN1
        '
        Me.GN1.BackColor = System.Drawing.Color.White
        Me.GN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GN1.Location = New System.Drawing.Point(1487, 340)
        Me.GN1.Name = "GN1"
        Me.GN1.Size = New System.Drawing.Size(165, 103)
        Me.GN1.TabIndex = 14
        Me.GN1.Text = "GN1"
        Me.GN1.UseVisualStyleBackColor = False
        Me.GN1.Visible = False
        '
        'Plug0
        '
        Me.Plug0.BackColor = System.Drawing.Color.White
        Me.Plug0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug0.Location = New System.Drawing.Point(11, 568)
        Me.Plug0.Name = "Plug0"
        Me.Plug0.Size = New System.Drawing.Size(165, 103)
        Me.Plug0.TabIndex = 15
        Me.Plug0.Text = "Plug0"
        Me.Plug0.UseVisualStyleBackColor = False
        Me.Plug0.Visible = False
        '
        'Plug1
        '
        Me.Plug1.BackColor = System.Drawing.Color.White
        Me.Plug1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug1.Location = New System.Drawing.Point(218, 568)
        Me.Plug1.Name = "Plug1"
        Me.Plug1.Size = New System.Drawing.Size(165, 103)
        Me.Plug1.TabIndex = 16
        Me.Plug1.Text = "Plug1"
        Me.Plug1.UseVisualStyleBackColor = False
        Me.Plug1.Visible = False
        '
        'Plug2
        '
        Me.Plug2.BackColor = System.Drawing.Color.White
        Me.Plug2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug2.Location = New System.Drawing.Point(432, 568)
        Me.Plug2.Name = "Plug2"
        Me.Plug2.Size = New System.Drawing.Size(165, 103)
        Me.Plug2.TabIndex = 17
        Me.Plug2.Text = "Plug2"
        Me.Plug2.UseVisualStyleBackColor = False
        Me.Plug2.Visible = False
        '
        'Plug3
        '
        Me.Plug3.BackColor = System.Drawing.Color.White
        Me.Plug3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug3.Location = New System.Drawing.Point(641, 568)
        Me.Plug3.Name = "Plug3"
        Me.Plug3.Size = New System.Drawing.Size(165, 103)
        Me.Plug3.TabIndex = 18
        Me.Plug3.Text = "Plug3"
        Me.Plug3.UseVisualStyleBackColor = False
        Me.Plug3.Visible = False
        '
        'Plug4
        '
        Me.Plug4.BackColor = System.Drawing.Color.White
        Me.Plug4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug4.Location = New System.Drawing.Point(855, 568)
        Me.Plug4.Name = "Plug4"
        Me.Plug4.Size = New System.Drawing.Size(165, 103)
        Me.Plug4.TabIndex = 19
        Me.Plug4.Text = "Plug4"
        Me.Plug4.UseVisualStyleBackColor = False
        Me.Plug4.Visible = False
        '
        'Plug5
        '
        Me.Plug5.BackColor = System.Drawing.Color.White
        Me.Plug5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug5.Location = New System.Drawing.Point(1067, 568)
        Me.Plug5.Name = "Plug5"
        Me.Plug5.Size = New System.Drawing.Size(165, 103)
        Me.Plug5.TabIndex = 20
        Me.Plug5.Text = "Plug5"
        Me.Plug5.UseVisualStyleBackColor = False
        Me.Plug5.Visible = False
        '
        'Plug6
        '
        Me.Plug6.BackColor = System.Drawing.Color.White
        Me.Plug6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug6.Location = New System.Drawing.Point(1283, 568)
        Me.Plug6.Name = "Plug6"
        Me.Plug6.Size = New System.Drawing.Size(165, 103)
        Me.Plug6.TabIndex = 21
        Me.Plug6.Text = "Plug6"
        Me.Plug6.UseVisualStyleBackColor = False
        Me.Plug6.Visible = False
        '
        'Plug7
        '
        Me.Plug7.BackColor = System.Drawing.Color.White
        Me.Plug7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug7.Location = New System.Drawing.Point(1487, 568)
        Me.Plug7.Name = "Plug7"
        Me.Plug7.Size = New System.Drawing.Size(165, 103)
        Me.Plug7.TabIndex = 22
        Me.Plug7.Text = "Plug7"
        Me.Plug7.UseVisualStyleBackColor = False
        Me.Plug7.Visible = False
        '
        'Plug8
        '
        Me.Plug8.BackColor = System.Drawing.Color.White
        Me.Plug8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Plug8.Location = New System.Drawing.Point(1695, 568)
        Me.Plug8.Name = "Plug8"
        Me.Plug8.Size = New System.Drawing.Size(165, 103)
        Me.Plug8.TabIndex = 23
        Me.Plug8.Text = "Plug8"
        Me.Plug8.UseVisualStyleBackColor = False
        Me.Plug8.Visible = False
        '
        'TemperatureLb
        '
        Me.TemperatureLb.AutoSize = True
        Me.TemperatureLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TemperatureLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TemperatureLb.Location = New System.Drawing.Point(12, 22)
        Me.TemperatureLb.Name = "TemperatureLb"
        Me.TemperatureLb.Padding = New System.Windows.Forms.Padding(10)
        Me.TemperatureLb.Size = New System.Drawing.Size(129, 39)
        Me.TemperatureLb.TabIndex = 20
        Me.TemperatureLb.Text = "Temperature : "
        '
        'HumidityLb
        '
        Me.HumidityLb.AutoSize = True
        Me.HumidityLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HumidityLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HumidityLb.Location = New System.Drawing.Point(213, 22)
        Me.HumidityLb.Name = "HumidityLb"
        Me.HumidityLb.Padding = New System.Windows.Forms.Padding(10)
        Me.HumidityLb.Size = New System.Drawing.Size(104, 39)
        Me.HumidityLb.TabIndex = 21
        Me.HumidityLb.Text = "Humidity : "
        '
        'PressureLb
        '
        Me.PressureLb.AutoSize = True
        Me.PressureLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PressureLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PressureLb.Location = New System.Drawing.Point(393, 22)
        Me.PressureLb.Name = "PressureLb"
        Me.PressureLb.Padding = New System.Windows.Forms.Padding(10)
        Me.PressureLb.Size = New System.Drawing.Size(97, 39)
        Me.PressureLb.TabIndex = 22
        Me.PressureLb.Text = "Pressure : "
        '
        'SmokeLb
        '
        Me.SmokeLb.AutoSize = True
        Me.SmokeLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmokeLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SmokeLb.Location = New System.Drawing.Point(1187, 22)
        Me.SmokeLb.Name = "SmokeLb"
        Me.SmokeLb.Padding = New System.Windows.Forms.Padding(10)
        Me.SmokeLb.Size = New System.Drawing.Size(86, 39)
        Me.SmokeLb.TabIndex = 25
        Me.SmokeLb.Text = "Smoke : "
        '
        'COLb
        '
        Me.COLb.AutoSize = True
        Me.COLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.COLb.Location = New System.Drawing.Point(1030, 22)
        Me.COLb.Name = "COLb"
        Me.COLb.Padding = New System.Windows.Forms.Padding(10)
        Me.COLb.Size = New System.Drawing.Size(59, 39)
        Me.COLb.TabIndex = 24
        Me.COLb.Text = "CO : "
        '
        'AlcoholLb
        '
        Me.AlcoholLb.AutoSize = True
        Me.AlcoholLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlcoholLb.Font = New System.Drawing.Font("Adobe Heiti Std R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AlcoholLb.Location = New System.Drawing.Point(829, 22)
        Me.AlcoholLb.Name = "AlcoholLb"
        Me.AlcoholLb.Padding = New System.Windows.Forms.Padding(10)
        Me.AlcoholLb.Size = New System.Drawing.Size(91, 39)
        Me.AlcoholLb.TabIndex = 23
        Me.AlcoholLb.Text = "Alcohol : "
        '
        'RealTimeLb
        '
        Me.RealTimeLb.AutoSize = True
        Me.RealTimeLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RealTimeLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealTimeLb.ForeColor = System.Drawing.Color.Red
        Me.RealTimeLb.Location = New System.Drawing.Point(1675, 23)
        Me.RealTimeLb.Name = "RealTimeLb"
        Me.RealTimeLb.Padding = New System.Windows.Forms.Padding(10)
        Me.RealTimeLb.Size = New System.Drawing.Size(217, 38)
        Me.RealTimeLb.TabIndex = 40
        Me.RealTimeLb.Text = "Current Time : hh.mm.ss pm"
        '
        'Connection0
        '
        Me.Connection0.Location = New System.Drawing.Point(103, 57)
        Me.Connection0.Name = "Connection0"
        Me.Connection0.Size = New System.Drawing.Size(274, 19)
        Me.Connection0.TabIndex = 52
        '
        'ConnectCheck
        '
        Me.ConnectCheck.AutoSize = True
        Me.ConnectCheck.Checked = True
        Me.ConnectCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConnectCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConnectCheck.Location = New System.Drawing.Point(60, 24)
        Me.ConnectCheck.Name = "ConnectCheck"
        Me.ConnectCheck.Size = New System.Drawing.Size(40, 17)
        Me.ConnectCheck.TabIndex = 48
        Me.ConnectCheck.Text = "All"
        Me.ConnectCheck.UseVisualStyleBackColor = True
        '
        'StreamDebugIdx
        '
        Me.StreamDebugIdx.Location = New System.Drawing.Point(110, 22)
        Me.StreamDebugIdx.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.StreamDebugIdx.Name = "StreamDebugIdx"
        Me.StreamDebugIdx.Size = New System.Drawing.Size(48, 20)
        Me.StreamDebugIdx.TabIndex = 50
        '
        'ConfigBt
        '
        Me.ConfigBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfigBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ConfigBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfigBt.Location = New System.Drawing.Point(1056, 935)
        Me.ConfigBt.Name = "ConfigBt"
        Me.ConfigBt.Size = New System.Drawing.Size(80, 46)
        Me.ConfigBt.TabIndex = 49
        Me.ConfigBt.Text = "Configure"
        Me.ConfigBt.UseVisualStyleBackColor = False
        '
        'Packet
        '
        Me.Packet.Location = New System.Drawing.Point(205, 22)
        Me.Packet.Name = "Packet"
        Me.Packet.Size = New System.Drawing.Size(143, 20)
        Me.Packet.TabIndex = 47
        '
        'debugButton
        '
        Me.debugButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.debugButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.debugButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debugButton.ForeColor = System.Drawing.Color.Black
        Me.debugButton.Location = New System.Drawing.Point(1409, 935)
        Me.debugButton.Name = "debugButton"
        Me.debugButton.Size = New System.Drawing.Size(80, 46)
        Me.debugButton.TabIndex = 46
        Me.debugButton.Text = "Debug"
        Me.debugButton.UseVisualStyleBackColor = False
        '
        'Connect
        '
        Me.Connect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connect.Location = New System.Drawing.Point(16, 928)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(127, 53)
        Me.Connect.TabIndex = 45
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = False
        '
        'DebugGrp
        '
        Me.DebugGrp.Controls.Add(Me.ComboBox1)
        Me.DebugGrp.Controls.Add(Me.Connection0)
        Me.DebugGrp.Controls.Add(Me.ConnectCheck)
        Me.DebugGrp.Controls.Add(Me.StreamDebugIdx)
        Me.DebugGrp.Controls.Add(Me.Packet)
        Me.DebugGrp.ForeColor = System.Drawing.Color.White
        Me.DebugGrp.Location = New System.Drawing.Point(1495, 910)
        Me.DebugGrp.Name = "DebugGrp"
        Me.DebugGrp.Size = New System.Drawing.Size(397, 89)
        Me.DebugGrp.TabIndex = 56
        Me.DebugGrp.TabStop = False
        Me.DebugGrp.Text = "Debug features"
        Me.DebugGrp.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(70, 21)
        Me.ComboBox1.TabIndex = 51
        '
        'Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1904, 1011)
        Me.Controls.Add(Me.DebugGrp)
        Me.Controls.Add(Me.debugButton)
        Me.Controls.Add(Me.ConfigBt)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.RealTimeLb)
        Me.Controls.Add(Me.SmokeLb)
        Me.Controls.Add(Me.COLb)
        Me.Controls.Add(Me.AlcoholLb)
        Me.Controls.Add(Me.PressureLb)
        Me.Controls.Add(Me.HumidityLb)
        Me.Controls.Add(Me.TemperatureLb)
        Me.Controls.Add(Me.Tabs)
        Me.Name = "Controller"
        Me.Text = "Controller"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tabs.ResumeLayout(False)
        Me.ApplianceTab.ResumeLayout(False)
        Me.ApplianceTab.PerformLayout()
        CType(Me.StreamDebugIdx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DebugGrp.ResumeLayout(False)
        Me.DebugGrp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents ApplianceTab As TabPage
    Friend WithEvents Light1Bt As Button
    Friend WithEvents Light0Bt As Button
    Friend WithEvents Room0Rb As RadioButton
    Friend WithEvents Light2Bt As Button
    Friend WithEvents Light4 As Button
    Friend WithEvents Light3 As Button
    Friend WithEvents Light8 As Button
    Friend WithEvents Light7 As Button
    Friend WithEvents Light6 As Button
    Friend WithEvents Light5 As Button
    Friend WithEvents Fan2 As Button
    Friend WithEvents Fan1 As Button
    Friend WithEvents Fan0 As Button
    Friend WithEvents GN1 As Button
    Friend WithEvents GN0 As Button
    Friend WithEvents Plug8 As Button
    Friend WithEvents Plug7 As Button
    Friend WithEvents Plug6 As Button
    Friend WithEvents Plug5 As Button
    Friend WithEvents Plug4 As Button
    Friend WithEvents Plug3 As Button
    Friend WithEvents Plug2 As Button
    Friend WithEvents Plug1 As Button
    Friend WithEvents Plug0 As Button
    Friend WithEvents TemperatureLb As Label
    Friend WithEvents HumidityLb As Label
    Friend WithEvents PressureLb As Label
    Friend WithEvents SmokeLb As Label
    Friend WithEvents COLb As Label
    Friend WithEvents AlcoholLb As Label
    Friend WithEvents RealTimeLb As Label
    Friend WithEvents Connection0 As ProgressBar
    Friend WithEvents ConnectCheck As CheckBox
    Friend WithEvents StreamDebugIdx As NumericUpDown
    Friend WithEvents ConfigBt As Button
    Friend WithEvents Packet As TextBox
    Friend WithEvents debugButton As Button
    Friend WithEvents Connect As Button
    Friend WithEvents DebugGrp As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
