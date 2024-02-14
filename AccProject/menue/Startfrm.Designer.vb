<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startfrm
    Inherits ZeftawyTools.startProjectForm

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
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(359, 9)
        '
        'Labelbox
        '
        Me.Labelbox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelbox.Location = New System.Drawing.Point(498, 288)
        '
        'T_button
        '
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'Startfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 454)
        Me.MyFormSurrundColor = System.Drawing.Color.DimGray
        Me.Name = "Startfrm"
        Me.Opacity = 1.0R
        Me.Text = "Startfrm"
        Me.WellcomFontColor = System.Drawing.Color.Yellow
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
