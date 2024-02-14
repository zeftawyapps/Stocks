<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDataMarket
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
        Dim SanfLabel As System.Windows.Forms.Label
        Dim Jom_priceLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim OlEdatabaseCodeing1 As Z_Apps.OLEdatabaseCodeing = New Z_Apps.OLEdatabaseCodeing()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QPBBTxt = New ZeftawyTools.t_textbox()
        Me.BBQTxt = New ZeftawyTools.t_textbox()
        Me.QutTxt = New ZeftawyTools.t_textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Jomlatxt = New ZeftawyTools.t_textbox()
        Me.Paypricetxt = New ZeftawyTools.t_textbox()
        Me.SalePricelbl = New System.Windows.Forms.Label()
        Me.Codetxt = New ZeftawyTools.t_textbox()
        Me.Sanftxt = New ZeftawyTools.t_textbox()
        Me.T_button1 = New ZeftawyTools.t_button()
        Me.T_button2 = New ZeftawyTools.t_button()
        Me.T_button3 = New ZeftawyTools.t_button()
        Me.T_button4 = New ZeftawyTools.t_button()
        Me.SearchTxt = New ZeftawyTools.t_textbox()
        Me.DataPostionCode1 = New Z_Apps.DataPostionCode()
        SanfLabel = New System.Windows.Forms.Label()
        Jom_priceLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(6)
        Me.TitelBar.Size = New System.Drawing.Size(1298, 64)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(6556, 5)
        Me.Logo.Margin = New System.Windows.Forms.Padding(5)
        Me.Logo.Size = New System.Drawing.Size(57, 53)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(1017, 1052)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(5)
        Me.massegBoxFormat.Size = New System.Drawing.Size(21, 21)
        '
        'MsgText
        '
        Me.MsgText.Location = New System.Drawing.Point(30, 60)
        Me.MsgText.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(6)
        Me.MsgTilteBar.Size = New System.Drawing.Size(21, 33)
        Me.MsgTilteBar.Visible = False
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-76, -5)
        Me.msgTitl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-41, 129)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.MsgT_Button.Size = New System.Drawing.Size(124, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(6459, 12)
        Me.Titel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Titel.Size = New System.Drawing.Size(148, 29)
        Me.Titel.Text = "بيانات الاصناف"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(204, 653)
        Me.Labelbox.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbox.Size = New System.Drawing.Size(0, 29)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(1088, 1099)
        Me.T_button.Margin = New System.Windows.Forms.Padding(5)
        Me.T_button.Size = New System.Drawing.Size(18, 17)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'MinBtn
        '
        Me.MinBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinBtn.Location = New System.Drawing.Point(75, 5)
        Me.MinBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        Me.MinBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.MinBtn.Size = New System.Drawing.Size(60, 62)
        '
        'CloosBtn
        '
        Me.CloosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloosBtn.Location = New System.Drawing.Point(5, 5)
        Me.CloosBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        Me.CloosBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.CloosBtn.Size = New System.Drawing.Size(60, 62)
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(1060, 1085)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(5)
        Me.T_textbox.Size = New System.Drawing.Size(15, 32)
        '
        'SanfLabel
        '
        SanfLabel.AutoSize = True
        SanfLabel.Location = New System.Drawing.Point(1040, 101)
        SanfLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        SanfLabel.Name = "SanfLabel"
        SanfLabel.Size = New System.Drawing.Size(96, 39)
        SanfLabel.TabIndex = 5
        SanfLabel.Text = "الصنف"
        '
        'Jom_priceLabel
        '
        Jom_priceLabel.AutoSize = True
        Jom_priceLabel.Location = New System.Drawing.Point(1034, 231)
        Jom_priceLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Jom_priceLabel.Name = "Jom_priceLabel"
        Jom_priceLabel.Size = New System.Drawing.Size(91, 39)
        Jom_priceLabel.TabIndex = 9
        Jom_priceLabel.Text = "الشراء"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(1038, 53)
        Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(144, 39)
        Label2.TabIndex = 21
        Label2.Text = "كود الصنف"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(1002, 300)
        Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(190, 39)
        Label3.TabIndex = 30
        Label3.Text = "رصيد اول المدة"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(670, 296)
        Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(76, 39)
        Label4.TabIndex = 32
        Label4.Text = "القيمة"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.QPBBTxt)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.BBQTxt)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.QutTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Jomlatxt)
        Me.GroupBox1.Controls.Add(Me.Paypricetxt)
        Me.GroupBox1.Controls.Add(Me.SalePricelbl)
        Me.GroupBox1.Controls.Add(Me.Codetxt)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.Sanftxt)
        Me.GroupBox1.Controls.Add(Jom_priceLabel)
        Me.GroupBox1.Controls.Add(SanfLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(75, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 403)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'QPBBTxt
        '
        Me.QPBBTxt.checkEmail = False
        Me.QPBBTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.QPBBTxt.combo_link = False
        Me.QPBBTxt.combobox = Nothing
        Me.QPBBTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.QPBBTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QPBBTxt.ForeColor = System.Drawing.Color.Black
        Me.QPBBTxt.LabelColor = System.Drawing.Color.Gray
        Me.QPBBTxt.LabelText = ""
        Me.QPBBTxt.leave_color = System.Drawing.SystemColors.Window
        Me.QPBBTxt.Location = New System.Drawing.Point(505, 287)
        Me.QPBBTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.QPBBTxt.Name = "QPBBTxt"
        Me.QPBBTxt.numaricCheck = True
        Me.QPBBTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.QPBBTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.QPBBTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.QPBBTxt.Size = New System.Drawing.Size(165, 46)
        Me.QPBBTxt.TabIndex = 33
        Me.QPBBTxt.Text = "0"
        Me.QPBBTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QPBBTxt.textColor = System.Drawing.Color.Black
        Me.QPBBTxt.Textlengthcheck = 0
        '
        'BBQTxt
        '
        Me.BBQTxt.checkEmail = False
        Me.BBQTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.BBQTxt.combo_link = False
        Me.BBQTxt.combobox = Nothing
        Me.BBQTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.BBQTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBQTxt.ForeColor = System.Drawing.Color.Black
        Me.BBQTxt.LabelColor = System.Drawing.Color.Gray
        Me.BBQTxt.LabelText = ""
        Me.BBQTxt.leave_color = System.Drawing.SystemColors.Window
        Me.BBQTxt.Location = New System.Drawing.Point(827, 293)
        Me.BBQTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.BBQTxt.Name = "BBQTxt"
        Me.BBQTxt.numaricCheck = True
        Me.BBQTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.BBQTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '   Me.BBQTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.BBQTxt.Size = New System.Drawing.Size(165, 46)
        Me.BBQTxt.TabIndex = 31
        Me.BBQTxt.Text = "0"
        Me.BBQTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BBQTxt.textColor = System.Drawing.Color.Black
        Me.BBQTxt.Textlengthcheck = 0
        '
        'QutTxt
        '
        Me.QutTxt.checkEmail = False
        Me.QutTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.QutTxt.combo_link = False
        Me.QutTxt.combobox = Nothing
        Me.QutTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.QutTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QutTxt.ForeColor = System.Drawing.Color.Black
        Me.QutTxt.LabelColor = System.Drawing.Color.Gray
        Me.QutTxt.LabelText = ""
        Me.QutTxt.leave_color = System.Drawing.SystemColors.Window
        Me.QutTxt.Location = New System.Drawing.Point(128, 231)
        Me.QutTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.QutTxt.Name = "QutTxt"
        Me.QutTxt.numaricCheck = True
        Me.QutTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.QutTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.QutTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.QutTxt.Size = New System.Drawing.Size(198, 46)
        Me.QutTxt.TabIndex = 28
        Me.QutTxt.Text = "0"
        Me.QutTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QutTxt.textColor = System.Drawing.Color.Black
        Me.QutTxt.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 39)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "سعر المستهلك"
        '
        'Jomlatxt
        '
        Me.Jomlatxt.checkEmail = False
        Me.Jomlatxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Jomlatxt.combo_link = False
        Me.Jomlatxt.combobox = Nothing
        Me.Jomlatxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Jomlatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jomlatxt.ForeColor = System.Drawing.Color.Black
        Me.Jomlatxt.LabelColor = System.Drawing.Color.Gray
        Me.Jomlatxt.LabelText = ""
        Me.Jomlatxt.leave_color = System.Drawing.SystemColors.Window
        Me.Jomlatxt.Location = New System.Drawing.Point(513, 231)
        Me.Jomlatxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Jomlatxt.Name = "Jomlatxt"
        Me.Jomlatxt.numaricCheck = True
        Me.Jomlatxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Jomlatxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.Jomlatxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Jomlatxt.Size = New System.Drawing.Size(134, 46)
        Me.Jomlatxt.TabIndex = 15
        Me.Jomlatxt.Text = "0"
        Me.Jomlatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Jomlatxt.textColor = System.Drawing.Color.Black
        Me.Jomlatxt.Textlengthcheck = 0
        '
        'Paypricetxt
        '
        Me.Paypricetxt.checkEmail = False
        Me.Paypricetxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Paypricetxt.combo_link = False
        Me.Paypricetxt.combobox = Nothing
        Me.Paypricetxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Paypricetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paypricetxt.ForeColor = System.Drawing.Color.Black
        Me.Paypricetxt.LabelColor = System.Drawing.Color.Gray
        Me.Paypricetxt.LabelText = ""
        Me.Paypricetxt.leave_color = System.Drawing.SystemColors.Window
        Me.Paypricetxt.Location = New System.Drawing.Point(861, 231)
        Me.Paypricetxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Paypricetxt.Name = "Paypricetxt"
        Me.Paypricetxt.numaricCheck = True
        Me.Paypricetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Paypricetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.Paypricetxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Paypricetxt.Size = New System.Drawing.Size(165, 46)
        Me.Paypricetxt.TabIndex = 14
        Me.Paypricetxt.Text = "0"
        Me.Paypricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Paypricetxt.textColor = System.Drawing.Color.Black
        Me.Paypricetxt.Textlengthcheck = 0
        '
        'SalePricelbl
        '
        Me.SalePricelbl.AutoSize = True
        Me.SalePricelbl.Location = New System.Drawing.Point(657, 231)
        Me.SalePricelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SalePricelbl.Name = "SalePricelbl"
        Me.SalePricelbl.Size = New System.Drawing.Size(182, 39)
        Me.SalePricelbl.TabIndex = 27
        Me.SalePricelbl.Text = "سعر بيع الجملة"
        '
        'Codetxt
        '
        Me.Codetxt.checkEmail = False
        Me.Codetxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Codetxt.combo_link = False
        Me.Codetxt.combobox = Nothing
        Me.Codetxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Codetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codetxt.ForeColor = System.Drawing.Color.Gray
        Me.Codetxt.LabelColor = System.Drawing.Color.Gray
        Me.Codetxt.LabelText = ""
        Me.Codetxt.leave_color = System.Drawing.SystemColors.Window
        Me.Codetxt.Location = New System.Drawing.Point(129, 42)
        Me.Codetxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Codetxt.Name = "Codetxt"
        Me.Codetxt.numaricCheck = False
        Me.Codetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Codetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        '  Me.Codetxt.SetLangAs = ZeftawyTools.SETlangAs.لاتيني
        Me.Codetxt.Size = New System.Drawing.Size(884, 46)
        Me.Codetxt.TabIndex = 10
        Me.Codetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Codetxt.textColor = System.Drawing.Color.Black
        Me.Codetxt.Textlengthcheck = 0
        '
        'Sanftxt
        '
        Me.Sanftxt.checkEmail = False
        Me.Sanftxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Sanftxt.combo_link = False
        Me.Sanftxt.combobox = Nothing
        Me.Sanftxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Sanftxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sanftxt.ForeColor = System.Drawing.Color.Gray
        Me.Sanftxt.LabelColor = System.Drawing.Color.Gray
        Me.Sanftxt.LabelText = ""
        Me.Sanftxt.leave_color = System.Drawing.SystemColors.Window
        Me.Sanftxt.Location = New System.Drawing.Point(129, 98)
        Me.Sanftxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Sanftxt.Multiline = True
        Me.Sanftxt.Name = "Sanftxt"
        Me.Sanftxt.numaricCheck = False
        Me.Sanftxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Sanftxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.Sanftxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Sanftxt.Size = New System.Drawing.Size(884, 90)
        Me.Sanftxt.TabIndex = 12
        Me.Sanftxt.textColor = System.Drawing.Color.Black
        Me.Sanftxt.Textlengthcheck = 0
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
        Me.T_button1.Location = New System.Drawing.Point(757, 659)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "سجل جديد"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(192, 66)
        Me.T_button1.TabIndex = 30
        Me.T_button1.Text = "سجل جديد"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'T_button2
        '
        Me.T_button2.BackColor = System.Drawing.Color.Blue
        Me.T_button2.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button2.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button2.CheckBox = False
        Me.T_button2.Checked = False
        Me.T_button2.font_color = System.Drawing.Color.Black
        Me.T_button2.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button2.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button2.Location = New System.Drawing.Point(382, 659)
        Me.T_button2.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button2.me_text = "حذف"
        Me.T_button2.meAutoSize = False
        Me.T_button2.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button2.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button2.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button2.Name = "T_button2"
        Me.T_button2.Size = New System.Drawing.Size(171, 66)
        Me.T_button2.TabIndex = 31
        Me.T_button2.Text = "حذف"
        Me.T_button2.UseDefFontInTxtShap = True
        Me.T_button2.UseDefultButton = False
        Me.T_button2.UseVisualStyleBackColor = True
        '
        'T_button3
        '
        Me.T_button3.BackColor = System.Drawing.Color.Blue
        Me.T_button3.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button3.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button3.CheckBox = False
        Me.T_button3.Checked = False
        Me.T_button3.font_color = System.Drawing.Color.Black
        Me.T_button3.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button3.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button3.Location = New System.Drawing.Point(580, 659)
        Me.T_button3.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button3.me_text = "حفظ"
        Me.T_button3.meAutoSize = False
        Me.T_button3.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button3.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button3.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button3.Name = "T_button3"
        Me.T_button3.Size = New System.Drawing.Size(171, 66)
        Me.T_button3.TabIndex = 32
        Me.T_button3.Text = "حفظ"
        Me.T_button3.UseDefFontInTxtShap = True
        Me.T_button3.UseDefultButton = False
        Me.T_button3.UseVisualStyleBackColor = True
        '
        'T_button4
        '
        Me.T_button4.BackColor = System.Drawing.Color.Blue
        Me.T_button4.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button4.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button4.CheckBox = False
        Me.T_button4.Checked = False
        Me.T_button4.font_color = System.Drawing.Color.Black
        Me.T_button4.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button4.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button4.Location = New System.Drawing.Point(457, 72)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "بحث"
        Me.T_button4.meAutoSize = False
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(108, 52)
        Me.T_button4.TabIndex = 33
        Me.T_button4.Text = "بحث"
        Me.T_button4.UseDefFontInTxtShap = True
        Me.T_button4.UseDefultButton = False
        Me.T_button4.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.checkEmail = False
        Me.SearchTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.SearchTxt.combo_link = False
        Me.SearchTxt.combobox = Nothing
        Me.SearchTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.SearchTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxt.ForeColor = System.Drawing.Color.Gray
        Me.SearchTxt.LabelColor = System.Drawing.Color.Gray
        Me.SearchTxt.LabelText = "ادخل كود الصنف"
        Me.SearchTxt.leave_color = System.Drawing.SystemColors.Window
        Me.SearchTxt.Location = New System.Drawing.Point(593, 74)
        Me.SearchTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.numaricCheck = False
        Me.SearchTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.SearchTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        ' Me.SearchTxt.SetLangAs = ZeftawyTools.SETlangAs.لاتيني
        Me.SearchTxt.Size = New System.Drawing.Size(516, 46)
        Me.SearchTxt.TabIndex = 34
        Me.SearchTxt.Text = "ادخل كود الصنف"
        Me.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SearchTxt.textColor = System.Drawing.Color.Black
        Me.SearchTxt.Textlengthcheck = 0
        '
        'DataPostionCode1
        '
        Me.DataPostionCode1.AutoSize = True
        Me.DataPostionCode1.BackColor = System.Drawing.Color.Transparent
        Me.DataPostionCode1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.DataPostionCode1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.DataPostionCode1.ButtonFareColor = System.Drawing.Color.Empty
        OlEdatabaseCodeing1.command = Nothing
        OlEdatabaseCodeing1.Connection = Nothing
        OlEdatabaseCodeing1.controlFram = Nothing
        OlEdatabaseCodeing1.Contronls = Nothing
        OlEdatabaseCodeing1.DataBasePath = Nothing
        OlEdatabaseCodeing1.DataGridveiw = Nothing
        OlEdatabaseCodeing1.Datareader = Nothing
        OlEdatabaseCodeing1.DataRow = Nothing
        OlEdatabaseCodeing1.Dataset = Nothing
        OlEdatabaseCodeing1.DataTable = Nothing
        OlEdatabaseCodeing1.FieldValue = Nothing
        OlEdatabaseCodeing1.FildsName = Nothing
        OlEdatabaseCodeing1.isDeleted = False
        OlEdatabaseCodeing1.isEdited = False
        OlEdatabaseCodeing1.Isinserted = False
        OlEdatabaseCodeing1.Row = Nothing
        OlEdatabaseCodeing1.RowCount = 0
        OlEdatabaseCodeing1.rowNo = 0
        OlEdatabaseCodeing1.ShowedContronls = Nothing
        OlEdatabaseCodeing1.SQL = Nothing
        OlEdatabaseCodeing1.TableAdabtor = Nothing
        OlEdatabaseCodeing1.TableCuloms = Nothing
        OlEdatabaseCodeing1.TableName = Nothing
        Me.DataPostionCode1.DataCode = OlEdatabaseCodeing1
        Me.DataPostionCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPostionCode1.font_color = System.Drawing.Color.Black
        Me.DataPostionCode1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataPostionCode1.font_color_Mousemove = System.Drawing.Color.White
        Me.DataPostionCode1.Location = New System.Drawing.Point(61, 536)
        Me.DataPostionCode1.Margin = New System.Windows.Forms.Padding(7)
        Me.DataPostionCode1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostionCode1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostionCode1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostionCode1.Name = "DataPostionCode1"
        Me.DataPostionCode1.Size = New System.Drawing.Size(1199, 113)
        Me.DataPostionCode1.TabIndex = 17
        Me.DataPostionCode1.textfont = Nothing
        '
        'StockDataMarket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 757)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.T_button4)
        Me.Controls.Add(Me.T_button3)
        Me.Controls.Add(Me.T_button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataPostionCode1)
        Me.Controls.Add(Me.T_button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "StockDataMarket"
        Me.Opacity = 1.0R
        Me.recshaps = ZeftawyTools.recshaps.rectopreght
        Me.Text = "بيانات الاصناف"
        Me.TiteText = "بيانات الاصناف"
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.DataPostionCode1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.T_button2, 0)
        Me.Controls.SetChildIndex(Me.T_button3, 0)
        Me.Controls.SetChildIndex(Me.T_button4, 0)
        Me.Controls.SetChildIndex(Me.SearchTxt, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents StockDataTableTableAdapter As Stocks.mydataDataSet1TableAdapters.StockDataTableTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sanftxt As ZeftawyTools.t_textbox
    Friend WithEvents Codetxt As ZeftawyTools.t_textbox
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalePricelbl As System.Windows.Forms.Label
    Friend WithEvents Jomlatxt As ZeftawyTools.t_textbox
    Friend WithEvents Paypricetxt As ZeftawyTools.t_textbox
    Friend WithEvents QutTxt As ZeftawyTools.t_textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataPostionCode1 As Z_Apps.DataPostionCode
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents T_button2 As ZeftawyTools.t_button
    Friend WithEvents T_button3 As ZeftawyTools.t_button
    Friend WithEvents QPBBTxt As ZeftawyTools.t_textbox
    Friend WithEvents BBQTxt As ZeftawyTools.t_textbox
    Friend WithEvents T_button4 As ZeftawyTools.t_button
    Friend WithEvents SearchTxt As ZeftawyTools.t_textbox
End Class
