<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HTML32BitVerHist
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
        Me.HTML32BitViewer = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HTML32BitViewer
        '
        Me.HTML32BitViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HTML32BitViewer.Location = New System.Drawing.Point(0, 0)
        Me.HTML32BitViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HTML32BitViewer.Name = "HTML32BitViewer"
        Me.HTML32BitViewer.ScrollBarsEnabled = False
        Me.HTML32BitViewer.Size = New System.Drawing.Size(376, 453)
        Me.HTML32BitViewer.TabIndex = 0
        Me.HTML32BitViewer.Url = New System.Uri("C:\resources.drew_general\rss_feeds\drews-apps_office32launch-rss.html", System.UriKind.Absolute)
        '
        'HTML32BitVerHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 453)
        Me.Controls.Add(Me.HTML32BitViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HTML32BitVerHist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "32-Bit Version History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HTML32BitViewer As System.Windows.Forms.WebBrowser

End Class
