<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcomeform
    Inherits ZeftawyTools.WelcomeFrm

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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(150, 328)
        Me.Label3.Size = New System.Drawing.Size(349, 50)
        Me.Label3.Text = "01120031403"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(125, 272)
        Me.Label1.Size = New System.Drawing.Size(260, 50)
        Me.Label1.Text = "Z-Apps تصميم  "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-4, 145)
        Me.Label2.Size = New System.Drawing.Size(492, 71)
        Me.Label2.Text = "Z-bookShope"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(93, 215)
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(260, 50)
        Me.Label5.Text = "النسخة :1.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(113, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        '
        'Welcomeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 511)
        Me.CombonyName = "Z-Apps تصميم  "
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyFormCenterColor = System.Drawing.Color.Gold
        Me.MyFormSurrundColor = System.Drawing.Color.DarkGoldenrod
        Me.Name = "Welcomeform"
        Me.PHone = "01120031403"
        Me.prograamName = "Z-bookShope"
        Me.Text = "شاشة التحريب"
        Me.Version = "النسخة :1.00"
        Me.WellcomStart = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
