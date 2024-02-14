<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashFlowfrm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AccNameDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecOrPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashOrBankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExplanationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChecknoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrAccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrAccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CahfFlowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet1 = New Z_Apps.mydataDataSet1()
        Me.cashFlowGrb = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.T_textbox4 = New ZeftawyTools.t_textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DrAccGrb = New System.Windows.Forms.GroupBox()
        Me.T_textbox10 = New ZeftawyTools.t_textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.T_textbox1 = New ZeftawyTools.t_textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrAccGrb = New System.Windows.Forms.GroupBox()
        Me.T_textbox7 = New ZeftawyTools.t_textbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.T_textbox3 = New ZeftawyTools.t_textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.T_textbox5 = New ZeftawyTools.t_textbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.T_textbox9 = New ZeftawyTools.t_textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T_textbox8 = New ZeftawyTools.t_textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T_textbox6 = New ZeftawyTools.t_textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_textbox2 = New ZeftawyTools.t_textbox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CahfFlowTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.CahfFlowTableAdapter()
        Me.TableAdapterManager = New Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.AccNameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CahfFlowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cashFlowGrb.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.DrAccGrb.SuspendLayout()
        Me.CrAccGrb.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(738, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(706, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(3, 75)
        Me.massegBoxFormat.Size = New System.Drawing.Size(10, 10)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Size = New System.Drawing.Size(10, 25)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-45, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-24, 75)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(651, 7)
        Me.Titel.Size = New System.Drawing.Size(157, 24)
        Me.Titel.Text = "حركة التدفقات النقدية"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(501, 427)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(0, 140)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(39, 57)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'AccNameDataGridView
        '
        Me.AccNameDataGridView.AllowUserToAddRows = False
        Me.AccNameDataGridView.AllowUserToDeleteRows = False
        Me.AccNameDataGridView.AutoGenerateColumns = False
        Me.AccNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccNameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecOrPayDataGridViewTextBoxColumn, Me.TransDataDataGridViewTextBoxColumn, Me.InvNoDataGridViewTextBoxColumn, Me.CashOrBankDataGridViewTextBoxColumn, Me.ExplanationDataGridViewTextBoxColumn, Me.ChecknoDataGridViewTextBoxColumn, Me.DrAccDataGridViewTextBoxColumn, Me.dr, Me.CrAccDataGridViewTextBoxColumn, Me.cr})
        Me.AccNameDataGridView.DataSource = Me.CahfFlowBindingSource
        Me.AccNameDataGridView.Location = New System.Drawing.Point(14, 217)
        Me.AccNameDataGridView.Name = "AccNameDataGridView"
        Me.AccNameDataGridView.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Olive
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccNameDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AccNameDataGridView.Size = New System.Drawing.Size(692, 270)
        Me.AccNameDataGridView.TabIndex = 10
        '
        'RecOrPayDataGridViewTextBoxColumn
        '
        Me.RecOrPayDataGridViewTextBoxColumn.DataPropertyName = "RecOrPay"
        Me.RecOrPayDataGridViewTextBoxColumn.HeaderText = "وارد او منصرف"
        Me.RecOrPayDataGridViewTextBoxColumn.Name = "RecOrPayDataGridViewTextBoxColumn"
        Me.RecOrPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransDataDataGridViewTextBoxColumn
        '
        Me.TransDataDataGridViewTextBoxColumn.DataPropertyName = "TransData"
        Me.TransDataDataGridViewTextBoxColumn.HeaderText = "التاريخ"
        Me.TransDataDataGridViewTextBoxColumn.Name = "TransDataDataGridViewTextBoxColumn"
        Me.TransDataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvNoDataGridViewTextBoxColumn
        '
        Me.InvNoDataGridViewTextBoxColumn.DataPropertyName = "invNo"
        Me.InvNoDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة"
        Me.InvNoDataGridViewTextBoxColumn.Name = "InvNoDataGridViewTextBoxColumn"
        Me.InvNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashOrBankDataGridViewTextBoxColumn
        '
        Me.CashOrBankDataGridViewTextBoxColumn.DataPropertyName = "CashOrBank"
        Me.CashOrBankDataGridViewTextBoxColumn.HeaderText = "نقد ام شيك"
        Me.CashOrBankDataGridViewTextBoxColumn.Name = "CashOrBankDataGridViewTextBoxColumn"
        Me.CashOrBankDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExplanationDataGridViewTextBoxColumn
        '
        Me.ExplanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation"
        Me.ExplanationDataGridViewTextBoxColumn.HeaderText = "الشرح"
        Me.ExplanationDataGridViewTextBoxColumn.Name = "ExplanationDataGridViewTextBoxColumn"
        Me.ExplanationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChecknoDataGridViewTextBoxColumn
        '
        Me.ChecknoDataGridViewTextBoxColumn.DataPropertyName = "Checkno"
        Me.ChecknoDataGridViewTextBoxColumn.HeaderText = "رقم الشيك"
        Me.ChecknoDataGridViewTextBoxColumn.Name = "ChecknoDataGridViewTextBoxColumn"
        Me.ChecknoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DrAccDataGridViewTextBoxColumn
        '
        Me.DrAccDataGridViewTextBoxColumn.DataPropertyName = "DrAcc"
        Me.DrAccDataGridViewTextBoxColumn.HeaderText = "حسابات مدينة"
        Me.DrAccDataGridViewTextBoxColumn.Name = "DrAccDataGridViewTextBoxColumn"
        Me.DrAccDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dr
        '
        Me.dr.DataPropertyName = "dr"
        Me.dr.HeaderText = "قيمة المدين "
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        '
        'CrAccDataGridViewTextBoxColumn
        '
        Me.CrAccDataGridViewTextBoxColumn.DataPropertyName = "CrAcc"
        Me.CrAccDataGridViewTextBoxColumn.HeaderText = "حسابات دائنة"
        Me.CrAccDataGridViewTextBoxColumn.Name = "CrAccDataGridViewTextBoxColumn"
        Me.CrAccDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cr
        '
        Me.cr.DataPropertyName = "cr"
        Me.cr.HeaderText = "قيمة الدائن"
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        '
        'CahfFlowBindingSource
        '
        Me.CahfFlowBindingSource.DataMember = "CahfFlow"
        Me.CahfFlowBindingSource.DataSource = Me.MydataDataSet1
        '
        'MydataDataSet1
        '
        Me.MydataDataSet1.DataSetName = "mydataDataSet1"
        Me.MydataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cashFlowGrb
        '
        Me.cashFlowGrb.BackColor = System.Drawing.Color.Transparent
        Me.cashFlowGrb.Controls.Add(Me.GroupBox4)
        Me.cashFlowGrb.Controls.Add(Me.DrAccGrb)
        Me.cashFlowGrb.Controls.Add(Me.CrAccGrb)
        Me.cashFlowGrb.Controls.Add(Me.ComboBox2)
        Me.cashFlowGrb.Controls.Add(Me.Label5)
        Me.cashFlowGrb.Controls.Add(Me.T_textbox5)
        Me.cashFlowGrb.Controls.Add(Me.Label9)
        Me.cashFlowGrb.Controls.Add(Me.T_textbox9)
        Me.cashFlowGrb.Controls.Add(Me.Label8)
        Me.cashFlowGrb.Controls.Add(Me.T_textbox8)
        Me.cashFlowGrb.Controls.Add(Me.Label7)
        Me.cashFlowGrb.Controls.Add(Me.Label6)
        Me.cashFlowGrb.Controls.Add(Me.T_textbox6)
        Me.cashFlowGrb.Controls.Add(Me.Label3)
        Me.cashFlowGrb.Controls.Add(Me.T_textbox2)
        Me.cashFlowGrb.Controls.Add(Me.AccNameDataGridView)
        Me.cashFlowGrb.Location = New System.Drawing.Point(3, 91)
        Me.cashFlowGrb.Name = "cashFlowGrb"
        Me.cashFlowGrb.Size = New System.Drawing.Size(712, 493)
        Me.cashFlowGrb.TabIndex = 21
        Me.cashFlowGrb.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.T_textbox4)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(415, 125)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(291, 57)
        Me.GroupBox4.TabIndex = 139
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "رقم الشيك"
        Me.GroupBox4.Visible = False
        '
        'T_textbox4
        '
        Me.T_textbox4.checkEmail = False
        Me.T_textbox4.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox4.combo_link = False
        Me.T_textbox4.combobox = Nothing
        Me.T_textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "Checkno", True))
        Me.T_textbox4.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox4.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelText = ""
        Me.T_textbox4.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox4.Location = New System.Drawing.Point(6, 19)
        Me.T_textbox4.Name = "T_textbox4"
        Me.T_textbox4.numaricCheck = False
        Me.T_textbox4.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox4.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox4.Size = New System.Drawing.Size(155, 30)
        Me.T_textbox4.TabIndex = 119
        Me.T_textbox4.textColor = System.Drawing.Color.Black
        Me.T_textbox4.Textlengthcheck = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "رقم الشيك"
        '
        'DrAccGrb
        '
        Me.DrAccGrb.Controls.Add(Me.T_textbox10)
        Me.DrAccGrb.Controls.Add(Me.Label13)
        Me.DrAccGrb.Controls.Add(Me.T_textbox1)
        Me.DrAccGrb.Controls.Add(Me.Label1)
        Me.DrAccGrb.Location = New System.Drawing.Point(9, 147)
        Me.DrAccGrb.Name = "DrAccGrb"
        Me.DrAccGrb.Size = New System.Drawing.Size(360, 35)
        Me.DrAccGrb.TabIndex = 139
        Me.DrAccGrb.TabStop = False
        Me.DrAccGrb.Text = "حسابات مدينة"
        Me.DrAccGrb.Visible = False
        '
        'T_textbox10
        '
        Me.T_textbox10.checkEmail = False
        Me.T_textbox10.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox10.combo_link = False
        Me.T_textbox10.combobox = Nothing
        Me.T_textbox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "dr", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.T_textbox10.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox10.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox10.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox10.LabelText = ""
        Me.T_textbox10.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox10.Location = New System.Drawing.Point(8, 55)
        Me.T_textbox10.Name = "T_textbox10"
        Me.T_textbox10.numaricCheck = False
        Me.T_textbox10.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox10.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox10.Size = New System.Drawing.Size(155, 30)
        Me.T_textbox10.TabIndex = 121
        Me.T_textbox10.textColor = System.Drawing.Color.Black
        Me.T_textbox10.Textlengthcheck = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(183, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 23)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "القيمة"
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "DrAcc", True))
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = ""
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(6, 19)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(155, 30)
        Me.T_textbox1.TabIndex = 119
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "حسابات مدينة"
        '
        'CrAccGrb
        '
        Me.CrAccGrb.Controls.Add(Me.T_textbox7)
        Me.CrAccGrb.Controls.Add(Me.Label12)
        Me.CrAccGrb.Controls.Add(Me.T_textbox3)
        Me.CrAccGrb.Controls.Add(Me.Label2)
        Me.CrAccGrb.Location = New System.Drawing.Point(17, 120)
        Me.CrAccGrb.Name = "CrAccGrb"
        Me.CrAccGrb.Size = New System.Drawing.Size(352, 20)
        Me.CrAccGrb.TabIndex = 138
        Me.CrAccGrb.TabStop = False
        Me.CrAccGrb.Text = "حسابات دائنة"
        Me.CrAccGrb.Visible = False
        '
        'T_textbox7
        '
        Me.T_textbox7.checkEmail = False
        Me.T_textbox7.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox7.combo_link = False
        Me.T_textbox7.combobox = Nothing
        Me.T_textbox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "cr", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.T_textbox7.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox7.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox7.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox7.LabelText = ""
        Me.T_textbox7.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox7.Location = New System.Drawing.Point(6, 55)
        Me.T_textbox7.Name = "T_textbox7"
        Me.T_textbox7.numaricCheck = False
        Me.T_textbox7.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.T_textbox7.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox7.Size = New System.Drawing.Size(206, 30)
        Me.T_textbox7.TabIndex = 121
        Me.T_textbox7.textColor = System.Drawing.Color.Black
        Me.T_textbox7.Textlengthcheck = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(218, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "القيمة"
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "CrAcc", True))
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox3.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = ""
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(6, 19)
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = False
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(206, 30)
        Me.T_textbox3.TabIndex = 119
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "حسابات دائنة"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "CashOrBank", True))
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"نقد", "شيك"})
        Me.ComboBox2.Location = New System.Drawing.Point(434, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 31)
        Me.ComboBox2.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "البيان"
        '
        'T_textbox5
        '
        Me.T_textbox5.checkEmail = False
        Me.T_textbox5.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox5.combo_link = False
        Me.T_textbox5.combobox = Nothing
        Me.T_textbox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "Explanation", True))
        Me.T_textbox5.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox5.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox5.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox5.LabelText = ""
        Me.T_textbox5.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox5.Location = New System.Drawing.Point(9, 56)
        Me.T_textbox5.Multiline = True
        Me.T_textbox5.Name = "T_textbox5"
        Me.T_textbox5.numaricCheck = False
        Me.T_textbox5.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox5.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox5.Size = New System.Drawing.Size(360, 58)
        Me.T_textbox5.TabIndex = 133
        Me.T_textbox5.textColor = System.Drawing.Color.Black
        Me.T_textbox5.Textlengthcheck = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(114, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 23)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "وارد منصرف"
        '
        'T_textbox9
        '
        Me.T_textbox9.checkEmail = False
        Me.T_textbox9.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox9.combo_link = False
        Me.T_textbox9.combobox = Nothing
        Me.T_textbox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "RecOrPay", True))
        Me.T_textbox9.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox9.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox9.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox9.LabelText = ""
        Me.T_textbox9.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox9.Location = New System.Drawing.Point(6, 14)
        Me.T_textbox9.Name = "T_textbox9"
        Me.T_textbox9.numaricCheck = False
        Me.T_textbox9.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox9.ReadOnly = True
        Me.T_textbox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.T_textbox9.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox9.Size = New System.Drawing.Size(97, 30)
        Me.T_textbox9.TabIndex = 131
        Me.T_textbox9.textColor = System.Drawing.Color.Black
        Me.T_textbox9.Textlengthcheck = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "التاريخ"
        '
        'T_textbox8
        '
        Me.T_textbox8.checkEmail = False
        Me.T_textbox8.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox8.combo_link = False
        Me.T_textbox8.combobox = Nothing
        Me.T_textbox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "TransData", True))
        Me.T_textbox8.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox8.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox8.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox8.LabelText = ""
        Me.T_textbox8.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox8.Location = New System.Drawing.Point(222, 18)
        Me.T_textbox8.Name = "T_textbox8"
        Me.T_textbox8.numaricCheck = False
        Me.T_textbox8.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox8.ReadOnly = True
        Me.T_textbox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.T_textbox8.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox8.Size = New System.Drawing.Size(147, 30)
        Me.T_textbox8.TabIndex = 129
        Me.T_textbox8.textColor = System.Drawing.Color.Black
        Me.T_textbox8.Textlengthcheck = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(611, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 23)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "نقد/شيك"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(611, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "القيمة"
        '
        'T_textbox6
        '
        Me.T_textbox6.checkEmail = False
        Me.T_textbox6.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox6.combo_link = False
        Me.T_textbox6.combobox = Nothing
        Me.T_textbox6.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox6.ForeColor = System.Drawing.Color.Black
        Me.T_textbox6.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox6.LabelText = ""
        Me.T_textbox6.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox6.Location = New System.Drawing.Point(434, 54)
        Me.T_textbox6.Name = "T_textbox6"
        Me.T_textbox6.numaricCheck = True
        Me.T_textbox6.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox6.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox6.Size = New System.Drawing.Size(171, 30)
        Me.T_textbox6.TabIndex = 125
        Me.T_textbox6.Text = "0"
        Me.T_textbox6.textColor = System.Drawing.Color.Black
        Me.T_textbox6.Textlengthcheck = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(611, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "رقم الاذن"
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CahfFlowBindingSource, "invNo", True))
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = ""
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(434, 18)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(171, 30)
        Me.T_textbox2.TabIndex = 115
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"وارد", "منصرف"})
        Me.ComboBox1.Location = New System.Drawing.Point(358, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 31)
        Me.ComboBox1.TabIndex = 135
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(521, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 23)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "وارد /منصرف"
        '
        'CahfFlowTableAdapter
        '
        Me.CahfFlowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CahfFlowTableAdapter = Me.CahfFlowTableAdapter
        Me.TableAdapterManager.CleintAccTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.DataENameTableTableAdapter = Nothing
        Me.TableAdapterManager.DocNoTableAdapter = Nothing
        Me.TableAdapterManager.mainSanftableTableAdapter = Nothing
        Me.TableAdapterManager.markadataTableAdapter = Nothing
        Me.TableAdapterManager.RebExpensseTableTableAdapter = Nothing
        Me.TableAdapterManager.SalePayMovementTableAdapter = Nothing
        Me.TableAdapterManager.StocBalancetableTableAdapter = Nothing
        Me.TableAdapterManager.StockDataTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CashFlowfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 674)
        Me.Controls.Add(Me.cashFlowGrb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.centerUp
        Me.Name = "CashFlowfrm"
        Me.Opacity = 1.0R
        Me.Text = "حركة التدفقات النقدية"
        Me.TiteText = "حركة التدفقات النقدية"
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.cashFlowGrb, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.AccNameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CahfFlowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cashFlowGrb.ResumeLayout(False)
        Me.cashFlowGrb.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.DrAccGrb.ResumeLayout(False)
        Me.DrAccGrb.PerformLayout()
        Me.CrAccGrb.ResumeLayout(False)
        Me.CrAccGrb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccNameDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cashFlowGrb As System.Windows.Forms.GroupBox
    Friend WithEvents ChecnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents T_textbox5 As ZeftawyTools.t_textbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents T_textbox9 As ZeftawyTools.t_textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents T_textbox8 As ZeftawyTools.t_textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents T_textbox6 As ZeftawyTools.t_textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox4 As ZeftawyTools.t_textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DrAccGrb As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrAccGrb As System.Windows.Forms.GroupBox
    Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1
    Friend WithEvents CahfFlowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CahfFlowTableAdapter As Z_Apps.mydataDataSet1TableAdapters.CahfFlowTableAdapter
    Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents RecOrPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransDataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashOrBankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExplanationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChecknoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrAccDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrAccDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_textbox7 As ZeftawyTools.t_textbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents T_textbox10 As ZeftawyTools.t_textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
