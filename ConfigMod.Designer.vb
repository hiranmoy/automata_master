<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigMod
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
        Me.AddApplianceBt = New System.Windows.Forms.Button()
        Me.ApplianceList = New System.Windows.Forms.ComboBox()
        Me.ConfigApplianceGrp = New System.Windows.Forms.GroupBox()
        Me.SpecialApplianceGrp = New System.Windows.Forms.GroupBox()
        Me.SpeakerList = New System.Windows.Forms.ComboBox()
        Me.ACList = New System.Windows.Forms.ComboBox()
        Me.RGLEDList = New System.Windows.Forms.ComboBox()
        Me.ApplianceRoomLb = New System.Windows.Forms.Label()
        Me.ApplianceRoomNm = New System.Windows.Forms.NumericUpDown()
        Me.AppliancePriorityLb = New System.Windows.Forms.Label()
        Me.ApplianceTypeLb = New System.Windows.Forms.Label()
        Me.ApplianceGPIOLb = New System.Windows.Forms.Label()
        Me.ApplianceRpiLb = New System.Windows.Forms.Label()
        Me.ApplianceNameLb = New System.Windows.Forms.Label()
        Me.ApplianceDeleteBt = New System.Windows.Forms.Button()
        Me.ApplianceNameTb = New System.Windows.Forms.TextBox()
        Me.AppliancePriority = New System.Windows.Forms.NumericUpDown()
        Me.ApplianceTypeList = New System.Windows.Forms.ComboBox()
        Me.ApplianceGPIONm = New System.Windows.Forms.NumericUpDown()
        Me.ApplianceRpiTb = New System.Windows.Forms.TextBox()
        Me.ConfigCameraGrp = New System.Windows.Forms.GroupBox()
        Me.CameraRoomNm = New System.Windows.Forms.NumericUpDown()
        Me.CameraDeleteBt = New System.Windows.Forms.Button()
        Me.CameraNameTb = New System.Windows.Forms.TextBox()
        Me.CameraPriority = New System.Windows.Forms.NumericUpDown()
        Me.AddCameraBt = New System.Windows.Forms.Button()
        Me.CameraList = New System.Windows.Forms.ComboBox()
        Me.CameraRoomLb = New System.Windows.Forms.Label()
        Me.CameraPriorityLb = New System.Windows.Forms.Label()
        Me.CameraNameLb = New System.Windows.Forms.Label()
        Me.ConfigSensorGrp = New System.Windows.Forms.GroupBox()
        Me.SensorRoomLb = New System.Windows.Forms.Label()
        Me.SensorRoomNm = New System.Windows.Forms.NumericUpDown()
        Me.SensorNameLb = New System.Windows.Forms.Label()
        Me.SensorNameTb = New System.Windows.Forms.TextBox()
        Me.SensorDeleteBt = New System.Windows.Forms.Button()
        Me.SensorList = New System.Windows.Forms.ComboBox()
        Me.AddSensorBt = New System.Windows.Forms.Button()
        Me.CameraRpiLb = New System.Windows.Forms.Label()
        Me.CameraRpiTb = New System.Windows.Forms.TextBox()
        Me.SensorRpiLb = New System.Windows.Forms.Label()
        Me.SensorRpiTb = New System.Windows.Forms.TextBox()
        Me.SensorTypeLb = New System.Windows.Forms.Label()
        Me.SensorTypeList = New System.Windows.Forms.ComboBox()
        Me.ConfigApplianceGrp.SuspendLayout()
        Me.SpecialApplianceGrp.SuspendLayout()
        CType(Me.ApplianceRoomNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppliancePriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplianceGPIONm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfigCameraGrp.SuspendLayout()
        CType(Me.CameraRoomNm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CameraPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfigSensorGrp.SuspendLayout()
        CType(Me.SensorRoomNm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddApplianceBt
        '
        Me.AddApplianceBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddApplianceBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddApplianceBt.Location = New System.Drawing.Point(26, 132)
        Me.AddApplianceBt.Name = "AddApplianceBt"
        Me.AddApplianceBt.Size = New System.Drawing.Size(102, 50)
        Me.AddApplianceBt.TabIndex = 0
        Me.AddApplianceBt.Text = "Add/Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appliance"
        Me.AddApplianceBt.UseVisualStyleBackColor = False
        '
        'ApplianceList
        '
        Me.ApplianceList.FormattingEnabled = True
        Me.ApplianceList.Location = New System.Drawing.Point(26, 34)
        Me.ApplianceList.Name = "ApplianceList"
        Me.ApplianceList.Size = New System.Drawing.Size(121, 21)
        Me.ApplianceList.TabIndex = 1
        '
        'ConfigApplianceGrp
        '
        Me.ConfigApplianceGrp.BackColor = System.Drawing.Color.PapayaWhip
        Me.ConfigApplianceGrp.Controls.Add(Me.SpecialApplianceGrp)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceRoomLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceRoomNm)
        Me.ConfigApplianceGrp.Controls.Add(Me.AppliancePriorityLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceTypeLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceGPIOLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceRpiLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceNameLb)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceDeleteBt)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceNameTb)
        Me.ConfigApplianceGrp.Controls.Add(Me.AppliancePriority)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceTypeList)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceGPIONm)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceRpiTb)
        Me.ConfigApplianceGrp.Controls.Add(Me.AddApplianceBt)
        Me.ConfigApplianceGrp.Controls.Add(Me.ApplianceList)
        Me.ConfigApplianceGrp.Location = New System.Drawing.Point(12, 12)
        Me.ConfigApplianceGrp.Name = "ConfigApplianceGrp"
        Me.ConfigApplianceGrp.Size = New System.Drawing.Size(641, 439)
        Me.ConfigApplianceGrp.TabIndex = 2
        Me.ConfigApplianceGrp.TabStop = False
        Me.ConfigApplianceGrp.Text = "Appliance"
        '
        'SpecialApplianceGrp
        '
        Me.SpecialApplianceGrp.BackColor = System.Drawing.Color.Snow
        Me.SpecialApplianceGrp.Controls.Add(Me.SpeakerList)
        Me.SpecialApplianceGrp.Controls.Add(Me.ACList)
        Me.SpecialApplianceGrp.Controls.Add(Me.RGLEDList)
        Me.SpecialApplianceGrp.Location = New System.Drawing.Point(26, 246)
        Me.SpecialApplianceGrp.Name = "SpecialApplianceGrp"
        Me.SpecialApplianceGrp.Size = New System.Drawing.Size(597, 160)
        Me.SpecialApplianceGrp.TabIndex = 16
        Me.SpecialApplianceGrp.TabStop = False
        Me.SpecialApplianceGrp.Text = "Category"
        '
        'SpeakerList
        '
        Me.SpeakerList.Enabled = False
        Me.SpeakerList.FormattingEnabled = True
        Me.SpeakerList.Items.AddRange(New Object() {"F&D F550X"})
        Me.SpeakerList.Location = New System.Drawing.Point(15, 104)
        Me.SpeakerList.Name = "SpeakerList"
        Me.SpeakerList.Size = New System.Drawing.Size(210, 21)
        Me.SpeakerList.TabIndex = 2
        '
        'ACList
        '
        Me.ACList.Enabled = False
        Me.ACList.FormattingEnabled = True
        Me.ACList.Items.AddRange(New Object() {"Voltas Window AC (3*) (2014)"})
        Me.ACList.Location = New System.Drawing.Point(367, 38)
        Me.ACList.Name = "ACList"
        Me.ACList.Size = New System.Drawing.Size(210, 21)
        Me.ACList.TabIndex = 1
        '
        'RGLEDList
        '
        Me.RGLEDList.Enabled = False
        Me.RGLEDList.FormattingEnabled = True
        Me.RGLEDList.Items.AddRange(New Object() {"Flood Light (10 W)"})
        Me.RGLEDList.Location = New System.Drawing.Point(15, 38)
        Me.RGLEDList.Name = "RGLEDList"
        Me.RGLEDList.Size = New System.Drawing.Size(210, 21)
        Me.RGLEDList.TabIndex = 0
        '
        'ApplianceRoomLb
        '
        Me.ApplianceRoomLb.AutoSize = True
        Me.ApplianceRoomLb.Location = New System.Drawing.Point(374, 100)
        Me.ApplianceRoomLb.Name = "ApplianceRoomLb"
        Me.ApplianceRoomLb.Size = New System.Drawing.Size(61, 13)
        Me.ApplianceRoomLb.TabIndex = 14
        Me.ApplianceRoomLb.Text = "Room No. :"
        '
        'ApplianceRoomNm
        '
        Me.ApplianceRoomNm.Location = New System.Drawing.Point(377, 118)
        Me.ApplianceRoomNm.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ApplianceRoomNm.Name = "ApplianceRoomNm"
        Me.ApplianceRoomNm.Size = New System.Drawing.Size(42, 20)
        Me.ApplianceRoomNm.TabIndex = 13
        '
        'AppliancePriorityLb
        '
        Me.AppliancePriorityLb.AutoSize = True
        Me.AppliancePriorityLb.Location = New System.Drawing.Point(576, 101)
        Me.AppliancePriorityLb.Name = "AppliancePriorityLb"
        Me.AppliancePriorityLb.Size = New System.Drawing.Size(44, 13)
        Me.AppliancePriorityLb.TabIndex = 12
        Me.AppliancePriorityLb.Text = "Priority :"
        '
        'ApplianceTypeLb
        '
        Me.ApplianceTypeLb.AutoSize = True
        Me.ApplianceTypeLb.Location = New System.Drawing.Point(452, 101)
        Me.ApplianceTypeLb.Name = "ApplianceTypeLb"
        Me.ApplianceTypeLb.Size = New System.Drawing.Size(37, 13)
        Me.ApplianceTypeLb.TabIndex = 11
        Me.ApplianceTypeLb.Text = "Type :"
        '
        'ApplianceGPIOLb
        '
        Me.ApplianceGPIOLb.AutoSize = True
        Me.ApplianceGPIOLb.Location = New System.Drawing.Point(325, 169)
        Me.ApplianceGPIOLb.Name = "ApplianceGPIOLb"
        Me.ApplianceGPIOLb.Size = New System.Drawing.Size(39, 13)
        Me.ApplianceGPIOLb.TabIndex = 10
        Me.ApplianceGPIOLb.Text = "GPIO :"
        '
        'ApplianceRpiLb
        '
        Me.ApplianceRpiLb.AutoSize = True
        Me.ApplianceRpiLb.Location = New System.Drawing.Point(211, 169)
        Me.ApplianceRpiLb.Name = "ApplianceRpiLb"
        Me.ApplianceRpiLb.Size = New System.Drawing.Size(45, 13)
        Me.ApplianceRpiLb.TabIndex = 9
        Me.ApplianceRpiLb.Text = "Module:"
        '
        'ApplianceNameLb
        '
        Me.ApplianceNameLb.AutoSize = True
        Me.ApplianceNameLb.Location = New System.Drawing.Point(210, 102)
        Me.ApplianceNameLb.Name = "ApplianceNameLb"
        Me.ApplianceNameLb.Size = New System.Drawing.Size(41, 13)
        Me.ApplianceNameLb.TabIndex = 8
        Me.ApplianceNameLb.Text = "Name :"
        '
        'ApplianceDeleteBt
        '
        Me.ApplianceDeleteBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ApplianceDeleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ApplianceDeleteBt.Location = New System.Drawing.Point(181, 34)
        Me.ApplianceDeleteBt.Name = "ApplianceDeleteBt"
        Me.ApplianceDeleteBt.Size = New System.Drawing.Size(75, 32)
        Me.ApplianceDeleteBt.TabIndex = 7
        Me.ApplianceDeleteBt.Text = "Delete"
        Me.ApplianceDeleteBt.UseVisualStyleBackColor = False
        '
        'ApplianceNameTb
        '
        Me.ApplianceNameTb.Location = New System.Drawing.Point(213, 118)
        Me.ApplianceNameTb.Name = "ApplianceNameTb"
        Me.ApplianceNameTb.Size = New System.Drawing.Size(126, 20)
        Me.ApplianceNameTb.TabIndex = 6
        '
        'AppliancePriority
        '
        Me.AppliancePriority.Location = New System.Drawing.Point(579, 117)
        Me.AppliancePriority.Name = "AppliancePriority"
        Me.AppliancePriority.Size = New System.Drawing.Size(44, 20)
        Me.AppliancePriority.TabIndex = 5
        '
        'ApplianceTypeList
        '
        Me.ApplianceTypeList.FormattingEnabled = True
        Me.ApplianceTypeList.Items.AddRange(New Object() {"Bright Light", "Fan", "Small Light", "Mosquito Repeller", "Laptop", "AC", "Speaker", "RGB LED"})
        Me.ApplianceTypeList.Location = New System.Drawing.Point(455, 117)
        Me.ApplianceTypeList.Name = "ApplianceTypeList"
        Me.ApplianceTypeList.Size = New System.Drawing.Size(106, 21)
        Me.ApplianceTypeList.TabIndex = 4
        '
        'ApplianceGPIONm
        '
        Me.ApplianceGPIONm.Location = New System.Drawing.Point(328, 185)
        Me.ApplianceGPIONm.Maximum = New Decimal(New Integer() {27, 0, 0, 0})
        Me.ApplianceGPIONm.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.ApplianceGPIONm.Name = "ApplianceGPIONm"
        Me.ApplianceGPIONm.Size = New System.Drawing.Size(42, 20)
        Me.ApplianceGPIONm.TabIndex = 3
        Me.ApplianceGPIONm.Value = New Decimal(New Integer() {21, 0, 0, 0})
        '
        'ApplianceRpiTb
        '
        Me.ApplianceRpiTb.Location = New System.Drawing.Point(214, 185)
        Me.ApplianceRpiTb.Name = "ApplianceRpiTb"
        Me.ApplianceRpiTb.Size = New System.Drawing.Size(83, 20)
        Me.ApplianceRpiTb.TabIndex = 2
        '
        'ConfigCameraGrp
        '
        Me.ConfigCameraGrp.BackColor = System.Drawing.Color.PapayaWhip
        Me.ConfigCameraGrp.Controls.Add(Me.CameraRpiLb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraRoomLb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraRpiTb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraPriorityLb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraRoomNm)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraNameLb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraNameTb)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraDeleteBt)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraList)
        Me.ConfigCameraGrp.Controls.Add(Me.AddCameraBt)
        Me.ConfigCameraGrp.Controls.Add(Me.CameraPriority)
        Me.ConfigCameraGrp.Location = New System.Drawing.Point(670, 12)
        Me.ConfigCameraGrp.Name = "ConfigCameraGrp"
        Me.ConfigCameraGrp.Size = New System.Drawing.Size(630, 168)
        Me.ConfigCameraGrp.TabIndex = 3
        Me.ConfigCameraGrp.TabStop = False
        Me.ConfigCameraGrp.Text = "Camera"
        '
        'CameraRoomNm
        '
        Me.CameraRoomNm.Location = New System.Drawing.Point(329, 119)
        Me.CameraRoomNm.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CameraRoomNm.Name = "CameraRoomNm"
        Me.CameraRoomNm.Size = New System.Drawing.Size(42, 20)
        Me.CameraRoomNm.TabIndex = 22
        '
        'CameraDeleteBt
        '
        Me.CameraDeleteBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CameraDeleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CameraDeleteBt.Location = New System.Drawing.Point(180, 36)
        Me.CameraDeleteBt.Name = "CameraDeleteBt"
        Me.CameraDeleteBt.Size = New System.Drawing.Size(75, 32)
        Me.CameraDeleteBt.TabIndex = 21
        Me.CameraDeleteBt.Text = "Delete"
        Me.CameraDeleteBt.UseVisualStyleBackColor = False
        '
        'CameraNameTb
        '
        Me.CameraNameTb.Location = New System.Drawing.Point(166, 119)
        Me.CameraNameTb.Name = "CameraNameTb"
        Me.CameraNameTb.Size = New System.Drawing.Size(126, 20)
        Me.CameraNameTb.TabIndex = 20
        '
        'CameraPriority
        '
        Me.CameraPriority.Location = New System.Drawing.Point(419, 119)
        Me.CameraPriority.Name = "CameraPriority"
        Me.CameraPriority.Size = New System.Drawing.Size(44, 20)
        Me.CameraPriority.TabIndex = 19
        '
        'AddCameraBt
        '
        Me.AddCameraBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddCameraBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddCameraBt.Location = New System.Drawing.Point(25, 89)
        Me.AddCameraBt.Name = "AddCameraBt"
        Me.AddCameraBt.Size = New System.Drawing.Size(102, 50)
        Me.AddCameraBt.TabIndex = 17
        Me.AddCameraBt.Text = "Add/Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Camera"
        Me.AddCameraBt.UseVisualStyleBackColor = False
        '
        'CameraList
        '
        Me.CameraList.FormattingEnabled = True
        Me.CameraList.Location = New System.Drawing.Point(25, 36)
        Me.CameraList.Name = "CameraList"
        Me.CameraList.Size = New System.Drawing.Size(121, 21)
        Me.CameraList.TabIndex = 18
        '
        'CameraRoomLb
        '
        Me.CameraRoomLb.AutoSize = True
        Me.CameraRoomLb.Location = New System.Drawing.Point(326, 103)
        Me.CameraRoomLb.Name = "CameraRoomLb"
        Me.CameraRoomLb.Size = New System.Drawing.Size(61, 13)
        Me.CameraRoomLb.TabIndex = 19
        Me.CameraRoomLb.Text = "Room No. :"
        '
        'CameraPriorityLb
        '
        Me.CameraPriorityLb.AutoSize = True
        Me.CameraPriorityLb.Location = New System.Drawing.Point(416, 103)
        Me.CameraPriorityLb.Name = "CameraPriorityLb"
        Me.CameraPriorityLb.Size = New System.Drawing.Size(44, 13)
        Me.CameraPriorityLb.TabIndex = 18
        Me.CameraPriorityLb.Text = "Priority :"
        '
        'CameraNameLb
        '
        Me.CameraNameLb.AutoSize = True
        Me.CameraNameLb.Location = New System.Drawing.Point(167, 103)
        Me.CameraNameLb.Name = "CameraNameLb"
        Me.CameraNameLb.Size = New System.Drawing.Size(41, 13)
        Me.CameraNameLb.TabIndex = 17
        Me.CameraNameLb.Text = "Name :"
        '
        'ConfigSensorGrp
        '
        Me.ConfigSensorGrp.BackColor = System.Drawing.Color.PapayaWhip
        Me.ConfigSensorGrp.Controls.Add(Me.SensorTypeLb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorRpiLb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorTypeList)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorRoomLb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorRpiTb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorRoomNm)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorNameLb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorNameTb)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorDeleteBt)
        Me.ConfigSensorGrp.Controls.Add(Me.SensorList)
        Me.ConfigSensorGrp.Controls.Add(Me.AddSensorBt)
        Me.ConfigSensorGrp.Location = New System.Drawing.Point(670, 283)
        Me.ConfigSensorGrp.Name = "ConfigSensorGrp"
        Me.ConfigSensorGrp.Size = New System.Drawing.Size(630, 168)
        Me.ConfigSensorGrp.TabIndex = 4
        Me.ConfigSensorGrp.TabStop = False
        Me.ConfigSensorGrp.Text = "Sensor"
        '
        'SensorRoomLb
        '
        Me.SensorRoomLb.AutoSize = True
        Me.SensorRoomLb.Location = New System.Drawing.Point(326, 103)
        Me.SensorRoomLb.Name = "SensorRoomLb"
        Me.SensorRoomLb.Size = New System.Drawing.Size(61, 13)
        Me.SensorRoomLb.TabIndex = 19
        Me.SensorRoomLb.Text = "Room No. :"
        '
        'SensorRoomNm
        '
        Me.SensorRoomNm.Location = New System.Drawing.Point(329, 119)
        Me.SensorRoomNm.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SensorRoomNm.Name = "SensorRoomNm"
        Me.SensorRoomNm.Size = New System.Drawing.Size(42, 20)
        Me.SensorRoomNm.TabIndex = 22
        '
        'SensorNameLb
        '
        Me.SensorNameLb.AutoSize = True
        Me.SensorNameLb.Location = New System.Drawing.Point(167, 102)
        Me.SensorNameLb.Name = "SensorNameLb"
        Me.SensorNameLb.Size = New System.Drawing.Size(41, 13)
        Me.SensorNameLb.TabIndex = 17
        Me.SensorNameLb.Text = "Name :"
        '
        'SensorNameTb
        '
        Me.SensorNameTb.Location = New System.Drawing.Point(166, 118)
        Me.SensorNameTb.Name = "SensorNameTb"
        Me.SensorNameTb.Size = New System.Drawing.Size(126, 20)
        Me.SensorNameTb.TabIndex = 20
        '
        'SensorDeleteBt
        '
        Me.SensorDeleteBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SensorDeleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SensorDeleteBt.Location = New System.Drawing.Point(180, 36)
        Me.SensorDeleteBt.Name = "SensorDeleteBt"
        Me.SensorDeleteBt.Size = New System.Drawing.Size(75, 32)
        Me.SensorDeleteBt.TabIndex = 21
        Me.SensorDeleteBt.Text = "Delete"
        Me.SensorDeleteBt.UseVisualStyleBackColor = False
        '
        'SensorList
        '
        Me.SensorList.FormattingEnabled = True
        Me.SensorList.Location = New System.Drawing.Point(25, 36)
        Me.SensorList.Name = "SensorList"
        Me.SensorList.Size = New System.Drawing.Size(121, 21)
        Me.SensorList.TabIndex = 18
        '
        'AddSensorBt
        '
        Me.AddSensorBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddSensorBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddSensorBt.Location = New System.Drawing.Point(25, 89)
        Me.AddSensorBt.Name = "AddSensorBt"
        Me.AddSensorBt.Size = New System.Drawing.Size(102, 50)
        Me.AddSensorBt.TabIndex = 17
        Me.AddSensorBt.Text = "Add/Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Camera"
        Me.AddSensorBt.UseVisualStyleBackColor = False
        '
        'CameraRpiLb
        '
        Me.CameraRpiLb.AutoSize = True
        Me.CameraRpiLb.Location = New System.Drawing.Point(497, 103)
        Me.CameraRpiLb.Name = "CameraRpiLb"
        Me.CameraRpiLb.Size = New System.Drawing.Size(45, 13)
        Me.CameraRpiLb.TabIndex = 18
        Me.CameraRpiLb.Text = "Module:"
        '
        'CameraRpiTb
        '
        Me.CameraRpiTb.Location = New System.Drawing.Point(500, 119)
        Me.CameraRpiTb.Name = "CameraRpiTb"
        Me.CameraRpiTb.Size = New System.Drawing.Size(83, 20)
        Me.CameraRpiTb.TabIndex = 17
        '
        'SensorRpiLb
        '
        Me.SensorRpiLb.AutoSize = True
        Me.SensorRpiLb.Location = New System.Drawing.Point(538, 103)
        Me.SensorRpiLb.Name = "SensorRpiLb"
        Me.SensorRpiLb.Size = New System.Drawing.Size(45, 13)
        Me.SensorRpiLb.TabIndex = 24
        Me.SensorRpiLb.Text = "Module:"
        '
        'SensorRpiTb
        '
        Me.SensorRpiTb.Location = New System.Drawing.Point(541, 119)
        Me.SensorRpiTb.Name = "SensorRpiTb"
        Me.SensorRpiTb.Size = New System.Drawing.Size(83, 20)
        Me.SensorRpiTb.TabIndex = 23
        '
        'SensorTypeLb
        '
        Me.SensorTypeLb.AutoSize = True
        Me.SensorTypeLb.Location = New System.Drawing.Point(406, 101)
        Me.SensorTypeLb.Name = "SensorTypeLb"
        Me.SensorTypeLb.Size = New System.Drawing.Size(37, 13)
        Me.SensorTypeLb.TabIndex = 13
        Me.SensorTypeLb.Text = "Type :"
        '
        'SensorTypeList
        '
        Me.SensorTypeList.FormattingEnabled = True
        Me.SensorTypeList.Items.AddRange(New Object() {"SenseHat", "MotionSensor", "GasSensors"})
        Me.SensorTypeList.Location = New System.Drawing.Point(409, 117)
        Me.SensorTypeList.Name = "SensorTypeList"
        Me.SensorTypeList.Size = New System.Drawing.Size(106, 21)
        Me.SensorTypeList.TabIndex = 12
        '
        'ConfigMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1311, 463)
        Me.Controls.Add(Me.ConfigSensorGrp)
        Me.Controls.Add(Me.ConfigCameraGrp)
        Me.Controls.Add(Me.ConfigApplianceGrp)
        Me.Name = "ConfigMod"
        Me.Text = "Configure"
        Me.ConfigApplianceGrp.ResumeLayout(False)
        Me.ConfigApplianceGrp.PerformLayout()
        Me.SpecialApplianceGrp.ResumeLayout(False)
        CType(Me.ApplianceRoomNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppliancePriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplianceGPIONm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfigCameraGrp.ResumeLayout(False)
        Me.ConfigCameraGrp.PerformLayout()
        CType(Me.CameraRoomNm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CameraPriority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfigSensorGrp.ResumeLayout(False)
        Me.ConfigSensorGrp.PerformLayout()
        CType(Me.SensorRoomNm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddApplianceBt As Button
    Friend WithEvents ApplianceList As ComboBox
    Friend WithEvents ConfigApplianceGrp As GroupBox
    Friend WithEvents ApplianceRpiTb As TextBox
    Friend WithEvents ApplianceGPIONm As NumericUpDown
    Friend WithEvents AppliancePriority As NumericUpDown
    Friend WithEvents ApplianceNameTb As TextBox
    Friend WithEvents ApplianceDeleteBt As Button
    Friend WithEvents ApplianceNameLb As Label
    Friend WithEvents ApplianceRpiLb As Label
    Friend WithEvents AppliancePriorityLb As Label
    Friend WithEvents ApplianceTypeLb As Label
    Friend WithEvents ApplianceGPIOLb As Label
    Friend WithEvents ApplianceRoomLb As Label
    Friend WithEvents ApplianceRoomNm As NumericUpDown
    Friend WithEvents ApplianceTypeList As ComboBox
    Friend WithEvents SpecialApplianceGrp As GroupBox
    Friend WithEvents ACList As ComboBox
    Friend WithEvents RGLEDList As ComboBox
    Friend WithEvents SpeakerList As ComboBox
    Friend WithEvents ConfigCameraGrp As GroupBox
    Friend WithEvents CameraRoomLb As Label
    Friend WithEvents CameraPriorityLb As Label
    Friend WithEvents CameraRoomNm As NumericUpDown
    Friend WithEvents CameraNameLb As Label
    Friend WithEvents CameraNameTb As TextBox
    Friend WithEvents CameraDeleteBt As Button
    Friend WithEvents CameraList As ComboBox
    Friend WithEvents AddCameraBt As Button
    Friend WithEvents CameraPriority As NumericUpDown
    Friend WithEvents ConfigSensorGrp As GroupBox
    Friend WithEvents SensorRoomLb As Label
    Friend WithEvents SensorRoomNm As NumericUpDown
    Friend WithEvents SensorNameLb As Label
    Friend WithEvents SensorNameTb As TextBox
    Friend WithEvents SensorDeleteBt As Button
    Friend WithEvents SensorList As ComboBox
    Friend WithEvents AddSensorBt As Button
    Friend WithEvents CameraRpiLb As Label
    Friend WithEvents CameraRpiTb As TextBox
    Friend WithEvents SensorRpiLb As Label
    Friend WithEvents SensorRpiTb As TextBox
    Friend WithEvents SensorTypeLb As Label
    Friend WithEvents SensorTypeList As ComboBox
End Class
