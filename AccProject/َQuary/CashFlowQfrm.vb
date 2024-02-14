Public Class CashFlowQfrm

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
      
            ExpRevgrp.Visible = True
            ExpRevgrp.Dock = DockStyle.Fill



    End Sub




  
    Private Sub ExRevbalanceLoad()
        'DataGridView1.Visible = True
        'SQL = "SELECT   Account, AccChild, SUM(dr) AS Expr1, SUM(cr) AS Expr2 FROM     RebExpensseTable GROUP BY Account, AccChild "
        'DataGridView1.Columns.Item(2).Visible = False
        'DataGridView1.Columns.Item(3).Visible = False
        exDatac.ConnectToDataBase(proj.Dataconpath)
        Select Case ComboBox1.SelectedIndex

            Case 0
                SQL = "SELECT    RecOrPay ,CrAcc , SUM(Cr) AS Expr1 " + _
               " FROM CashFlow  GROUP BY CrAcc , RecOrPay"
                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " HAVING    RecOrPay  = '" + AccName + "'"
                DataGridView1.Columns.Item(2).Visible = True
                DataGridView1.Columns.Item(3).Visible = False

              
            Case 1
                SQL = "SELECT    RecOrPay ,DrAcc , SUM(dr) AS Expr1 " + _
                " FROM CashFlow  GROUP BY DrAcc , RecOrPay"
                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " HAVING     RecOrPay  = '" + AccName + "'"
                DataGridView1.Columns.Item(3).Visible = True
                DataGridView1.Columns.Item(2).Visible = False

                DataGridView1.Visible = True
              
        End Select

        Sql = Sql + Haveing
        exDatac.GetReader(Sql, exDatac.Connection)
        exDatac.showDatabyReader(DataGridView1)
        If ComboBox1.SelectedIndex = 0 Then

            SQL = "SELECT    RecOrPay ,  SUM(cr) AS Expr1  FROM CashFlow  GROUP BY  RecOrPay  HAVING     RecOrPay  = '" + AccName + "'"
            Label1.Text = exDatac.showDataValuebyReader(SQL, 1)
        Else
            SQL = "SELECT    RecOrPay ,  SUM(dr) AS Expr1  FROM CashFlow  GROUP BY  RecOrPay  HAVING     RecOrPay  = '" + AccName + "'"

            Label1.Text = exDatac.showDataValuebyReader(SQL, 1)
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

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        exDatac.ConnectToDataBase(proj.Dataconpath)
        Dim net, dr, cr As Single
        'exDatac.GetReader(SQL, exDatac.Connection)
        SQL = "SELECT      SUM(cr) AS Expr1  FROM CashFlow "
        cr = exDatac.showDataValuebyReader(SQL, 0)

        SQL = "SELECT      SUM(dr) AS Expr1  FROM CashFlow "

        dr = exDatac.showDataValuebyReader(SQL, 0)


        net = dr - cr
        Label2.Text = net
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
     




        exDatac.ConnectToDataBase(proj.Dataconpath)
        Select Case ComboBox1.SelectedIndex

            Case 0
                SQL = "SELECT    RecOrPay , CrAcc ,   Cr ,  invNo    " + _
             " FROM CashFlow "

                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " Where    RecOrPay  = '" + AccName + "'"
                DataGridView1.Columns.Item(2).Visible = True
                DataGridView1.Columns.Item(3).Visible = False
            

            Case 1
                SQL = "SELECT    RecOrPay ,DrAcc ,  dr  , invNo " + _
                " FROM CashFlow  "
                DataGridView1.Rows.Clear()
                AccName = ComboBox1.Text
                Haveing = " Where      RecOrPay  = '" + AccName + "'"
                DataGridView1.Columns.Item(3).Visible = True
                DataGridView1.Columns.Item(2).Visible = False

                DataGridView1.Visible = True

        End Select
        DataGridView1.Columns.Add("invNo", "رقم الفاتورة")

        SQL = SQL + Haveing
        exDatac.GetReader(SQL, exDatac.Connection)
        exDatac.showDatabyReader(DataGridView1)
       


    End Sub
End Class