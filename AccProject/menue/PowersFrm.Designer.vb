<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowersFrm
    Inherits ZeftawyTools.myformDesign

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaleChk = New ZeftawyTools.t_button()
        Me.rsalechk = New ZeftawyTools.t_button()
        Me.parshChk = New ZeftawyTools.t_button()
        Me.RparshChek = New ZeftawyTools.t_button()
        Me.DataChk = New ZeftawyTools.t_button()
        Me.ReportsChk = New ZeftawyTools.t_button()
        Me.FormatChk = New ZeftawyTools.t_button()
        Me.AdminChk = New ZeftawyTools.t_button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Cahserchk = New ZeftawyTools.t_button()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitelBar.Size = New System.Drawing.Size(425, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(216, 2)
        Me.Logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(12, 370)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.massegBoxFormat.Size = New System.Drawing.Size(10, 10)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MsgTilteBar.Size = New System.Drawing.Size(10, 25)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-45, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-24, 75)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(-58, 7)
        Me.Titel.Size = New System.Drawing.Size(86, 24)
        Me.Titel.Text = "الصلاحيات"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(197, 400)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(3, 204)
        Me.T_button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'CloosBtn
        '
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(-2, 272)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'T_button1
        '
        Me.T_button1.BackColor = System.Drawing.Color.Blue
        Me.T_button1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button1.CheckBox = False
        Me.T_button1.Checked = False
        Me.T_button1.font_color = System.Drawing.Color.Black
        Me.T_button1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button1.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button1.Location = New System.Drawing.Point(155, 224)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "موافق"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(80, 40)
        Me.T_button1.TabIndex = 10
        Me.T_button1.Text = "موافق"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SaleChk)
        Me.GroupBox1.Controls.Add(Me.rsalechk)
        Me.GroupBox1.Controls.Add(Me.parshChk)
        Me.GroupBox1.Controls.Add(Me.RparshChek)
        Me.GroupBox1.Controls.Add(Me.DataChk)
        Me.GroupBox1.Controls.Add(Me.ReportsChk)
        Me.GroupBox1.Controls.Add(Me.FormatChk)
        Me.GroupBox1.Controls.Add(Me.AdminChk)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 118)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'SaleChk
        '
        Me.SaleChk.BackColor = System.Drawing.Color.Blue
        Me.SaleChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.SaleChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.SaleChk.CheckBox = True
        Me.SaleChk.Checked = False
        Me.SaleChk.font_color = System.Drawing.Color.Black
        Me.SaleChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.SaleChk.font_color_Mousemove = System.Drawing.Color.White
        Me.SaleChk.Location = New System.Drawing.Point(279, 19)
        Me.SaleChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.SaleChk.me_text = "مبيعات"
        Me.SaleChk.meAutoSize = False
        Me.SaleChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.SaleChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.SaleChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.SaleChk.Name = "SaleChk"
        Me.SaleChk.Size = New System.Drawing.Size(80, 40)
        Me.SaleChk.TabIndex = 18
        Me.SaleChk.Text = "مبيعات"
        Me.SaleChk.UseDefFontInTxtShap = True
        Me.SaleChk.UseDefultButton = False
        Me.SaleChk.UseVisualStyleBackColor = True
        '
        'rsalechk
        '
        Me.rsalechk.BackColor = System.Drawing.Color.Blue
        Me.rsalechk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.rsalechk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.rsalechk.CheckBox = True
        Me.rsalechk.Checked = False
        Me.rsalechk.font_color = System.Drawing.Color.Black
        Me.rsalechk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.rsalechk.font_color_Mousemove = System.Drawing.Color.White
        Me.rsalechk.Location = New System.Drawing.Point(193, 19)
        Me.rsalechk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.rsalechk.me_text = "مرتتجع بيع"
        Me.rsalechk.meAutoSize = False
        Me.rsalechk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.rsalechk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.rsalechk.mousemove_center_color = System.Drawing.Color.Lime
        Me.rsalechk.Name = "rsalechk"
        Me.rsalechk.Size = New System.Drawing.Size(80, 40)
        Me.rsalechk.TabIndex = 17
        Me.rsalechk.Text = "مرتتجع بيع"
        Me.rsalechk.UseDefFontInTxtShap = True
        Me.rsalechk.UseDefultButton = False
        Me.rsalechk.UseVisualStyleBackColor = True
        '
        'parshChk
        '
        Me.parshChk.BackColor = System.Drawing.Color.Blue
        Me.parshChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.parshChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.parshChk.CheckBox = True
        Me.parshChk.Checked = False
        Me.parshChk.font_color = System.Drawing.Color.Black
        Me.parshChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.parshChk.font_color_Mousemove = System.Drawing.Color.White
        Me.parshChk.Location = New System.Drawing.Point(112, 19)
        Me.parshChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.parshChk.me_text = "مشتريات"
        Me.parshChk.meAutoSize = False
        Me.parshChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.parshChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.parshChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.parshChk.Name = "parshChk"
        Me.parshChk.Size = New System.Drawing.Size(80, 40)
        Me.parshChk.TabIndex = 16
        Me.parshChk.Text = "مشتريات"
        Me.parshChk.UseDefFontInTxtShap = True
        Me.parshChk.UseDefultButton = False
        Me.parshChk.UseVisualStyleBackColor = True
        '
        'RparshChek
        '
        Me.RparshChek.BackColor = System.Drawing.Color.Blue
        Me.RparshChek.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.RparshChek.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.RparshChek.CheckBox = True
        Me.RparshChek.Checked = False
        Me.RparshChek.font_color = System.Drawing.Color.Black
        Me.RparshChek.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.RparshChek.font_color_Mousemove = System.Drawing.Color.White
        Me.RparshChek.Location = New System.Drawing.Point(17, 19)
        Me.RparshChek.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.RparshChek.me_text = "مرتجع شراء"
        Me.RparshChek.meAutoSize = False
        Me.RparshChek.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.RparshChek.meloodserruonding_color = System.Drawing.Color.Blue
        Me.RparshChek.mousemove_center_color = System.Drawing.Color.Lime
        Me.RparshChek.Name = "RparshChek"
        Me.RparshChek.Size = New System.Drawing.Size(89, 40)
        Me.RparshChek.TabIndex = 15
        Me.RparshChek.Text = "مرتجع شراء"
        Me.RparshChek.UseDefFontInTxtShap = True
        Me.RparshChek.UseDefultButton = False
        Me.RparshChek.UseVisualStyleBackColor = True
        '
        'DataChk
        '
        Me.DataChk.BackColor = System.Drawing.Color.Blue
        Me.DataChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.DataChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.DataChk.CheckBox = True
        Me.DataChk.Checked = False
        Me.DataChk.font_color = System.Drawing.Color.Black
        Me.DataChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataChk.font_color_Mousemove = System.Drawing.Color.White
        Me.DataChk.Location = New System.Drawing.Point(279, 65)
        Me.DataChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.DataChk.me_text = "البيانات"
        Me.DataChk.meAutoSize = False
        Me.DataChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataChk.Name = "DataChk"
        Me.DataChk.Size = New System.Drawing.Size(80, 40)
        Me.DataChk.TabIndex = 14
        Me.DataChk.Text = "البيانات"
        Me.DataChk.UseDefFontInTxtShap = True
        Me.DataChk.UseDefultButton = False
        Me.DataChk.UseVisualStyleBackColor = True
        '
        'ReportsChk
        '
        Me.ReportsChk.BackColor = System.Drawing.Color.Blue
        Me.ReportsChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.ReportsChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.ReportsChk.CheckBox = True
        Me.ReportsChk.Checked = False
        Me.ReportsChk.font_color = System.Drawing.Color.Black
        Me.ReportsChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.ReportsChk.font_color_Mousemove = System.Drawing.Color.White
        Me.ReportsChk.Location = New System.Drawing.Point(193, 65)
        Me.ReportsChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.ReportsChk.me_text = "الارصدة"
        Me.ReportsChk.meAutoSize = False
        Me.ReportsChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.ReportsChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.ReportsChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.ReportsChk.Name = "ReportsChk"
        Me.ReportsChk.Size = New System.Drawing.Size(80, 40)
        Me.ReportsChk.TabIndex = 13
        Me.ReportsChk.Text = "الارصدة"
        Me.ReportsChk.UseDefFontInTxtShap = True
        Me.ReportsChk.UseDefultButton = False
        Me.ReportsChk.UseVisualStyleBackColor = True
        '
        'FormatChk
        '
        Me.FormatChk.BackColor = System.Drawing.Color.Blue
        Me.FormatChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.FormatChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.FormatChk.CheckBox = True
        Me.FormatChk.Checked = False
        Me.FormatChk.font_color = System.Drawing.Color.Black
        Me.FormatChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.FormatChk.font_color_Mousemove = System.Drawing.Color.White
        Me.FormatChk.Location = New System.Drawing.Point(107, 65)
        Me.FormatChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.FormatChk.me_text = "الحسابات"
        Me.FormatChk.meAutoSize = False
        Me.FormatChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.FormatChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.FormatChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.FormatChk.Name = "FormatChk"
        Me.FormatChk.Size = New System.Drawing.Size(80, 40)
        Me.FormatChk.TabIndex = 12
        Me.FormatChk.Text = "الحسابات"
        Me.FormatChk.UseDefFontInTxtShap = True
        Me.FormatChk.UseDefultButton = False
        Me.FormatChk.UseVisualStyleBackColor = True
        '
        'AdminChk
        '
        Me.AdminChk.BackColor = System.Drawing.Color.Blue
        Me.AdminChk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.AdminChk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.AdminChk.CheckBox = True
        Me.AdminChk.Checked = False
        Me.AdminChk.font_color = System.Drawing.Color.Black
        Me.AdminChk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.AdminChk.font_color_Mousemove = System.Drawing.Color.White
        Me.AdminChk.Location = New System.Drawing.Point(17, 65)
        Me.AdminChk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.AdminChk.me_text = "مدير عام"
        Me.AdminChk.meAutoSize = False
        Me.AdminChk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.AdminChk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.AdminChk.mousemove_center_color = System.Drawing.Color.Lime
        Me.AdminChk.Name = "AdminChk"
        Me.AdminChk.Size = New System.Drawing.Size(89, 40)
        Me.AdminChk.TabIndex = 11
        Me.AdminChk.Text = "مدير عام"
        Me.AdminChk.UseDefFontInTxtShap = True
        Me.AdminChk.UseDefultButton = False
        Me.AdminChk.UseVisualStyleBackColor = True
        '
        'Cahserchk
        '
        Me.Cahserchk.BackColor = System.Drawing.Color.Blue
        Me.Cahserchk.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Cahserchk.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Cahserchk.CheckBox = True
        Me.Cahserchk.Checked = False
        Me.Cahserchk.font_color = System.Drawing.Color.Black
        Me.Cahserchk.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.Cahserchk.font_color_Mousemove = System.Drawing.Color.White
        Me.Cahserchk.Location = New System.Drawing.Point(38, 174)
        Me.Cahserchk.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.Cahserchk.me_text = "شاشه الكاشير"
        Me.Cahserchk.meAutoSize = False
        Me.Cahserchk.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Cahserchk.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Cahserchk.mousemove_center_color = System.Drawing.Color.Lime
        Me.Cahserchk.Name = "Cahserchk"
        Me.Cahserchk.Size = New System.Drawing.Size(342, 40)
        Me.Cahserchk.TabIndex = 19
        Me.Cahserchk.Text = "شاشه الكاشير"
        Me.Cahserchk.UseDefFontInTxtShap = True
        Me.Cahserchk.UseDefultButton = False
        Me.Cahserchk.UseVisualStyleBackColor = True
        '
        'PowersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 274)
        Me.Controls.Add(Me.Cahserchk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.T_button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "PowersFrm"
        Me.Opacity = 1.0R
        Me.Text = "الصلاحيات"
        Me.TiteText = "الصلاحيات"
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.Cahserchk, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SaleChk As ZeftawyTools.t_button
    Friend WithEvents rsalechk As ZeftawyTools.t_button
    Friend WithEvents parshChk As ZeftawyTools.t_button
    Friend WithEvents RparshChek As ZeftawyTools.t_button
    Friend WithEvents DataChk As ZeftawyTools.t_button
    Friend WithEvents ReportsChk As ZeftawyTools.t_button
    Friend WithEvents FormatChk As ZeftawyTools.t_button
    Friend WithEvents AdminChk As ZeftawyTools.t_button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Cahserchk As ZeftawyTools.t_button
End Class
