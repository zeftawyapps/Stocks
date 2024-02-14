Imports ZeftawyTools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPostionCode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.movefirstB = New ZeftawyTools.t_button()
        Me.moveprevB = New ZeftawyTools.t_button()
        Me.movenextB = New ZeftawyTools.t_button()
        Me.movelastB = New ZeftawyTools.t_button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.movefirstB)
        Me.GroupBox1.Controls.Add(Me.moveprevB)
        Me.GroupBox1.Controls.Add(Me.movenextB)
        Me.GroupBox1.Controls.Add(Me.movelastB)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(407, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "التنقل بين السجلات"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(162, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'movefirstB
        '
        Me.movefirstB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.movefirstB.BackColor = System.Drawing.Color.Blue
        Me.movefirstB.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.movefirstB.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.movefirstB.CheckBox = False
        Me.movefirstB.Checked = False
        Me.movefirstB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movefirstB.font_color = System.Drawing.Color.Black
        Me.movefirstB.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.movefirstB.font_color_Mousemove = System.Drawing.Color.White
        Me.movefirstB.Location = New System.Drawing.Point(32, 14)
        Me.movefirstB.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.movefirstB.me_text = "<<"
        Me.movefirstB.meAutoSize = False
        Me.movefirstB.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.movefirstB.meloodserruonding_color = System.Drawing.Color.Blue
        Me.movefirstB.mousemove_center_color = System.Drawing.Color.Lime
        Me.movefirstB.Name = "movefirstB"
        Me.movefirstB.Size = New System.Drawing.Size(47, 23)
        Me.movefirstB.TabIndex = 3
        Me.movefirstB.Text = "<<"
        Me.movefirstB.UseDefFontInTxtShap = True
        Me.movefirstB.UseDefultButton = False
        Me.movefirstB.UseVisualStyleBackColor = True
        '
        'moveprevB
        '
        Me.moveprevB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.moveprevB.BackColor = System.Drawing.Color.Blue
        Me.moveprevB.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.moveprevB.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.moveprevB.CheckBox = False
        Me.moveprevB.Checked = False
        Me.moveprevB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moveprevB.font_color = System.Drawing.Color.Black
        Me.moveprevB.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.moveprevB.font_color_Mousemove = System.Drawing.Color.White
        Me.moveprevB.Location = New System.Drawing.Point(85, 14)
        Me.moveprevB.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.moveprevB.me_text = "<"
        Me.moveprevB.meAutoSize = False
        Me.moveprevB.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.moveprevB.meloodserruonding_color = System.Drawing.Color.Blue
        Me.moveprevB.mousemove_center_color = System.Drawing.Color.Lime
        Me.moveprevB.Name = "moveprevB"
        Me.moveprevB.Size = New System.Drawing.Size(47, 23)
        Me.moveprevB.TabIndex = 2
        Me.moveprevB.Text = "<"
        Me.moveprevB.UseDefFontInTxtShap = True
        Me.moveprevB.UseDefultButton = False
        Me.moveprevB.UseVisualStyleBackColor = True
        '
        'movenextB
        '
        Me.movenextB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.movenextB.BackColor = System.Drawing.Color.Blue
        Me.movenextB.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.movenextB.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.movenextB.CheckBox = False
        Me.movenextB.Checked = False
        Me.movenextB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movenextB.font_color = System.Drawing.Color.Black
        Me.movenextB.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.movenextB.font_color_Mousemove = System.Drawing.Color.White
        Me.movenextB.Location = New System.Drawing.Point(275, 14)
        Me.movenextB.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.movenextB.me_text = ">"
        Me.movenextB.meAutoSize = False
        Me.movenextB.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.movenextB.meloodserruonding_color = System.Drawing.Color.Blue
        Me.movenextB.mousemove_center_color = System.Drawing.Color.Lime
        Me.movenextB.Name = "movenextB"
        Me.movenextB.Size = New System.Drawing.Size(47, 23)
        Me.movenextB.TabIndex = 1
        Me.movenextB.Text = ">"
        Me.movenextB.UseDefFontInTxtShap = True
        Me.movenextB.UseDefultButton = False
        Me.movenextB.UseVisualStyleBackColor = True
        '
        'movelastB
        '
        Me.movelastB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.movelastB.BackColor = System.Drawing.Color.Blue
        Me.movelastB.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.movelastB.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.movelastB.CheckBox = False
        Me.movelastB.Checked = False
        Me.movelastB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movelastB.font_color = System.Drawing.Color.Black
        Me.movelastB.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.movelastB.font_color_Mousemove = System.Drawing.Color.White
        Me.movelastB.Location = New System.Drawing.Point(328, 14)
        Me.movelastB.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.movelastB.me_text = ">>"
        Me.movelastB.meAutoSize = False
        Me.movelastB.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.movelastB.meloodserruonding_color = System.Drawing.Color.Blue
        Me.movelastB.mousemove_center_color = System.Drawing.Color.Lime
        Me.movelastB.Name = "movelastB"
        Me.movelastB.Size = New System.Drawing.Size(47, 23)
        Me.movelastB.TabIndex = 0
        Me.movelastB.Text = ">>"
        Me.movelastB.UseDefFontInTxtShap = True
        Me.movelastB.UseDefultButton = False
        Me.movelastB.UseVisualStyleBackColor = True
        '
        'DataPostionCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DataPostionCode"
        Me.Size = New System.Drawing.Size(407, 48)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents movelastB As t_button
    Friend WithEvents movefirstB As t_button
    Friend WithEvents moveprevB As t_button
    Friend WithEvents movenextB As t_button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
