Imports ZeftawyTools

Public Class ClientBalanceFrm
    Inherits myformDesign

    Dim AccName, SQL, Haveing As String

    Private DataC, exDatac As New OLEdatabaseCodeing
    Private proj As New projectDataBase
    Friend isClint As Boolean = False
    Dim Cmbindex As Integer = 0

    Private Sub ClientSupplaermovementFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet1.RebExpensseTable' table. You can move, or remove it, as needed.
        'Me.RebExpensseTableTableAdapter.Fill(Me.MydataDataSet1.RebExpensseTable)
        'DataC.DataConnection = CahfFlowTableAdapter.Connection

        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        If isClint Then
            SupplierClientgrp.Visible = True
            SupplierClientgrp.Dock = DockStyle.Fill
        Else
            ExpRevgrp.Visible = True
            ExpRevgrp.Dock = DockStyle.Fill

        End If
      
    End Sub

    

 
    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        isClint = False
        BalanceLoad()

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        isClint = True
        BalanceLoad()

    End Sub
    Private Sub ExRevbalanceLoad()
        'DataGridView1.Visible = True
        'SQL = "SELECT   Account, AccChild, SUM(dr) AS Expr1, SUM(cr) AS Expr2 FROM     RebExpensseTable GROUP BY Account, AccChild "
        'DataGridView1.Columns.Item(2).Visible = False
        'DataGridView1.Columns.Item(3).Visible = False
        exDatac.ConnectToDataBase(proj.Dataconpath)
        Select Case ComboBox1.SelectedIndex

            Case 0
                SQL = "SELECT    Account ,proAcc , SUM(dr) AS Expr1 " + _
               " FROM RebExpensseTable  GROUP BY proAcc , Account"
                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " HAVING    Account  = '" + AccName + "'"
                DataGridView1.Columns.Item(2).Visible = True
                DataGridView1.Columns.Item(3).Visible = False

                'Label1.Text = RebExpensseTableTableAdapter.ScalarQueryex(AccName)
                'Label1.Text = exDatac.showDataValuebyReader(SQL, 1)

            Case 1
                SQL = "SELECT  Account , proAcc , SUM(cr) AS Expr1   " + _
             " FROM RebExpensseTable  GROUP BY proAcc,  Account "
                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " HAVING     Account  = '" + AccName + "'"
                DataGridView1.Columns.Item(3).Visible = True
                DataGridView1.Columns.Item(2).Visible = False

                DataGridView1.Visible = True
                'Label1.Text = RebExpensseTableTableAdapter.ScalarQueryrev(AccName)
                'Label1.Text = exDatac.showDataValuebyReader(SQL, 1)

        End Select

        SQL = SQL + Haveing
        exDatac.GetReader(SQL, exDatac.Connection)
        exDatac.showDatabyReader(DataGridView1)
        If ComboBox1.SelectedIndex = 0 Then

            SQL = "SELECT    Account ,  SUM(dr) AS Expr1 " + _
               " FROM RebExpensseTable  GROUP BY  Account  HAVING     Account  = '" + AccName + "'"
            Label1.Text = exDatac.showDataValuebyReader(SQL, 1)
        Else
            SQL = " SELECT  Account ,   SUM(cr) AS Expr1   " + _
             " FROM RebExpensseTable  GROUP BY    Account HAVING     Account  = '" + AccName + "'"

            Label1.Text = exDatac.showDataValuebyReader(SQL, 1)
        End If
    End Sub
    Private Sub BalanceLoad()
        DataC.ConnectToDataBase(proj.Dataconpath)
        SalePayMovementDataGridView.Visible = True
        SQL = "SELECT  CleintSupp , Namec  , SUM (Dr)  AS Expr2 ,   SUM (Cr)  AS Expr1 FROM CleintAcc  GROUP BY Namec , CleintSupp"
        If isClint Then
            SalePayMovementDataGridView.Rows.Clear()
            AccName = "عميل"

            Haveing = " HAVING    CleintSupp = '" + AccName + "'"
            SalePayMovementDataGridView.Columns.Item(3).Visible = False
            SalePayMovementDataGridView.Columns.Item(2).Visible = True

        Else
            SalePayMovementDataGridView.Rows.Clear()
            AccName = "مورد"
            Haveing = " HAVING    CleintSupp = '" + AccName + "'"
            SalePayMovementDataGridView.Columns.Item(3).Visible = True
            SalePayMovementDataGridView.Columns.Item(2).Visible = False

        End If
        SQL = SQL + Haveing
        DataC.GetReader(SQL, DataC.Connection)
        DataC.showDatabyReader(SalePayMovementDataGridView)
        If isClint Then

            SQL = "SELECT  CleintSupp  , " + DataC.SelectSum("Dr", "Ex") + "  FROM CleintAcc   GROUP BY  CleintSupp   HAVING    CleintSupp = 'عميل'"

            Label14.Text = DataC.showDataValuebyReader(SQL, 1)
        Else
            SQL = "  SELECT  CleintSupp   , " + DataC.SelectSum("Cr", "Ex") + "  FROM CleintAcc GROUP BY  CleintSupp   HAVING    CleintSupp = 'مورد'"

            Label14.Text = DataC.showDataValuebyReader(SQL, 1)
        End If
    End Sub
    Dim iscs As Boolean
    Friend Property ISClitnAndsup As Boolean
        Get
            Return iscs
        End Get
        Set(ByVal value As Boolean)
            iscs = value
        End Set
    End Property

    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ExRevbalanceLoad()
         End Sub

    Private Sub ExpRevgrp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpRevgrp.Enter

    End Sub
End Class