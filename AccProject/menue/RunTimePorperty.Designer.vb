<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RunTimeColorPorperty
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Colorlbl = New System.Windows.Forms.Label()
        Me.PropertyNamelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Colorlbl
        '
        Me.Colorlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Colorlbl.Location = New System.Drawing.Point(13, 10)
        Me.Colorlbl.Name = "Colorlbl"
        Me.Colorlbl.Size = New System.Drawing.Size(47, 36)
        Me.Colorlbl.TabIndex = 0
        '
        'PropertyNamelbl
        '
        Me.PropertyNamelbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropertyNamelbl.AutoSize = True
        Me.PropertyNamelbl.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyNamelbl.Location = New System.Drawing.Point(66, 17)
        Me.PropertyNamelbl.Name = "PropertyNamelbl"
        Me.PropertyNamelbl.Size = New System.Drawing.Size(143, 29)
        Me.PropertyNamelbl.TabIndex = 1
        Me.PropertyNamelbl.Text = "اسم الخاصية"
        '
        'RunTimeColorPorperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PropertyNamelbl)
        Me.Controls.Add(Me.Colorlbl)
        Me.Name = "RunTimeColorPorperty"
        Me.Size = New System.Drawing.Size(238, 46)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Colorlbl As System.Windows.Forms.Label
    Friend WithEvents PropertyNamelbl As System.Windows.Forms.Label

End Class
