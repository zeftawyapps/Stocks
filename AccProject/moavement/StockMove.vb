Imports ZeftawyTools
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class StockMove

    Friend myStockMoveDatac, myDocNO, mystockDatac, myCashFlow, mydataReader, myClientAcc As New OLEdatabaseCodeing
    Dim project As New projectDataBase
    Dim projW As New myProjectWork
    Dim StckmoveFM, stockDataFm As FieldMombers()
    Dim power As New Power
    Dim issale, lowSanf, isCash, isSearch, issaveing As Boolean
    Dim transName, namec, ClientAR_AP, AccountName As String
    Friend isLoading As Boolean = True
    Dim iJomla As Boolean
    Dim atleast As Integer
    Dim Q, untq As Integer
    Dim isAllawlecin As Boolean
    Dim q1, totalq, p As String

#Region "control Panal"
    Dim isTransactCash As Boolean = Contorlpanal.isTransactCash
    Dim OrgnizationName As String = Contorlpanal.ShopName
    Dim autoFatorano As Boolean = Contorlpanal.AoutoFatorano
    Dim stocktyp As StockType = Contorlpanal.StockType
    Dim usmatudate As Boolean = Contorlpanal.ismatueDateUsed
    Dim matueDate As Integer = Contorlpanal.matueDateTime
    Dim isliecened As Boolean = Contorlpanal.islicended
    Dim isprint As Boolean = Contorlpanal.isprintinv
    Dim isShoprint As Boolean = Contorlpanal.isShowPrintInv
    Dim iskg As Boolean = Contorlpanal.isKg
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
        If stocktyp = StockType.Casher Then
            isCash = True
        End If
        If isCash Then
            SetMeCasher(False)
            WendowsTypebtn.Visible = False
        End If

        ''نهاية التحميل ممنوع الاقتراب
        load = False
        SetMeCasher(False)
        CodeTxt.Focus()
    
    End Sub
    Private Function CalculatTotalValue() As Single
        'On Error Resume Next
        Dim r As Integer = SalePayMovementDataGridView.Rows.Count
        Dim s As Single = 0

        For i = 0 To r - 1
            If Not IsDBNull(SalePayMovementDataGridView.Rows.Item(i).Cells(8).Value) Then
                s += SalePayMovementDataGridView.Rows.Item(i).Cells(8).Value
            End If
 Next
        Return s
    End Function
    Dim load As Boolean
    Dim mydatar As New OLEdatabaseCodeing
    Dim saledata As New SaleMove
    Private Sub SetMeCasher(Optional Fatora As Boolean = False)
        If Not Fatora Then
            TransActGrb.Height = 197
            'SalePayMovementDataGridView.Top = 465
            SalePayMovementDataGridView.Height = 313
        Else
            TransActGrb.Height = 311

            SalePayMovementDataGridView.Height = 289
        End If
        SalePayMovementDataGridView.Top = TransActGrb.Top + TransActGrb.Height + 5
    End Sub
    Private Sub LoadLogin()
        If Not isLoading Then Exit Sub
        Dim login As New logeinFrm

        login.ShowDialog()
        power = login.powrstr
        ProjectFunc.Powers = power
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
        totalq = mydataReader.showDataValuebyReader(GetSQl, 8)
      
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
            menuBtn.Visible = power.Format.powr
            Reportsbtn.Visible = power.report.powr
            DataEbtn.Visible = False
            If power.casher.powr Then
                WendowsTypebtn.Checked = False
                WendowsTypebtn.Visible = False
                isCash = True
            End If
        End If
    End Sub
    Dim val_un_major As Object
    Dim check_un As Boolean
    Private Function un_major_enter_value(s As String) As String

        If check_un Then
            val_un_major = s
        Else
            val_un_major = projW.UnitedQ(un_major, s)
        End If
        Return val_un_major
    End Function
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

        Cashflow.invNo.value = Me.transactionNolbl.Text
        Cashflow.invNo.isWanted = True

        Cashflow.DataEntery.Control = Me.DataEntertxt
        Cashflow.DataEntery.isWanted = True
        Cashflow.transNo.Control = transactionNolbl
        Cashflow.transNo.isWanted = True
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
        Cashflow.Explanation.Control = Explenationtxt
        Cashflow.Explanation.visable = True
        Cashflow.ser.isWanted = True
        Cashflow.Cashflow_Fm = {Cashflow.TransData, Cashflow.invNo, Cashflow.Dr, Cashflow.Cr, Cashflow.DataEntery, Cashflow.RecOrPay, _
                                Cashflow.CashOrBank, Cashflow.DrAcc, Cashflow.CrAcc, Cashflow.Explanation, Cashflow.transNo, Cashflow.ser}

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
        If isTransactCash Then
            TransactCmb.Enabled = True
            menuBtn.Visible = False
        Else
            TransactCmb.SelectedIndex = 0
            TransactCmb.Enabled = False

        End If
    End Sub
    Private Sub LoadClientAcc(ByVal lc As loadCase)
        Dim ClientAcc As New CleintAcc
        ClientAcc.load()
        With ClientAcc
            .transdate.Control = DateTxt
            .transdate.isWanted = True
            .FatoraNo.Control = transactionNolbl
            .FatoraNo.isWanted = True
            .DataEnter.Control = DataEntertxt
            .DataEnter.isWanted = True
            .Namec.Control = NameCtxt
            .Namec.isWanted = True
            .transNo.Control = transactionNolbl
            .transNo.isWanted = True
            .matDate.Control = MatueDateBeker
           
            .matDate.isWanted = True
            If issale Then
                .CleintSupp.value = "عميل"

                .Dr.Control = StealTxt
                .Dr.isWanted = True
                .Cr.Control = Nothing
                .Cr.value = 0
                .Cr.isWanted = False
                ClientAR_AP = "AR"
            Else
                .CleintSupp.value = "مورد"
                .Cr.Control = StealTxt
                .Cr.isWanted = True
                .Dr.Control = Nothing
                .Dr.value = 0
                .Dr.isWanted = False
                ClientAR_AP = "AP"
            End If
            
            .Account.value = AccountName
            .Account.isWanted = True
            .CleintSupp.isWanted = True
            'ClientAcc.CleintAcc_Fm = {.Account, .Namec, .transdate, .FatoraNo, .DataEnter _
            '                        , .Dr, .Cr, .CleintSupp, .transNo, .ser}
            ClientAcc.load_FM()

        End With
       
        myClientAcc.Load(project.Dataconpath, ClientAcc.CleintAccTabe, myClientAcc.GetWantedFeild(ClientAcc.CleintAcc_Fm))
            End Sub

    Private Sub TransactionDataEnter(ByVal lc As loadCase)
        StockLoad()
        LoadDocno()

        LoadCashFlow(lc)


        Select Case lc
            Case loadCase.sale
                FatoraName = "Sa"
                FatoraNo = CInt(DocNo.Sale.value) + 1
                Label5.Text = "نوع المعالمة بيع"
                Explenationtxt.Text = "  بيع   "
                AccountName = "بيع "
                namec = "زبون"
                issale = True
            Case loadCase.rsale
                FatoraName = "Sr"
                FatoraNo = CInt(DocNo.SaleReturn.value) + 1
                Label5.Text = "نوع المعالمةمرتجع بيع"
                Explenationtxt.Text = "  مرتجع بيع  "
                AccountName = "مرتجع بيع  "
                namec = "زبون"
                issale = True
            Case loadCase.pay
                FatoraNo = CInt(DocNo.Parchase.value) + 1
                FatoraName = "Pa"
                Label5.Text = "نوع المعالمة شراء"
                Explenationtxt.Text = "  شراء   "
                AccountName = "شراء   "
                issale = False
                namec = "مورد"
            Case loadCase.rpay
                FatoraName = "Pr"
                FatoraNo = CInt(DocNo.ParshaseReturn.value) + 1
                Label5.Text = " نوع المعالمة مرتحع شراء"
                Explenationtxt.Text = "  مرتجع شراء   "
                AccountName = "مرتجع شراء   "
                issale = False
                namec = "مورد"
        End Select
        fatoraNoTxts = FatoraName + Format(FatoraNo, "0000")
        transactionNolbl.Text = FatoraName + Format(FatoraNo, "0000")

        myStockMoveDatac.DataFilter("FatoraNo = '" + transactionNolbl.Text + "'")
        DateTxt.Text = Format(Now.Date, "yyyy/MM/dd")
        transactionNolbl.Text = FatoraName + Format(FatoraNo, "0000")
        transactChecBox(lc)

        myCashFlow.DataFilter(Cashflow.invNo.Name + "= '" + transactionNolbl.Text + "'")

        loadcases = lc

        EnterDoc(lc)
        'الهدف من هذا الكود هو كتابة رقم الفاتورة في خانة الشرح
        Select Case lc
            Case loadCase.sale

                Explenationtxt.Text = "  بيع بفاتورة رقم  "

            Case loadCase.rsale

                Explenationtxt.Text = "   مرتجع  بيع بفاتورة رقم   "

            Case loadCase.pay

                Explenationtxt.Text = "   شراء بفاتورة رقم  "

            Case loadCase.rpay

                Explenationtxt.Text = "  مرتجع شراء بفاتورة رقم   "

        End Select

        isTrasactload()

        Dim l As New List(Of String)
        l.AddRange(myStockMoveDatac.showDatabyReaderTocombobox(FatoraCmb, saledata.FatoraNo.Name, saledata.SaleMove_Table, myStockMoveDatac.FeildWhere(feildtyp.simistring, saledata.FatoraNo.Name, FatoraName)))

        FatoraCmb.AutoCompleteCustomSource.AddRange(l.ToArray)

        DataEntertxt.Text = users
        FatoraCmb.Text = ""
        CodeTxt.Focus()
        If autoFatorano Then
            DocumentNotxt.Text = transactionNolbl.Text
            DocumentNotxt.ReadOnly = True

        Else
            DocumentNotxt.Text = ""
            DocumentNotxt.ReadOnly = False
            transactionNolbl.Visible = True
        End If
    End Sub

    Dim sanf, code, FatoraNoF, trDate, dataEntery, qsale, psale, qpsale, qpay, ppay, qppay As FieldMombers
    Dim qrSale, prsale, totalrsale, qrpay, prpay, totalrpahy, transNo As FieldMombers

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
        FatoraNoF = SetDataField(1, True, DocumentNotxt)
        dataEntery = SetDataField(3, True, DataEntertxt)
        trDate = SetDataField(4, True, DateTxt)
        '
        saledata.cashc = SetDataField(5, True, TransactCmb)
        saledata.NameC = SetDataField(21, True, NameCtxt)
        transNo = SetDataField(22, True, transactionNolbl)
        StckmoveFM(22).dgvVisalbe = False
        saledata.moveSer = SetDataField(23, True, Nothing)
        StckmoveFM(23).dgvVisalbe = False
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
        If DocNo.Sale.value > 100 Then
            If Not isliecened Then
                isAllawlecin = False
            Else
                isAllawlecin = True
            End If
        End If
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
    Dim codeData, sanfdata, payprice, qutprice, jomlaprice, balance As FieldMombers
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
        'الجزء الخاص بوحدات القياس 
        If stocktyp = StockType.BookShop Then
            datafp(10).isWanted = False
        Else
            datafp(10).isWanted = True
        End If
        If Contorlpanal.StockType = StockType.Shope Then
            datafp(11).isWanted = True
        Else
            datafp(11).isWanted = False
        End If

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

        Dim tableName As String
        'اخذ اسم الجدول على حسب نوع المخزون
        If stocktyp = StockType.BookShop Then
            tableName = "StockDataBookShops"

        Else
            tableName = "StockDataTableShops"

        End If
        mystockDatac.Load(project.dataConPath_MyData, tableName, dataF)

        mystockDatac.DataFilter(mystockDatac.FildsName(2) + "  = '" + s + "'")
        mystockDatac.ShowDataValue()
        Sanftxt.Text = mystockDatac.FieldValue(1)

        If IsDBNull(mystockDatac.FieldValue(5)) Then
            atleast = Contorlpanal.At_Least_Q
        Else
            atleast = mystockDatac.FieldValue(5)
        End If
        'لوضع خطه وحدات القياس 
        If stocktyp = StockType.BookShop Then
         
        Else

            If isSale Then
                un_major = getUn_major_type(mystockDatac.FieldValue(7))
                PsaleLabel.Text = "سعر  التجزئه"


            Else
                un_major = getUn_major_type(mystockDatac.FieldValue(6))
                PsaleLabel.Text = "سعر الشراء"
            End If


        End If
        If Not Contorlpanal.StockType = StockType.BookShop Then
            If isSale Then
                If Not IsDBNull(mystockDatac.FieldValue(8)) Then
                    Balancelbl.Text = mystockDatac.FieldValue(8)

                End If
            Else
                If Not IsDBNull(mystockDatac.FieldValue(7)) Then
                    Balancelbl.Text = mystockDatac.FieldValue(7)

                End If
            End If
        End If
        'Balancelbl.Text = atleast
        If Sanftxt.Text = "" Then
            msgbox("لا يوجد صنف بهذا الكود")


        Else
            If isSale Then
                Ptxt.Text = Jomlapricef()
                p = Jomlapricef()
            Else
                Ptxt.Text = mystockDatac.FieldValue(3)
                p = mystockDatac.FieldValue(3)
            End If
        End If
        GetSanfQuant()


        If Contorlpanal.StockType = StockType.BookShop Then
            If Not lowSanf Then
                Qtxt.Text = 1
                Qtxt.Focus()
            Else
                If isSale Then
                    msgbox("لا يوجد كمية كافية في المخزن")
                    mystockDatac.FieldValue(5) = Q
                    Qtxt.Text = 0
                    Ptxt.Text = Jomlapricef()
                    Qtxt.Focus()
                Else
                    Qtxt.Focus()
                    mystockDatac.FieldValue(5) = ""
                End If

            End If

        Else
            If Not lowSanf Then
                Qtxt.Text = 1
                Qtxt.Focus()
            Else
                If isSale Then
                    msgbox("لا يوجد كمية كافية في المخزن")
                    mystockDatac.FieldValue(6) = Q
                    Qtxt.Text = 0
                    Ptxt.Text = Jomlapricef()
                    p = Jomlapricef()
                    Qtxt.Focus()
                Else
                    Qtxt.Focus()
                    mystockDatac.FieldValue(6) = ""
                End If

            End If

        End If
        'mystockDatac.Edet()
        'mystockDatac.SaveEdite(False)
        unMajlbl.Visible = True
        Q = Qtxt.Text
        p = Ptxt.Text
        totalq = QPtxt.Text
val:
    End Sub
    

    Private un_major As Unet_major
    Private Function getUn_major_type(s As String) As Unet_major
     
        Select Case s

            Case 0

                un_major = Unet_major.unit
                unMajlbl.ischeck = False
                unMajlbl.Text = "الادخال  قطعة قطعة"
            Case 1

                un_major = Unet_major.dasta
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال بالقطعة"
                unMajlbl.nocheckText = "الادخال الدسته"
                unMajlbl.Text = "الادخال بالقطعة"
            Case 2

                un_major = Unet_major.kg
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال جم"
                unMajlbl.nocheckText = "الادخال بالكجم"
                unMajlbl.Text = "الادخال جم"
               
            Case 3

                un_major = Unet_major.leter
                unMajlbl.ischeck = True
                unMajlbl.checkText = "الادخال سنتلتر"
                unMajlbl.nocheckText = "الادخال لتر"
                unMajlbl.Text = "الادخال سنتلتر"

        End Select
        unMajlbl.check = True
        Return un_major
        'check_un = unMajlbl.check
        'uncode.Text = MajorCmb.SelectedIndex

    End Function
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

    Private Sub CodeTxt_DoubleClick(sender As Object, e As EventArgs) Handles CodeTxt.DoubleClick

    End Sub

    Private Sub CodeTxt_Enter(sender As Object, e As EventArgs) Handles CodeTxt.Enter

        CpPanal.Visible = False
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
    End Sub

    Private Sub SearchofSanf()
        If stocktyp = StockType.BookShop Then
            Dim search As New QueryBookShopfrm
            search.isclient = True
            search.power = power.data.powr
            search.ShowDialog()
            CodeTxt.Text = search.Quima
            Sanftxt.Text = search.SanfQuima
            search.Close()
        ElseIf stocktyp = StockType.Shope Or stocktyp = StockType.Casher Then
            Dim search As New smallQfrm
            search.isclient = True
            'search.power = power.data.powr
            search.ShowDialog()
            CodeTxt.Text = search.Quima
            Sanftxt.Text = search.SanfQuima

            search.Close()
        End If




        GetSanf(issale, CodeTxt.Text)

    End Sub
    Private Sub CodeTxt_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CodeTxt.MouseDoubleClick
        SearchofSanf()
    End Sub

    Private Sub CodeTxt_pressEnter() Handles CodeTxt.pressEnter
        GetSanf(issale, CodeTxt.Text)
        If un_major = Unet_major.kg Then
            If iskg Then
                unMajlbl.check = False
                unMajlbl.Text = unMajlbl.nocheckText
                unmajors()
                Qtxt.Text = 1
            End If
        End If
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
            If unMajlbl.check Then
                GoTo dd
            Else
                unMajlbl.check = True
                unMajlbl.Text = unMajlbl.checkText
                Qlbl.Text = projW.calculatMajor(un_major, Qlbl.Text, unMajlbl, Balancelbl.Text)
                Qtxt.Text = projW.calculatMajor(un_major, Qtxt.Text, unMajlbl, Balancelbl.Text)
                '  Ptxt.Text = projW.calculatMajor(un_major, Ptxt.Text, unMajlbl, True)
            End If
dd:
            If issale Then
                If CInt(Qlbl.Text) >= CInt(Qtxt.Text) Then
                    QPtxt.Text = (CSng(Qtxt.Text) * CSng(Ptxt.Text)).ToString
                Else
                    Qtxt.Text = CInt(Qlbl.Text)
                    If Qtxt.Text <= 0 Then Exit Sub
                    If Not issale Then Qtxt.Focus() : Exit Sub
                    msgbox("الكمية المطلوبة اقل من الكمية التي في المخزن")
                    QPtxt.Text = (CSng(Qtxt.Text) * CSng(Ptxt.Text)).ToString

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
        If unMajlbl.check Then
            GoTo dd
        Else
            unMajlbl.check = True
            unmajors()
            '  Ptxt.Text = projW.calculatMajor(un_major, Ptxt.Text, unMajlbl, True)
                   End If
dd:
        CalculatValue()
        If lowSanf Then
            If issale Then
                Exit Sub

            End If
        End If

        If Sanftxt.Text = "" Then Exit Sub
       
        NameCtxt.Text = namec
        myStockMoveDatac.insert()
        myStockMoveDatac.Isinserted = False
        Sums += CSng(QPtxt.Text)

        TotalValueTxt.Text = CalculatTotalValue()
        If SalePayMovementDataGridView.RowCount > 0 Then
            TransactCmb.Enabled = True
        Else
            TransactCmb.Enabled = False
        End If

        CodeTxt.Focus()
        isSearch = False
    End Sub

    Private Sub Qtxt_Leave(sender As Object, e As EventArgs) Handles Qtxt.Leave

    End Sub
    Private Sub Qtxt_pressEnter() Handles Qtxt.pressEnter
        AddNewSanf()
    End Sub
    Private Sub Qtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtxt.TextChanged
        Try


        Catch ex As Exception
            Ptxt.Text = 0
            QPtxt.Text = 0
            Qlbl.Text = 0
            msgbox("يرجى التاكد من صحة بيانات الصنف")
        End Try

    End Sub

    Private Sub Paiedtxt_Enter(sender As Object, e As EventArgs) Handles Paiedtxt.Enter
        'On Error Resume Next
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
            If isSearch Then
                fatoraNoTxts = transactionNolbl.Text
            Else
                fatoraNoTxts = transName + transactionNolbl.Text
            End If

            Explenationtxt.Text = Explenationtxt.Text + " " + transactionNolbl.Text + " " + TransactCmb.Text + " بقيمة  " + TotalValueTxt.Text

        Else
            If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then
                If (Paiedtxt.Text = 0) Then
                    transName = ClientAR_AP

                    If isSearch Then
                        fatoraNoTxts = transactionNolbl.Text
                    Else
                        fatoraNoTxts = transName + transactionNolbl.Text
                    End If
                Else
                    transName = "C" + ClientAR_AP
                    If isSearch Then
                        fatoraNoTxts = transactionNolbl.Text
                    Else
                        fatoraNoTxts = transName + transactionNolbl.Text
                    End If
                End If
            Else
                transName = "C"
                If isSearch Then
                    fatoraNoTxts = transactionNolbl.Text
                Else
                    fatoraNoTxts = transName + transactionNolbl.Text
                End If
            End If

        End If

    End Sub
    Private Sub setExplinationtxt()
        If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then
            If (Paiedtxt.Text = 0) Then
                TransactCmb.SelectedIndex = 2
                Explenationtxt.Text = Explenationtxt.Text + " " + transactionNolbl.Text + "  اجل  بقيمة  " + TotalValueTxt.Text

            Else
                TransactCmb.SelectedIndex = 1
                Explenationtxt.Text = Explenationtxt.Text + " " + transactionNolbl.Text + "   اجل مدفوع مقدما نقد  بقيمة  " + Paiedtxt.Text + "والاجل بقيمة" + StealTxt.Text

            End If
        Else
            TransactCmb.SelectedIndex = 0
            Explenationtxt.Text = Explenationtxt.Text + " " + transactionNolbl.Text + " " + TransactCmb.Text + " بقيمة  " + TotalValueTxt.Text

        End If
        Select Case loadcases

            Case loadCase.sale
                Explenationtxt.Text += "   من"


            Case loadCase.rsale
                Explenationtxt.Text += " من  "

            Case loadCase.pay
                Explenationtxt.Text += " الى"

            Case loadCase.rpay
                Explenationtxt.Text += " الى"
        End Select
        Explenationtxt.Text += " " + NameCtxt.Text
    End Sub
    Private Sub PaidCash()


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

    Private Sub Save_client()
        'اجل بدون مدفوع مقدم
        Dim Val As Single = TotalValueTxt.Text - Paiedtxt.Text
        If loadcases = loadCase.rsale Or loadcases = loadCase.rpay Then
            Val = -Val
        End If

        TransactCmb.SelectedIndex = 2
        transName = ClientAR_AP
        NameCtxt.Focus()
        If namec = "" Then Exit Sub
        If isSearch Then
            fatoraNoTxts = transactionNolbl.Text
            myClientAcc.Contronls(2) = Nothing
            myClientAcc.FieldValue(2) = fatoraNoTxts
        Else
            fatoraNoTxts = transName + transactionNolbl.Text
            myClientAcc.Contronls(2) = Nothing
            myClientAcc.FieldValue(2) = fatoraNoTxts
        End If
        myClientAcc.FieldValue(5) = Val
        StealTxt.Text = TotalValueTxt.Text - Paiedtxt.Text
        If issale Then
            myClientAcc.FieldValue(0) = myProjectWork.Client
        Else
            myClientAcc.FieldValue(0) = myProjectWork.Moarid
        End If
        myClientAcc.FieldValue(6) += TransactCmb.Text
        myClientAcc.FieldValue(3) = MatueDateBeker.Value
        myClientAcc.insert()
        myClientAcc.SaveInsert(False)
    End Sub
    Private Sub Save_ClientPaidCase()
        'SetNewFatorano()
        transName = "C" + ClientAR_AP

        If isSearch Then
            fatoraNoTxts = transactionNolbl.Text
        Else
            fatoraNoTxts = transName + transactionNolbl.Text

        End If

        transName = ClientAR_AP
        NameCtxt.Focus()
        If namec = "" Then Exit Sub
        Dim I As FieldMombers()
        I = myClientAcc.TableCuloms 'تجربه واختبار 

           TransactCmb.SelectedIndex = 1
          myClientAcc.Contronls(2) = Nothing
        myClientAcc.FieldValue(2) = fatoraNoTxts
        'عشان يكتب نوع المعامل 
        If issale Then
            myClientAcc.FieldValue(0) = myProjectWork.Client
        Else
            myClientAcc.FieldValue(0) = myProjectWork.Moarid
        End If
        myClientAcc.FieldValue(6) += TransactCmb.Text

        myClientAcc.FieldValue(5) = steel
        StealTxt.Text = TotalValueTxt.Text - Paiedtxt.Text
        myClientAcc.FieldValue(3) = MatueDateBeker.Value
       
        PaidCash()

        
       

        myClientAcc.insert()
        myClientAcc.SaveInsert(False)

    End Sub
    Private Sub SaveCash()
       
    End Sub
    Private Sub SaveFatora()
        'On Error Resume Next
        issaveing = True
        If isSearch Then
            msgbox("لا يجوز التعديل على الفاتوره")
            isSearch = True
            Exit Sub
        End If
        '
        Dim steal As Single
        If (CSng(Paiedtxt.Text) < CSng(TotalValueTxt.Text)) Then ' المدفوع اقل من القيمة

            steal = (CSng(Paiedtxt.Text) - CSng(TotalValueTxt.Text))
            StealTxt.Text = steal
            If isCash Then
                msgbox("المبلغ المدفوع اقل من قيمة الفاتورة")
                Exit Sub
            Else
                SetMeCasher(True)
                steal = CSng(StealTxt.Text) * -1
                If Paiedtxt.Text = 0 Then
                    LoadClientAcc(loadcases)
                    Save_client() ' اجل بدون مقدم
                Else
                    LoadClientAcc(loadcases)
                    Save_ClientPaidCase() 'اجل مدفوع مقدما

                End If
                If namec = "" Then Exit Sub
                StealTxt.Text = (CSng(Paiedtxt.Text) - CSng(TotalValueTxt.Text))

                transName = "C"
                If isSearch Then
                    fatoraNoTxts = transactionNolbl.Text

                Else
                    fatoraNoTxts = transName + transactionNolbl.Text

                End If

            End If
        Else 'حالة ان المدفوع اكبر من القيمة
        
            If autoFatorano Then
                DocumentNotxt.Text = transactionNolbl.Text
                DocumentNotxt.ReadOnly = True
            End If

            myCashFlow.FieldValue(1) = fatoraNoTxts


            myCashFlow.insert()
            myCashFlow.Save(False)
        End If
        NameCtxt.Text = namec
       
        setExplinationtxt()


            myDocNO.Save(False)

            myStockMoveDatac.Save(False)
        
        print()

            myStockMoveDatac.DataFilter("FatoraNo = '" + transactionNolbl.Text + "'")

            SetNewFatorano()
            transactionNolbl.Text = fatoraNoTxts
       

            Dim ic As Integer = SalePayMovementDataGridView.RowCount - 1
            Dim i As Integer = 0
        If autoFatorano Then
            DocumentNotxt.Text = transactionNolbl.Text
        Else

        End If
        StealTxt.Text = steal
            ' اعادة ادخال لبيانات في دفتر المخزن
            For i = 0 To ic
            SalePayMovementDataGridView.Item(1, i).Value = DocumentNotxt.Text
                SalePayMovementDataGridView.Item(5, i).Value = TransactCmb.Text
                SalePayMovementDataGridView.Item(9, i).Value = NameCtxt.Text
            SalePayMovementDataGridView.Item(10, i).Value = transactionNolbl.Text

                myStockMoveDatac.Edet()
                FatoraNo = 0
            Next

            myStockMoveDatac.SaveEdite()
        ''
      

            Sums = 0
            TotalValueTxt.Text = 0
            Paiedtxt.Text = ""
            Qlbl.Text = 0
        StealTxt.Clear()
        TransactionDataEnter(loadcases)
        SetMeCasher(False)
        isSearch = False
        issaveing = False
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
        If autoFatorano Then
            DocumentNotxt.Text = transactionNolbl.Text
            DocumentNotxt.ReadOnly = True
        End If
        isSearch = True
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
            TransactCmb.Enabled = True
        Else
            TransactCmb.Enabled = False
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
        inv.SetHeaders(OrgnizationName, Format(Date.Now.Date, "dd/MM/yyyy"), DataEntertxt.Text, transactionNolbl.Text)
        inv.SetBodyArea(SalePayMovementDataGridView, 0, 6, 7, 8)
        inv.SetFooters(TotalValueTxt.Text, Paiedtxt.Text, StealTxt.Text)
        If isShoprint Then
            Dim pDocDailoge As New PrintPreviewDialog
            pDocDailoge.Document = inv.MyInvoice
            pDocDailoge.ShowDialog()
            pDocDailoge.Close()
        Else
            inv.MyInvoice.Print()
        End If
    

    End Sub
   

   
     
    Private Function getNamec() As String
        If issale Then
            Return myProjectWork.Client
        Else
            Return myProjectWork.Moarid

        End If
    End Function

    Private Sub NameCtxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameCtxt.Enter

        Dim c As New smallQfrm
        c.snf = False
        If issale Then
            c.isclient = True
        Else
            c.isclient = False
        End If
        c.ShowDialog()
        NameCtxt.Text = c.Quima
        namec = c.Quima
        If namec = "" Then Paiedtxt.Focus() : Exit Sub
        c.Close()
        MatueDateBeker.Value = DateAdd(DateInterval.Month, matueDate, Now)
        If Me.usmatudate Then
            Dim datechose As New DataChoseFrm
            datechose.ChosedDate = DateAdd(DateInterval.Month, matueDate, Now)
            MatueDateBeker.Value = datechose.GetChosedDate()

        Else
            Paiedtxt.Focus()
        End If

    End Sub

    Private Sub NameCtxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameCtxt.Leave
        If NameCtxt.Text = "" Then
            namec = getNamec()
        Else
            namec = NameCtxt.Text
        End If

    End Sub

 

    Private Sub TransactCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactCmb.SelectedIndexChanged
        transName = TransactCmb.Text
        Select Case TransactCmb.SelectedIndex
            Case 0
                Paiedtxt.Text = TotalValueTxt.Text
            Case 1
                If Not issaveing Then
                    Paiedtxt.Text = CSng(TotalValueTxt.Text) - 1
                End If
            Case 2
                Paiedtxt.Text = 0

        End Select
        Paiedtxt.Focus()
    End Sub

    Private Sub Label9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.LightYellow
    End Sub

    Private Sub Label9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseMove
        Label9.ForeColor = Color.Red
    End Sub

    Private Sub menuBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBtn.Click
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
            Return mystockDatac.FieldValue(3)
        Else
            PsaleLabel.Text = "سعر التجزئة"
            Return mystockDatac.FieldValue(4)
        End If
    End Function
    
    Private Sub T_button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        If Qtxt.Text = "" Then Exit Sub
        AddNewSanf()
    End Sub

    Private Sub T_button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        If Paiedtxt.Text = "" Then Exit Sub
        If isAllawlecin Then
            SaveFatora()
        Else
            msgbox("الرجاء مراجعة الدعم الفني")
        End If
    End Sub

    Private Sub SalePayMovementDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellContentClick

    End Sub

    Private Sub T_button5_Click_2(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub CpPanal_Leave(sender As Object, e As EventArgs) Handles CpPanal.Leave
        CpPanal.Visible = False
    End Sub

    Private Sub T_button5_Click_3(sender As Object, e As EventArgs) Handles WendowsTypebtn.Click

        If WendowsTypebtn.Checked Then
            SetMeCasher(True)
            WendowsTypebtn.me_text = "شاشة كاشير"
        Else
            SetMeCasher(False)
            WendowsTypebtn.me_text = "شاشة فاتوره"
        End If
    End Sub
    Private Sub unmajors()
        Qtxt.Text = projW.calculatMajor(un_major, Qtxt.Text, unMajlbl, Balancelbl.Text, False)
        Ptxt.Text = projW.calculatMajor(un_major, Ptxt.Text, unMajlbl, Balancelbl.Text, True)
        Qlbl.Text = projW.calculatMajor(un_major, Qlbl.Text, unMajlbl, Balancelbl.Text, False)
        'If lowSanf Then
        '    Qtxt.Text = projW.calculatMajor(un_major, Q, unMajlbl, False)
        '    Ptxt.Text = projW.calculatMajor(un_major, p, unMajlbl, Balancelbl.Text, True)
        '    Qlbl.Text = projW.calculatMajor(un_major, totalq, unMajlbl, Balancelbl.Text, False)

        'End If
    End Sub
    Private Sub unMajlbl_Click(sender As Object, e As EventArgs) Handles unMajlbl.Click
        unmajors()
    End Sub

 

   
 
    Private Sub Paiedtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paiedtxt.TextChanged

    End Sub

    Private Sub NameCtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCtxt.TextChanged

    End Sub
End Class

