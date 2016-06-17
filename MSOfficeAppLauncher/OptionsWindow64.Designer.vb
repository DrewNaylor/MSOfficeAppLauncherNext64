<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsWindow64
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.groupboxChangelogStyle = New System.Windows.Forms.GroupBox()
        Me.checkboxChangelog = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonResetToDefaults = New System.Windows.Forms.Button()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.buttonClearDrive = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxOfficeDrive = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.groupboxChangelogStyle.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.groupboxChangelogStyle)
        Me.Panel1.Controls.Add(Me.buttonCancel)
        Me.Panel1.Controls.Add(Me.buttonResetToDefaults)
        Me.Panel1.Controls.Add(Me.buttonSaveSettings)
        Me.Panel1.Controls.Add(Me.groupboxOfficeLocation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 292)
        Me.Panel1.TabIndex = 0
        '
        'groupboxChangelogStyle
        '
        Me.groupboxChangelogStyle.Controls.Add(Me.checkboxChangelog)
        Me.groupboxChangelogStyle.Controls.Add(Me.Label3)
        Me.groupboxChangelogStyle.Location = New System.Drawing.Point(4, 126)
        Me.groupboxChangelogStyle.Name = "groupboxChangelogStyle"
        Me.groupboxChangelogStyle.Size = New System.Drawing.Size(361, 107)
        Me.groupboxChangelogStyle.TabIndex = 0
        Me.groupboxChangelogStyle.TabStop = False
        Me.groupboxChangelogStyle.Text = "How should changelogs be presented?"
        '
        'checkboxChangelog
        '
        Me.checkboxChangelog.AutoSize = True
        Me.checkboxChangelog.Checked = True
        Me.checkboxChangelog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxChangelog.Location = New System.Drawing.Point(21, 78)
        Me.checkboxChangelog.Name = "checkboxChangelog"
        Me.checkboxChangelog.Size = New System.Drawing.Size(323, 17)
        Me.checkboxChangelog.TabIndex = 3
        Me.checkboxChangelog.Text = "Use the old, soon-to-be-unsupported internal changelog pages."
        Me.checkboxChangelog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(39, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "The following option will be removed in version 3.0." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If unsure, leave it uncheck" & _
    "ed."
        '
        'buttonCancel
        '
        Me.buttonCancel.AccessibleName = "Cancel Button"
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.Location = New System.Drawing.Point(211, 260)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(64, 23)
        Me.buttonCancel.TabIndex = 98
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonResetToDefaults
        '
        Me.buttonResetToDefaults.AccessibleName = "Restore Defaults Button"
        Me.buttonResetToDefaults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonResetToDefaults.Location = New System.Drawing.Point(12, 260)
        Me.buttonResetToDefaults.Name = "buttonResetToDefaults"
        Me.buttonResetToDefaults.Size = New System.Drawing.Size(64, 23)
        Me.buttonResetToDefaults.TabIndex = 97
        Me.buttonResetToDefaults.Text = "Defaults"
        Me.buttonResetToDefaults.UseVisualStyleBackColor = True
        '
        'buttonSaveSettings
        '
        Me.buttonSaveSettings.AccessibleName = "Save Button"
        Me.buttonSaveSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSaveSettings.Location = New System.Drawing.Point(292, 260)
        Me.buttonSaveSettings.Name = "buttonSaveSettings"
        Me.buttonSaveSettings.Size = New System.Drawing.Size(64, 23)
        Me.buttonSaveSettings.TabIndex = 99
        Me.buttonSaveSettings.Text = "Save"
        Me.buttonSaveSettings.UseVisualStyleBackColor = True
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonClearDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.Label2)
        Me.groupboxOfficeLocation.Controls.Add(Me.textboxOfficeDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.Label1)
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(3, 3)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(362, 116)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Where is Microsoft Office located?"
        '
        'buttonClearDrive
        '
        Me.buttonClearDrive.AutoSize = True
        Me.buttonClearDrive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonClearDrive.Location = New System.Drawing.Point(285, 76)
        Me.buttonClearDrive.Name = "buttonClearDrive"
        Me.buttonClearDrive.Size = New System.Drawing.Size(41, 23)
        Me.buttonClearDrive.TabIndex = 2
        Me.buttonClearDrive.Text = "Clear"
        Me.buttonClearDrive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please type in the textbox below the drive you installed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Microsoft Office on. No" & _
    "te that you cannot use backspaces," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lowercase letters (a, b, c,) or numbers/spec" & _
    "ial characters."
        '
        'textboxOfficeDrive
        '
        Me.textboxOfficeDrive.AccessibleName = "Please type in the textbox the drive you installed"
        Me.textboxOfficeDrive.Location = New System.Drawing.Point(22, 79)
        Me.textboxOfficeDrive.MaxLength = 1
        Me.textboxOfficeDrive.Name = "textboxOfficeDrive"
        Me.textboxOfficeDrive.ShortcutsEnabled = False
        Me.textboxOfficeDrive.Size = New System.Drawing.Size(20, 20)
        Me.textboxOfficeDrive.TabIndex = 1
        Me.textboxOfficeDrive.Text = "C"
        Me.textboxOfficeDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textboxOfficeDrive.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(40, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":\Program Files (X86)\Microsoft Office\Office14"
        '
        'OptionsWindow64
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 292)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsWindow64"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.groupboxChangelogStyle.ResumeLayout(False)
        Me.groupboxChangelogStyle.PerformLayout()
        Me.groupboxOfficeLocation.ResumeLayout(False)
        Me.groupboxOfficeLocation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents groupboxOfficeLocation As System.Windows.Forms.GroupBox
    Friend WithEvents buttonSaveSettings As System.Windows.Forms.Button
    Friend WithEvents buttonResetToDefaults As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonCancel As System.Windows.Forms.Button
    Friend WithEvents textboxOfficeDrive As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents buttonClearDrive As System.Windows.Forms.Button
    Friend WithEvents groupboxChangelogStyle As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkboxChangelog As System.Windows.Forms.CheckBox
End Class
