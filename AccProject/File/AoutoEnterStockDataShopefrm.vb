Imports ZeftawyTools
Public Class AoutoEnterStockDataShopefrm
    'Dim datacomb As New TashfeenDataBaseWork.OLEDataBaseBinding
    Friend isclient As Boolean
    Dim StockShope As New StockDataShops
    Dim mydatac As New OLEdatabaseCodeing
    Dim proj As New projectDataBase
    Friend power As Boolean = True
    Dim mydataReader As New OLEdatabaseCodeing
    Dim saledata As New SaleMove
    Private Sub SanfQfrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MydataDataSet1.mainSanftable' table. You can move, or remove it, as needed.
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        StockShope.load()
         
        T_textbox5.Focus()
        proj.LoadAoutoEnter_StockDataShop()
        proj.StockData_Shope.Code.Control = T_textbox6
        proj.StockData_Shope.Code.visable = True

        proj.StockData_Shope.sanf.Control = T_textbox2
        proj.StockData_Shope.sanf.visable = True
        proj.StockData_Shope.AdditionalData.Control = BookTxt
        proj.StockData_Shope.AdditionalData.visable = True

        proj.StockData_Shope.ParchasePrice.Control = Paytxt
        proj.StockData_BookShope.ParchasePrice.visable = True
        proj.StockData_Shope.jom_price.Control = Jomtxt
        proj.StockData_Shope.jom_price.visable = True
        proj.StockData_Shope.qut_price.Control = Quttxt
        proj.StockData_Shope.qut_price.visable = True
        proj.LoadStockmove()
        saledata.load()
        saledata.SaleMove_FM = proj.StockMove_FieldMember
        proj.StockData_Shope.StockDataShope_Fm = {proj.StockData_Shope.Code, proj.StockData_Shope.sanf, proj.StockData_Shope.main_sanf, proj.StockData_Shope.parnck, proj.StockData_Shope.mark, _
                                                          proj.StockData_Shope.ParchasePrice, proj.StockData_Shope.jom_price, proj.StockData_Shope.qut_price, proj.StockData_Shope.AdditionalData, proj.StockData_Shope.ser}

        mydatac.Load(proj.dataConPath_MyData, StockShope.StockData_TabaleName, proj.StockData_Shope.StockDataShope_Fm, SaleDGV, 10)
        mydatac.showDatabyReaderTocombobox(MainSanfCmp, "main_sanf", StockShope.StockData_TabaleName)
        mydatac.showDatabyReaderTocombobox(Moalefcmp, "mark", StockShope.StockData_TabaleName)
        mydatac.showDatabyReaderTocombobox(DarNashrCmb, "parnck", StockShope.StockData_TabaleName)



        For Each c In sanfgrp.Controls
            If TypeOf c Is t_textbox Then
                c.ReadOnly = False
                c.BackColor = c.leave_color
                c.Refresh()
            End If
        Next
        Paytxt.Visible = True



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

    Dim dataf As New TashfeenDataBaseWork.DataFilter

    Private Sub T_textbox1_pressEnter() Handles T_textbox1.pressEnter
        meCloss = True
        SaleDGV.Focus()
    End Sub
    Private Sub T_textbox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles T_textbox1.TextChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockShope.sanf.Name, T_textbox1.Text))
        GetNew()
    End Sub
    Friend Property Quima As String
    Friend Property SanfQuima As String
    Private Sub SaleDGV_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
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
    Private Sub T_button1_Click(ByVal sender As Object, ByVal e As EventArgs)
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

    Private Sub SaleDGV_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        endfrm()
    End Sub

    Private Sub SaleDGV_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
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
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockShope.Code.Name, T_textbox5.Text))
        GetNew()
    End Sub
    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        meCloss = True
        endfrm()
    End Sub

    Private Sub MainSanfCmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainSanfCmp.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockShope.main_sanf.Name, MainSanfCmp.Text))
        GetNew()
        Valuetxt.Text = MainSanfCmp.Text
    End Sub

    Private Sub Moalefcmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Moalefcmp.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockShope.mark.Name, Moalefcmp.Text))
        GetNew()
        Valuetxt.Text = Moalefcmp.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarNashrCmb.SelectedIndexChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.strings, StockShope.parnck.Name, DarNashrCmb.Text))
        GetNew()
        Valuetxt.Text = DarNashrCmb.Text
    End Sub
    Private Sub GetNew()
        If Not power Then Exit Sub
        If mydatac.RowCount < 1 Then
            NewBtn.Visible = True
        Else
            NewBtn.Visible = False
        End If
    End Sub
    Private Sub SaleDGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBtn.Click
        Dim f As New StockDataBookShopsFrm
        f.ShowDialog()
        mydatac.Load(proj.dataConPath_MyData, StockShope.StockData_TabaleName, proj.StockData_BookShope.StockDataBookShope_Fm, SaleDGV)
    End Sub

    Private Sub T_button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        mydatac.Save()
        mydatac.reLoad()
        mydatac.showDatabyReaderTocombobox(MainSanfCmp, "main_sanf", "StockDataBookShops")
        mydatac.showDatabyReaderTocombobox(Moalefcmp, "moalef", "StockDataBookShops")
        mydatac.showDatabyReaderTocombobox(DarNashrCmb, "DarNashr", "StockDataBookShops")

    End Sub

    Private Sub sanfgrp_Enter(sender As Object, e As EventArgs) Handles sanfgrp.Enter

    End Sub

    Private Sub T_button4_Click(sender As Object, e As EventArgs) Handles T_button4.Click

        mydatac.CopyPase_PastNews()

    End Sub

    Private Sub SaleDGV_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs)
        mydatac.datagrideInserted()
    End Sub

    Private Sub T_button3_Click(sender As Object, e As EventArgs)
        mydatac.Save()
    End Sub

    Private Sub T_button5_Click(sender As Object, e As EventArgs) Handles T_button5.Click
        mydatac.CopyPase_Past()
        Rename()
    End Sub

    Private Sub T_button1_Click_1(sender As Object, e As EventArgs) Handles T_button1.Click
        mydatac.CopyPase_Pastvalue(Valuetxt.Text)
        Rename()
    End Sub

    Private Sub T_button3_Click_1(sender As Object, e As EventArgs) Handles T_button3.Click
        mydatac.Load(proj.dataConPath_MyData, StockShope.StockData_TabaleName, proj.StockData_BookShope.StockDataBookShope_Fm, SaleDGV, 0)
        mydatac.showDatabyReaderTocombobox(MainSanfCmp, "main_sanf", StockShope.StockData_TabaleName)
        mydatac.showDatabyReaderTocombobox(Moalefcmp, "mark", StockShope.StockData_TabaleName)
        mydatac.showDatabyReaderTocombobox(DarNashrCmb, "parnck", StockShope.StockData_TabaleName)
        Dim main(MainSanfCmp.Items.Count), darnasf(DarNashrCmb.Items.Count) As String
        MainSanfCmp.Items.CopyTo(main, 0)
        DarNashrCmb.Items.CopyTo(darnasf, 0)

        Rename()
    End Sub
    Private Sub Rename()
        mydatac.MoveFirst()
        Dim mains, pranch, AddData, mark As String
        Dim maini, darnasri, booknamei As Integer
        For i = 0 To mydatac.RowCount
            mains = SaleDGV.CurrentRow.Cells(3).Value
            pranch = SaleDGV.CurrentRow.Cells(5).Value
            AddData = SaleDGV.CurrentRow.Cells(2).Value
            mark = SaleDGV.CurrentRow.Cells(4).Value
            SaleDGV.CurrentRow.Cells.Item(1).Value = mains + " - " + AddData + "/تاليف " + mark + " /طابعة " + pranch
            mydatac.MoveNext()

        Next
    End Sub

     
    Private Sub SetSanf()
        'Dim x As String = BookNameTxt.Text
        'Sanftxt.Text = MainSanfCmb.Text + " - " + x + "/تاليف " + MoalefCmb.Text + " /طابعة " + DarNashcmb.Text

    End Sub

    Private Sub SaleDGV_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDGV.CellContentClick
        mydatac.MoveByDataGrideView()


    End Sub

    Private Sub SaleDGV_CellEnter1(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDGV.CellEnter
        mydatac.MoveByDataGrideView()

    End Sub
End Class