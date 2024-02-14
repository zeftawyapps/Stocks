Imports ZeftawyTools
Public Class smallQfrm
    Inherits myformDesign
    Dim datacomb As New TashfeenDataBaseWork.OLEDataBaseBinding
    Friend isclient As Boolean
    Dim StockShope As New StockDataShops
    Dim proj As New projectDataBase
    Dim mydatac As New OLEdatabaseCodeing
    Private Sub SanfQfrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet1.mainSanftable' table. You can move, or remove it, as needed.
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)

        If snf Then

            grpDestnations(sanfgrp)
            T_textbox5.Focus()
            'datacomb.showDatabyReaderTocombobox(ComboBox1, "main_sanf", "StockDataTable", StockDataTableTableAdapter.Connection)
            proj.LoadSimplQuery_StockDatsShope()
            proj.StockData_Shope.Code.Control = T_textbox6
            proj.StockData_Shope.Code.visable = True

            proj.StockData_Shope.sanf.Control = T_textbox2
            proj.StockData_Shope.sanf.visable = True


            proj.StockData_Shope.ParchasePrice.Control = Paytxt
            proj.StockData_Shope.ParchasePrice.visable = True
            proj.StockData_Shope.jom_price.Control = Jomtxt
            proj.StockData_Shope.jom_price.visable = True
            proj.StockData_Shope.qut_price.Control = Quttxt
            proj.StockData_Shope.qut_price.visable = True

            StockShope.load()
            proj.StockData_Shope.StockDataShope_Fm = {proj.StockData_Shope.Code, proj.StockData_Shope.sanf, proj.StockData_Shope.AdditionalData _
                                                             , proj.StockData_Shope.ParchasePrice, proj.StockData_Shope.jom_price, proj.StockData_Shope.qut_price}
            StockShope.StockDataShope_Fm = proj.StockData_Shope.StockDataShope_Fm
            mydatac.Load(proj.dataConPath_MyData, "StockDataTableShops", proj.StockData_Shope.StockDataShope_Fm, SaleDGV, 50)
            mydatac.showDatabyReaderTocombobox(MainSanfCmp, "main_sanf", "StockDataTableShops")
            mydatac.showDatabyReaderTocombobox(Moalefcmp, "mark", "StockDataTableShops")

            mydatac.showDatabyReaderTocombobox(Moalefcmp, "parnck", "StockDataTableShops")

        Else
            If isclient Then
                ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Client)
            Else
                ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Moarid)

            End If
            dataf.Bindingsource = ClientTableBindingSource
            grpDestnations(clentgrp)
            T_textbox3.Focus()
        End If
    End Sub
    Friend snf As Boolean = True
    Private meCloss As Boolean
    Private Sub grpDestnations(g As GroupBox)
        If snf Then
            g.Visible = True
            g.Top = 43
            g.Left = 10
            g.Width = 817
            g.Height = 373
            Me.Width = 853
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

    Private Sub T_textbox1_pressEnter()
        meCloss = True
        SaleDGV.Focus()
    End Sub
    Private Sub T_textbox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        dataf.filteration("sanf", T_textbox1.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)
    End Sub
    Friend Property Quima As String
    Friend Property SanfQuima As String
    Private Sub endfrm()
        If meCloss Then
            Me.Close()
        Else

            If snf Then
                Quima = T_textbox6.Text
                SanfQuima = T_textbox2.Text
            Else
                Quima = T_textbox4.Text
            End If
            Me.Close()
        End If
    End Sub
    Private Sub T_button1_Click(sender As Object, e As EventArgs) Handles T_button1.Click
        endfrm()
    End Sub
    Dim cellenter As Boolean

    Private Sub T_textbox3_TextChanged(sender As Object, e As EventArgs) Handles T_textbox3.TextChanged
        dataf.filteration("ClientNmae", T_textbox3.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)

    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        endfrm()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
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
 
    Private Sub T_textbox5_pressEnter()

        SaleDGV.Focus()
    End Sub

    Private Sub T_textbox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dataf.filteration("Code", T_textbox5.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)

    End Sub
    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        meCloss = True
        endfrm()
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Dim f As New CleintData
        f.isclient = Me.isclient
        f.ShowDialog()

        If isclient Then
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Client)
        Else
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Moarid)

        End If
        f.Close()
    End Sub

    Private Sub SaleDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDGV.CellContentClick

    End Sub

    Private Sub SaleDGV_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDGV.CellContentDoubleClick
        endfrm()
    End Sub

    Private Sub SaleDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDGV.CellEnter
        mydatac.MoveByDataGrideView()
    End Sub

    Private Sub SaleDGV_KeyDown1(sender As Object, e As KeyEventArgs) Handles SaleDGV.KeyDown
        If e.KeyCode = Keys.Enter Then
            endfrm()
        End If
    End Sub

    Private Sub T_textbox5_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox5.TextChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockShope.Code.Name, T_textbox5.Text))

    End Sub

    Private Sub T_textbox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged
        mydatac.DataFilter(mydatac.FeildWhere(feildtyp.simistring, StockShope.sanf.Name, T_textbox1.Text))

    End Sub
End Class