Imports ZeftawyTools
Public Class StockDataBookShopsFrm
    Inherits myformDesign
    Private Dataconpath = "mydata.mdb"
    Private StockDataTable = "StockDataBookShops"

    Private DataconPathMove = "Movement.mdb"
    Private stockMoveTable = "SalePayMovement"
    Dim Datac As New projectDataBase
    Dim mydatac, mydatac2, mydataCode As New OLEdatabaseCodeing
    Dim codemainSanf, codeProduct, codeDarNashr As String
    Dim main, maol, darnsh As String
    Dim bookArry As New AutoCompleteStringCollection
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(GroupBox1, T_textbox.textColor)

        LoadStockData()

        DataPostionCode1.DataCode = mydatac
        DataPostionCode1.GetT_buttonColor(T_button)
        StockMoveBBSearch()


    End Sub

    Private Sub setCode()
        If Codetxt.Text = "" Then
            Codetxt.Text = codemainSanf + codeProduct + codeDarNashr
        End If
    End Sub
    Friend Sub GetSer()
        On Error Resume Next
        Dim r As Integer
        Dim s As String
        Dim o() As Object
        Dim ser = New FieldMombers With {.Name = "ser", .iskey = True}
        Dim StockDataField As FieldMombers() = {ser}
        mydataCode.Load(Dataconpath, StockDataTable, StockDataField)
        o = mydataCode.showDatabyReaderToArray(ser.Name, StockDataTable)
        Array.Sort(o)

        r = mydataCode.MoveLast
        s = o(r)
        codeProduct = Format(CInt(s + 1), "0000")

    End Sub
  
    Friend Sub LoadStockData()
        'بيانات الجدول
        Dim stock As New StockDataBookShopsFrm
        Dim ser = New FieldMombers With {.Name = "ser", .iskey = True}
        Dim sanf = New FieldMombers With {.Name = "sanf", .Control = Sanftxt, .visable = True}
        Dim Code = New FieldMombers With {.Name = "Code", .Control = Codetxt, .visable = True}
        Dim main_sanf = New FieldMombers With {.Name = "main_sanf", .Control = MainSanfCmb, .visable = True}
        Dim moalef = New FieldMombers With {.Name = "moalef", .Control = MoalefCmb, .visable = True}
        Dim DarNashr = New FieldMombers With {.Name = "DarNashr", .Control = DarNashcmb, .visable = True}
        Dim bookName = New FieldMombers With {.Name = "BookName", .Control = BookNameTxt, .visable = True}

        Dim ParchasePrice = New FieldMombers With {.Name = "ParchasePrice", .Control = Paypricetxt, .visable = True}
        Dim jom_price = New FieldMombers With {.Name = "jom_price", .Control = Jomlatxt, .visable = True}
        Dim qut_price = New FieldMombers With {.Name = "qut_price", .Control = QutTxt, .visable = True}
        Dim AtLeast = New FieldMombers With {.Name = "AtLeast", .Control = AtLeadt, .visable = True}
        Dim isLow = New FieldMombers With {.Name = "isLow"}
        Dim StockDataField As FieldMombers() = {sanf, Code, ParchasePrice, main_sanf, moalef, DarNashr, bookName, jom_price, _
         qut_price, AtLeast, ser}

        mydatac.isFeildShow = True
        mydatac.Load(Dataconpath, StockDataTable, StockDataField)

        mydatac.showDatabyReaderTocombobox(MainSanfCmb, main_sanf.Name, StockDataTable)
        mydatac.showDatabyReaderTocombobox(MoalefCmb, moalef.Name, StockDataTable)
        mydatac.showDatabyReaderTocombobox(DarNashcmb, DarNashr.Name, StockDataTable)
        bookArry.AddRange(mydatac.showDatabyReaderTolist(bookName.Name, StockDataTable).ToArray)

        ' لادخال رصيد اول المدة 
        Dim moveSer = New FieldMombers With {.Name = "ser", .Caption = "ASDF", .iskey = True}
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
        mydatac2.Load(DataconPathMove, stockMoveTable, StockMove)
        GetSer()
        BookNameTxt.AutoCompleteCustomSource = bookArry
        BookNameTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        BookNameTxt.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub BeforAddnew()
        If MainSanfchekbox.Checked Then
            main = MainSanfCmb.Text
        Else
            main = ""
        End If
        If moalefCheckbox.Checked Then
            maol = MoalefCmb.Text
        Else
            maol = ""
        End If

        If Darnasherchekbox.Checked Then
            darnsh = DarNashcmb.Text
        Else
            darnsh = ""

        End If
    End Sub
    Private Sub AfterSave()
        If MainSanfchekbox.Checked Or moalefCheckbox.Checked Or Darnasherchekbox.Checked Then
            mydatac.MoveLast()
        End If

    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        BeforAddnew()
        mydatac.AddNew()
        mydatac2.AddNew()
        MainSanfCmb.Text = main
        MoalefCmb.Text = maol
        DarNashcmb.Text = darnsh
        AtLeadt.Text = Contorlpanal.At_Least_Q
        MainSanfCmb.Focus()
    End Sub
    Private Sub SetTxt_Zero(ByVal t As t_textbox)
        If t.Text = "" Then
            t.Text = 0
        End If
    End Sub
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        'On Error Resume Next
        SetSanf()
        setCode()
        SetTxt_Zero(Paypricetxt)
        SetTxt_Zero(Jomlatxt)
        SetTxt_Zero(QutTxt)
        SetTxt_Zero(BBQTxt)

        Saveing()
        AfterSave()
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
        LoadStockData()
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
        mydatac2.DataFilter(mydatac2.FildsName(2) + " = '" + SearchTxt.Text + "'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  = '" + SearchTxt.Text + "'")

    End Sub


    Private Sub T_button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        mydatac2.DataFilter(mydatac2.FildsName(2) + " like '%" + SearchTxt.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  like '" + SearchTxt.Text + "%'")

    End Sub

    Private Sub DataPostionCode1_movepreveus() Handles DataPostionCode1.movepreveus
        StockMoveBBSearch()
    End Sub

    Private Sub BBQTxt_pressEnter() Handles BBQTxt.pressEnter
        Saveing()
    End Sub

    Private Sub BBQTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBQTxt.TextChanged

        On Error Resume Next
        Dim x As Single = CSng(BBQTxt.MeText)
        Dim y As Single = CSng(Paypricetxt.MeText)
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

    Private Sub SetSanf()
        Dim x As String = BookNameTxt.Text
        Sanftxt.Text = MainSanfCmb.Text + " - " + x + "/تاليف " + MoalefCmb.Text + " /طابعة " + DarNashcmb.Text

    End Sub
    Private Sub Sanftxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sanftxt.Leave
        SetSanf()
    End Sub

    Private Sub Sanftxt_pressEnter() Handles Sanftxt.pressEnter
        Paypricetxt.Focus()
    End Sub

    Private Sub Sanftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sanftxt.TextChanged

    End Sub

    Private Sub Paypricetxt_pressEnter() Handles Paypricetxt.pressEnter
        Jomlatxt.Focus()
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

    Private Sub DataPostionCode1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPostionCode1.Load

    End Sub

    Private Sub MainSanfCmb_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainSanfCmb.Enter
        MainSanfCmb.BackColor = Color.Aquamarine
    End Sub

    Private Sub MainSanfCmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MainSanfCmb.KeyDown
        If e.KeyCode = Keys.Enter Then

            codemainSanf = Format(MainSanfCmb.SelectedIndex, "000")

        End If
    End Sub

    Private Sub MainSanfCmb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainSanfCmb.Leave
        MainSanfCmb.BackColor = Color.White
    End Sub

    Private Sub MainSanfCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainSanfCmb.SelectedIndexChanged



        codemainSanf = Format(MainSanfCmb.SelectedIndex, "000")

    End Sub

    Private Sub MoalefCmb_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoalefCmb.Enter
        MoalefCmb.BackColor = Color.Aquamarine
    End Sub

    Private Sub MoalefCmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MoalefCmb.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub MoalefCmb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoalefCmb.Leave
        MoalefCmb.BackColor = Color.White
    End Sub

    Private Sub MoalefCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoalefCmb.SelectedIndexChanged

    End Sub

    Private Sub DarNashcmb_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DarNashcmb.Enter
        DarNashcmb.BackColor = Color.Aquamarine
    End Sub

    Private Sub DarNashcmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DarNashcmb.KeyDown
        If e.KeyCode = Keys.Enter Then

            codeDarNashr = Format(DarNashcmb.SelectedIndex, "000")

        End If
    End Sub

    Private Sub DarNashcmb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DarNashcmb.Leave
        DarNashcmb.BackColor = Color.White
        Paypricetxt.Focus()
    End Sub

    Private Sub DarNashcmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarNashcmb.SelectedIndexChanged

        codeDarNashr = Format(DarNashcmb.SelectedIndex, "000")

    End Sub

    Private Sub BookNameTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BookNameTxt.KeyDown

    End Sub

    Private Sub BookNameTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookNameTxt.Leave
        SetSanf()
    End Sub

    Private Sub BookNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookNameTxt.TextChanged


    End Sub

    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button5.Click
        mydatac2.DataFilter(" sandf like '%" + SearchTxt.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + SearchTxt.Text + "%'")

    End Sub

    Private Sub mainSanftxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        codemainSanf = Format(MainSanfCmb.Items.Count + 1, "000")
        'If e.KeyCode = Keys.F1 Then
        '    MainSanfCmb.Focus()
        'End If
    End Sub

    Private Sub mainSanftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DarNashrTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        codeDarNashr = Format(DarNashcmb.Items.Count + 1, "000")

    End Sub

    Private Sub DarNashrTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Paypricetxt.Focus()
    End Sub

    Private Sub DarNashrTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub T_button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button6.Click
        mydatac2.DataFilter(" sandf like '%" + MainSanfCmb.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + MainSanfCmb.Text + "%'")

    End Sub

    Private Sub T_button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button7.Click
        mydatac2.DataFilter(" sandf like '%" + MoalefCmb.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + MoalefCmb.Text + "%'")

    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button8.Click
        mydatac2.DataFilter(" sandf like '%" + DarNashcmb.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + DarNashcmb.Text + "%'")

    End Sub

    Private Sub moalftxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.F1 Then
        '    MoalefCmb.Focus()
        'End If
    End Sub

    Private Sub moalftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub T_button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button9.Click
        Dim f As New AoutoEnterStockDataBookShopefrm

        f.power = True
        f.Show()

    End Sub

    Private Sub T_button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button10.Click
        mydatac2.DataFilter(" sandf like '%" + BookNameTxt.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + BookNameTxt.Text + "%'")

    End Sub

    Private Sub T_button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainSanfchekbox.Click
        If MainSanfchekbox.Checked Then
            main = MainSanfCmb.Text
        Else
            main = ""
        End If
    End Sub



    Private Sub moalefCheckbox_Click(sender As Object, e As EventArgs) Handles moalefCheckbox.Click
        If moalefCheckbox.Checked Then
            maol = MoalefCmb.Text
        Else
            maol = ""
        End If

    End Sub

    Private Sub Darnasherchekbox_Click(sender As Object, e As EventArgs) Handles Darnasherchekbox.Click

        If Darnasherchekbox.Checked Then
            darnsh = DarNashcmb.Text
        Else
            darnsh = ""

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTxt.TextChanged

    End Sub
End Class