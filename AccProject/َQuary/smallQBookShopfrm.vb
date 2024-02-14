Imports ZeftawyTools
Public Class QueryBookShopfrm
    Inherits myformDesign
    Dim datacomb As New TashfeenDataBaseWork.OLEDataBaseBinding
    Friend isclient As Boolean
    Dim StockBookShope As New StockDataBookShops
    Dim mydatac As New OLEdatabaseCodeing
    Dim proj As New projectDataBase
    Friend power As Boolean = False
    Dim mydataReader As New OLEdatabaseCodeing
    Dim saledata As New SaleMove
    Private Sub SanfQfrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MydataDataSet1.mainSanftable' table. You can move, or remove it, as needed.
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)


        StockBookShope.load()
        grpDestnations(sanfgrp)
        T_textbox5.Focus()
        proj.LoadSimplQuery_StockDataBookShop()
        proj.StockData_BookShope.Code.Control = T_textbox6
        proj.StockData_BookShope.Code.visable = True

        proj.StockData_BookShope.sanf.Control = T_textbox2
        proj.StockData_BookShope.sanf.visable = True
        proj.StockData_BookShope.bookName.Control = BookTxt
        proj.StockData_BookShope.bookName.visable = True

        proj.StockData_BookShope.ParchasePrice.Control = Paytxt
        proj.StockData_BookShope.ParchasePrice.visable = True
        proj.StockData_BookShope.jom_price.Control = Jomtxt
        proj.StockData_BookShope.jom_price.visable = True
        proj.StockData_BookShope.qut_price.Control = Quttxt
        proj.StockData_BookShope.qut_price.visable = True
        proj.LoadStockmove()
        saledata.load()
        saledata.SaleMove_FM = proj.StockMove_FieldMember
        proj.StockData_BookShope.StockDataBookShope_Fm = {proj.StockData_BookShope.Code, proj.StockData_BookShope.sanf, proj.StockData_BookShope.bookName _
                                                         , proj.StockData_BookShope.ParchasePrice, proj.StockData_BookShope.jom_price, proj.StockData_BookShope.qut_price, proj.StockData_BookShope.ser}

        mydatac.Load(proj.dataConPath_MyData, StockBookShope.StockData_TabaleName, proj.StockData_BookShope.StockDataBookShope_Fm, SaleDGV, 10)
        mydatac.showDatabyReaderTocombobox(MainSanfCmp, "main_sanf", "StockDataBookShops")
        mydatac.showDatabyReaderTocombobox(Moalefcmp, "moalef", "StockDataBookShops")
        mydatac.showDatabyReaderTocombobox(DarNashrCmb, "DarNashr", "StockDataBookShops")

        If power Then
            Savebtn.Visible = True
            For Each c In sanfgrp.Controls
                If TypeOf c Is t_textbox Then
                    c.ReadOnly = False
                    c.BackColor = c.leave_color
                    c.Refresh()
                End If
            Next
            Paytxt.Visible = True
            Savebtn.Visible = True
        Else
            Paytxt.Visible = False
            Savebtn.Visible = False
        End If


    End Sub

    Private Function SQLQ() As String

        Dim s As String
        mydataReader.ClearSQL()
        'myDataR.AddSelectSQL(" year ( " + SaleData.trDate.Name + ") ", "Dates", "التاريخ")

        mydataReader.AddSelectSQL(mydataReader.SelectSum(saledata.m_QBB.Name, "QBBs"))

        mydataReader.AddSelectSQL(mydataReader.SelectSum(saledata.Qpay.Name, "Qps"))
        mydataReader.AddSelectSQL(mydataReader.SelectSum(saledata.QrturnPay.Name, "QRps"))

        mydataReader.AddSelectSQL("( QBBs +([Qps]-[QRps])) as NetPay")

        mydataReader.AddSelectSQL(mydataReader.SelectSum(saledata.Qsale.Name, "Qs"))
        mydataReader.AddSelectSQL(mydataReader.SelectSum(saledata.QrturnSale.Name, "QrS"))
        mydataReader.AddSelectSQL("( Qs- QrS ) as NetSale")

        s = mydataReader.AddSelectSQL("(  [NetPay]-[NetSale]) as EB")
        Return s

    End Function
    Private Function GetSQl() As String
        Dim s As String
        s = " Where sandf like '%" + T_textbox2.Text + "%'"
        Return "Select    sandf , " + SQLQ() + "   From " + saledata.SaleMove_Table + s + "   GROUP BY sandf "

    End Function

    Private Sub GetSanfQuant()
        mydataReader.ConnectToDataBase(proj.Dataconpath)
        Qtxt.Text = mydataReader.showDataValuebyReader(GetSQl, 8)


    End Sub

    Friend snf As Boolean = True
    Private meCloss As Boolean
    Private Sub grpDestnations(ByVal g As GroupBox)
        If snf Then
            g.Visible = True
            g.Top = 43
            g.Left = 10
            g.Width = 903
            g.Height = 511
            Me.Width = 913
            'Me.Top = 535
        Else
            g.Visible = True
            g.Top = 43
            g.Left = 67
            g.Width = 513
            g.Height = 332
            Me.Width = 624
            'Me.Top = 485
        End If

    End Sub
    Dim dataf As New TashfeenDataBaseWork.DataFilter

    Private Sub T_textbox1_pressEnter() Handles T_textbox1.pressEnter
        meCloss = True
        SaleDGV.Focus()
    End Sub
    Private Sub T_textbox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles T_textbox1.TextChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockBookShope.sanf.Name, T_textbox1.Text))
        GetNew()
    End Sub
    Friend Property Quima As String
    Friend Property SanfQuima As String
    Private Sub SaleDGV_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles SaleDGV.CellEnter
        mydatac.MoveByDataGrideView()
        'T_textbox2.Text = SaleDGV.CurrentRow.Cells.Item(2).Value
        GetSanfQuant()
    End Sub
    Private Sub endfrm()
        If meCloss Then
            Me.Close()
        Else

            If snf Then
                Quima = T_textbox6.Text
                SanfQuima = BookTxt.Text
            Else
                Quima = T_textbox4.Text
            End If
            Me.Close()
        End If
    End Sub
    Private Sub T_button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles T_button1.Click
        endfrm()
    End Sub
    Dim cellenter As Boolean

    Private Sub T_textbox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles T_textbox3.TextChanged
        dataf.filteration("ClientNmae", T_textbox3.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)

    End Sub


    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'T_textbox4.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
    End Sub



    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.DoubleClick
        endfrm()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            endfrm()
        End If
    End Sub

    Private Sub SaleDGV_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles SaleDGV.DoubleClick
        endfrm()
    End Sub

    Private Sub SaleDGV_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles SaleDGV.KeyDown
        If e.KeyCode = Keys.Enter Then
            endfrm()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StockDataTableTableAdapter.FillByMainSanf(Me.MydataDataSet1.StockDataTable, ComboBox1.Text)
        'T_textbox1.Focus()
    End Sub

    Private Sub T_textbox5_pressEnter() Handles T_textbox5.pressEnter

        SaleDGV.Focus()
    End Sub

    Private Sub T_textbox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox5.TextChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockBookShope.Code.Name, T_textbox5.Text))
        GetNew()
    End Sub
    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        meCloss = True
        endfrm()
    End Sub

    Private Sub MainSanfCmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainSanfCmp.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockBookShope.main_sanf.Name, MainSanfCmp.Text))
        GetNew()
    End Sub

    Private Sub Moalefcmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Moalefcmp.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockBookShope.moalef.Name, Moalefcmp.Text))
        GetNew()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarNashrCmb.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockBookShope.DarNashr.Name, DarNashrCmb.Text))
        GetNew()
    End Sub
    Private Sub GetNew()
        If Not power Then Exit Sub
        If mydatac.RowCount < 1 Then
            NewBtn.Visible = True
        Else
            NewBtn.Visible = False
        End If
    End Sub
    Private Sub SaleDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDGV.CellContentClick

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        Dim f As New StockDataBookShopsFrm
        f.ShowDialog()
        mydatac.Load(proj.dataConPath_MyData, StockBookShope.StockData_TabaleName, proj.StockData_BookShope.StockDataBookShope_Fm, SaleDGV)
    End Sub

    Private Sub T_button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebtn.Click
        mydatac.Edet()
        mydatac.SaveEdite(True)
    End Sub
End Class