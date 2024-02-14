Public Class projectDataBase
    Friend dataConPath_MyData = "mydata.mdb"
    Friend Dataconpath = "Movement.mdb"
    Friend StockDatabookShop = "StockDataBookShops"
    Friend StockDataMarket = "StockDataMarket"
    Friend stockData
    Friend stockMoveTable = "SalePayMovement"

    Friend StockData_Datac, StockMove_datac As New OLEdatabaseCodeing
    Friend StockMove_FieldMember As FieldMombers()
    Friend StockDataField As FieldMombers()
    Friend DocNo As DocNo
    Friend cashFlow As CashFlow
    Friend Salemove As SaleMove
    Friend StockData_BookShope As New StockDataBookShops
    Friend StockData_Shope As New StockDataShops




    Friend Sub LoadStockData()

        'بيانات الجدول
        Dim stock As New StockDataBookShopsFrm
        Dim ser = New FieldMombers With {.Name = "ser", .iskey = True}
        Dim sanf = New FieldMombers With {.Name = "sanf"}
        Dim Code = New FieldMombers With {.Name = "Code"}
        Dim mark As New FieldMombers With {.Name = "mark"}
        Dim mainSanf As New FieldMombers With {.Name = "main_sanf"}
        Dim ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
        Dim jom_price = New FieldMombers With {.Name = "jom_price"}
        Dim qut_price = New FieldMombers With {.Name = "qut_price"}
        Dim AtLeast As New FieldMombers With {.Name = "AtLeast"}
        Dim isLow As New FieldMombers With {.Name = "isLow"}
        Dim major_unit As New FieldMombers With {.Name = "major_unit"}
        Dim Balances = New FieldMombers With {.Name = "Balance"}

        StockDataField = {ser, sanf, Code, ParchasePrice, jom_price, _
                                          qut_price, mainSanf, mark, AtLeast, isLow, major_unit, Balances}

    End Sub
    

    Friend Sub loadWelcome()
        Select Case Contorlpanal.StockType
            Case StockType.BookShop
                Contorlpanal.WelcomeProgramName = "Z-Book Shope"
            Case StockType.Casher
                Contorlpanal.WelcomeProgramName = "Z-Market"
            Case StockType.Shope
                Contorlpanal.WelcomeProgramName = "Z-shope"
        End Select
    End Sub
    Friend Sub LoadStockmove()
        ' المبيعات و المشتريات  
        Dim m_sandf = New FieldMombers With {.IDF = 0, .Name = "sandf", .Caption = "الاصناف", .isWanted = False, .visable = False}
        Dim FatoraNo = New FieldMombers With {.IDF = 1, .Name = "FatoraNo", .Caption = "رقم الفاتورة", .isWanted = False, .visable = False}
        Dim m_code = New FieldMombers With {.IDF = 2, .Name = "code", .Caption = "الكود", .isWanted = False, .visable = False}
        Dim DataEntery As New FieldMombers With {.IDF = 3, .Name = "DataEntery", .Caption = "مدخل البيانات", .isWanted = False, .visable = False}
        Dim trDate As New FieldMombers With {.IDF = 4, .Name = "DataTr", .Caption = "التاريخ", .isWanted = False, .visable = False}
        Dim cashc = New FieldMombers With {.IDF = 5, .Name = "CashCr", .Caption = "كاش ام اجل", .isWanted = False, .visable = False}
               '
        Dim m_QBB = New FieldMombers With {.IDF = 6, .Name = "QBB", .Caption = "كمية اول المدة", .isWanted = False, .visable = False}
        Dim PBB = New FieldMombers With {.IDF = 7, .Name = "PBB", .Caption = "سعر اول المدة", .isWanted = False, .visable = False}
        Dim qpbb = New FieldMombers With {.IDF = 8, .Name = "QPbb", .Caption = "اجمالي اول المدة", .isWanted = False, .visable = False}
        '
        Dim Qsale As New FieldMombers With {.IDF = 9, .Name = "Qsale", .Caption = "كمية البيع", .isWanted = False, .visable = False}
        Dim Psale As New FieldMombers With {.IDF = 10, .Name = "Psale", .Caption = "سعر البيع", .isWanted = False, .visable = False}
        Dim Qpsale As New FieldMombers With {.IDF = 11, .Name = "Qpsale", .Caption = "اجمالي البيع", .isWanted = False, .visable = False}
        '
        Dim Qpay As New FieldMombers With {.IDF = 12, .Name = "Qpay", .Caption = "كمية الشراء", .isWanted = False, .visable = False}
        Dim pPay As New FieldMombers With {.IDF = 13, .Name = "pPay", .Caption = "سعر الشراء", .isWanted = False, .visable = False}
        Dim QPPay As New FieldMombers With {.IDF = 14, .Name = "QPPay", .Caption = "مجمل الشراء", .isWanted = False, .visable = False}
        '
        Dim QrturnSale As New FieldMombers With {.IDF = 15, .Name = "QrturnSale", .Caption = "كمية مرتجع البيع", .isWanted = False, .visable = False}
        Dim PreturnSale As New FieldMombers With {.IDF = 16, .Name = "PreturnSale", .Caption = "سعر مرتجع البيع", .isWanted = False, .visable = False}
        Dim TotalRetarnSale As New FieldMombers With {.IDF = 17, .Name = "TotalRetarnSale", .Caption = "مجمل مرتجع البيع", .isWanted = False, .visable = False}
        '
        Dim QrturnPay As New FieldMombers With {.IDF = 18, .Name = "QrturnPay", .Caption = "كمية مرتجع الشراء", .isWanted = False, .visable = False}
        Dim PreturnPay As New FieldMombers With {.IDF = 19, .Name = "PreturnPay", .Caption = "سعر مرتجع الشراء", .isWanted = False, .visable = False}
        Dim TotalRetarnpay As New FieldMombers With {.IDF = 20, .Name = "TotalRetarnpay", .Caption = "محمل مرتجع الشراء", .isWanted = False, .visable = False}

        Dim NameC = New FieldMombers With {.IDF = 21, .Name = "NameC", .Caption = "اسم العميل"}
        Dim transNo = New FieldMombers With {.IDF = 22, .Name = "transNo"}

        '
        Dim moveSer = New FieldMombers With {.IDF = 23, .Name = "ser", .visable = False, .iskey = True}

        StockMove_FieldMember = {m_sandf, FatoraNo, m_code, DataEntery, trDate, cashc, m_QBB, PBB, qpbb, Qsale, Psale, Qpsale, Qpay, pPay, QPPay, QrturnSale, PreturnSale, TotalRetarnSale, _
                                        QrturnPay, PreturnPay, TotalRetarnpay, NameC, transNo, moveSer}

        DocNo = New DocNo(Dataconpath)
        DocNo.DocNo_Fm = {DocNo.Sale, DocNo.SaleReturn, DocNo.Parchase, DocNo.ParshaseReturn, DocNo.ser}
        cashFlow = New CashFlow(Dataconpath)
        cashFlow.Cashflow_Fm = {cashFlow.TransData, cashFlow.invNo, cashFlow.Dr, cashFlow.DataEntery}
    End Sub
     
    Friend Sub LoadQuery()

        Salemove = New SaleMove(Dataconpath)
        Salemove.SaleMove_FM = {Salemove.m_sandf, Salemove.FatoraNo, Salemove.m_code, Salemove.DataEntery, Salemove.trDate, Salemove.cashc, Salemove.m_QBB, Salemove.PBB, Salemove.qpbb, Salemove.Qsale, Salemove.Psale, Salemove.Qpsale, Salemove.Qpay, Salemove.pPay, Salemove.QPPay, Salemove.QrturnSale, Salemove.PreturnSale, Salemove.TotalRetarnSale, _
                                Salemove.QrturnPay, Salemove.PreturnPay, Salemove.TotalRetarnpay, Salemove.moveSer}

    End Sub
    Friend Sub LoadSimplQuery_StockDataBookShop()
        StockData_BookShope.ser = New FieldMombers With {.Name = "ser"}
        StockData_BookShope.Code = New FieldMombers With {.Name = "Code", .Caption = "الكود", .dgvVisalbe = True}
        StockData_BookShope.sanf = New FieldMombers With {.Name = "sanf", .Caption = "الصنف", .dgvVisalbe = True}
        StockData_BookShope.bookName = New FieldMombers With {.Name = "BookName", .Caption = "اسم الكتاب", .dgvVisalbe = True}
        StockData_BookShope.ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
        StockData_BookShope.jom_price = New FieldMombers With {.Name = "jom_price"}
        StockData_BookShope.qut_price = New FieldMombers With {.Name = "qut_price"}
        StockData_BookShope.StockDataBookShope_Fm = {StockData_BookShope.Code, StockData_BookShope.sanf _
                                                 , StockData_BookShope.ParchasePrice, StockData_BookShope.jom_price, StockData_BookShope.qut_price, StockData_BookShope.ser}

    End Sub
    Friend Sub LoadSimplQuery_StockDatsShope()
        StockData_Shope.ser = New FieldMombers With {.Name = "ser"}
        StockData_Shope.Code = New FieldMombers With {.Name = "Code", .Caption = "الكود", .dgvVisalbe = True}
        StockData_Shope.sanf = New FieldMombers With {.Name = "sanf", .Caption = "الصنف", .dgvVisalbe = True}
        StockData_Shope.AdditionalData = New FieldMombers With {.Name = "AdditionalData", .Caption = "مواصفات اخرى"}
        StockData_Shope.ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
        StockData_Shope.jom_price = New FieldMombers With {.Name = "jom_price"}
        StockData_Shope.qut_price = New FieldMombers With {.Name = "qut_price"}
        StockData_Shope.mark = New FieldMombers With {.Name = "mark", .Caption = "الماركه"}
        StockData_Shope.parnck = New FieldMombers With {.Name = "parnck", .Caption = "الفرع"}

        StockData_Shope.StockDataShope_Fm = {StockData_Shope.Code, StockData_Shope.sanf _
                                                 , StockData_Shope.mark, StockData_Shope.parnck, StockData_Shope.ParchasePrice, StockData_Shope.jom_price, StockData_Shope.qut_price, StockData_Shope.ser}

    End Sub
    Friend Sub LoadAoutoEnter_StockDataBookShop()
        StockData_BookShope.ser = New FieldMombers With {.Name = "ser"}
        StockData_BookShope.Code = New FieldMombers With {.Name = "Code", .Caption = "الكود", .dgvVisalbe = True}
        StockData_BookShope.sanf = New FieldMombers With {.Name = "sanf", .Caption = "الصنف", .dgvVisalbe = True}
        StockData_BookShope.bookName = New FieldMombers With {.Name = "BookName", .Caption = "اسم الكتاب", .dgvVisalbe = True}
        StockData_BookShope.main_sanf = New FieldMombers With {.Name = "main_sanf", .Caption = "الصنف الاساسي", .dgvVisalbe = True}
        StockData_BookShope.moalef = New FieldMombers With {.Name = "moalef", .Caption = "المؤلف", .dgvVisalbe = True}
        StockData_BookShope.DarNashr = New FieldMombers With {.Name = "DarNashr", .Caption = "دار النشر", .dgvVisalbe = True}


        StockData_BookShope.ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
        StockData_BookShope.jom_price = New FieldMombers With {.Name = "jom_price"}
        StockData_BookShope.qut_price = New FieldMombers With {.Name = "qut_price"}
        StockData_BookShope.StockDataBookShope_Fm = {StockData_BookShope.Code, StockData_BookShope.sanf _
                                                 , StockData_BookShope.ParchasePrice, StockData_BookShope.jom_price, StockData_BookShope.qut_price, StockData_BookShope.ser}

    End Sub
    Friend Sub LoadAoutoEnter_StockDataShop()
        StockData_Shope.ser = New FieldMombers With {.Name = "ser"}
        StockData_Shope.Code = New FieldMombers With {.Name = "Code", .Caption = "الكود", .dgvVisalbe = True}
        StockData_Shope.sanf = New FieldMombers With {.Name = "sanf", .Caption = "الصنف", .dgvVisalbe = True}
        StockData_Shope.AdditionalData = New FieldMombers With {.Name = "AdditionalData", .Caption = "المواصفات", .dgvVisalbe = True}
        StockData_Shope.main_sanf = New FieldMombers With {.Name = "main_sanf", .Caption = "الصنف الاساسي", .dgvVisalbe = True}
        StockData_Shope.mark = New FieldMombers With {.Name = "mark", .Caption = "الماركه", .dgvVisalbe = True}
        StockData_Shope.parnck = New FieldMombers With {.Name = "parnck", .Caption = "الفرع", .dgvVisalbe = True}


        StockData_Shope.ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
        StockData_Shope.jom_price = New FieldMombers With {.Name = "jom_price"}
        StockData_Shope.qut_price = New FieldMombers With {.Name = "qut_price"}
        StockData_Shope.StockDataShope_Fm = {StockData_Shope.Code, StockData_Shope.sanf _
                                                 , StockData_Shope.ParchasePrice, StockData_Shope.jom_price, StockData_Shope.qut_price, StockData_Shope.ser}

    End Sub
End Class

Public Enum StockType
    Casher
    BookShop
    Shope
End Enum
Public Enum Unet_major
    unit
    dasta
    kg
    leter
End Enum