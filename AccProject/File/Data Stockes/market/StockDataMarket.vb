Imports ZeftawyTools
Public Class StockDataMarket
    Inherits myformDesign
    Private Dataconpath = "mydata.mdb"
    Private StockDataTable = "StockDataTable"
    Private stockMoveTable = "SalePayMovement"
    Dim Datac As New projectDataBase
    Dim mydatac, mydatac2 As New OLEdatabaseCodeing
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(GroupBox1, T_textbox.textColor)

        LoadStockData()
        DataPostionCode1.DataCode = mydatac
        DataPostionCode1.GetT_buttonColor(T_button)
        StockMoveBBSearch()
    End Sub


    Friend Sub LoadStockData()
        'بيانات الجدول
        Dim stock As New StockDataShops
        Dim ser = New FieldMombers With {.Name = "ser"}
        Dim sanf = New FieldMombers With {.Name = "sanf", .Control = Sanftxt, .visable = True}
        Dim Code = New FieldMombers With {.Name = "Code", .Control = Codetxt, .visable = True}
        Dim ParchasePrice = New FieldMombers With {.Name = "ParchasePrice", .Control = Paypricetxt, .visable = True}
        Dim jom_price = New FieldMombers With {.Name = "jom_price", .Control = Jomlatxt, .visable = True}
        Dim qut_price = New FieldMombers With {.Name = "qut_price", .Control = QutTxt, .visable = True}

        Dim StockDataField As FieldMombers() = {sanf, Code, ParchasePrice, jom_price, _
         qut_price, ser}
        mydatac.isFeildShow = True
        mydatac.Load(Dataconpath, StockDataTable, StockDataField)

        ' لادخال رصيد اول المدة 
        Dim moveSer = New FieldMombers With {.Name = "ser", .Caption = "ASDF"}
        Dim m_sandf = New FieldMombers With {.Name = "sandf", .Caption = "ASDF", .Control = Sanftxt}
        Dim FatoraNo = New FieldMombers With {.Name = "FatoraNo", .value = "BB"}
        Dim m_code = New FieldMombers With {.Name = "code", .Control = Codetxt}
        Dim m_QBB = New FieldMombers With {.Name = "QBB", .Control = BBQTxt, .visable = True}
        Dim PBB = New FieldMombers With {.Name = "PBB", .Control = Paypricetxt, .visable = False}
        Dim qpbb = New FieldMombers With {.Name = "QPbb", .Control = QPBBTxt, .visable = True}
        Dim cashc = New FieldMombers With {.Name = "CashCr", .value = "رصيد اول المدة"}
        Dim trDate As New FieldMombers With {.Name = "DataTr", .value = Now.Date}

        Dim StockMove As FieldMombers() = {m_sandf, FatoraNo, m_code, m_QBB, PBB, qpbb, cashc, trDate, moveSer}

        mydatac2.isFeildShow = True
        mydatac2.Load(Dataconpath, stockMoveTable, StockMove)

    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        mydatac.AddNew()
        mydatac2.AddNew()
        Codetxt.Focus()
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        'On Error Resume Next
        Saveing()
    End Sub
    Private Sub Saveing()
        If mydatac2.RowCount = 0 Then
            mydatac2.Isinserted = True
        End If
        mydatac.Save(False)
        mydatac2.Save(False)
        mydatac.reLoad()
        mydatac2.reLoad()
        StockMoveBBSearch()
        msgbox("تم الحفظ")
    End Sub
    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        mydatac.Delete()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        mydatac2.datagrideInserted()

    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        mydatac2.datagrideDeleted()

    End Sub


    Private Sub DataPostionCode1_movefirst() Handles DataPostionCode1.movefirst
        StockMoveBBSearch()
    End Sub

    Private Sub DataPostionCode1_movelast() Handles DataPostionCode1.movelast
        StockMoveBBSearch()
    End Sub
    Private Sub StockMoveBBSearch()
        mydatac2.DataFilter(mydatac2.FildsName(2) + " ='" + Codetxt.Text + "'  And " + mydatac2.FildsName(1) + "= 'BB'")

    End Sub
    Private Sub DataPostionCode1_movenext() Handles DataPostionCode1.movenext
        StockMoveBBSearch()
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mydatac.DataFilter(mydatac.FildsName(1) + "  like '%" + Codetxt.Text + "%'")
    End Sub

    Private Sub SearchTxt_pressEnter() Handles SearchTxt.pressEnter
        mydatac2.DataFilter(mydatac2.FildsName(2) + " like '%" + SearchTxt.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  like '%" + SearchTxt.Text + "%'")

    End Sub


    Private Sub T_button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        mydatac2.DataFilter(mydatac2.FildsName(2) + " like '%" + SearchTxt.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  like '%" + SearchTxt.Text + "%'")

    End Sub

    Private Sub DataPostionCode1_movepreveus() Handles DataPostionCode1.movepreveus
        StockMoveBBSearch()
    End Sub

    Private Sub BBQTxt_pressEnter() Handles BBQTxt.pressEnter
        Saveing()
    End Sub

    Private Sub BBQTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBQTxt.TextChanged

        On Error Resume Next
        Dim x As Single = CSng(BBQTxt.Text)
        Dim y As Single = CSng(Paypricetxt.Text)
        Dim z As Single = x * y
        QPBBTxt.Text = z.ToString

    End Sub



    Private Sub DataGridView1_UserAddedRow1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        mydatac.datagrideInserted()
    End Sub

    Private Sub Codetxt_pressEnter() Handles Codetxt.pressEnter
        Sanftxt.Focus()
    End Sub

    Private Sub Codetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codetxt.TextChanged

    End Sub

    Private Sub Sanftxt_pressEnter() Handles Sanftxt.pressEnter
        Paypricetxt.Focus()
    End Sub

    Private Sub Sanftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sanftxt.TextChanged

    End Sub

    Private Sub Paypricetxt_pressEnter() Handles Paypricetxt.pressEnter
        Jomlatxt.Focus()
    End Sub

    Private Sub Paypricetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paypricetxt.TextChanged

    End Sub

    Private Sub Jomlatxt_pressEnter() Handles Jomlatxt.pressEnter
        QutTxt.Focus()
    End Sub

    Private Sub Jomlatxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jomlatxt.TextChanged

    End Sub

    Private Sub QutTxt_pressEnter() Handles QutTxt.pressEnter
        BBQTxt.Focus()
    End Sub

    Private Sub QutTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QutTxt.TextChanged

    End Sub
End Class