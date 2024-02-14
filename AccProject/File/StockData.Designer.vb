<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDataBookShopsFrm
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim OlEdatabaseCodeing1 As Z_Apps.OLEdatabaseCodeing = New Z_Apps.OLEdatabaseCodeing()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AtLeadt = New ZeftawyTools.t_textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QPBBTxt = New ZeftawyTools.t_textbox()
        Me.BBQTxt = New ZeftawyTools.t_textbox()
        Me.QutTxt = New ZeftawyTools.t_textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Jomlatxt = New ZeftawyTools.t_textbox()
        Me.Paypricetxt = New ZeftawyTools.t_textbox()
        Me.SalePricelbl = New System.Windows.Forms.Label()
        Me.Codetxt = New ZeftawyTools.t_textbox()
        Me.Sanftxt = New ZeftawyTools.t_textbox()
        Me.BookShopHelpGrp = New System.Windows.Forms.GroupBox()
        Me.MainSanfchekbox = New ZeftawyTools.t_button()
        Me.moalefCheckbox = New ZeftawyTools.t_button()
        Me.Darnasherchekbox = New ZeftawyTools.t_button()
        Me.T_button10 = New ZeftawyTools.t_button()
        Me.T_button8 = New ZeftawyTools.t_button()
        Me.T_button7 = New ZeftawyTools.t_button()
        Me.BookNameTxt = New ZeftawyTools.t_textbox()
        Me.T_button6 = New ZeftawyTools.t_button()
        Me.MainSanfCmb = New System.Windows.Forms.ComboBox()
        Me.MoalefCmb = New System.Windows.Forms.ComboBox()
        Me.DarNashcmb = New System.Windows.Forms.ComboBox()
        Me.T_button1 = New ZeftawyTools.t_button()
        Me.T_button2 = New ZeftawyTools.t_button()
        Me.T_button3 = New ZeftawyTools.t_button()
        Me.T_button4 = New ZeftawyTools.t_button()
        Me.SearchTxt = New ZeftawyTools.t_textbox()
        Me.T_button5 = New ZeftawyTools.t_button()
        Me.T_button9 = New ZeftawyTools.t_button()
        Me.DataPostionCode1 = New Z_Apps.DataPostionCode()
        SanfLabel = New System.Windows.Forms.Label()
        Jom_priceLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BookShopHelpGrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(5)
        Me.TitelBar.Size = New System.Drawing.Size(1292, 64)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(9110, 5)
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
        Me.MsgText.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(5)
        Me.MsgTilteBar.Size = New System.Drawing.Size(21, 33)
        Me.MsgTilteBar.Visible = False
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-76, -5)
        Me.msgTitl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-41, 129)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.MsgT_Button.Size = New System.Drawing.Size(124, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(9013, 12)
        Me.Titel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Titel.Size = New System.Drawing.Size(119, 24)
        Me.Titel.Text = "بيانات الاصناف"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(239, 613)
        Me.Labelbox.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
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
        Me.MinBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinBtn.Location = New System.Drawing.Point(75, 2)
        Me.MinBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        Me.MinBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.MinBtn.Size = New System.Drawing.Size(63, 62)
        '
        'CloosBtn
        '
        Me.CloosBtn.Location = New System.Drawing.Point(5, 2)
        Me.CloosBtn.MakeMeAs = ZeftawyTools.Shap.نجمة
        Me.CloosBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.CloosBtn.Size = New System.Drawing.Size(60, 62)
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(1060, 1085)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(5)
        Me.T_textbox.Size = New System.Drawing.Size(15, 27)
        '
        'SanfLabel
        '
        SanfLabel.AutoSize = True
        SanfLabel.Location = New System.Drawing.Point(1211, 110)
        SanfLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        SanfLabel.Name = "SanfLabel"
        SanfLabel.Size = New System.Drawing.Size(68, 29)
        SanfLabel.TabIndex = 5
        SanfLabel.Text = "الصنف"
        '
        'Jom_priceLabel
        '
        Jom_priceLabel.AutoSize = True
        Jom_priceLabel.Location = New System.Drawing.Point(1218, 185)
        Jom_priceLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Jom_priceLabel.Name = "Jom_priceLabel"
        Jom_priceLabel.Size = New System.Drawing.Size(63, 29)
        Jom_priceLabel.TabIndex = 9
        Jom_priceLabel.Text = "الشراء"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(1211, 44)
        Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(101, 29)
        Label2.TabIndex = 21
        Label2.Text = "كود الصنف"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(931, 184)
        Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(132, 29)
        Label3.TabIndex = 30
        Label3.Text = "رصيد اول المدة"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(731, 185)
        Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 29)
        Label4.TabIndex = 32
        Label4.Text = "القيمة"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(433, 95)
        Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(138, 29)
        Label8.TabIndex = 43
        Label8.Text = "الصنف الاساسي"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(481, 142)
        Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(98, 29)
        Label9.TabIndex = 44
        Label9.Text = "اسم المؤلف"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(493, 203)
        Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(85, 29)
        Label10.TabIndex = 45
        Label10.Text = "دار النشر"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(470, 33)
        Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(93, 29)
        Label11.TabIndex = 51
        Label11.Text = "اسم الكتاب"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AtLeadt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.QPBBTxt)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.BBQTxt)
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
        Me.GroupBox1.Controls.Add(Me.BookShopHelpGrp)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 122)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(1349, 352)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'AtLeadt
        '
        Me.AtLeadt.checkEmail = False
        Me.AtLeadt.checkNolength = ZeftawyTools.chekcno.None
        Me.AtLeadt.combo_link = False
        Me.AtLeadt.combobox = Nothing
        Me.AtLeadt.enter_color = System.Drawing.Color.DodgerBlue
        Me.AtLeadt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtLeadt.ForeColor = System.Drawing.Color.Gray
        Me.AtLeadt.LabelColor = System.Drawing.Color.Gray
        Me.AtLeadt.LabelText = ""
        Me.AtLeadt.leave_color = System.Drawing.SystemColors.Window
        Me.AtLeadt.Location = New System.Drawing.Point(798, 283)
        Me.AtLeadt.Margin = New System.Windows.Forms.Padding(5)
        Me.AtLeadt.Name = "AtLeadt"
        Me.AtLeadt.numaricCheck = False
        Me.AtLeadt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.AtLeadt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AtLeadt.Size = New System.Drawing.Size(123, 38)
        Me.AtLeadt.TabIndex = 53
        Me.AtLeadt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AtLeadt.textColor = System.Drawing.Color.Black
        Me.AtLeadt.Textlengthcheck = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(931, 289)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 29)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "الحد الادنى للكمية"
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
        Me.QPBBTxt.Location = New System.Drawing.Point(622, 184)
        Me.QPBBTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.QPBBTxt.Name = "QPBBTxt"
        Me.QPBBTxt.numaricCheck = True
        Me.QPBBTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.QPBBTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QPBBTxt.Size = New System.Drawing.Size(110, 38)
        Me.QPBBTxt.TabIndex = 11
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
        Me.BBQTxt.ForeColor = System.Drawing.Color.Gray
        Me.BBQTxt.LabelColor = System.Drawing.Color.Gray
        Me.BBQTxt.LabelText = ""
        Me.BBQTxt.leave_color = System.Drawing.SystemColors.Window
        Me.BBQTxt.Location = New System.Drawing.Point(798, 184)
        Me.BBQTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.BBQTxt.Name = "BBQTxt"
        Me.BBQTxt.numaricCheck = False
        Me.BBQTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.BBQTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BBQTxt.Size = New System.Drawing.Size(130, 38)
        Me.BBQTxt.TabIndex = 8
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
        Me.QutTxt.ForeColor = System.Drawing.Color.Gray
        Me.QutTxt.LabelColor = System.Drawing.Color.Gray
        Me.QutTxt.LabelText = ""
        Me.QutTxt.leave_color = System.Drawing.SystemColors.Window
        Me.QutTxt.Location = New System.Drawing.Point(798, 234)
        Me.QutTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.QutTxt.Name = "QutTxt"
        Me.QutTxt.numaricCheck = False
        Me.QutTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.QutTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QutTxt.Size = New System.Drawing.Size(123, 38)
        Me.QutTxt.TabIndex = 10
        Me.QutTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QutTxt.textColor = System.Drawing.Color.Black
        Me.QutTxt.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(931, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
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
        Me.Jomlatxt.ForeColor = System.Drawing.Color.Gray
        Me.Jomlatxt.LabelColor = System.Drawing.Color.Gray
        Me.Jomlatxt.LabelText = ""
        Me.Jomlatxt.leave_color = System.Drawing.SystemColors.Window
        Me.Jomlatxt.Location = New System.Drawing.Point(1086, 234)
        Me.Jomlatxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Jomlatxt.Name = "Jomlatxt"
        Me.Jomlatxt.numaricCheck = False
        Me.Jomlatxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Jomlatxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Jomlatxt.Size = New System.Drawing.Size(98, 38)
        Me.Jomlatxt.TabIndex = 9
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
        Me.Paypricetxt.ForeColor = System.Drawing.Color.Gray
        Me.Paypricetxt.LabelColor = System.Drawing.Color.Gray
        Me.Paypricetxt.LabelText = ""
        Me.Paypricetxt.leave_color = System.Drawing.SystemColors.Window
        Me.Paypricetxt.Location = New System.Drawing.Point(1095, 184)
        Me.Paypricetxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Paypricetxt.Name = "Paypricetxt"
        Me.Paypricetxt.numaricCheck = False
        Me.Paypricetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Paypricetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Paypricetxt.Size = New System.Drawing.Size(99, 38)
        Me.Paypricetxt.TabIndex = 7
        Me.Paypricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Paypricetxt.textColor = System.Drawing.Color.Black
        Me.Paypricetxt.Textlengthcheck = 0
        '
        'SalePricelbl
        '
        Me.SalePricelbl.AutoSize = True
        Me.SalePricelbl.Location = New System.Drawing.Point(1190, 240)
        Me.SalePricelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SalePricelbl.Name = "SalePricelbl"
        Me.SalePricelbl.Size = New System.Drawing.Size(128, 29)
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
        Me.Codetxt.Location = New System.Drawing.Point(622, 44)
        Me.Codetxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Codetxt.Name = "Codetxt"
        Me.Codetxt.numaricCheck = False
        Me.Codetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Codetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Codetxt.Size = New System.Drawing.Size(581, 38)
        Me.Codetxt.TabIndex = 12
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
        Me.Sanftxt.Location = New System.Drawing.Point(622, 100)
        Me.Sanftxt.Margin = New System.Windows.Forms.Padding(5)
        Me.Sanftxt.Multiline = True
        Me.Sanftxt.Name = "Sanftxt"
        Me.Sanftxt.numaricCheck = False
        Me.Sanftxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Sanftxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Sanftxt.Size = New System.Drawing.Size(583, 79)
        Me.Sanftxt.TabIndex = 12
        Me.Sanftxt.textColor = System.Drawing.Color.Black
        Me.Sanftxt.Textlengthcheck = 0
        '
        'BookShopHelpGrp
        '
        Me.BookShopHelpGrp.Controls.Add(Me.MainSanfchekbox)
        Me.BookShopHelpGrp.Controls.Add(Me.moalefCheckbox)
        Me.BookShopHelpGrp.Controls.Add(Me.Darnasherchekbox)
        Me.BookShopHelpGrp.Controls.Add(Me.T_button10)
        Me.BookShopHelpGrp.Controls.Add(Me.T_button8)
        Me.BookShopHelpGrp.Controls.Add(Label11)
        Me.BookShopHelpGrp.Controls.Add(Me.T_button7)
        Me.BookShopHelpGrp.Controls.Add(Me.BookNameTxt)
        Me.BookShopHelpGrp.Controls.Add(Me.T_button6)
        Me.BookShopHelpGrp.Controls.Add(Label10)
        Me.BookShopHelpGrp.Controls.Add(Me.MainSanfCmb)
        Me.BookShopHelpGrp.Controls.Add(Label8)
        Me.BookShopHelpGrp.Controls.Add(Me.MoalefCmb)
        Me.BookShopHelpGrp.Controls.Add(Me.DarNashcmb)
        Me.BookShopHelpGrp.Controls.Add(Label9)
        Me.BookShopHelpGrp.Location = New System.Drawing.Point(7, 26)
        Me.BookShopHelpGrp.Name = "BookShopHelpGrp"
        Me.BookShopHelpGrp.Size = New System.Drawing.Size(607, 284)
        Me.BookShopHelpGrp.TabIndex = 52
        Me.BookShopHelpGrp.TabStop = False
        '
        'MainSanfchekbox
        '
        Me.MainSanfchekbox.BackColor = System.Drawing.Color.Blue
        Me.MainSanfchekbox.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.MainSanfchekbox.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.MainSanfchekbox.CheckBox = True
        Me.MainSanfchekbox.Checked = False
        Me.MainSanfchekbox.font_color = System.Drawing.Color.Black
        Me.MainSanfchekbox.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.MainSanfchekbox.font_color_Mousemove = System.Drawing.Color.White
        Me.MainSanfchekbox.Location = New System.Drawing.Point(112, 89)
        Me.MainSanfchekbox.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.MainSanfchekbox.me_text = "تثبيت"
        Me.MainSanfchekbox.meAutoSize = False
        Me.MainSanfchekbox.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.MainSanfchekbox.meloodserruonding_color = System.Drawing.Color.Blue
        Me.MainSanfchekbox.mousemove_center_color = System.Drawing.Color.Lime
        Me.MainSanfchekbox.Name = "MainSanfchekbox"
        Me.MainSanfchekbox.Size = New System.Drawing.Size(88, 52)
        Me.MainSanfchekbox.TabIndex = 55
        Me.MainSanfchekbox.Text = "تثبيت"
        Me.MainSanfchekbox.UseDefFontInTxtShap = True
        Me.MainSanfchekbox.UseDefultButton = False
        Me.MainSanfchekbox.UseVisualStyleBackColor = True
        '
        'moalefCheckbox
        '
        Me.moalefCheckbox.BackColor = System.Drawing.Color.Blue
        Me.moalefCheckbox.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.moalefCheckbox.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.moalefCheckbox.CheckBox = True
        Me.moalefCheckbox.Checked = False
        Me.moalefCheckbox.font_color = System.Drawing.Color.Black
        Me.moalefCheckbox.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.moalefCheckbox.font_color_Mousemove = System.Drawing.Color.White
        Me.moalefCheckbox.Location = New System.Drawing.Point(114, 147)
        Me.moalefCheckbox.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.moalefCheckbox.me_text = "تثبيت"
        Me.moalefCheckbox.meAutoSize = False
        Me.moalefCheckbox.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.moalefCheckbox.meloodserruonding_color = System.Drawing.Color.Blue
        Me.moalefCheckbox.mousemove_center_color = System.Drawing.Color.Lime
        Me.moalefCheckbox.Name = "moalefCheckbox"
        Me.moalefCheckbox.Size = New System.Drawing.Size(88, 52)
        Me.moalefCheckbox.TabIndex = 54
        Me.moalefCheckbox.Text = "تثبيت"
        Me.moalefCheckbox.UseDefFontInTxtShap = True
        Me.moalefCheckbox.UseDefultButton = False
        Me.moalefCheckbox.UseVisualStyleBackColor = True
        '
        'Darnasherchekbox
        '
        Me.Darnasherchekbox.BackColor = System.Drawing.Color.Blue
        Me.Darnasherchekbox.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Darnasherchekbox.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Darnasherchekbox.CheckBox = True
        Me.Darnasherchekbox.Checked = False
        Me.Darnasherchekbox.font_color = System.Drawing.Color.Black
        Me.Darnasherchekbox.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.Darnasherchekbox.font_color_Mousemove = System.Drawing.Color.White
        Me.Darnasherchekbox.Location = New System.Drawing.Point(118, 202)
        Me.Darnasherchekbox.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.Darnasherchekbox.me_text = "تثبيت"
        Me.Darnasherchekbox.meAutoSize = False
        Me.Darnasherchekbox.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Darnasherchekbox.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Darnasherchekbox.mousemove_center_color = System.Drawing.Color.Lime
        Me.Darnasherchekbox.Name = "Darnasherchekbox"
        Me.Darnasherchekbox.Size = New System.Drawing.Size(88, 52)
        Me.Darnasherchekbox.TabIndex = 53
        Me.Darnasherchekbox.Text = "تثبيت"
        Me.Darnasherchekbox.UseDefFontInTxtShap = True
        Me.Darnasherchekbox.UseDefultButton = False
        Me.Darnasherchekbox.UseVisualStyleBackColor = True
        '
        'T_button10
        '
        Me.T_button10.BackColor = System.Drawing.Color.Blue
        Me.T_button10.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button10.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button10.CheckBox = False
        Me.T_button10.Checked = False
        Me.T_button10.font_color = System.Drawing.Color.Black
        Me.T_button10.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button10.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button10.Location = New System.Drawing.Point(18, 25)
        Me.T_button10.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button10.me_text = "بحث"
        Me.T_button10.meAutoSize = False
        Me.T_button10.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button10.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button10.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button10.Name = "T_button10"
        Me.T_button10.Size = New System.Drawing.Size(88, 52)
        Me.T_button10.TabIndex = 52
        Me.T_button10.Text = "بحث"
        Me.T_button10.UseDefFontInTxtShap = True
        Me.T_button10.UseDefultButton = False
        Me.T_button10.UseVisualStyleBackColor = True
        '
        'T_button8
        '
        Me.T_button8.BackColor = System.Drawing.Color.Blue
        Me.T_button8.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button8.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button8.CheckBox = False
        Me.T_button8.Checked = False
        Me.T_button8.font_color = System.Drawing.Color.Black
        Me.T_button8.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button8.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button8.Location = New System.Drawing.Point(24, 200)
        Me.T_button8.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button8.me_text = "بحث"
        Me.T_button8.meAutoSize = False
        Me.T_button8.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button8.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button8.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button8.Name = "T_button8"
        Me.T_button8.Size = New System.Drawing.Size(88, 52)
        Me.T_button8.TabIndex = 45
        Me.T_button8.Text = "بحث"
        Me.T_button8.UseDefFontInTxtShap = True
        Me.T_button8.UseDefultButton = False
        Me.T_button8.UseVisualStyleBackColor = True
        '
        'T_button7
        '
        Me.T_button7.BackColor = System.Drawing.Color.Blue
        Me.T_button7.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button7.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button7.CheckBox = False
        Me.T_button7.Checked = False
        Me.T_button7.font_color = System.Drawing.Color.Black
        Me.T_button7.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button7.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button7.Location = New System.Drawing.Point(18, 142)
        Me.T_button7.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button7.me_text = "بحث"
        Me.T_button7.meAutoSize = False
        Me.T_button7.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button7.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button7.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button7.Name = "T_button7"
        Me.T_button7.Size = New System.Drawing.Size(88, 52)
        Me.T_button7.TabIndex = 44
        Me.T_button7.Text = "بحث"
        Me.T_button7.UseDefFontInTxtShap = True
        Me.T_button7.UseDefultButton = False
        Me.T_button7.UseVisualStyleBackColor = True
        '
        'BookNameTxt
        '
        Me.BookNameTxt.AutoCompleteCustomSource.AddRange(New String() {"الكتاب", "الكتب ", "ابن القيم"})
        Me.BookNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BookNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.BookNameTxt.checkEmail = False
        Me.BookNameTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.BookNameTxt.combo_link = False
        Me.BookNameTxt.combobox = Nothing
        Me.BookNameTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.BookNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNameTxt.ForeColor = System.Drawing.Color.Gray
        Me.BookNameTxt.LabelColor = System.Drawing.Color.Gray
        Me.BookNameTxt.LabelText = ""
        Me.BookNameTxt.leave_color = System.Drawing.SystemColors.Window
        Me.BookNameTxt.Location = New System.Drawing.Point(114, 27)
        Me.BookNameTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.BookNameTxt.Name = "BookNameTxt"
        Me.BookNameTxt.numaricCheck = False
        Me.BookNameTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.BookNameTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BookNameTxt.Size = New System.Drawing.Size(316, 38)
        Me.BookNameTxt.TabIndex = 3
        Me.BookNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BookNameTxt.textColor = System.Drawing.Color.Black
        Me.BookNameTxt.Textlengthcheck = 0
        '
        'T_button6
        '
        Me.T_button6.BackColor = System.Drawing.Color.Blue
        Me.T_button6.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button6.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button6.CheckBox = False
        Me.T_button6.Checked = False
        Me.T_button6.font_color = System.Drawing.Color.Black
        Me.T_button6.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button6.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button6.Location = New System.Drawing.Point(18, 84)
        Me.T_button6.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button6.me_text = "بحث"
        Me.T_button6.meAutoSize = False
        Me.T_button6.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button6.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button6.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button6.Name = "T_button6"
        Me.T_button6.Size = New System.Drawing.Size(88, 52)
        Me.T_button6.TabIndex = 43
        Me.T_button6.Text = "بحث"
        Me.T_button6.UseDefFontInTxtShap = True
        Me.T_button6.UseDefultButton = False
        Me.T_button6.UseVisualStyleBackColor = True
        '
        'MainSanfCmb
        '
        Me.MainSanfCmb.ForeColor = System.Drawing.Color.Maroon
        Me.MainSanfCmb.FormattingEnabled = True
        Me.MainSanfCmb.Location = New System.Drawing.Point(206, 92)
        Me.MainSanfCmb.Name = "MainSanfCmb"
        Me.MainSanfCmb.Size = New System.Drawing.Size(211, 37)
        Me.MainSanfCmb.TabIndex = 4
        '
        'MoalefCmb
        '
        Me.MoalefCmb.ForeColor = System.Drawing.Color.Maroon
        Me.MoalefCmb.FormattingEnabled = True
        Me.MoalefCmb.Location = New System.Drawing.Point(208, 147)
        Me.MoalefCmb.Name = "MoalefCmb"
        Me.MoalefCmb.Size = New System.Drawing.Size(209, 37)
        Me.MoalefCmb.TabIndex = 5
        '
        'DarNashcmb
        '
        Me.DarNashcmb.ForeColor = System.Drawing.Color.Maroon
        Me.DarNashcmb.FormattingEnabled = True
        Me.DarNashcmb.ItemHeight = 29
        Me.DarNashcmb.Location = New System.Drawing.Point(212, 203)
        Me.DarNashcmb.Name = "DarNashcmb"
        Me.DarNashcmb.Size = New System.Drawing.Size(205, 37)
        Me.DarNashcmb.TabIndex = 41
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
        Me.T_button1.Location = New System.Drawing.Point(780, 613)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "سجل جديد"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(197, 66)
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
        Me.T_button2.Location = New System.Drawing.Point(361, 613)
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
        Me.T_button3.Location = New System.Drawing.Point(578, 613)
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
        Me.T_button4.Location = New System.Drawing.Point(627, 69)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "بحث بالكود"
        Me.T_button4.meAutoSize = False
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(215, 52)
        Me.T_button4.TabIndex = 33
        Me.T_button4.Text = "بحث بالكود"
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
        Me.SearchTxt.LabelText = "ادخل البحث"
        Me.SearchTxt.leave_color = System.Drawing.SystemColors.Window
        Me.SearchTxt.Location = New System.Drawing.Point(850, 73)
        Me.SearchTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.numaricCheck = False
        Me.SearchTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.SearchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SearchTxt.Size = New System.Drawing.Size(456, 38)
        Me.SearchTxt.TabIndex = 34
        Me.SearchTxt.Text = "ادخل البحث"
        Me.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SearchTxt.textColor = System.Drawing.Color.Black
        Me.SearchTxt.Textlengthcheck = 0
        '
        'T_button5
        '
        Me.T_button5.BackColor = System.Drawing.Color.Blue
        Me.T_button5.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button5.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button5.CheckBox = False
        Me.T_button5.Checked = False
        Me.T_button5.font_color = System.Drawing.Color.Black
        Me.T_button5.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button5.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button5.Location = New System.Drawing.Point(377, 69)
        Me.T_button5.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button5.me_text = "بحث بالصنف"
        Me.T_button5.meAutoSize = False
        Me.T_button5.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button5.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button5.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button5.Name = "T_button5"
        Me.T_button5.Size = New System.Drawing.Size(241, 52)
        Me.T_button5.TabIndex = 35
        Me.T_button5.Text = "بحث بالصنف"
        Me.T_button5.UseDefFontInTxtShap = True
        Me.T_button5.UseDefultButton = False
        Me.T_button5.UseVisualStyleBackColor = True
        '
        'T_button9
        '
        Me.T_button9.BackColor = System.Drawing.Color.Blue
        Me.T_button9.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button9.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button9.CheckBox = False
        Me.T_button9.Checked = False
        Me.T_button9.font_color = System.Drawing.Color.Black
        Me.T_button9.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button9.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button9.Location = New System.Drawing.Point(0, 69)
        Me.T_button9.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button9.me_text = "استخدام شاشة البحث"
        Me.T_button9.meAutoSize = False
        Me.T_button9.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button9.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button9.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button9.Name = "T_button9"
        Me.T_button9.Size = New System.Drawing.Size(354, 52)
        Me.T_button9.TabIndex = 36
        Me.T_button9.Text = "استخدام شاشة البحث"
        Me.T_button9.UseDefFontInTxtShap = True
        Me.T_button9.UseDefultButton = False
        Me.T_button9.UseVisualStyleBackColor = True
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
        OlEdatabaseCodeing1.CopyPast_RowNoAdded = 0
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
        Me.DataPostionCode1.Location = New System.Drawing.Point(36, 475)
        Me.DataPostionCode1.Margin = New System.Windows.Forms.Padding(7)
        Me.DataPostionCode1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostionCode1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostionCode1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostionCode1.Name = "DataPostionCode1"
        Me.DataPostionCode1.Size = New System.Drawing.Size(1201, 112)
        Me.DataPostionCode1.TabIndex = 17
        Me.DataPostionCode1.textfont = Nothing
        '
        'StockDataBookShopsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 677)
        Me.Controls.Add(Me.T_button9)
        Me.Controls.Add(Me.T_button5)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.T_button4)
        Me.Controls.Add(Me.T_button3)
        Me.Controls.Add(Me.T_button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataPostionCode1)
        Me.Controls.Add(Me.T_button1)
        Me.DoubleBuffered = False
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "StockDataBookShopsFrm"
        Me.Opacity = 1.0R
        Me.recshaps = ZeftawyTools.recshaps.rectopreght
        Me.Text = "بيانات الاصناف"
        Me.TiteText = "بيانات الاصناف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.DataPostionCode1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.T_button2, 0)
        Me.Controls.SetChildIndex(Me.T_button3, 0)
        Me.Controls.SetChildIndex(Me.T_button4, 0)
        Me.Controls.SetChildIndex(Me.SearchTxt, 0)
        Me.Controls.SetChildIndex(Me.T_button5, 0)
        Me.Controls.SetChildIndex(Me.T_button9, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BookShopHelpGrp.ResumeLayout(False)
        Me.BookShopHelpGrp.PerformLayout()
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
    Friend WithEvents BookNameTxt As ZeftawyTools.t_textbox
    Friend WithEvents T_button5 As ZeftawyTools.t_button
    Friend WithEvents BookShopHelpGrp As System.Windows.Forms.GroupBox
    Friend WithEvents T_button8 As ZeftawyTools.t_button
    Friend WithEvents T_button7 As ZeftawyTools.t_button
    Friend WithEvents T_button6 As ZeftawyTools.t_button
    Friend WithEvents MainSanfCmb As System.Windows.Forms.ComboBox
    Friend WithEvents MoalefCmb As System.Windows.Forms.ComboBox
    Friend WithEvents DarNashcmb As System.Windows.Forms.ComboBox
    Friend WithEvents T_button9 As ZeftawyTools.t_button
    Friend WithEvents AtLeadt As ZeftawyTools.t_textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents T_button10 As ZeftawyTools.t_button
    Friend WithEvents MainSanfchekbox As ZeftawyTools.t_button
    Friend WithEvents moalefCheckbox As ZeftawyTools.t_button
    Friend WithEvents Darnasherchekbox As ZeftawyTools.t_button
End Class
