<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainStnfFrm
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
        Dim Main_sunfLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DataPostion1 = New ZeftawyTools.DataPostion()
        Me.DataENameTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet1 = New Z_Apps.mydataDataSet1()
        Me.Datacontrol3B1 = New ZeftawyTools.datacontrol3B()
        Me.T_textbox1 = New ZeftawyTools.t_textbox()
        Me.mainGrp = New System.Windows.Forms.GroupBox()
        Me.T_textbox2 = New ZeftawyTools.t_textbox()
        Me.DataENameTableTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.DataENameTableTableAdapter()
        Me.TableAdapterManager1 = New Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager()
        Me.markagrp = New System.Windows.Forms.GroupBox()
        Me.T_textbox3 = New ZeftawyTools.t_textbox()
        Me.MarkadataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarkadataTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.markadataTableAdapter()
        Main_sunfLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.DataENameTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainGrp.SuspendLayout()
        Me.markagrp.SuspendLayout()
        CType(Me.MarkadataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(501, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(-1401, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(11, 206)
        Me.massegBoxFormat.Size = New System.Drawing.Size(26, 36)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Size = New System.Drawing.Size(26, 25)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-29, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-16, 75)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(-1456, 7)
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(509, 128)
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(43, 215)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(75, 211)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'Main_sunfLabel
        '
        Main_sunfLabel.AutoSize = True
        Main_sunfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Main_sunfLabel.Location = New System.Drawing.Point(264, 21)
        Main_sunfLabel.Name = "Main_sunfLabel"
        Main_sunfLabel.Size = New System.Drawing.Size(127, 25)
        Main_sunfLabel.TabIndex = 1
        Main_sunfLabel.Text = "الصنف الاساسي"
        Main_sunfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(264, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 25)
        Label1.TabIndex = 1
        Label1.Text = "ماركة"
        Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.DataPostion1.font_color = System.Drawing.Color.Black
        Me.DataPostion1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataPostion1.font_color_Mousemove = System.Drawing.Color.White
        Me.DataPostion1.Location = New System.Drawing.Point(75, 129)
        Me.DataPostion1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostion1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostion1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostion1.Name = "DataPostion1"
        Me.DataPostion1.Size = New System.Drawing.Size(355, 48)
        Me.DataPostion1.TabIndex = 15
        Me.DataPostion1.textfont = Nothing
        '
        'DataENameTableBindingSource
        '
        Me.DataENameTableBindingSource.DataMember = "DataENameTable"
        Me.DataENameTableBindingSource.DataSource = Me.MydataDataSet1
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
        Me.Datacontrol3B1.Location = New System.Drawing.Point(119, 184)
        Me.Datacontrol3B1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Datacontrol3B1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Datacontrol3B1.mousemove_center_color = System.Drawing.Color.Lime
        Me.Datacontrol3B1.Name = "Datacontrol3B1"
        Me.Datacontrol3B1.Size = New System.Drawing.Size(288, 54)
        Me.Datacontrol3B1.TabIndex = 14
        Me.Datacontrol3B1.textfont = Nothing
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(56, 215)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ' Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(10, 29)
        Me.T_textbox1.TabIndex = 13
        Me.T_textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'mainGrp
        '
        Me.mainGrp.BackColor = System.Drawing.Color.Transparent
        Me.mainGrp.Controls.Add(Me.T_textbox2)
        Me.mainGrp.Controls.Add(Main_sunfLabel)
        Me.mainGrp.Location = New System.Drawing.Point(56, 55)
        Me.mainGrp.Name = "mainGrp"
        Me.mainGrp.Size = New System.Drawing.Size(397, 68)
        Me.mainGrp.TabIndex = 16
        Me.mainGrp.TabStop = False
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataENameTableBindingSource, "DataEName", True))
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(6, 19)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(244, 29)
        Me.T_textbox2.TabIndex = 2
        Me.T_textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'DataENameTableTableAdapter
        '
        Me.DataENameTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager1.CashAccTableAdapter = Nothing
        Me.TableAdapterManager1.CleintAccTableAdapter = Nothing
        Me.TableAdapterManager1.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager1.DataENameTableTableAdapter = Me.DataENameTableTableAdapter
        Me.TableAdapterManager1.mainSanftableTableAdapter = Nothing
        Me.TableAdapterManager1.markadataTableAdapter = Nothing
        'Me.TableAdapterManager1.RebExpensseTableTableAdapter = Nothing
        'Me.TableAdapterManager1.StocBalancetableTableAdapter = Nothing
        'Me.TableAdapterManager1.StockDataTableTableAdapter = Nothing
        'Me.TableAdapterManager1.StooremovingDataTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'markagrp
        '
        Me.markagrp.BackColor = System.Drawing.Color.Transparent
        Me.markagrp.Controls.Add(Me.T_textbox3)
        Me.markagrp.Controls.Add(Label1)
        Me.markagrp.Location = New System.Drawing.Point(33, 132)
        Me.markagrp.Name = "markagrp"
        Me.markagrp.Size = New System.Drawing.Size(323, 68)
        Me.markagrp.TabIndex = 17
        Me.markagrp.TabStop = False
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarkadataBindingSource, "main sunf", True))
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_textbox3.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(6, 19)
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = False
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '  Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(244, 29)
        Me.T_textbox3.TabIndex = 2
        Me.T_textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'MarkadataBindingSource
        '
        Me.MarkadataBindingSource.DataMember = "markadata"
        Me.MarkadataBindingSource.DataSource = Me.MydataDataSet1
        '
        'MarkadataTableAdapter
        '
        Me.MarkadataTableAdapter.ClearBeforeFill = True
        '
        'mainStnfFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 242)
        Me.Controls.Add(Me.markagrp)
        Me.Controls.Add(Me.DataPostion1)
        Me.Controls.Add(Me.Datacontrol3B1)
        Me.Controls.Add(Me.T_textbox1)
        Me.Controls.Add(Me.mainGrp)
        Me.FormCloseAnimationType = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.FormOpenAnimationtype = ZeftawyTools.AnimaitionType.VerticalSpreed
        Me.myFormAnimationCase = ZeftawyTools.AnimationCase.الاثنثن_معا
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "mainStnfFrm"
        Me.Opacity = 1.0R
        Me.Text = "الصنف الاساسي"
        Me.Controls.SetChildIndex(Me.mainGrp, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.T_textbox1, 0)
        Me.Controls.SetChildIndex(Me.Datacontrol3B1, 0)
        Me.Controls.SetChildIndex(Me.DataPostion1, 0)
        Me.Controls.SetChildIndex(Me.markagrp, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.DataENameTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainGrp.ResumeLayout(False)
        Me.mainGrp.PerformLayout()
        Me.markagrp.ResumeLayout(False)
        Me.markagrp.PerformLayout()
        CType(Me.MarkadataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainSanftableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.mainSanftableTableAdapter
    Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataPostion1 As ZeftawyTools.DataPostion
    Friend WithEvents Datacontrol3B1 As ZeftawyTools.datacontrol3B
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents mainGrp As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1
    Friend WithEvents DataENameTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataENameTableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.DataENameTableTableAdapter
    Friend WithEvents TableAdapterManager1 As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents markagrp As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents MarkadataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarkadataTableAdapter As Z_Apps.mydataDataSet1TableAdapters.markadataTableAdapter
End Class
