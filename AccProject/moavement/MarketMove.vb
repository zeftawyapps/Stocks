Imports ZeftawyTools
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class MarketMove

    Friend myStockMoveDatac, myDocNO, mystockDatac, myCashFlow, mydataReader, myClientAcc As New OLEdatabaseCodeing
    Dim project As New projectDataBase
    Dim StckmoveFM, stockDataFm As FieldMombers()
    Dim power As New Power
    Dim issale, lowSanf, isCash, isprint, isShoprint As Boolean
    Dim transName, namec, ClientAR_AP As String
    Friend isLoading As Boolean = True
    Dim iJomla As Boolean
    Dim atleast As Integer
    Dim Q As Integer

#Region "control Panal"
    Dim isTransactCash As Boolean = Contorlpanal.isTransactCash
    Dim OrgnizationName As String = Contorlpanal.ShopName
#End Region
    Private users As String
    Private Sub MarketMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        LoadLogin()
        load = True
        loadcases = loadCase.sale
        saledata.load()
        TransactionDataEnter(loadcases)
        FatoraNo = 0
        Me.WindowState = FormWindowState.Maximized
        isCash = isTransactCash


        CodeTxt.Focus()
        load = False
    End Sub
    Dim load As Boolean
    Dim mydatar As New OLEdatabaseCodeing
    Dim saledata As New SaleMove
    Private Sub LoadLogin()
        If Not isLoading Then Exit Sub
        Dim login As New logeinFrm

        login.ShowDialog()
        power = login.powrstr
        Setpower()
        users = login.user
        Contorlpanal.User = users
        login.Close()
        isLoading = False
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
        s = " Where sandf like '%" + Sanftxt.Text + "%'"
        Return "Select  sandf , " + SQLQ() + "   From " + saledata.SaleMove_Table + s + "   GROUP BY sandf "

    End Function
    Private Sub GetSanfQuant()
        mydataReader.ConnectToDataBase(project.Dataconpath)
        Qlbl.Text = mydataReader.showDataValuebyReader(GetSQl, 8)


        If Qlbl.Text = "" Then
            Qlbl.Text = 0

        End If
        Q = CInt(Qlbl.Text)
        If Q <= atleast Then
            lowSanf = True
        Else
            lowSanf = False
        End If
    End Sub
    Private Sub Setpower()
        If power.Admin.powr Then
            DataEbtn.Visible = True
            Salebtn.Visible = True
            SaleRbtn.Visible = True
            PayBtn.Visible = True
            PayRbtn.Visible = True

            StockDatabtn.Visible = True
            'Formatbtn.Visible = True
            Reportsbtn.Visible = True
            power.sale.powr = True
            power.rsale.powr = True
            power.parshase.powr = True
            power.reparshase.powr = True

            power.data.powr = True
            power.Format.powr = True
            power.report.powr = True
        Else
            Salebtn.Visible = power.sale.powr
            SaleRbtn.Visible = power.rsale.powr
            PayBtn.Visible = power.parshase.powr
            PayRbtn.Visible = power.reparshase.powr

            StockDatabtn.Visible = power.data.powr
            'menuBtn.Visible = power.Format.powr
            Reportsbtn.Visible = power.report.powr
        End If
    End Sub

    Private Sub showControlBanal()
        CpPanal.Width = 293
        CpPanal.Height = 312
        CpPanal.Left = 1020
        CpPanal.Top = 114
        CpPanal.Visible = True
    End Sub
    Dim Sums As Single
    Dim loadcases As loadCase = loadCase.sale
    Dim DocNo As DocNo
    Dim Cashflow As CashFlow
    Dim FatoraNo As Integer
    Dim FatoraName, fatoraNoTxts As String
    Private Sub LoadDocno()
        myDocNO.Load(project.Dataconpath, project.DocNo.DocNoTabe, project.DocNo.DocNo_Fm)
        myDocNO.ShowDataValue()
        DocNo = New DocNo("")
        DocNo.Sale.value = myDocNO.FieldValue(0)
        DocNo.SaleReturn.value = myDocNO.FieldValue(1)
        DocNo.Parchase.value = myDocNO.FieldValue(2)
        DocNo.ParshaseReturn.value = myDocNO.FieldValue(3)
    End Sub

    Private Sub LoadCashFlow(ByVal lc As loadCase)
        Cashflow = New CashFlow("")

        Cashflow.TransData.value = Now.Date
        Cashflow.TransData.isWanted = True

        Cashflow.invNo.value = Me.FatoraNotxt.Text
        Cashflow.invNo.isWanted = True

        Cashflow.DataEntery.Control = Me.DataEntertxt
        Cashflow.DataEntery.isWanted = True

        Select Case lc
            Case loadCase.sale
                Cashflow.Dr.isWanted = True
                Cashflow.Cr.isWanted = False

                Cashflow.CrAcc.isWanted = False
                Cashflow.DrAcc.isWanted = True

                Cashflow.RecOrPay.isWanted = True
                Cashflow.RecOrPay.value = "وارد"
                Cashflow.DrAcc.value = " بيع نقدا"
                Cashflow.Dr.Control = Me.TotalValueTxt
                Cashflow.Dr.visable = True
            Case loadCase.rsale
                Cashflow.Dr.isWanted = False
                Cashflow.Cr.isWanted = True

                Cashflow.CrAcc.isWanted = True
                Cashflow.DrAcc.isWanted = False

                Cashflow.RecOrPay.isWanted = True
                Cashflow.RecOrPay.value = "منصرف"
                Cashflow.CrAcc.value = "مرتجع بيع نقدا"

                Cashflow.Cr.Control = Me.TotalValueTxt
                Cashflow.Cr.visable = True
            Case loadCase.pay
                'القيمة
                Cashflow.Dr.isWanted = False
                Cashflow.Cr.isWanted = True
                'الحساب
                Cashflow.CrAcc.isWanted = True
                Cashflow.DrAcc.isWanted = False
                'وارد ام منصرف
                Cashflow.RecOrPay.isWanted = True
                Cashflow.RecOrPay.value = "منصرف"
                Cashflow.CrAcc.value = " مشتريات نقدا"

                Cashflow.Cr.Control = Me.TotalValueTxt
                Cashflow.Cr.visable = True
            Case loadCase.rpay
                Cashflow.Dr.isWanted = True
                Cashflow.Cr.isWanted = False

                Cashflow.CrAcc.isWanted = False
                Cashflow.DrAcc.isWanted = True

                Cashflow.RecOrPay.isWanted = True
                Cashflow.RecOrPay.value = "وارد"
                Cashflow.DrAcc.value = "  مرتجع مشتريات نقدا"

                Cashflow.Dr.Control = Me.TotalValueTxt
                Cashflow.Dr.visable = True
        End Select
        Cashflow.CashOrBank.value = "نقدا"
        Cashflow.Explanation.isWanted = True
        'Cashflow.Explanation.Control = Explenationtxt
        Cashflow.Explanation.visable = True
        Cashflow.ser.isWanted = True
        Cashflow.Cashflow_Fm = {Cashflow.TransData, Cashflow.invNo, Cashflow.Dr, Cashflow.Cr, Cashflow.DataEntery, Cashflow.RecOrPay, _
                                Cashflow.CashOrBank, Cashflow.DrAcc, Cashflow.CrAcc, Cashflow.Explanation, Cashflow.ser}

        myCashFlow.Load(project.Dataconpath, Cashflow.CashFlowTabe, myCashFlow.GetWantedFeild(Cashflow.Cashflow_Fm))

    End Sub
    Private Sub transactChecBox(ByVal lc As loadCase)
        For Each c As t_button In transactPnl.Controls
            c.Checked = False
        Next
        Select Case lc
            Case loadCase.sale
                Salebtn.Checked = True
            Case loadCase.rsale
                SaleRbtn.Checked = True
            Case loadCase.pay
                PayBtn.Checked = True
            Case loadCase.rpay
                PayRbtn.Checked = True
        End Select
    End Sub
    Private Sub StockLoad()
        project.LoadStockmove()
        project.LoadStockData()

        StckmoveFM = project.StockMove_FieldMember
        stockDataFm = project.StockDataField
        Dim top As Integer
        If load Then
            top = 5
        Else
            top = 0
        End If


        StckmoveFM = StockMoveload(loadcases)
        myStockMoveDatac.Load(project.Dataconpath, project.stockMoveTable, StckmoveFM, SalePayMovementDataGridView, top)

    End Sub
    Private Sub isTrasactload()
        'If isTransactCash Then
        '    TransactCmb.Enabled = True
        '    menuBtn.Visible = False
        'Else
        '    TransactCmb.SelectedIndex = 0
        '    TransactCmb.Enabled = False

        'End If
    End Sub
    Private Sub LoadClientAcc(ByVal lc As loadCase)
        'Dim ClientAcc As New CleintAcc
        'ClientAcc.load()
        'With ClientAcc
        '    .transdate.Control = DateTxt
        '    .FatoraNo.Control = FatoraNotxt
        '    .DataEnter.Control = DataEntertxt
        '    .Namec.Control = NameCtxt
        '    If issale Then
        '        .CleintSupp.value = "عميل"
        '        .Dr.Control = StealTxt
        '        .Cr.Control = Nothing
        '        .Cr.value = 0
        '        ClientAR_AP = "AR"
        '    Else
        '        .CleintSupp.value = "مورد"
        '        .Cr.Control = StealTxt
        '        .Dr.Control = Nothing
        '        .Dr.value = 0
        '        ClientAR_AP = "AP"
        '    End If
        '    Select Case lc
        '        Case loadCase.sale
        '            .Account.value = "بيع اجل"
        '        Case loadCase.rsale
        '            .Account.value = " مرتجع بيع  اجل"
        '        Case loadCase.pay
        '            .Account.value = "شراء اجل"
        '        Case loadCase.pay
        '            .Account.value = "مرتجع شراء اجل"
        '    End Select
        '    ClientAcc.CleintAcc_Fm = {.Account, .Namec, .transdate, .FatoraNo, .DataEnter _
        '                            , .Dr, .Cr, .CleintSupp, .ser}

        'End With
        'myClientAcc.Load(project.Dataconpath, ClientAcc.CleintAccTabe, ClientAcc.CleintAcc_Fm)
    End Sub
    Private Sub TransactionDataEnter(ByVal lc As loadCase)
        StockLoad()
        LoadDocno()

        LoadCashFlow(lc)


        Select Case lc
            Case loadCase.sale
                FatoraName = "S"
                FatoraNo = CInt(DocNo.Sale.value) + 1
                Label5.Text = "نوع المعالمة بيع"
                'Explenationtxt.Text = "  بيع   "
                namec = "زبون"
                issale = True
            Case loadCase.rsale
                FatoraName = "Sr"
                FatoraNo = CInt(DocNo.SaleReturn.value) + 1
                Label5.Text = "نوع المعالمةمرتجع بيع"
                'Explenationtxt.Text = "  مرتجع بيع  "
                namec = "زبون"
                issale = True
            Case loadCase.pay
                FatoraNo = CInt(DocNo.Parchase.value) + 1
                FatoraName = "P"
                Label5.Text = "نوع المعالمة شراء"
                'Explenationtxt.Text = "  شراء   "
                issale = False
                namec = "مورد"
            Case loadCase.rpay
                FatoraName = "Pr"
                FatoraNo = CInt(DocNo.ParshaseReturn.value) + 1
                Label5.Text = " نوع المعالمة مرتحع شراء"
                'Explenationtxt.Text = "  مرتجع شراء   "
                issale = False
                namec = "مورد"
        End Select
        fatoraNoTxts = FatoraName + Format(FatoraNo, "0000")
        FatoraNotxt.Text = FatoraName + Format(FatoraNo, "0000")

        myStockMoveDatac.DataFilter("FatoraNo = '" + FatoraNotxt.Text + "'")
        DateTxt.Text = Format(Now.Date, "yyyy/MM/dd")
        FatoraNotxt.Text = FatoraName + Format(FatoraNo, "0000")
        transactChecBox(lc)

        myCashFlow.DataFilter(Cashflow.invNo.Name + "= '" + FatoraNotxt.Text + "'")

        loadcases = lc

        EnterDoc(lc)
        'الهدف من هذا الكود هو كتابة رقم الفاتورة في خانة الشرح
        Select Case lc
            Case loadCase.sale

                'Explenationtxt.Text = "  بيع بفاتورة رقم  "

            Case loadCase.rsale

                'Explenationtxt.Text = "   مرتجع  بيع بفاتورة رقم   "

            Case loadCase.pay

                'Explenationtxt.Text = "   شراء بفاتورة رقم  "

            Case loadCase.rpay

                'Explenationtxt.Text = "  مرتجع شراء بفاتورة رقم   "

        End Select
        LoadClientAcc(lc)
        isTrasactload()
        myStockMoveDatac.showDatabyReaderTocombobox(FatoraCmb, saledata.FatoraNo.Name, saledata.SaleMove_Table, myStockMoveDatac.FeildWhere(feildtyp.simistring, saledata.FatoraNo.Name, FatoraName))

        DataEntertxt.Text = users
        FatoraCmb.Text = ""
        CodeTxt.Focus()
    End Sub
    Dim sanf, code, FatoraNoF, trDate, dataEntery, qsale, psale, qpsale, qpay, ppay, qppay As FieldMombers
    Dim qrSale, prsale, totalrsale, qrpay, prpay, totalrpahy As FieldMombers

    Private Function StockMoveload(ByVal lcase As loadCase) As FieldMombers()
        Dim s As Integer
        For Each c In StckmoveFM
            c.isWanted = False
            c.visable = False
            StckmoveFM(s) = c
            s += 1
        Next

        Select Case lcase
            Case loadCase.sale
                qsale = SetDataField(9, True, Qtxt)
                psale = SetDataField(10, True, Ptxt)
                qpsale = SetDataField(11, True, QPtxt)
            Case loadCase.pay

                qpay = SetDataField(12, True, Qtxt)
                ppay = SetDataField(13, True, Ptxt)
                qppay = SetDataField(14, True, QPtxt)
            Case loadCase.rsale

                qrSale = SetDataField(15, True, Qtxt)
                prsale = SetDataField(16, True, Ptxt)
                totalrsale = SetDataField(17, True, QPtxt)
            Case loadCase.rpay
                qrpay = SetDataField(18, True, Qtxt)
                prpay = SetDataField(19, True, Ptxt)
                totalrpahy = SetDataField(20, True, QPtxt)
        End Select

        sanf = SetDataField(0, True, Sanftxt)
        code = SetDataField(2, True, CodeTxt)
        FatoraNoF = SetDataField(1, True, FatoraNotxt)
        dataEntery = SetDataField(3, True, DataEntertxt)
        trDate = SetDataField(4, True, DateTxt)
        '
        'saledata.cashc = SetDataField(5, True, TransactCmb)
        'saledata.NameC = SetDataField(21, True, NameCtxt)
        saledata.moveSer = SetDataField(22, True, Nothing)
        StckmoveFM(22).dgvVisalbe = False
        '

        'trDate.value = Now.Date
        'trDate.isWanted = True
        Dim getdata = (From i In StckmoveFM _
                         Where i.isWanted = True _
                           Select i)

        Return getdata.ToArray

    End Function

    Private Sub EnterDoc(ByVal lc As loadCase)
        DocNo = New DocNo("")
        Select Case lc
            Case loadCase.sale

                DocNo.Sale.value = FatoraNo
            Case loadCase.rsale
                DocNo.SaleReturn.value = FatoraNo
            Case loadCase.pay
                DocNo.Parchase.value = FatoraNo
            Case loadCase.rpay
                DocNo.ParshaseReturn.value = FatoraNo
        End Select

        myDocNO.FieldValue(0) = DocNo.Sale.value
        myDocNO.FieldValue(1) = DocNo.SaleReturn.value
        myDocNO.FieldValue(2) = DocNo.Parchase.value
        myDocNO.FieldValue(3) = DocNo.ParshaseReturn.value
        myDocNO.isEdited = True
    End Sub
    Private Enum loadCase
        sale
        pay
        rsale
        rpay
    End Enum
    Private Function SetDataField(ByVal i As Integer, ByVal bol As Boolean, ByVal ctrl As Control) As FieldMombers
        Dim fmp As FieldMombers() = StckmoveFM
        fmp(i).isWanted = bol
        fmp(i).Control = ctrl
        fmp(i).visable = True
        fmp(i).dgvVisalbe = True
        Return fmp(i)
    End Function

    Private Function SetstockDataField(ByVal i As Integer, ByVal bol As Boolean, ByVal ctrl As Control) As FieldMombers
        Dim fmp As FieldMombers() = stockDataFm
        fmp(i).isWanted = bol
        fmp(i).Control = ctrl
        fmp(i).visable = True
        Return fmp(i)
    End Function
    Dim codeData, sanfdata, payprice, qutprice, jomlaprice As FieldMombers
    Private Function LoadStockData(ByVal issale As Boolean) As FieldMombers()
        For Each c In stockDataFm
            c.isWanted = False
            c.visable = False
        Next
        Dim datafp As FieldMombers() = stockDataFm

        If issale Then
            qutprice = SetstockDataField(5, True, Ptxt)
            qutprice.visable = True

            jomlaprice = SetstockDataField(4, True, Ptxt)
            jomlaprice.visable = True

            payprice = SetstockDataField(3, False, Ptxt)
            payprice.visable = True
        Else
            payprice = SetstockDataField(3, True, Ptxt)
            payprice.visable = True
            qutprice = SetstockDataField(5, False, Ptxt)
            qutprice.visable = True

            jomlaprice = SetstockDataField(4, False, Ptxt)
            jomlaprice.visable = True
        End If

        codeData = SetstockDataField(2, True, CodeTxt)
        codeData.visable = False

        sanfdata = SetstockDataField(1, True, Sanftxt)
        sanfdata.visable = True

        datafp(8).isWanted = True
        datafp(9).isWanted = True
        datafp(0).isWanted = True
        datafp(0).iskey = True
        Dim getdata = (From i In datafp _
                         Where i.isWanted = True _
                           Select i)
        Return getdata.ToArray

    End Function

    Private Sub GetSanf(ByVal isSale As Boolean, ByVal s As String)
        'On Error Resume Next
        If s = "" Then GoTo val
        Dim dataF As FieldMombers() = stockDataFm

        If isSale Then
            dataF = LoadStockData(True)

        Else
            dataF = LoadStockData(False)

        End If
        mystockDatac.Load(project.dataConPath_MyData, project.StockDatabookShop, dataF)

        mystockDatac.DataFilter(mystockDatac.FildsName(2) + "  = '" + s + "'")
        mystockDatac.ShowDataValue()
        Sanftxt.Text = mystockDatac.FieldValue(1)

        If IsDBNull(mystockDatac.FieldValue(5)) Then
            atleast = Contorlpanal.At_Least_Q
        Else
            atleast = mystockDatac.FieldValue(5)
        End If


        Label16.Text = atleast
        If Sanftxt.Text = "" Then
            msgbox("لا يوجد صنف بهذا الكود")


        Else
            If isSale Then
                Ptxt.Text = Jomlapricef()
            Else
                Ptxt.Text = mystockDatac.FieldValue(3)
            End If
        End If
        GetSanfQuant()



        If Not lowSanf Then
            Qtxt.Text = 1
            Qtxt.Focus()
        Else
            If isSale Then
                msgbox("لا يوجد كمية كافية في المخزن")
                mystockDatac.FieldValue(6) = Q
                Qtxt.Text = 0
                Ptxt.Text = 0
                Qtxt.Focus()
            Else
                Qtxt.Focus()
                mystockDatac.FieldValue(6) = ""
            End If

        End If
        mystockDatac.Edet()
        mystockDatac.SaveEdite(False)
val:
    End Sub

    Private Sub enterData(ByVal lcase As loadCase)
        Select Case lcase
            Case loadCase.sale

            Case loadCase.rsale

            Case loadCase.rpay

            Case loadCase.pay

        End Select

    End Sub

    Private Sub SalePayMovementDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellEnter
        myStockMoveDatac.MoveByDataGrideView()
        TotalValueTxt.Text = CalculatTotalValue()
    End Sub

    Private Sub CodeTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodeTxt.KeyDown
        If e.KeyCode = Keys.Down Then
            Paiedtxt.Focus()
        End If
        If e.KeyCode = Keys.Up Then
            MenuBnl.Visible = True
            transactPnl.Focus()
            Salebtn.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            CodeTxt.Clear()
        End If
        If e.KeyCode = Keys.F1 Then
            SearchofSanf()
        End If
        If e.KeyCode = Keys.F4 Then
            SearchofSanf()
        End If
    End Sub

    Private Sub SearchofSanf()
        Dim search As New smallQfrm
        search.isclient = True
        'search.power = power.data.powr
        search.ShowDialog()
        CodeTxt.Text = search.Quima
        Sanftxt.Text = search.SanfQuima

        search.Close()

        GetSanf(issale, CodeTxt.Text)

    End Sub
    Private Sub CodeTxt_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CodeTxt.MouseDoubleClick
        SearchofSanf()
    End Sub

    Private Sub CodeTxt_pressEnter() Handles CodeTxt.pressEnter
        GetSanf(issale, CodeTxt.Text)


    End Sub
    Private Sub TitelBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitelBar.MouseMove
        MenuBnl.Visible = True
    End Sub

    Private Sub TitelBar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitelBar.Leave
        MenuBnl.Visible = False
    End Sub


    Private Sub MenuBnl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuBnl.MouseMove
        MenuBnl.Visible = True
    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        MenuBnl.Visible = False
    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.LightYellow
    End Sub

    Private Sub T_button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button9.Click
        showControlBanal()

    End Sub

    Private Sub CalculatValue()

        Try
            If issale Then
                If CInt(Qlbl.Text) >= CInt(Qtxt.Text) Then
                    QPtxt.Text = (CSng(Qtxt.Text) * CSng(Ptxt.Text)).ToString
                Else
                    Qtxt.Text = CInt(Qlbl.Text)
                    If Qtxt.Text <= 0 Then Exit Sub
                    If Not issale Then Qtxt.Focus() : Exit Sub
                    msgbox("الكمية المطلوبة اقل من الكمية التي في المخزن")

                End If
            Else
                QPtxt.Text = (CSng(Qtxt.Text) * CSng(Ptxt.Text)).ToString

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Qtxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtxt.Enter

        CalculatValue()

    End Sub

    Private Sub Qtxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Qtxt.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                Paiedtxt.Focus()
            Case Keys.Up
                CodeTxt.Focus()
            Case Keys.Escape
                Qtxt.Clear()
        End Select
    End Sub
    Private Sub AddNewSanf()
        If lowSanf Then
            If issale Then
                Exit Sub

            End If
        End If

        If Sanftxt.Text = "" Then Exit Sub
        'NameCtxt.Text = namec
        myStockMoveDatac.insert()
        myStockMoveDatac.Isinserted = False
        Sums += CSng(QPtxt.Text)

        TotalValueTxt.Text = CalculatTotalValue()
        If SalePayMovementDataGridView.RowCount > 0 Then
            'TransactCmb.Enabled = True
        Else
            'TransactCmb.Enabled = False
        End If

        CodeTxt.Focus()
    End Sub
    Private Sub Qtxt_pressEnter() Handles Qtxt.pressEnter
        AddNewSanf()
    End Sub
    Private Function CalculatTotalValue() As Single
        Try
            Dim r As Integer = SalePayMovementDataGridView.Rows.Count
            Dim s As Single = 0
            For i = 0 To r - 1
                s += SalePayMovementDataGridView.Rows.Item(i).Cells(7).Value
            Next
            Return s

        Catch ex As Exception

        End Try

    
    End Function
    Private Sub Qtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtxt.TextChanged
        Try
            CalculatValue()

        Catch ex As Exception
            Ptxt.Text = 0
            QPtxt.Text = 0
            Qlbl.Text = 0
            msgbox("يرجى التاكد من صحة بيانات الصنف")
        End Try

    End Sub

    Private Sub Paiedtxt_Enter(sender As Object, e As EventArgs) Handles Paiedtxt.Enter
        TotalValueTxt.Text = CalculatTotalValue()
    End Sub

    Private Sub Paiedtxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Paiedtxt.KeyDown
        If e.KeyCode = Keys.Up Then
            Qtxt.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            Me.SalePayMovementDataGridView.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Paiedtxt.Clear()
        End If
    End Sub


    Private Sub SetNewFatorano()

        If isCash Then
            transName = "C"
            fatoraNoTxts = transName + FatoraNotxt.Text
            'Explenationtxt.Text = Explenationtxt.Text + " " + FatoraNotxt.Text + " " + TransactCmb.Text + " بقيمة  " + TotalValueTxt.Text

        Else
            If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then
                If (Paiedtxt.Text = 0) Then
                    transName = ClientAR_AP
                    fatoraNoTxts = transName + FatoraNotxt.Text

                Else
                    transName = "C" + ClientAR_AP
                    fatoraNoTxts = transName + FatoraNotxt.Text

                End If
            Else
                transName = "C"
                fatoraNoTxts = transName + FatoraNotxt.Text

            End If

        End If

    End Sub
    Private Sub setExplinationtxt()
        If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then
            If (Paiedtxt.Text = 0) Then
                'TransactCmb.SelectedIndex = 2
                'Explenationtxt.Text = Explenationtxt.Text + " " + FatoraNotxt.Text + "  اجل  بقيمة  " + TotalValueTxt.Text

            Else
                'TransactCmb.SelectedIndex = 1
                'Explenationtxt.Text = Explenationtxt.Text + " " + FatoraNotxt.Text + "   اجل مدفوع مقدما نقد  بقيمة  " + Paiedtxt.Text + "والاجل بقيمة" + StealTxt.Text

            End If
        Else
            'TransactCmb.SelectedIndex = 0
            'Explenationtxt.Text = Explenationtxt.Text + " " + FatoraNotxt.Text + " " + TransactCmb.Text + " بقيمة  " + TotalValueTxt.Text

        End If
        Select Case loadcases

            Case loadCase.sale
                'Explenationtxt.Text += "   من"


            Case loadCase.rsale
                'Explenationtxt.Text += " من  "

            Case loadCase.pay
                'Explenationtxt.Text += " الى"

            Case loadCase.rpay
                'Explenationtxt.Text += " الى"
        End Select
        'Explenationtxt.Text += " " + NameCtxt.Text
    End Sub
    Private Sub PaidCash()
        SetNewFatorano()

        If issale Then
            myCashFlow.FieldValue(1) = fatoraNoTxts
            myCashFlow.Contronls(2) = Nothing
            myCashFlow.FieldValue(2) = Paiedtxt.Text
            myCashFlow.FieldValue(6) = "مقدم بيع"
        Else
            myCashFlow.FieldValue(1) = fatoraNoTxts
            myCashFlow.Contronls(2) = Nothing
            myCashFlow.FieldValue(2) = Paiedtxt.Text
            myCashFlow.FieldValue(6) = "مقدم مشتريات"
        End If

        myCashFlow.insert()
        myCashFlow.Save(False)
    End Sub
    Private Sub SaveFatora()
        'On Error Resume Next
        If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then
            StealTxt.Text = (CSng(Paiedtxt.Text) - CSng(TotalValueTxt.Text)).ToString

            If isCash Then
                msgbox("المبلغ المدفوع اقل من قيمة الفاتورة")
                Exit Sub
            Else
                StealTxt.Text = CSng(StealTxt.Text) * -1
                If Paiedtxt.Text = 0 Then
                    'TransactCmb.SelectedIndex = 2
                    transName = ClientAR_AP
                    fatoraNoTxts = transName + FatoraNotxt.Text
                    myClientAcc.Contronls(3) = Nothing
                    myClientAcc.FieldValue(3) = fatoraNoTxts
                Else
                    transName = "C" + ClientAR_AP
                    fatoraNoTxts = transName + FatoraNotxt.Text

                    'TransactCmb.SelectedIndex = 1
                    myClientAcc.FieldValue(0) += "مدفوع مقدما"
                    myClientAcc.Contronls(3) = Nothing
                    myClientAcc.FieldValue(3) = fatoraNoTxts
                    'عشان يكتب نوع المعامل 
                    If issale Then
                        myClientAcc.FieldValue(7) = myProjectWork.Client
                    Else
                        myClientAcc.FieldValue(7) = myProjectWork.Moarid
                    End If
                    PaidCash()
                End If

                'NameCtxt.Focus()
                myClientAcc.insert()
                myClientAcc.SaveInsert(False)
            End If
        Else
            transName = "C"
            fatoraNoTxts = transName + FatoraNotxt.Text

            myCashFlow.FieldValue(1) = fatoraNoTxts
            myCashFlow.insert()
            myCashFlow.Save(False)
        End If



        myDocNO.Save(False)

        myStockMoveDatac.Save(False)
        isprint = True
        print()
        myStockMoveDatac.DataFilter("FatoraNo = '" + FatoraNotxt.Text + "'")

        SetNewFatorano()
        FatoraNotxt.Text = fatoraNoTxts
        'NameCtxt.Text = namec

        setExplinationtxt()

        Dim ic As Integer = SalePayMovementDataGridView.RowCount - 1
        Dim i As Integer = 0


        ' اعادة ادخال لبيانات في دفتر المخزن
        For i = 0 To ic
            SalePayMovementDataGridView.Item(1, i).Value = FatoraNotxt.Text
            'SalePayMovementDataGridView.Item(5, i).Value = TransactCmb.Text
            'SalePayMovementDataGridView.Item(9, i).Value = NameCtxt.Text

            myStockMoveDatac.Edet()
            FatoraNo = 0
        Next

        myStockMoveDatac.SaveEdite()
        ''
        TransactionDataEnter(loadcases)

        Sums = 0
        TotalValueTxt.Text = 0
        Paiedtxt.Text = ""
        Qlbl.Text = 0
        StealTxt.Clear()

    End Sub
    Private Sub Paiedtxt_pressEnter() Handles Paiedtxt.pressEnter
        SaveFatora()
    End Sub



    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salebtn.Click
        loadcases = loadCase.sale

        TransactionDataEnter(loadcases)

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRbtn.Click
        loadcases = loadCase.rsale
        TransactionDataEnter(loadcases)

    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayBtn.Click
        loadcases = loadCase.pay
        TransactionDataEnter(loadcases)
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayRbtn.Click
        loadcases = loadCase.rpay
        TransactionDataEnter(loadcases)
    End Sub

    Private Sub T_textbox6_Enter(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Fatorasearch()
        myStockMoveDatac.DataFilter("FatoraNo = '" + FatoraCmb.Text + "'")
        myCashFlow.DataFilter(Cashflow.invNo.Name + "= '" + FatoraCmb.Text + "'")
    End Sub

    Private Sub SearchTxt_pressEnter()
        Fatorasearch()
    End Sub

    Private Sub SalePayMovementDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SalePayMovementDataGridView.KeyDown
        Try

            If e.KeyCode = Keys.Escape Then
                Paiedtxt.Focus()
            End If
            If e.KeyCode = Keys.Enter Then
                CodeTxt.Focus()
            End If
            If e.KeyCode = Keys.Up Then
                If SalePayMovementDataGridView.CurrentRow.Index = 0 Then
                    Paiedtxt.Focus()
                End If

            End If
        Catch ex As Exception

        Finally
            Paiedtxt.Focus()
        End Try
    End Sub


    Private Sub T_button5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Salebtn.KeyDown
        If e.KeyCode = Keys.Left Then
            SaleRbtn.Focus()
        End If
        If e.KeyCode = Keys.Right Then

        End If
        If e.KeyCode = Keys.Enter Then
            CodeTxt.Focus()
        End If
    End Sub

    Private Sub T_button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SaleRbtn.KeyDown
        If e.KeyCode = Keys.Left Then
            PayBtn.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            Salebtn.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            CodeTxt.Focus()
        End If
    End Sub

    Private Sub T_button4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PayBtn.KeyDown
        If e.KeyCode = Keys.Left Then
            PayRbtn.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            SaleRbtn.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            CodeTxt.Focus()
        End If
    End Sub

    Private Sub T_button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PayRbtn.KeyDown
        If e.KeyCode = Keys.Left Then
            T_button9.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            PayBtn.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            CodeTxt.Focus()
        End If
    End Sub

    Private Sub CodeTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles CodeTxt.PreviewKeyDown

    End Sub

    Private Sub CodeTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeTxt.TextChanged

    End Sub

    Private Sub SearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        TransactionDataEnter(loadcases)
        'LoadCashFlow(loadCase)
    End Sub

    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        Startfrm.ApplicationExit()
    End Sub
    Private Sub SalePayMovementDataGridView_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SalePayMovementDataGridView.Leave
        newSum()
    End Sub
    Private Sub newSum()
        Dim sum(SalePayMovementDataGridView.RowCount - 1) As Single
        Sums = 0
        For i = 0 To SalePayMovementDataGridView.RowCount - 1
            sum(i) = SalePayMovementDataGridView.Item(8, i).Value
            Sums += sum(i)
        Next
        TotalValueTxt.Text = Sums
    End Sub

    Private Sub SalePayMovementDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles SalePayMovementDataGridView.UserDeletedRow
        newSum()
        If SalePayMovementDataGridView.RowCount > 0 Then
            'TransactCmb.Enabled = True
        Else
            'TransactCmb.Enabled = False
            Paiedtxt.Text = 0
            Qtxt.Text = 0
            CodeTxt.Focus()
        End If
    End Sub

    Private Sub T_button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New Form1
        'f.names = DataEntertxt.Text
        'f.fat = FatoraNotxt.Text
        'f.dates = DateTxt.Text
        'f.total = TotalValueTxt.Text
        'f.paid = Paiedtxt.Text
        'f.steal = StealTxt.Text
        'f.mydata.DataTable = myStockMoveDatac.DataTable
        'Form1.show(DataEntertxt.Text)
    End Sub
    Private Sub print_Inv()
        'Dim f As New Form1
        'Form1.show(DataEntertxt.Text, FatoraNotxt.Text, DateTxt.Text, TotalValueTxt.Text, Paiedtxt.Text, StealTxt.Text)
        'f.mydata.DataTable = myStockMoveDatac.DataTable
        ''f.names = DataEntertxt.Text
        'f.fat = FatoraNotxt.Text
        'f.dates = DateTxt.Text
        'f.total = TotalValueTxt.Text
        'f.paid = Paiedtxt.Text
        'f.steal = StealTxt.Text


    End Sub
    Private Sub T_button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDatabtn.Click
        Dim stock As New StockDataMarket
        stock.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        CpPanal.Visible = False
    End Sub

    Private Sub Label9_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.Enter

    End Sub

    Private Sub T_button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataEbtn.Click
        Dim datae As New DataEpFrm
        datae.Show()
    End Sub

    Private Sub Formatbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As New DesigneControlFrm
        i.ShowDialog()

        i.Close()
    End Sub

    Private Sub T_button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim inv As New InvoicePrint
        'inv.SetDefPaperAndMargine()
        'inv.DefSetHeaderParts_Arabic("الفلاح", FatoraNotxt.Text, DateTxt.Text, DataEntertxt.Text)
        'inv.SetValues(Me.SalePayMovementDataGridView, 0, 5, 6, 7)
        'inv.DefSetFooterParts_Arabic(TotalValueTxt.Text, Paiedtxt.Text, StealTxt.Text)
        'Dim prpev As New PrintPreviewDialog
        'prpev.Document = inv.MyInvoice
        'prpev.Show()
    End Sub

    Private Sub Reportsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reportsbtn.Click
        Dim i As New MarketBalanceFrm
        i.Show()
    End Sub

    Private Sub Ptxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ptxt.TextChanged
        price.Text = Ptxt.Text
        If Ptxt.Text = "" Then price.Text = "0"
    End Sub

    Private Sub TotalValueTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalValueTxt.TextChanged
        totalValue.Text = TotalValueTxt.Text
        If TotalValueTxt.Text = "" Then totalValue.Text = "0"
    End Sub



    Private Sub StealTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StealTxt.TextChanged
        steel.Text = StealTxt.Text
        If StealTxt.Text = "" Then steel.Text = "0"
    End Sub

    Private Sub T_button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim inv As New InvoicePrint
        'inv.SetDefPaperAndMargine()
        'inv.DefSetHeaderParts_Arabic("الفلاح", FatoraNotxt.Text, DateTxt.Text, DataEntertxt.Text)
        'inv.SetValues(Me.SalePayMovementDataGridView, 0, 5, 6, 7)
        ''inv.DefSetFooterParts_Arabic(TotalValueTxt.Text, Paiedtxt.Text, StealTxt.Text)
        'Dim prpev As New PrintPreviewDialog
        'prpev.Document = inv.MyInvoice
        'prpev.Show()
    End Sub
    Private Sub print()
        If Not isprint Then Exit Sub
        Dim inv As New InvoicePrint
        inv.setPapers(2.55)
        inv.Setinvoicepart()
        inv.SetHeaders(OrgnizationName, Format(Date.Now.Date, "dd/MM/yyyy"), DataEntertxt.Text, FatoraNotxt.Text)
        inv.SetBodyArea(SalePayMovementDataGridView, 0, 6, 7, 8)
        inv.SetFooters(TotalValueTxt.Text, Paiedtxt.Text, StealTxt.Text)

        Dim pDocDailoge As New PrintPreviewDialog
        pDocDailoge.Document = inv.MyInvoice
        pDocDailoge.ShowDialog()
        pDocDailoge.Close()

    End Sub



    Private Sub Paiedtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paiedtxt.TextChanged

    End Sub
    Private Function getNamec() As String
        If issale Then
            Return myProjectWork.Client
        Else
            Return myProjectWork.Moarid

        End If
    End Function

    Private Sub NameCtxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim c As New smallQfrm
        c.snf = False
        If issale Then
            c.isclient = True
        Else
            c.isclient = False
        End If
        c.ShowDialog()
        'NameCtxt.Text = c.Quima
        namec = c.Quima
        c.Close()
        Paiedtxt.Focus()
    End Sub

    Private Sub NameCtxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If NameCtxt.Text = "" Then
        '    namec = getNamec()
        'Else
        '    namec = NameCtxt.Text
        'End If

    End Sub
    Private Sub NameCtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TransactCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'transName = TransactCmb.Text
        'Select Case TransactCmb.SelectedIndex
        '    Case 0
        '        Paiedtxt.Text = TotalValueTxt.Text
        '    Case 1
        '        Paiedtxt.Text = 0
        '    Case 2
        '        Paiedtxt.Text = CSng(TotalValueTxt.Text) - 1
        'End Select
        'Paiedtxt.Focus()
    End Sub

    Private Sub Label9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.LightYellow
    End Sub

    Private Sub Label9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseMove
        Label9.ForeColor = Color.Red
    End Sub

    Private Sub menuBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim men As New MainMenuefrm
        men.Show()
        Me.Close()

    End Sub

    Private Sub T_button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        isLoading = True
        LoadLogin()
        TransactionDataEnter(loadcases)
        MenuBnl.Visible = False
        CpPanal.Visible = False
    End Sub

    Private Sub TitelBar_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TitelBar.Paint

    End Sub

    Private Sub FatoraCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FatoraCmb.SelectedIndexChanged
        Fatorasearch()
    End Sub

    Private Sub PsaleLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PsaleLabel.Click
        Try
            If iJomla Then
                iJomla = False
                Ptxt.Text = Jomlapricef()
            Else
                iJomla = True
                Ptxt.Text = Jomlapricef()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function Jomlapricef() As Single
        If iJomla Then
            PsaleLabel.Text = "سعر الجملة"
            Return mystockDatac.FieldValue(2)
        Else
            PsaleLabel.Text = "سعر التجزئة"
            Return mystockDatac.FieldValue(3)
        End If
    End Function

    Private Sub T_button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        If Qtxt.Text = "" Then Exit Sub
        AddNewSanf()
    End Sub

    Private Sub T_button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        If Paiedtxt.Text = "" Then Exit Sub

        SaveFatora()
    End Sub

    Private Sub SalePayMovementDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellContentClick

    End Sub

    Private Sub SalePayMovementDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles SalePayMovementDataGridView.UserDeletingRow

    End Sub
End Class