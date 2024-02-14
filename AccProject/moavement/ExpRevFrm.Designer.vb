<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpRevFrm

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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataeLabel As System.Windows.Forms.Label
        Dim DecomentLabel As System.Windows.Forms.Label
        Dim CashCrLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.TransActGrb = New System.Windows.Forms.GroupBox()
        Me.ExRegrp = New System.Windows.Forms.GroupBox()
        Me.NotComboBox = New System.Windows.Forms.ComboBox()
        Me.DrEXtxt = New ZeftawyTools.t_textbox()
        Me.CashCrComboBox = New System.Windows.Forms.ComboBox()
        Me.T_button3 = New ZeftawyTools.t_button()
        Me.DecomentTextBox = New System.Windows.Forms.TextBox()
        Me.DataeTextBox = New System.Windows.Forms.TextBox()
        Me.AccTyptxt = New ZeftawyTools.t_textbox()
        Me.AccountComb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DataeLabel = New System.Windows.Forms.Label()
        DecomentLabel = New System.Windows.Forms.Label()
        CashCrLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.TransActGrb.SuspendLayout()
        Me.ExRegrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitelBar.Size = New System.Drawing.Size(616, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(1087, 3)
        Me.Logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(12, 461)
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
        Me.Titel.Location = New System.Drawing.Point(1032, 7)
        Me.Titel.Size = New System.Drawing.Size(175, 24)
        Me.Titel.Text = "الايرادات و المصروفات"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(-289, 493)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(12, 387)
        Me.T_button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'MinBtn
        '
        Me.MinBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        '
        'CloosBtn
        '
        Me.CloosBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(-258, 299)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(357, 121)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(82, 25)
        Label9.TabIndex = 0
        Label9.Text = "الحساب"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(357, 79)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(117, 25)
        Label1.TabIndex = 38
        Label1.Text = "نوع الحساب"
        '
        'DataeLabel
        '
        DataeLabel.AutoSize = True
        DataeLabel.Location = New System.Drawing.Point(409, 29)
        DataeLabel.Name = "DataeLabel"
        DataeLabel.Size = New System.Drawing.Size(65, 25)
        DataeLabel.TabIndex = 39
        DataeLabel.Text = "التاريخ"
        '
        'DecomentLabel
        '
        DecomentLabel.AutoSize = True
        DecomentLabel.Location = New System.Drawing.Point(131, 29)
        DecomentLabel.Name = "DecomentLabel"
        DecomentLabel.Size = New System.Drawing.Size(111, 25)
        DecomentLabel.TabIndex = 40
        DecomentLabel.Text = "رقم الفاتورة"
        '
        'CashCrLabel
        '
        CashCrLabel.AutoSize = True
        CashCrLabel.Location = New System.Drawing.Point(357, 172)
        CashCrLabel.Name = "CashCrLabel"
        CashCrLabel.Size = New System.Drawing.Size(116, 25)
        CashCrLabel.TabIndex = 41
        CashCrLabel.Text = "نقد ام شيك"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Label4.Location = New System.Drawing.Point(467, 41)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(117, 25)
        Label4.TabIndex = 45
        Label4.Text = "نوع الحساب"
        '
        'TransActGrb
        '
        Me.TransActGrb.BackColor = System.Drawing.Color.Transparent
        Me.TransActGrb.Controls.Add(Me.ExRegrp)
        Me.TransActGrb.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransActGrb.Location = New System.Drawing.Point(10, 80)
        Me.TransActGrb.Name = "TransActGrb"
        Me.TransActGrb.Size = New System.Drawing.Size(585, 318)
        Me.TransActGrb.TabIndex = 12
        Me.TransActGrb.TabStop = False
        '
        'ExRegrp
        '
        Me.ExRegrp.Controls.Add(Me.NotComboBox)
        Me.ExRegrp.Controls.Add(Me.DrEXtxt)
        Me.ExRegrp.Controls.Add(CashCrLabel)
        Me.ExRegrp.Controls.Add(Me.CashCrComboBox)
        Me.ExRegrp.Controls.Add(DecomentLabel)
        Me.ExRegrp.Controls.Add(Me.T_button3)
        Me.ExRegrp.Controls.Add(Me.DecomentTextBox)
        Me.ExRegrp.Controls.Add(DataeLabel)
        Me.ExRegrp.Controls.Add(Me.DataeTextBox)
        Me.ExRegrp.Controls.Add(Label1)
        Me.ExRegrp.Controls.Add(Me.AccTyptxt)
        Me.ExRegrp.Controls.Add(Label9)
        Me.ExRegrp.Location = New System.Drawing.Point(75, 32)
        Me.ExRegrp.Name = "ExRegrp"
        Me.ExRegrp.Size = New System.Drawing.Size(494, 279)
        Me.ExRegrp.TabIndex = 44
        Me.ExRegrp.TabStop = False
        Me.ExRegrp.Text = "الايرادات و المصروفات "
        Me.ExRegrp.Visible = False
        '
        'NotComboBox
        '
        Me.NotComboBox.FormattingEnabled = True
        Me.NotComboBox.Location = New System.Drawing.Point(10, 115)
        Me.NotComboBox.Name = "NotComboBox"
        Me.NotComboBox.Size = New System.Drawing.Size(341, 33)
        Me.NotComboBox.TabIndex = 45
        '
        'DrEXtxt
        '
        Me.DrEXtxt.checkEmail = False
        Me.DrEXtxt.checkNolength = ZeftawyTools.chekcno.None
        Me.DrEXtxt.combo_link = False
        Me.DrEXtxt.combobox = Nothing
        Me.DrEXtxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.DrEXtxt.ForeColor = System.Drawing.Color.Black
        Me.DrEXtxt.LabelColor = System.Drawing.Color.Gray
        Me.DrEXtxt.LabelText = ""
        Me.DrEXtxt.leave_color = System.Drawing.SystemColors.Window
        Me.DrEXtxt.Location = New System.Drawing.Point(47, 172)
        Me.DrEXtxt.Name = "DrEXtxt"
        Me.DrEXtxt.numaricCheck = False
        Me.DrEXtxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.DrEXtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DrEXtxt.Size = New System.Drawing.Size(103, 33)
        Me.DrEXtxt.TabIndex = 39
        Me.DrEXtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DrEXtxt.textColor = System.Drawing.Color.Black
        Me.DrEXtxt.Textlengthcheck = 0
        '
        'CashCrComboBox
        '
        Me.CashCrComboBox.FormattingEnabled = True
        Me.CashCrComboBox.Items.AddRange(New Object() {"نقد", "شيك", "اجل"})
        Me.CashCrComboBox.Location = New System.Drawing.Point(215, 169)
        Me.CashCrComboBox.Name = "CashCrComboBox"
        Me.CashCrComboBox.Size = New System.Drawing.Size(136, 33)
        Me.CashCrComboBox.TabIndex = 42
        '
        'T_button3
        '
        Me.T_button3.BackColor = System.Drawing.Color.Blue
        Me.T_button3.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button3.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button3.CheckBox = False
        Me.T_button3.Checked = False
        Me.T_button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button3.font_color = System.Drawing.Color.Black
        Me.T_button3.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button3.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button3.Location = New System.Drawing.Point(250, 216)
        Me.T_button3.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button3.me_text = "ادخال الفاتورة"
        Me.T_button3.meAutoSize = False
        Me.T_button3.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button3.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button3.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button3.Name = "T_button3"
        Me.T_button3.Size = New System.Drawing.Size(193, 43)
        Me.T_button3.TabIndex = 40
        Me.T_button3.Text = "ادخال الفاتورة"
        Me.T_button3.UseDefFontInTxtShap = True
        Me.T_button3.UseDefultButton = False
        Me.T_button3.UseVisualStyleBackColor = True
        '
        'DecomentTextBox
        '
        Me.DecomentTextBox.Location = New System.Drawing.Point(6, 26)
        Me.DecomentTextBox.Name = "DecomentTextBox"
        Me.DecomentTextBox.Size = New System.Drawing.Size(122, 33)
        Me.DecomentTextBox.TabIndex = 41
        '
        'DataeTextBox
        '
        Me.DataeTextBox.Location = New System.Drawing.Point(250, 29)
        Me.DataeTextBox.Name = "DataeTextBox"
        Me.DataeTextBox.Size = New System.Drawing.Size(153, 33)
        Me.DataeTextBox.TabIndex = 40
        '
        'AccTyptxt
        '
        Me.AccTyptxt.checkEmail = False
        Me.AccTyptxt.checkNolength = ZeftawyTools.chekcno.None
        Me.AccTyptxt.combo_link = False
        Me.AccTyptxt.combobox = Nothing
        Me.AccTyptxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.AccTyptxt.ForeColor = System.Drawing.Color.Gray
        Me.AccTyptxt.LabelColor = System.Drawing.Color.Gray
        Me.AccTyptxt.LabelText = ""
        Me.AccTyptxt.leave_color = System.Drawing.SystemColors.Window
        Me.AccTyptxt.Location = New System.Drawing.Point(10, 76)
        Me.AccTyptxt.Name = "AccTyptxt"
        Me.AccTyptxt.numaricCheck = False
        Me.AccTyptxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.AccTyptxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccTyptxt.Size = New System.Drawing.Size(341, 33)
        Me.AccTyptxt.TabIndex = 37
        Me.AccTyptxt.textColor = System.Drawing.Color.Black
        Me.AccTyptxt.Textlengthcheck = 0
        '
        'AccountComb
        '
        Me.AccountComb.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.AccountComb.FormattingEnabled = True
        Me.AccountComb.Items.AddRange(New Object() {"مصروفات", "ايرادات"})
        Me.AccountComb.Location = New System.Drawing.Point(230, 41)
        Me.AccountComb.Name = "AccountComb"
        Me.AccountComb.Size = New System.Drawing.Size(231, 33)
        Me.AccountComb.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 46
        '
        'ExpRevFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.AccountComb)
        Me.Controls.Add(Me.TransActGrb)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.MyFormSurrundColor = System.Drawing.Color.LightSlateGray
        Me.Name = "ExpRevFrm"
        Me.Opacity = 1.0R
        Me.Text = "الايرادات و المصروفات"
        Me.TiteText = "الايرادات و المصروفات"
        Me.Controls.SetChildIndex(Me.TransActGrb, 0)
        Me.Controls.SetChildIndex(Me.AccountComb, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.TransActGrb.ResumeLayout(False)
        Me.ExRegrp.ResumeLayout(False)
        Me.ExRegrp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransActGrb As System.Windows.Forms.GroupBox
    Friend WithEvents T_button3 As ZeftawyTools.t_button
    Friend WithEvents ExRegrp As System.Windows.Forms.GroupBox
    Friend WithEvents CashCrComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DecomentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccTyptxt As ZeftawyTools.t_textbox
    Friend WithEvents DrEXtxt As ZeftawyTools.t_textbox
    Friend WithEvents AccountComb As System.Windows.Forms.ComboBox
    Friend WithEvents NotComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
