Imports ZeftawyTools

Public Class StockDataShopeingfr
    Inherits myformDesign
    Private Dataconpath = "mydata.mdb"
    Private StockDataTable = "StockDataTableShops"

    Private DataconPathMove = "Movement.mdb"
    Private stockMoveTable = "SalePayMovement"
    Dim Datac As New projectDataBase
    Dim mydatac, mydatac2, mydataCode As New OLEdatabaseCodeing
    Dim codemainSanf, codeProduct, codeDarNashr As String
    Dim main, maol, darnsh As String
    Dim myproj As New myProjectWork
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(GroupBox1, T_textbox.textColor)
        loadme()
      
    End Sub

    Private Sub setCode()
        If Codetxt.Text = "" Then
            Codetxt.Text = codemainSanf + codeProduct + codeDarNashr
        End If
    End Sub
    Private Sub loadme()
         
        LoadStockData()

        DataPostionCode1.DataCode = mydatac
        DataPostionCode1.GetT_buttonColor(T_button)
        StockMoveBBSearch()
        major_un_Changes()
        unMajlbl.BackColor = Color.DarkRed
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
        Dim mark = New FieldMombers With {.Name = "mark", .Control = markcmb, .visable = True}
        Dim parnck = New FieldMombers With {.Name = "parnck", .Control = pranch, .visable = True}
        Dim AdditionalData = New FieldMombers With {.Name = "AdditionalData", .Control = BookNameTxt, .visable = True}
       Dim ParchasePrice = New FieldMombers With {.Name = "ParchasePrice", .Control = Paypricetxt, .visable = True}
        Dim jom_price = New FieldMombers With {.Name = "jom_price", .Control = Jomlatxt, .visable = True}
        Dim qut_price = New FieldMombers With {.Name = "qut_price", .Control = QutTxt, .visable = True}
        Dim AtLeast = New FieldMombers With {.Name = "AtLeast", .Control = AtLeadt, .visable = True}
        Dim isLow = New FieldMombers With {.Name = "isLow"}
        Dim major_unit As New FieldMombers With {.Name = "major_unit", .Control = uncode, .visable = True}
        Dim Balances = New FieldMombers With {.Name = "Balance", .Control = Balancetxt, .visable = True}

        Dim StockDataField As FieldMombers() = {sanf, Code, ParchasePrice, main_sanf, mark, parnck, AdditionalData, jom_price, _
         qut_price, AtLeast, major_unit, Balances, ser}

        mydatac.isFeildShow = True
        mydatac.Load(Dataconpath, StockDataTable, StockDataField)

        mydatac.showDatabyReaderTocombobox(MainSanfCmb, main_sanf.Name, StockDataTable)
        mydatac.showDatabyReaderTocombobox(markcmb, mark.Name, StockDataTable)
        mydatac.showDatabyReaderTocombobox(pranch, parnck.Name, StockDataTable)

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

    End Sub
    Private Sub BeforAddnew()
        If MainSanfchekbox.Checked Then
            main = MainSanfCmb.Text
        Else
            main = ""
        End If
        If moalefCheckbox.Checked Then
            maol = markcmb.Text
        Else
            maol = ""
        End If

        If Darnasherchekbox.Checked Then
            darnsh = pranch.Text
        Else
            darnsh = ""

        End If
    End Sub
    Private Sub AfterSave()
        If MainSanfchekbox.Checked Or moalefCheckbox.Checked Or Darnasherchekbox.Checked Then

            mydatac.MoveLast()
        Else

            mydatac.MoveFirst()
            major_un_Changes()
        End If

    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        BeforAddnew()
        mydatac.AddNew()
        mydatac2.AddNew()
        MainSanfCmb.Text = main
        markcmb.Text = maol
        pranch.Text = darnsh
        AtLeadt.Text = Contorlpanal.At_Least_Q
        MajorCmb.SelectedIndex = 0
        uncode.Text = 0
        Balancetxt.Text = 1
        Codetxt.Focus()
    End Sub
    Private Sub SetTxt_Zero(ByVal t As t_textbox)
        If Not IsNumeric(t.Text) Then
            t.Text = 0
        End If
    End Sub
    Private Sub beforSave()
        If unMajlbl.check Then Exit Sub
        unMajlbl.check = True
        Paypricetxt.Text = myproj.calculatMajor(unMajor, Paypricetxt.Text, unMajlbl, Balancetxt.Text, True)
        BBQTxt.Text = myproj.calculatMajor(unMajor, BBQTxt.Text, unMajlbl, Balancetxt.Text)
        Jomlatxt.Text = myproj.calculatMajor(unMajor, Jomlatxt.Text, unMajlbl, Balancetxt.Text, True)
        QutTxt.Text = myproj.calculatMajor(unMajor, QutTxt.Text, unMajlbl, Balancetxt.Text, True)
        AtLeadt.Text = myproj.calculatMajor(unMajor, AtLeadt.Text, unMajlbl, Balancetxt.Text)

    End Sub
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        'On Error Resume Next
        SetSanf()
        setCode()
        SetTxt_Zero(Paypricetxt)
        SetTxt_Zero(Jomlatxt)
        SetTxt_Zero(QutTxt)
        SetTxt_Zero(BBQTxt)
        beforSave()
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


        LoadStockData()
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

    Private Sub DataPostionCode1_Move(sender As Object, e As EventArgs) Handles DataPostionCode1.Move

    End Sub


    Private Sub DataPostionCode1_movefirst() Handles DataPostionCode1.movefirst
        StockMoveBBSearch()
        major_un_Changes()
    End Sub

    Private Sub DataPostionCode1_movelast() Handles DataPostionCode1.movelast
        StockMoveBBSearch()
        major_un_Changes()
    End Sub
    Private Sub StockMoveBBSearch()
        mydatac2.DataFilter(mydatac2.FildsName(2) + " ='" + Codetxt.Text + "'  And " + mydatac2.FildsName(1) + "= 'BB'")

    End Sub
    Private Sub DataPostionCode1_movenext() Handles DataPostionCode1.movenext
        StockMoveBBSearch()
        major_un_Changes()
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mydatac.DataFilter(mydatac.FildsName(1) + "  like '%" + Codetxt.Text + "%'")
    End Sub

    Private Sub SearchTxt_pressEnter() Handles SearchTxt.pressEnter
        mydatac2.DataFilter(mydatac2.FildsName(2) + " = '" + SearchTxt.Text + "'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  = '" + SearchTxt.Text + "'")
        uncodwork()
    End Sub


    Private Sub T_button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        mydatac2.DataFilter(mydatac2.FildsName(2) + " = '" + SearchTxt.Text + "'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(mydatac.FildsName(1) + "  = '" + SearchTxt.Text + "'")
        uncodwork() ' لحساب وحدات القياس 
    End Sub

    Private Sub DataPostionCode1_movepreveus() Handles DataPostionCode1.movepreveus
        StockMoveBBSearch()
        major_un_Changes()
    End Sub

    Private Sub BBQTxt_Leave(sender As Object, e As EventArgs) Handles BBQTxt.Leave
        'QPBBTxt.Text = un_major_enter_value(BBQTxt.Text)
    End Sub
    

    Private Function un_major_enter_value(s As String, Optional op As Boolean = False, Optional chec As Boolean = True) As String

        If check_un Then
            val_un_major = myproj.UnitedQ(unMajor, s, op)
        Else
            val_un_major = s
        End If
        Return val_un_major
    End Function
     

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
        MainSanfCmb.Focus()
    End Sub

    Private Sub Codetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codetxt.TextChanged

    End Sub

    Private Sub SetSanf()
        Dim x As String = BookNameTxt.Text
        Sanftxt.Text = MainSanfCmb.Text + " - " + x + "/ماركه " + markcmb.Text + " / فرع " + pranch.Text

    End Sub
    Private Sub Sanftxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sanftxt.Leave
        SetSanf()
    End Sub

    Private Sub Sanftxt_pressEnter() Handles Sanftxt.pressEnter
        Paypricetxt.Focus()
    End Sub

    Private Sub Sanftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sanftxt.TextChanged

    End Sub

    Private Sub Paypricetxt_Leave(sender As Object, e As EventArgs) Handles Paypricetxt.Leave
        'Paypricetxt.Text = un_major_enter_value(Paypricetxt.Text)
    End Sub

    Private Sub Paypricetxt_pressEnter() Handles Paypricetxt.pressEnter
        Jomlatxt.Focus()
    End Sub

    Private Sub Jomlatxt_Layout(sender As Object, e As LayoutEventArgs) Handles Jomlatxt.Layout

    End Sub

    Private Sub Jomlatxt_Leave(sender As Object, e As EventArgs) Handles Jomlatxt.Leave
        'Jomlatxt.Text = un_major_enter_value(Jomlatxt.Text)
    End Sub




    Private Sub Jomlatxt_pressEnter() Handles Jomlatxt.pressEnter
        QutTxt.Focus()
    End Sub

    Private Sub Jomlatxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jomlatxt.TextChanged

    End Sub

    Private Sub QutTxt_Leave(sender As Object, e As EventArgs) Handles QutTxt.Leave
        'QutTxt.Text = un_major_enter_value(QutTxt.Text)
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

    Private Sub MoalefCmb_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles markcmb.Enter
        markcmb.BackColor = Color.Aquamarine
    End Sub

    Private Sub MoalefCmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles markcmb.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub MoalefCmb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles markcmb.Leave
        markcmb.BackColor = Color.White
    End Sub
 

    Private Sub DarNashcmb_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pranch.Enter
        pranch.BackColor = Color.Aquamarine
    End Sub

    Private Sub DarNashcmb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pranch.KeyDown
        If e.KeyCode = Keys.Enter Then

            codeDarNashr = Format(pranch.SelectedIndex, "000")

        End If
    End Sub

    Private Sub DarNashcmb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pranch.Leave
        pranch.BackColor = Color.White

    End Sub

    Private Sub DarNashcmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pranch.SelectedIndexChanged

        codeDarNashr = Format(pranch.SelectedIndex, "000")

    End Sub

    Private Sub BookNameTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BookNameTxt.KeyDown

    End Sub

    Private Sub BookNameTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookNameTxt.Leave
        Paypricetxt.Focus()
        SetSanf()
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
        codeDarNashr = Format(pranch.Items.Count + 1, "000")

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
        mydatac2.DataFilter(" sandf like '%" + markcmb.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + markcmb.Text + "%'")

    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button8.Click
        mydatac2.DataFilter(" sandf like '%" + pranch.Text + "%'  And " + mydatac2.FildsName(1) + "= 'BB'")
        mydatac.DataFilter(" sanf like '%" + pranch.Text + "%'")

    End Sub

    Private Sub moalftxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.F1 Then
        '    MoalefCmb.Focus()
        'End If
    End Sub

    Private Sub moalftxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub T_button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button9.Click
        Dim f As New AoutoEnterStockDataShopefrm

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
            maol = markcmb.Text
        Else
            maol = ""
        End If

    End Sub

    Private Sub Darnasherchekbox_Click(sender As Object, e As EventArgs) Handles Darnasherchekbox.Click

        If Darnasherchekbox.Checked Then
            darnsh = pranch.Text
        Else
            darnsh = ""

        End If
    End Sub
    Dim unMajor As Unet_major
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MajorCmb.SelectedIndexChanged
        unet_Choosed()

    End Sub
    Private Sub unet_Choosed()
        Select Case MajorCmb.SelectedIndex
            Case 0
                unMajor = Unet_major.unit
                unMajlbl.ischeck = False
                unMajlbl.checkText = "الادخال  قطعة قطعة"
                unMajlbl.nocheckText = "الادخال  قطعة قطعة"
                unMajlbl.Text = "الادخال  قطعة قطعة"
                helplbl.Text = "وحده الفياس بالقطعه الواحد"
                Balancetxt.Text = 1
                Balancelbl.Visible = False
                Balancetxt.Visible = False
            Case 1
                unMajor = Unet_major.dasta
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال بالقطعة"
                unMajlbl.nocheckText = "الادخال الدسته"
                unMajlbl.Text = "الادخال بالقطعة"
                If Not IsNumeric(Balancetxt.Text) Then
                    Balancetxt.Text = 12
                End If

                helplbl.Text = "  الفياس بالقطعه الواحد الدسته على حسب القطع الموجودة في الكرتونة   "
                Balancelbl.Visible = True
                Balancetxt.Visible = True
            Case 2
                unMajor = Unet_major.kg
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال جم"
                unMajlbl.nocheckText = "الادخال بالكجم"
                unMajlbl.Text = "الادخال جم"
                helplbl.Text = "وحده الفياس بالجرام الواحد  الكيلو =1000 جم"
                Balancetxt.Text = 1000
                Balancelbl.Visible = False
                Balancetxt.Visible = False
            Case 3
                unMajor = Unet_major.leter
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال سنتلتر"
                unMajlbl.nocheckText = "الادخال لتر"
                unMajlbl.Text = "الادخال سنتلتر"
                helplbl.Text = "وحده الفياس بالسنتلر الواحد اللتر =1000 سل"
                Balancetxt.Text = 1000
                Balancelbl.Visible = False
                Balancetxt.Visible = False
        End Select
        unMajlbl.check = True
        check_un = unMajlbl.check
        uncode.Text = MajorCmb.SelectedIndex

    End Sub
    Dim val_un_major As Object
    Private Function calculatMajor(s As String) As String

        If unMajlbl.check Then
            Return myproj.UnitedQ(unMajor, s, True)
        Else
            Return myproj.UnitedQ(unMajor, s)
        End If
    End Function
    Dim check_un As Boolean

    Private Sub unMajlbl_cheked() Handles unMajlbl.cheked
      
    End Sub
    Private Sub unMajlbl_Click(sender As Object, e As EventArgs) Handles unMajlbl.Click
        'On Error Resume Next
        check_un = unMajlbl.check

        Paypricetxt.Text = myproj.calculatMajor(unMajor, Paypricetxt.Text, unMajlbl, Balancetxt.Text, True)
        BBQTxt.Text = myproj.calculatMajor(unMajor, BBQTxt.Text, unMajlbl, Balancetxt.Text)
        Jomlatxt.Text = myproj.calculatMajor(unMajor, Jomlatxt.Text, unMajlbl, Balancetxt.Text, True)
        QutTxt.Text = myproj.calculatMajor(unMajor, QutTxt.Text, unMajlbl, Balancetxt.Text, True)
        AtLeadt.Text = myproj.calculatMajor(unMajor, AtLeadt.Text, unMajlbl, Balancetxt.Text, False)
       
    End Sub

    Private Sub DataPostionCode1_moveingRecord() Handles DataPostionCode1.moveingRecord

    End Sub
    Private Sub major_un_Changes()
        If Not IsNumeric(uncode.Text) Then uncode.Text = 0
        MajorCmb.SelectedIndex = uncode.Text
        unet_Choosed()
    End Sub
    Private Sub MajorCmb_SelectedValueChanged(sender As Object, e As EventArgs) Handles MajorCmb.SelectedValueChanged
      
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Paypricetxt_TextChanged(sender As Object, e As EventArgs) Handles Paypricetxt.TextChanged

    End Sub

    Private Sub BookShopHelpGrp_Enter(sender As Object, e As EventArgs) Handles BookShopHelpGrp.Enter

    End Sub

    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Balancetxt.TextChanged


    End Sub

    Private Sub SearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTxt.TextChanged

    End Sub

    Private Sub uncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uncode.Click

    End Sub
    Public Sub uncodwork()
        If Not IsNumeric(uncode.Text) Then uncode.Text = 0
        MajorCmb.SelectedIndex = uncode.Text
    End Sub
    Private Sub uncode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uncode.TextChanged
        uncodwork()
    End Sub

    Private Sub T_button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button11.Click
        loadme()
    End Sub
End Class