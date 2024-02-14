Imports ZeftawyTools
Imports System.Math
Public Class StockMovementQuary
    Inherits myformDesign
    Dim datac As New TashfeenDataBaseWork.OLEDataBaseBinding
    Dim dg As New DataGrideVeiwWorks
    Dim datacomb As New TashfeenDataBaseWork.OLEDataBaseBinding
    Dim sql As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MydataDataSet1.SalePayMovement' table. You can move, or remove it, as needed.
        Me.SalePayMovementTableAdapter.Fill(Me.MydataDataSet1.SalePayMovement)
        'TODO: This line of code loads data into the 'MydataDataSet1.StockQuary' table. You can move, or remove it, as needed.
        Me.StockQuaryTableAdapter.Fill(Me.MydataDataSet1.StockQuary)
        dg.DataGridView = SalePayMovementDataGridView

        'TODO: This line of code loads data into the 'MydataDataSet1.StockQuary' table. You can move, or remove it, as needed.
        Me.StockQuaryTableAdapter.Fill(Me.MydataDataSet1.StockQuary)
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        'TODO: This line of code loads data into the 'MydataDataSet1.SalePayMovement' table. You can move, or remove it, as needed.
        Dim sql As String
             datac.DataConnection = SalePayMovementTableAdapter.Connection
        sql = "SELECT    code,sandf, SUM(QBB) AS Expr1 , SUM(Qsale) AS Expr2 , SUM(QrturnSale) AS Exp1, SUM(Qpay) AS Expr3 , SUM(QrturnPay) AS Exp2, SUM(ppay) AS Expr4 , SUM(QPbb) AS Exp8, SUM(Qpsale) AS Exp9, SUM(TotalRetarnSale) AS Exp10, SUM(QPPay) AS Exp11, SUM(TotalRetarnpay) AS Exp12  " + _
" FROM     SalePayMovement GROUP BY sandf, code"
        datac.GetReader(sql, datac.DataConnection)
        datac.showDatabyReader(SalePayMovementDataGridView)
        dg.DataGridView = SalePayMovementDataGridView
        datacomb.showDatabyReaderTocombobox(ComboBox1, "main_sanf", "StockDataTable", SalePayMovementTableAdapter.Connection)
        StockBalanc()
        TotalStockBalanc()
        groubBoxload(InvQgrb)
    End Sub

    Private Sub groubBoxload(ByVal gr As GroupBox)
        For Each c As Control In Me.Controls
            If TypeOf c Is GroupBox Then
                c.Visible = False
            End If
        Next
        gr.Visible = True
        gr.Width = 373
        gr.Height = 321
        gr.Top = 387
        gr.Left = 403
        gr.Visible = True
    End Sub
    Dim isTotal As Boolean = False
    Dim Qs, Qsr, Qp, Qpr, Qbb, ppay As Integer
    Dim BalanceQ, totalSQ, TotalpQ, GAforSale, GAforSaleQ, crBalane As Integer
    Dim EndInv, CGS, AVG_PricePer_Unet As Single

    Dim s, sr, p, pr, bb As Integer
    Dim Balance, totalS, Totalp As Integer
    Private Sub totalinvintory()

        Qbb = GetNumeric(DataGridView1.CurrentRow.Cells(0).Value)
        Qs = GetNumeric(DataGridView1.CurrentRow.Cells(1).Value)
        Qsr = GetNumeric(DataGridView1.CurrentRow.Cells(2).Value)
        Qp = GetNumeric(DataGridView1.CurrentRow.Cells(3).Value)
        Qpr = GetNumeric(DataGridView1.CurrentRow.Cells(4).Value)
        ppay = GetNumeric(DataGridView1.CurrentRow.Cells(5).Value)

       

        bb = GetNumeric(DataGridView1.CurrentRow.Cells(6).Value)

        s = GetNumeric(DataGridView1.CurrentRow.Cells(7).Value)

        sr = GetNumeric(DataGridView1.CurrentRow.Cells(8).Value)

        p = GetNumeric(DataGridView1.CurrentRow.Cells(9).Value)

        pr = GetNumeric(DataGridView1.CurrentRow.Cells(10).Value)

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        totalSQ = Qs - Qsr
        TotalpQ = (Qp - Qpr)
        GAforSaleQ = Qbb + (Qp - Qpr)
        BalanceQ = GAforSaleQ - totalSQ
        QBBtxt.Text = Qbb

        neTQSaletxt.Text = totalSQ.ToString
        netQparchasetxt.Text = TotalpQ.ToString
        GoodsAvialblForSaleTxt.Text = GAforSaleQ.ToString
        QBalancTxt.Text = BalanceQ.ToString
        crBalane = totalSQ + BalanceQ
        CrBalancetxt.Text = crBalane.ToString



        totalS = Math.Round(s - sr, 2)
        Totalp = Math.Round(p - pr, 2)

        GAforSale = Math.Round(Totalp + bb, 2)

        AVG_PricePer_Unet = Math.Round((GAforSale / GAforSaleQ), 2)
        EndInv = Math.Round(BalanceQ * AVG_PricePer_Unet, 0)
        TotalInvintoryTxt.Text = EndInv

        TotalCGSTxt.Text = CGS.ToString
        TotalParchasetxt.Text = Totalp
        CGS = Math.Round(Qs * AVG_PricePer_Unet, 0)
        TotalBBtxt.Text = bb
        WAPricetxt.Text = AVG_PricePer_Unet

        TotalNetSaletxt.Text = totalS
        CGSTxt.Text = CGS
        GrossMargienTxt.Text = Math.Round((totalS - CGS), 2)
        Totaldrtxt.Text = GAforSale
        TotalCrtxt.Text = Math.Round(EndInv + CGS, 0)
        SanfTxt.Text = "الاجمالي "
    End Sub


    Private Sub StockBalanc()

        SanfTxt.Text = SalePayMovementDataGridView.CurrentRow.Cells(1).Value

        Qbb = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(2).Value)
        Qs = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(3).Value)
        Qsr = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(4).Value)
        Qp = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(5).Value)
        Qpr = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(6).Value)
        ppay = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(7).Value)

        totalSQ = Qs - Qsr
        TotalpQ = (Qp - Qpr)
        GAforSaleQ = Qbb + (Qp - Qpr)
        BalanceQ = GAforSaleQ - totalSQ
        QBBtxt.Text = Qbb

        neTQSaletxt.Text = totalSQ.ToString
        netQparchasetxt.Text = TotalpQ.ToString
        GoodsAvialblForSaleTxt.Text = GAforSaleQ.ToString
        QBalancTxt.Text = BalanceQ.ToString
        crBalane = totalSQ + BalanceQ
        CrBalancetxt.Text = crBalane.ToString
    End Sub
    Private Function GetNumeric(ByVal x As Object) As Integer
        If IsDBNull(x) Then x = 0

        Return CInt(x)
    End Function

    Private Sub TotalStockBalanc()

        bb = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(8).Value)

        s = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(9).Value)

        sr = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(10).Value)

        p = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(11).Value)

        pr = GetNumeric(SalePayMovementDataGridView.CurrentRow.Cells(12).Value)


      

        totalS = s - sr
        Totalp = p - pr

        GAforSale = Totalp + bb

        AVG_PricePer_Unet = (GAforSale / GAforSaleQ)
        EndInv = BalanceQ * AVG_PricePer_Unet
        TotalInvintoryTxt.Text = EndInv

        TotalCGSTxt.Text = CGS.ToString
        TotalParchasetxt.Text = Totalp
        CGS = Qs * AVG_PricePer_Unet
        TotalBBtxt.Text = bb
        WAPricetxt.Text = AVG_PricePer_Unet

        TotalNetSaletxt.Text = totalS
        CGSTxt.Text = CGS
        GrossMargienTxt.Text = (totalS - CGS)
        Totaldrtxt.Text = GAforSale
        TotalCrtxt.Text = EndInv + CGS
    End Sub
    Dim istotals As Boolean
    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            StockBalanc()
            TotalStockBalanc()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SalePayMovementDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellEnter
        Try
            StockBalanc()

            TotalStockBalanc()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub SalePayMovementDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        SalePayMovementDataGridView.Rows.Clear()
        Dim sqlWhere As String = "having   sandf like '%" + ComboBox1.Text + "%'"
        sql = "SELECT    code,sandf, SUM(QBB) AS Expr1 , SUM(Qsale) AS Expr2 , SUM(QrturnSale) AS Exp1, SUM(Qpay) AS Expr3 , SUM(QrturnPay) AS Exp2, SUM(ppay) AS Expr4 , SUM(QPbb) AS Exp8, SUM(Qpsale) AS Exp9, SUM(TotalRetarnSale) AS Exp10, SUM(QPPay) AS Exp11, SUM(TotalRetarnpay) AS Exp12  " + _
" FROM     SalePayMovement GROUP BY sandf, code  "
        datac.GetReader(sql + sqlWhere, SalePayMovementTableAdapter.Connection)
        datac.showDatabyReader(SalePayMovementDataGridView)
        StockBalanc()
        TotalStockBalanc()
        groubBoxload(InvQgrb)
        SalePayMovementDataGridView.Visible = True
        DataGridView1.Visible = False

    End Sub

   

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        groubBoxload(InvQgrb)
    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button8.Click
        groubBoxload(TotalINvGrb)
    End Sub

    Private Sub T_button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click

        groubBoxload(Grossmagingrp)
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        sql = "SELECT       SUM(QBB) AS Expr1 , SUM(Qsale) AS Expr2 , SUM(QrturnSale) AS Exp1, SUM(Qpay) AS Expr3 , SUM(QrturnPay) AS Exp2, SUM(ppay) AS Expr4 , SUM(QPbb) AS Exp8, SUM(Qpsale) AS Exp9, SUM(TotalRetarnSale) AS Exp10, SUM(QPPay) AS Exp11, SUM(TotalRetarnpay) AS Exp12  " + _
" FROM     SalePayMovement "
        datac.GetReader(sql, datac.DataConnection)
        datac.showDatabyReader(DataGridView1)
        DataGridView1.Visible = True
        SalePayMovementDataGridView.Visible = False
        isTotal = True
        totalinvintory()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        totalinvintory()
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        sql = "SELECT    code,sandf, SUM(QBB) AS Expr1 , SUM(Qsale) AS Expr2 , SUM(QrturnSale) AS Exp1, SUM(Qpay) AS Expr3 , SUM(QrturnPay) AS Exp2, SUM(ppay) AS Expr4 , SUM(QPbb) AS Exp8, SUM(Qpsale) AS Exp9, SUM(TotalRetarnSale) AS Exp10, SUM(QPPay) AS Exp11, SUM(TotalRetarnpay) AS Exp12  " + _
" FROM     SalePayMovement GROUP BY sandf, code"
        ComboBox1.Text = ""
        datac.GetReader(sql, datac.DataConnection)
        datac.showDatabyReader(SalePayMovementDataGridView)
        DataGridView1.Visible = False
        SalePayMovementDataGridView.Visible = True
        StockBalanc()
        TotalStockBalanc()
        groubBoxload(InvQgrb)
    End Sub
End Class