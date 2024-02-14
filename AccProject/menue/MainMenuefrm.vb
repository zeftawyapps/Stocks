Imports ZeftawyTools
Public Class MainMenuefrm
    Inherits myformDesign
    Private Sub MainMenuefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopleft)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)

    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        Select Case Contorlpanal.StockType
            Case StockType.BookShop
                Dim stock As New StockDataBookShopsFrm
                stock.Show()
            Case StockType.Casher
                Dim stock As New StockDataShopeingfr
                stock.Show()
            Case StockType.Shope
                Dim stock As New StockDataShopeingfr
                stock.Show()
        End Select

    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fr As New StockMove
        fr.Show()
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Dim fr As New StockMove
        fr.isLoading = False
        fr.Show()
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        Dim fr As New MarketBalanceFrm
        fr.Show()
    End Sub

    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        Startfrm.ApplicationExit()
    End Sub

    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button5.Click
        Dim fr As New ExpRevFrm
        fr.Show()
    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button8.Click
        Dim fr As New CleintData
        fr.isclient = True
        fr.Show()
    End Sub

    
    

   
    Private Sub T_button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button10.Click
        Dim fr As New ClientBalanceFrm
        fr.ISClitnAndsup = True
        fr.isClint = True
        fr.Show()
    End Sub

    Private Sub T_button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button11.Click
        Dim fr As New ClientBalanceFrm
        fr.ISClitnAndsup = True
        fr.isClint = False
        fr.Show()
    End Sub
    Private Sub load(ByVal grp As GroupBox)
        For Each c As Control In Me.Controls
            If TypeOf c Is GroupBox Then
                c.Visible = False
            End If
            grp.Left = 382
            grp.Top = 127
            grp.Visible = True
        Next
    End Sub
    Private Sub T_button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button14.Click
        load(filegrp)
    End Sub

    Private Sub T_button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button13.Click
        load(Movegrp)
    End Sub

    Private Sub T_button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button12.Click
        load(repgrp)
    End Sub

    Private Sub T_button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button7.Click
        Dim fr As New ClientSupplierAccfrm
        fr.isBB = True
        fr.Show()
    End Sub

    Private Sub T_button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button6.Click
        Dim fr As New ClientSupplierAccfrm
        fr.isBB = False
        fr.Show()
    End Sub

    Private Sub T_button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button9.Click
        Dim fr As New CleintData
        fr.isclient = False
        fr.Show()
    End Sub

    Private Sub T_button1_Click_1(sender As Object, e As EventArgs) Handles T_button1.Click
        Dim fr As New CashFlowQfrm
        fr.Show()
    End Sub

    Private Sub T_button15_Click(sender As Object, e As EventArgs) Handles T_button15.Click
        Dim tb As New TrailBalanceFrm
        tb.Show()
    End Sub
End Class