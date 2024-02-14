<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataChoseFrm
    Inherits Z_Apps.DesgineFrm

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
        Me.T_button1 = New ZeftawyTools.t_button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(393, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(-5839, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(5, 332)
        Me.massegBoxFormat.Size = New System.Drawing.Size(10, 10)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Size = New System.Drawing.Size(10, 25)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-77, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-24, 75)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(-5894, 7)
        Me.Titel.Size = New System.Drawing.Size(107, 24)
        Me.Titel.Text = "اختيار التاريخ"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(377, 372)
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(365, 317)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'MinBtn
        '
        Me.MinBtn.Visible = False
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(-35, 244)
        Me.T_textbox.Size = New System.Drawing.Size(10, 33)
        '
        'T_button1
        '
        Me.T_button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.T_button1.BackColor = System.Drawing.Color.Blue
        Me.T_button1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button1.CheckBox = False
        Me.T_button1.Checked = False
        Me.T_button1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button1.font_color = System.Drawing.Color.Black
        Me.T_button1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button1.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button1.Location = New System.Drawing.Point(51, 332)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "موافق"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(97, 47)
        Me.T_button1.TabIndex = 11
        Me.T_button1.Text = "موافق"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 43)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'DataChoseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(393, 391)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_button1)
        Me.FormCloseAnimationType = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.FormOpenAnimationtype = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.myFormAnimationCase = ZeftawyTools.AnimationCase.الاثنثن_معا
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "DataChoseFrm"
        Me.recshaps = ZeftawyTools.recshaps.rectopleft
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اختيار التاريخ"
        Me.TiteText = "اختيار التاريخ"
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar1, 0)
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
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
