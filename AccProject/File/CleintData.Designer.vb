Imports ZeftawyTools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleintData
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
        Dim ClientNmaeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddriesLabel As System.Windows.Forms.Label
        Me.DataPostion1 = New ZeftawyTools.DataPostion()
        Me.ClientTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet1 = New Z_Apps.mydataDataSet1()
        Me.Datacontrol3B1 = New ZeftawyTools.datacontrol3B()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.T_textbox3 = New ZeftawyTools.t_textbox()
        Me.T_textbox2 = New ZeftawyTools.t_textbox()
        Me.T_textbox1 = New ZeftawyTools.t_textbox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClientTableTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.ClientTableTableAdapter()

        ClientNmaeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddriesLabel = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TitelBar.Size = New System.Drawing.Size(598, 51)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(-82, 4)
        Me.Logo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Logo.Size = New System.Drawing.Size(48, 43)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(43, 434)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.massegBoxFormat.Size = New System.Drawing.Size(15, 14)
        '
        'MsgText
        '
        Me.MsgText.Location = New System.Drawing.Point(25, 49)
        Me.MsgText.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MsgTilteBar.Size = New System.Drawing.Size(15, 34)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-43, 8)
        Me.msgTitl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-36, 104)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MsgT_Button.Size = New System.Drawing.Size(105, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(-164, 10)
        Me.Titel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(-46, 394)
        Me.Labelbox.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(92, 442)
        Me.T_button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.T_button.Size = New System.Drawing.Size(16, 14)
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
        Me.T_textbox.Location = New System.Drawing.Point(20, 410)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.T_textbox.Size = New System.Drawing.Size(13, 27)
        '
        'ClientNmaeLabel
        '
        ClientNmaeLabel.AutoSize = True
        ClientNmaeLabel.Location = New System.Drawing.Point(430, 21)
        ClientNmaeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ClientNmaeLabel.Name = "ClientNmaeLabel"
        ClientNmaeLabel.Size = New System.Drawing.Size(34, 18)
        ClientNmaeLabel.TabIndex = 2
        ClientNmaeLabel.Text = "الاسم"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(195, 21)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(61, 18)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "رقم الهاتف"
        '
        'AddriesLabel
        '
        AddriesLabel.AutoSize = True
        AddriesLabel.Location = New System.Drawing.Point(427, 61)
        AddriesLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddriesLabel.Name = "AddriesLabel"
        AddriesLabel.Size = New System.Drawing.Size(43, 18)
        AddriesLabel.TabIndex = 6
        AddriesLabel.Text = "العنوان"
        '
        'DataPostion1
        '
        Me.DataPostion1.AutoSize = True
        Me.DataPostion1.BackColor = System.Drawing.Color.Transparent
        Me.DataPostion1.bindingsouce = Me.ClientTableBindingSource
        Me.DataPostion1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.DataPostion1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.DataPostion1.ButtonFareColor = System.Drawing.Color.Empty
        Me.DataPostion1.Data_Posetion_Active = True
        Me.DataPostion1.font_color = System.Drawing.Color.Black
        Me.DataPostion1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataPostion1.font_color_Mousemove = System.Drawing.Color.White
        Me.DataPostion1.Location = New System.Drawing.Point(25, 241)
        Me.DataPostion1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataPostion1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostion1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostion1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostion1.Name = "DataPostion1"
        Me.DataPostion1.Size = New System.Drawing.Size(533, 67)
        Me.DataPostion1.TabIndex = 12
        Me.DataPostion1.textfont = Nothing
        '
        'ClientTableBindingSource
        '
        Me.ClientTableBindingSource.DataMember = "ClientTable"
        Me.ClientTableBindingSource.DataSource = Me.MydataDataSet1
        '
        'MydataDataSet1
        '
        Me.MydataDataSet1.DataSetName = "mydataDataSet1"
        Me.MydataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Datacontrol3B1
        '
        Me.Datacontrol3B1.BackColor = System.Drawing.Color.Transparent
        Me.Datacontrol3B1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Datacontrol3B1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Datacontrol3B1.ButtonForeColor = System.Drawing.Color.Empty
        Me.Datacontrol3B1.Location = New System.Drawing.Point(80, 316)
        Me.Datacontrol3B1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Datacontrol3B1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Datacontrol3B1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Datacontrol3B1.mousemove_center_color = System.Drawing.Color.Lime
        Me.Datacontrol3B1.Name = "Datacontrol3B1"
        Me.Datacontrol3B1.Size = New System.Drawing.Size(432, 61)
        Me.Datacontrol3B1.TabIndex = 13
        Me.Datacontrol3B1.textfont = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.T_textbox3)
        Me.GroupBox1.Controls.Add(Me.T_textbox2)
        Me.GroupBox1.Controls.Add(Me.T_textbox1)
        Me.GroupBox1.Controls.Add(ClientNmaeLabel)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(AddriesLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(501, 153)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTableBindingSource, "Addries", True))
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(11, 61)
        Me.T_textbox3.Margin = New System.Windows.Forms.Padding(2)
        Me.T_textbox3.Multiline = True
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = False
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(409, 78)
        Me.T_textbox3.TabIndex = 9
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTableBindingSource, "Phone", True))
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(11, 23)
        Me.T_textbox2.Margin = New System.Windows.Forms.Padding(2)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(168, 24)
        Me.T_textbox2.TabIndex = 8
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTableBindingSource, "ClientNmae", True))
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(263, 23)
        Me.T_textbox1.Margin = New System.Windows.Forms.Padding(2)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(160, 24)
        Me.T_textbox1.TabIndex = 7
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTableBindingSource, "Cleint/supplar", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(185, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(167, 26)
        Me.TextBox1.TabIndex = 15
        '
        'ClientTableTableAdapter
        '
        Me.ClientTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.CleintAccTableAdapter = Nothing
        'Me.TableAdapterManager.ClientTableTableAdapter = Me.ClientTableTableAdapter
        'Me.TableAdapterManager.DataENameTableTableAdapter = Nothing
        'Me.TableAdapterManager.mainSanftableTableAdapter = Nothing

        'Me.TableAdapterManager.UpdateOrder = Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        ''
        'CleintData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 409)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Datacontrol3B1)
        Me.Controls.Add(Me.DataPostion1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCloseAnimationType = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.FormOpenAnimationtype = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.myFormAnimationCase = ZeftawyTools.AnimationCase.الاثنثن_معا
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "CleintData"
        Me.Opacity = 1.0R
        Me.Text = "بيانات العميل"
        Me.Controls.SetChildIndex(Me.DataPostion1, 0)
        Me.Controls.SetChildIndex(Me.Datacontrol3B1, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1
    Friend WithEvents ClientTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.ClientTableTableAdapter
    Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataPostion1 As ZeftawyTools.DataPostion
    Friend WithEvents Datacontrol3B1 As ZeftawyTools.datacontrol3B
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
