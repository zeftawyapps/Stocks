<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientBalanceFrm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SalePayMovementDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientSupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_button2 = New ZeftawyTools.t_button()
        Me.T_button4 = New ZeftawyTools.t_button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SupplierClientgrp = New System.Windows.Forms.GroupBox()
        Me.ExpRevgrp = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.SalePayMovementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SupplierClientgrp.SuspendLayout()
        Me.ExpRevgrp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitelBar.Size = New System.Drawing.Size(765, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(1017, 3)
        Me.Logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(3, 339)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.massegBoxFormat.Size = New System.Drawing.Size(15, 21)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MsgTilteBar.Size = New System.Drawing.Size(15, 25)
        Me.MsgTilteBar.Visible = False
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-40, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-22, 75)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(962, 7)
        Me.Titel.Size = New System.Drawing.Size(190, 24)
        Me.Titel.Text = "ارصدة العملاء و الموردين"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(538, 140)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(27, 287)
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
        Me.T_textbox.Location = New System.Drawing.Point(66, 266)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'SalePayMovementDataGridView
        '
        Me.SalePayMovementDataGridView.AllowUserToAddRows = False
        Me.SalePayMovementDataGridView.AllowUserToDeleteRows = False
        Me.SalePayMovementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SalePayMovementDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalePayMovementDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SalePayMovementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalePayMovementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientSupp, Me.ClientName, Me.Dr, Me.Cr})
        Me.SalePayMovementDataGridView.Location = New System.Drawing.Point(20, 99)
        Me.SalePayMovementDataGridView.Name = "SalePayMovementDataGridView"
        Me.SalePayMovementDataGridView.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy
        Me.SalePayMovementDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SalePayMovementDataGridView.Size = New System.Drawing.Size(670, 198)
        Me.SalePayMovementDataGridView.TabIndex = 46
        Me.SalePayMovementDataGridView.Visible = False
        '
        'ClientSupp
        '
        Me.ClientSupp.HeaderText = "عميل ام مورد"
        Me.ClientSupp.Name = "ClientSupp"
        Me.ClientSupp.ReadOnly = True
        Me.ClientSupp.Width = 122
        '
        'ClientName
        '
        Me.ClientName.HeaderText = "الاسم"
        Me.ClientName.Name = "ClientName"
        Me.ClientName.ReadOnly = True
        Me.ClientName.Width = 75
        '
        'Dr
        '
        Me.Dr.HeaderText = "الرصيد"
        Me.Dr.Name = "Dr"
        Me.Dr.ReadOnly = True
        Me.Dr.Width = 77
        '
        'Cr
        '
        Me.Cr.HeaderText = "الرصيد"
        Me.Cr.Name = "Cr"
        Me.Cr.ReadOnly = True
        Me.Cr.Width = 77
        '
        'T_button2
        '
        Me.T_button2.BackColor = System.Drawing.Color.Blue
        Me.T_button2.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button2.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button2.CheckBox = False
        Me.T_button2.Checked = False
        Me.T_button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button2.font_color = System.Drawing.Color.Black
        Me.T_button2.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button2.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button2.Location = New System.Drawing.Point(310, 50)
        Me.T_button2.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button2.me_text = "عميل"
        Me.T_button2.meAutoSize = True
        Me.T_button2.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button2.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button2.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button2.Name = "T_button2"
        Me.T_button2.Size = New System.Drawing.Size(145, 43)
        Me.T_button2.TabIndex = 48
        Me.T_button2.Text = "عميل"
        Me.T_button2.UseDefFontInTxtShap = True
        Me.T_button2.UseDefultButton = False
        Me.T_button2.UseVisualStyleBackColor = True
        '
        'T_button4
        '
        Me.T_button4.BackColor = System.Drawing.Color.Blue
        Me.T_button4.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button4.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button4.CheckBox = False
        Me.T_button4.Checked = False
        Me.T_button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button4.font_color = System.Drawing.Color.Black
        Me.T_button4.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button4.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button4.Location = New System.Drawing.Point(471, 50)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "مورد"
        Me.T_button4.meAutoSize = True
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(145, 43)
        Me.T_button4.TabIndex = 49
        Me.T_button4.Text = "مورد"
        Me.T_button4.UseDefFontInTxtShap = True
        Me.T_button4.UseDefultButton = False
        Me.T_button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 52)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الاجمالي"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(44, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 42)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "0"
        '
        'SupplierClientgrp
        '
        Me.SupplierClientgrp.BackColor = System.Drawing.Color.Transparent
        Me.SupplierClientgrp.Controls.Add(Me.GroupBox2)
        Me.SupplierClientgrp.Controls.Add(Me.T_button4)
        Me.SupplierClientgrp.Controls.Add(Me.T_button2)
        Me.SupplierClientgrp.Controls.Add(Me.SalePayMovementDataGridView)
        Me.SupplierClientgrp.Location = New System.Drawing.Point(3, 43)
        Me.SupplierClientgrp.Name = "SupplierClientgrp"
        Me.SupplierClientgrp.Size = New System.Drawing.Size(157, 52)
        Me.SupplierClientgrp.TabIndex = 51
        Me.SupplierClientgrp.TabStop = False
        Me.SupplierClientgrp.Text = " "
        '
        'ExpRevgrp
        '
        Me.ExpRevgrp.BackColor = System.Drawing.Color.Transparent
        Me.ExpRevgrp.Controls.Add(Me.ComboBox1)
        Me.ExpRevgrp.Controls.Add(Me.GroupBox3)
        Me.ExpRevgrp.Controls.Add(Me.DataGridView1)
        Me.ExpRevgrp.Location = New System.Drawing.Point(334, 112)
        Me.ExpRevgrp.Name = "ExpRevgrp"
        Me.ExpRevgrp.Size = New System.Drawing.Size(400, 27)
        Me.ExpRevgrp.TabIndex = 52
        Me.ExpRevgrp.TabStop = False
        Me.ExpRevgrp.Text = " "
        Me.ExpRevgrp.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"مصروفات", "ايرادات"})
        Me.ComboBox1.Location = New System.Drawing.Point(317, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 27)
        Me.ComboBox1.TabIndex = 51
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 52)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "الاجمالي"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 42)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.Location = New System.Drawing.Point(43, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(670, 198)
        Me.DataGridView1.TabIndex = 46
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "نوع الحساب"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "الحساب "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "الرصيد"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "الرصيد"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'ClientBalanceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(765, 380)
        Me.Controls.Add(Me.ExpRevgrp)
        Me.Controls.Add(Me.SupplierClientgrp)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.MyFormSurrundColor = System.Drawing.Color.LightSlateGray
        Me.Name = "ClientBalanceFrm"
        Me.Opacity = 1.0R
        Me.Text = "ارصدة العملاء و الموردين"
        Me.TiteText = "ارصدة العملاء و الموردين"
        Me.Controls.SetChildIndex(Me.SupplierClientgrp, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.ExpRevgrp, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.SalePayMovementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SupplierClientgrp.ResumeLayout(False)
        Me.ExpRevgrp.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1

    'Friend WithEvents CahfFlowBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents CahfFlowTableAdapter As Z_Apps.mydataDataSet1TableAdapters.CahfFlowTableAdapter
    'Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    'Friend WithEvents CleintAccTableAdapter As Z_Apps.mydataDataSet1TableAdapters.CleintAccTableAdapter
    'Friend WithEvents CleintAccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalePayMovementDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_button2 As ZeftawyTools.t_button
    Friend WithEvents T_button4 As ZeftawyTools.t_button
    'Friend WithEvents DocNoBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents DocNoTableAdapter As Z_Apps.mydataDataSet1TableAdapters.DocNoTableAdapter
    Friend WithEvents ClientSupp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SupplierClientgrp As System.Windows.Forms.GroupBox
    Friend WithEvents ExpRevgrp As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents RebExpensseTableBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents RebExpensseTableTableAdapter As Z_Apps.mydataDataSet1TableAdapters.RebExpensseTableTableAdapter

End Class
