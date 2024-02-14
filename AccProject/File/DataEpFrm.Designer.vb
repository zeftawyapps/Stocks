<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataEpFrm
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
        Dim DataENameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim PowrLabel As System.Windows.Forms.Label
        Dim PasseWordLabel As System.Windows.Forms.Label
        Me.MydataDataSet1 = New Z_Apps.mydataDataSet1()
        Me.DataENameTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataENameTableTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.DataENameTableTableAdapter()
        Me.TableAdapterManager = New Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.T_textbox4 = New ZeftawyTools.t_textbox()
        Me.T_textbox3 = New ZeftawyTools.t_textbox()
        Me.T_textbox2 = New ZeftawyTools.t_textbox()
        Me.T_textbox1 = New ZeftawyTools.t_textbox()
        Me.Datacontrol3B1 = New ZeftawyTools.datacontrol3B()
        Me.DataPostion1 = New ZeftawyTools.DataPostion()
        Me.StockDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataTableTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.StockDataTableTableAdapter()
        DataENameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        PowrLabel = New System.Windows.Forms.Label()
        PasseWordLabel = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataENameTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StockDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TitelBar.Size = New System.Drawing.Size(651, 51)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(598, 0)
        Me.Logo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Logo.Size = New System.Drawing.Size(48, 43)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(87, 432)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.massegBoxFormat.Size = New System.Drawing.Size(15, 14)
        '
        'MsgText
        '
        Me.MsgText.Location = New System.Drawing.Point(25, 49)
        Me.MsgText.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MsgTilteBar.Size = New System.Drawing.Size(15, 34)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-68, 0)
        Me.msgTitl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-36, 104)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MsgT_Button.Size = New System.Drawing.Size(105, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(527, 9)
        Me.Titel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Titel.Size = New System.Drawing.Size(148, 29)
        Me.Titel.Text = "بيانات المستخدم"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(-175, 365)
        Me.Labelbox.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbox.Size = New System.Drawing.Size(0, 29)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(437, 432)
        Me.T_button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.T_button.Size = New System.Drawing.Size(15, 14)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'MinBtn
        '
        Me.MinBtn.Location = New System.Drawing.Point(57, -7)
        Me.MinBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinBtn.Size = New System.Drawing.Size(51, 50)
        '
        'CloosBtn
        '
        Me.CloosBtn.Location = New System.Drawing.Point(5, -7)
        Me.CloosBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CloosBtn.Size = New System.Drawing.Size(51, 50)
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(141, 432)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.T_textbox.Size = New System.Drawing.Size(13, 32)
        '
        'DataENameLabel
        '
        DataENameLabel.AutoSize = True
        DataENameLabel.Location = New System.Drawing.Point(433, 28)
        DataENameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DataENameLabel.Name = "DataENameLabel"
        DataENameLabel.Size = New System.Drawing.Size(76, 24)
        DataENameLabel.TabIndex = 12
        DataENameLabel.Text = "اسم المدخل"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(142, 56)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(75, 24)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "رقم التلفون"
        '
        'PowrLabel
        '
        PowrLabel.AutoSize = True
        PowrLabel.Location = New System.Drawing.Point(441, 84)
        PowrLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PowrLabel.Name = "PowrLabel"
        PowrLabel.Size = New System.Drawing.Size(67, 24)
        PowrLabel.TabIndex = 16
        PowrLabel.Text = "الصلاحيه"
        '
        'PasseWordLabel
        '
        PasseWordLabel.AutoSize = True
        PasseWordLabel.Location = New System.Drawing.Point(441, 56)
        PasseWordLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PasseWordLabel.Name = "PasseWordLabel"
        PasseWordLabel.Size = New System.Drawing.Size(67, 24)
        PasseWordLabel.TabIndex = 18
        PasseWordLabel.Text = "كلمة السر"
        '
        'MydataDataSet1
        '
        Me.MydataDataSet1.DataSetName = "mydataDataSet1"
        Me.MydataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataENameTableBindingSource
        '
        Me.DataENameTableBindingSource.DataMember = "DataENameTable"
        Me.DataENameTableBindingSource.DataSource = Me.MydataDataSet1
        '
        'DataENameTableTableAdapter
        '
        Me.DataENameTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CahfFlowTableAdapter = Nothing
        Me.TableAdapterManager.CashFlowTableAdapter = Nothing
        Me.TableAdapterManager.CleintAccTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.DataENameTableTableAdapter = Me.DataENameTableTableAdapter
        Me.TableAdapterManager.DocNoTableAdapter = Nothing
        Me.TableAdapterManager.mainSanftableTableAdapter = Nothing
        Me.TableAdapterManager.markadataTableAdapter = Nothing
        Me.TableAdapterManager.RebExpensseTableTableAdapter = Nothing
        Me.TableAdapterManager.SalePayMovementTableAdapter = Nothing
        Me.TableAdapterManager.StocBalancetableTableAdapter = Nothing
        Me.TableAdapterManager.StockDataTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.T_textbox4)
        Me.GroupBox1.Controls.Add(Me.T_textbox3)
        Me.GroupBox1.Controls.Add(Me.T_textbox2)
        Me.GroupBox1.Controls.Add(Me.T_textbox1)
        Me.GroupBox1.Controls.Add(DataENameLabel)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(PasseWordLabel)
        Me.GroupBox1.Controls.Add(PowrLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 147)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'T_textbox4
        '
        Me.T_textbox4.checkEmail = False
        Me.T_textbox4.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox4.combo_link = False
        Me.T_textbox4.combobox = Nothing
        Me.T_textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataENameTableBindingSource, "passeWord", True))
        Me.T_textbox4.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox4.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox4.Location = New System.Drawing.Point(210, 55)
        Me.T_textbox4.Name = "T_textbox4"
        Me.T_textbox4.numaricCheck = False
        Me.T_textbox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.T_textbox4.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox4.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox4.Size = New System.Drawing.Size(215, 29)
        Me.T_textbox4.TabIndex = 22
        Me.T_textbox4.textColor = System.Drawing.Color.Black
        Me.T_textbox4.Textlengthcheck = 0
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataENameTableBindingSource, "Powr", True))
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(14, 87)
        Me.T_textbox3.Multiline = True
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = False
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(419, 54)
        Me.T_textbox3.TabIndex = 21
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataENameTableBindingSource, "Phone", True))
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(6, 51)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(128, 29)
        Me.T_textbox2.TabIndex = 20
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataENameTableBindingSource, "DataEName", True))
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(6, 20)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(419, 29)
        Me.T_textbox1.TabIndex = 19
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'Datacontrol3B1
        '
        Me.Datacontrol3B1.BackColor = System.Drawing.Color.Transparent
        Me.Datacontrol3B1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Datacontrol3B1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Datacontrol3B1.ButtonForeColor = System.Drawing.Color.Empty
        Me.Datacontrol3B1.Location = New System.Drawing.Point(57, 283)
        Me.Datacontrol3B1.Margin = New System.Windows.Forms.Padding(4)
        Me.Datacontrol3B1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Datacontrol3B1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Datacontrol3B1.mousemove_center_color = System.Drawing.Color.Lime
        Me.Datacontrol3B1.Name = "Datacontrol3B1"
        Me.Datacontrol3B1.Size = New System.Drawing.Size(490, 88)
        Me.Datacontrol3B1.TabIndex = 20
        Me.Datacontrol3B1.textfont = Nothing
        '
        'DataPostion1
        '
        Me.DataPostion1.AutoSize = True
        Me.DataPostion1.BackColor = System.Drawing.Color.Transparent
        Me.DataPostion1.bindingsouce = Me.DataENameTableBindingSource
        Me.DataPostion1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.DataPostion1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.DataPostion1.ButtonFareColor = System.Drawing.Color.Empty
        Me.DataPostion1.Data_Posetion_Active = True
        Me.DataPostion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPostion1.font_color = System.Drawing.Color.Black
        Me.DataPostion1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataPostion1.font_color_Mousemove = System.Drawing.Color.White
        Me.DataPostion1.Location = New System.Drawing.Point(5, 212)
        Me.DataPostion1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataPostion1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostion1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostion1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostion1.Name = "DataPostion1"
        Me.DataPostion1.Size = New System.Drawing.Size(641, 80)
        Me.DataPostion1.TabIndex = 21
        Me.DataPostion1.textfont = Nothing
        '
        'StockDataTableBindingSource
        '
        Me.StockDataTableBindingSource.DataMember = "StockDataTable"
        Me.StockDataTableBindingSource.DataSource = Me.MydataDataSet1
        '
        'StockDataTableTableAdapter
        '
        Me.StockDataTableTableAdapter.ClearBeforeFill = True
        '
        'DataEpFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 369)
        Me.Controls.Add(Me.DataPostion1)
        Me.Controls.Add(Me.Datacontrol3B1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "DataEpFrm"
        Me.Opacity = 1.0R
        Me.Text = "بيانات المستخدم"
        Me.TiteText = "بيانات المستخدم"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.Datacontrol3B1, 0)
        Me.Controls.SetChildIndex(Me.DataPostion1, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataENameTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StockDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1
    Friend WithEvents DataENameTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataENameTableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.DataENameTableTableAdapter
    Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox4 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents Datacontrol3B1 As ZeftawyTools.datacontrol3B
    Friend WithEvents DataPostion1 As ZeftawyTools.DataPostion
    Friend WithEvents StockDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataTableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.StockDataTableTableAdapter
End Class
