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
        Me.ApplianceRpiTb = New System.Windows.Forms.TextBox()
        Me.ApplianceGPIONm = New System.Windows.Forms.NumericUpDown()
        Me.AppliancePriority = New System.Windows.Forms.NumericUpDown()
        Me.ApplianceNameTb = New System.Windows.Forms.TextBox()
        Me.ApplianceDeleteBt = New System.Windows.Forms.Button()
        Me.ApplianceNameLb = New System.Windows.Forms.Label()
        Me.ApplianceRpiLb = New System.Windows.Forms.Label()
        Me.ApplianceGPIOLb = New System.Windows.Forms.Label()
        Me.ApplianceTypeLb = New System.Windows.Forms.Label()
        Me.AppliancePriorityLb = New System.Windows.Forms.Label()
        Me.ApplianceRoomNm = New System.Windows.Forms.NumericUpDown()
        Me.ApplianceRoomLb = New System.Windows.Forms.Label()
        Me.ApplianceTypeList = New System.Windows.Forms.ComboBox()
        Me.SpecialApplianceGrp = New System.Windows.Forms.GroupBox()
        Me.RGLEDList = New System.Windows.Forms.ComboBox()
        Me.ACList = New System.Windows.Forms.ComboBox()
        Me.SpeckerList = New System.Windows.Forms.ComboBox()
        Me.ConfigApplianceGrp.SuspendLayout()
        CType(Me.ApplianceGPIONm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppliancePriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplianceRoomNm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpecialApplianceGrp.SuspendLayout()
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
        'ApplianceRpiTb
        '
        Me.ApplianceRpiTb.Location = New System.Drawing.Point(214, 185)
        Me.ApplianceRpiTb.Name = "ApplianceRpiTb"
        Me.ApplianceRpiTb.Size = New System.Drawing.Size(83, 20)
        Me.ApplianceRpiTb.TabIndex = 2
        '
        'ApplianceGPIONm
        '
        Me.ApplianceGPIONm.Location = New System.Drawing.Point(328, 185)
        Me.ApplianceGPIONm.Maximum = New Decimal(New Integer() {27, 0, 0, 0})
        Me.ApplianceGPIONm.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ApplianceGPIONm.Name = "ApplianceGPIONm"
        Me.ApplianceGPIONm.Size = New System.Drawing.Size(42, 20)
        Me.ApplianceGPIONm.TabIndex = 3
        Me.ApplianceGPIONm.Value = New Decimal(New Integer() {21, 0, 0, 0})
        '
        'AppliancePriority
        '
        Me.AppliancePriority.Location = New System.Drawing.Point(579, 117)
        Me.AppliancePriority.Name = "AppliancePriority"
        Me.AppliancePriority.Size = New System.Drawing.Size(44, 20)
        Me.AppliancePriority.TabIndex = 5
        '
        'ApplianceNameTb
        '
        Me.ApplianceNameTb.Location = New System.Drawing.Point(213, 118)
        Me.ApplianceNameTb.Name = "ApplianceNameTb"
        Me.ApplianceNameTb.Size = New System.Drawing.Size(126, 20)
        Me.ApplianceNameTb.TabIndex = 6
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
        'ApplianceNameLb
        '
        Me.ApplianceNameLb.AutoSize = True
        Me.ApplianceNameLb.Location = New System.Drawing.Point(210, 102)
        Me.ApplianceNameLb.Name = "ApplianceNameLb"
        Me.ApplianceNameLb.Size = New System.Drawing.Size(41, 13)
        Me.ApplianceNameLb.TabIndex = 8
        Me.ApplianceNameLb.Text = "Name :"
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
        'ApplianceGPIOLb
        '
        Me.ApplianceGPIOLb.AutoSize = True
        Me.ApplianceGPIOLb.Location = New System.Drawing.Point(325, 169)
        Me.ApplianceGPIOLb.Name = "ApplianceGPIOLb"
        Me.ApplianceGPIOLb.Size = New System.Drawing.Size(39, 13)
        Me.ApplianceGPIOLb.TabIndex = 10
        Me.ApplianceGPIOLb.Text = "GPIO :"
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
        'AppliancePriorityLb
        '
        Me.AppliancePriorityLb.AutoSize = True
        Me.AppliancePriorityLb.Location = New System.Drawing.Point(576, 101)
        Me.AppliancePriorityLb.Name = "AppliancePriorityLb"
        Me.AppliancePriorityLb.Size = New System.Drawing.Size(44, 13)
        Me.AppliancePriorityLb.TabIndex = 12
        Me.AppliancePriorityLb.Text = "Priority :"
        '
        'ApplianceRoomNm
        '
        Me.ApplianceRoomNm.Location = New System.Drawing.Point(377, 118)
        Me.ApplianceRoomNm.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ApplianceRoomNm.Name = "ApplianceRoomNm"
        Me.ApplianceRoomNm.Size = New System.Drawing.Size(42, 20)
        Me.ApplianceRoomNm.TabIndex = 13
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
        'ApplianceTypeList
        '
        Me.ApplianceTypeList.FormattingEnabled = True
        Me.ApplianceTypeList.Items.AddRange(New Object() {"Bright Light", "Fan", "Small Light", "Mosquito Repeller", "Laptop", "AC", "Speaker", "RGB LED"})
        Me.ApplianceTypeList.Location = New System.Drawing.Point(455, 117)
        Me.ApplianceTypeList.Name = "ApplianceTypeList"
        Me.ApplianceTypeList.Size = New System.Drawing.Size(106, 21)
        Me.ApplianceTypeList.TabIndex = 4
        '
        'SpecialApplianceGrp
        '
        Me.SpecialApplianceGrp.BackColor = System.Drawing.Color.Snow
        Me.SpecialApplianceGrp.Controls.Add(Me.SpeckerList)
        Me.SpecialApplianceGrp.Controls.Add(Me.ACList)
        Me.SpecialApplianceGrp.Controls.Add(Me.RGLEDList)
        Me.SpecialApplianceGrp.Location = New System.Drawing.Point(26, 246)
        Me.SpecialApplianceGrp.Name = "SpecialApplianceGrp"
        Me.SpecialApplianceGrp.Size = New System.Drawing.Size(597, 160)
        Me.SpecialApplianceGrp.TabIndex = 16
        Me.SpecialApplianceGrp.TabStop = False
        Me.SpecialApplianceGrp.Text = "Category"
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
        'SpeckerList
        '
        Me.SpeckerList.Enabled = False
        Me.SpeckerList.FormattingEnabled = True
        Me.SpeckerList.Items.AddRange(New Object() {"F&D F550X"})
        Me.SpeckerList.Location = New System.Drawing.Point(15, 104)
        Me.SpeckerList.Name = "SpeckerList"
        Me.SpeckerList.Size = New System.Drawing.Size(210, 21)
        Me.SpeckerList.TabIndex = 2
        '
        'ConfigMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(674, 470)
        Me.Controls.Add(Me.ConfigApplianceGrp)
        Me.Name = "ConfigMod"
        Me.Text = "Configure"
        Me.ConfigApplianceGrp.ResumeLayout(False)
        Me.ConfigApplianceGrp.PerformLayout()
        CType(Me.ApplianceGPIONm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppliancePriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplianceRoomNm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpecialApplianceGrp.ResumeLayout(False)
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
    Friend WithEvents SpeckerList As ComboBox
End Class
