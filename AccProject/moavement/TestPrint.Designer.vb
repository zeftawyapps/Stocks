<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestPrint
    Inherits System.Windows.Forms.Form

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
        Me.MydataDataSet1 = New Z_Apps.mydataDataSet1()
        Me.SalePayMovementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalePayMovementTableAdapter = New Z_Apps.mydataDataSet1TableAdapters.SalePayMovementTableAdapter()
        Me.TableAdapterManager = New Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalePayMovementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MydataDataSet1
        '
        Me.MydataDataSet1.DataSetName = "mydataDataSet1"
        Me.MydataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalePayMovementBindingSource
        '
        Me.SalePayMovementBindingSource.DataMember = "SalePayMovement"
        Me.SalePayMovementBindingSource.DataSource = Me.MydataDataSet1
        '
        'SalePayMovementTableAdapter
        '
        Me.SalePayMovementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CahfFlowTableAdapter = Nothing
        Me.TableAdapterManager.CashFlowTableAdapter = Nothing
        Me.TableAdapterManager.CleintAccTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.DataENameTableTableAdapter = Nothing
        Me.TableAdapterManager.DocNoTableAdapter = Nothing
        Me.TableAdapterManager.mainSanftableTableAdapter = Nothing
        Me.TableAdapterManager.markadataTableAdapter = Nothing
        Me.TableAdapterManager.RebExpensseTableTableAdapter = Nothing
        Me.TableAdapterManager.SalePayMovementTableAdapter = Me.SalePayMovementTableAdapter
        Me.TableAdapterManager.StocBalancetableTableAdapter = Nothing
        Me.TableAdapterManager.StockDataTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 61)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 19)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(314, 37)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(206, 122)
        Me.DataGridView1.TabIndex = 2
        '
        'TestPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 232)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TestPrint"
        Me.Text = "TestPrint"
        CType(Me.MydataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalePayMovementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MydataDataSet1 As Z_Apps.mydataDataSet1
    Friend WithEvents SalePayMovementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalePayMovementTableAdapter As Z_Apps.mydataDataSet1TableAdapters.SalePayMovementTableAdapter
    Friend WithEvents TableAdapterManager As Z_Apps.mydataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
