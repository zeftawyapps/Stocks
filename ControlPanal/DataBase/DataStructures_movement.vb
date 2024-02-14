Module DataStructures_movment

    Public Structure DocNo
        Public ser As FieldMombers
        Public Sale As FieldMombers
        Public SaleReturn As FieldMombers
        Public Parchase As FieldMombers
        Public ParshaseReturn As FieldMombers
        Public AR As FieldMombers
        Public Ap As FieldMombers
        Public Expga As FieldMombers
        Public Rev As FieldMombers
        ' Table name and database Path 
        Public DocNoTabe As String
        Public DBPath As String
        Public DocNo_Fm As FieldMombers()
        Public Sub New(ByVal Dbpa As String)
            ser = New FieldMombers With {.Name = "ser", .iskey = True}
            Sale = New FieldMombers With {.Name = "Sale"}
            SaleReturn = New FieldMombers With {.Name = "SaleReturn"}
            Parchase = New FieldMombers With {.Name = "Parchase"}
            ParshaseReturn = New FieldMombers With {.Name = "ParshaseReturn"}
            AR = New FieldMombers With {.Name = "AR"}
            Ap = New FieldMombers With {.Name = "AP"}
            Expga = New FieldMombers With {.Name = "Exp"}
            Rev = New FieldMombers With {.Name = "Rev"}
            DocNoTabe = "DocNo"
            DBPath = Dbpa
        End Sub



    End Structure

    Public Structure CashFlow
        Public TransData As FieldMombers
        Public invNo As FieldMombers
        Public Dr As FieldMombers
        Public Cr As FieldMombers
        Public DataEntery As FieldMombers
        Public RecOrPay As FieldMombers
        Public CashOrBank As FieldMombers
        Public DrAcc As FieldMombers
        Public CrAcc As FieldMombers
        Public Explanation As FieldMombers
        Public ser As FieldMombers
        Public transNo As FieldMombers
        ' Table name and database Path 
        Public CashFlowTabe As String
        Public DBPath As String
        Public Cashflow_Fm As FieldMombers()
        Public Sub New(ByVal Dbpa As String)

            TransData = New FieldMombers With {.Name = "TransData"}
            invNo = New FieldMombers With {.Name = "invNo"}
            Dr = New FieldMombers With {.Name = "dr"}
            Cr = New FieldMombers With {.Name = "cr"}
            DataEntery = New FieldMombers With {.Name = "DataEntery"}
            RecOrPay = New FieldMombers With {.Name = "RecOrPay"}
            CashOrBank = New FieldMombers With {.Name = "CashOrBank", .isWanted = True}
            CrAcc = New FieldMombers With {.Name = "CrAcc"}
            DrAcc = New FieldMombers With {.Name = "DrAcc"}
            Explanation = New FieldMombers With {.Name = "Explanation"}
            transNo = New FieldMombers With {.Name = "transNo"}
            ser = New FieldMombers With {.Name = "ser", .iskey = True}
            CashFlowTabe = "CashFlow"
            DBPath = Dbpa
        End Sub
        Public Function load_fm() As FieldMombers()
            Cashflow_Fm = {TransData, invNo, Dr, Cr, DataEntery, RecOrPay _
                           , CashOrBank, DrAcc, CrAcc, Explanation, transNo, ser}

            Return {TransData, invNo, Dr, Cr, DataEntery, RecOrPay _
                           , CashOrBank, DrAcc, CrAcc, Explanation, transNo, ser}

        End Function
    End Structure
  
    
    Public Structure SaleMove

        Public m_sandf As FieldMombers

        Public FatoraNo As FieldMombers
        Public m_code As FieldMombers
        Public DataEntery As FieldMombers
        Public trDate As FieldMombers
        Public cashc As FieldMombers
        Public m_QBB As FieldMombers
        Public PBB As FieldMombers
        Public qpbb As FieldMombers
        '
        Public Qsale As FieldMombers
        Public Psale As FieldMombers
        Public Qpsale As FieldMombers

        Public Qpay As FieldMombers
        Public pPay As FieldMombers
        Public QPPay As FieldMombers

        Public QrturnSale As FieldMombers
        Public PreturnSale As FieldMombers
        Public TotalRetarnSale As FieldMombers

        Public QrturnPay As FieldMombers
        Public PreturnPay As FieldMombers
        Public TotalRetarnpay As FieldMombers
        Public moveSer As FieldMombers
        Public NameC As FieldMombers
        Public transNo As FieldMombers
        Public SaleMove_Table As String
        Public SaleMove_FM As FieldMombers()

        Public Sub New(ByVal data As String)
            ' المبيعات و المشتريات  
            m_sandf = New FieldMombers With {.IDF = 0, .Name = "sandf", .Caption = "الاصناف", .isWanted = False, .visable = False}
            FatoraNo = New FieldMombers With {.IDF = 1, .Name = "FatoraNo", .Caption = "رقم الفاتورة", .isWanted = False, .visable = False}
            m_code = New FieldMombers With {.IDF = 2, .Name = "code", .Caption = "الكود", .isWanted = False, .visable = False}
            DataEntery = New FieldMombers With {.IDF = 3, .Name = "DataEntery", .Caption = "مدخل البيانات", .isWanted = False, .visable = False}
            trDate = New FieldMombers With {.IDF = 4, .Name = "DataTr", .Caption = "التاريخ", .isWanted = False, .visable = False}
            cashc = New FieldMombers With {.IDF = 5, .Name = "CashCr", .Caption = "كاش ام اجل", .isWanted = False, .visable = False}
            NameC = New FieldMombers With {.Name = "NameC"}
            '
            m_QBB = New FieldMombers With {.IDF = 6, .Name = "QBB", .Caption = "كمية اول المدة", .isWanted = False, .visable = False}
            PBB = New FieldMombers With {.IDF = 7, .Name = "PBB", .Caption = "سعر اول المدة", .isWanted = False, .visable = False}
            qpbb = New FieldMombers With {.IDF = 8, .Name = "QPbb", .Caption = "اجمالي اول المدة", .isWanted = False, .visable = False}
            '
            Qsale = New FieldMombers With {.IDF = 9, .Name = "Qsale", .Caption = "كمية البيع", .isWanted = False, .visable = False}
            Psale = New FieldMombers With {.IDF = 10, .Name = "Psale", .Caption = "سعر البيع", .isWanted = False, .visable = False}
            Qpsale = New FieldMombers With {.IDF = 11, .Name = "Qpsale", .Caption = "اجمالي البيع", .isWanted = False, .visable = False}
            '
            Qpay = New FieldMombers With {.IDF = 12, .Name = "Qpay", .Caption = "كمية الشراء", .isWanted = False, .visable = False}
            pPay = New FieldMombers With {.IDF = 13, .Name = "pPay", .Caption = "سعر الشراء", .isWanted = False, .visable = False}
            QPPay = New FieldMombers With {.IDF = 14, .Name = "QPPay", .Caption = "مجمل الشراء", .isWanted = False, .visable = False}
            '
            QrturnSale = New FieldMombers With {.IDF = 15, .Name = "QrturnSale", .Caption = "كمية مرتجع البيع", .isWanted = False, .visable = False}
            PreturnSale = New FieldMombers With {.IDF = 16, .Name = "PreturnSale", .Caption = "سعر مرتجع البيع", .isWanted = False, .visable = False}
            TotalRetarnSale = New FieldMombers With {.IDF = 17, .Name = "TotalRetarnSale", .Caption = "مجمل مرتجع البيع", .isWanted = False, .visable = False}
            '
            QrturnPay = New FieldMombers With {.IDF = 18, .Name = "QrturnPay", .Caption = "كمية مرتجع الشراء", .isWanted = False, .visable = False}
            PreturnPay = New FieldMombers With {.IDF = 19, .Name = "PreturnPay", .Caption = "سعر مرتجع الشراء", .isWanted = False, .visable = False}
            TotalRetarnpay = New FieldMombers With {.IDF = 20, .Name = "TotalRetarnpay", .Caption = "محمل مرتجع الشراء", .isWanted = False, .visable = False}
            transNo = New FieldMombers With {.IDF = 21, .Name = "transNo"}
            '
            moveSer = New FieldMombers With {.IDF = 22, .Name = "ser", .visable = False}
            SaleMove_Table = "SalePayMovement"
        End Sub

        Public Sub load()
            ' المبيعات و المشتريات  
            m_sandf = New FieldMombers With {.IDF = 0, .Name = "sandf", .Caption = "الاصناف", .isWanted = False, .visable = False}
            FatoraNo = New FieldMombers With {.IDF = 1, .Name = "FatoraNo", .Caption = "رقم الفاتورة", .isWanted = False, .visable = False}
            m_code = New FieldMombers With {.IDF = 2, .Name = "code", .Caption = "الكود", .isWanted = False, .visable = False}
            DataEntery = New FieldMombers With {.IDF = 3, .Name = "DataEntery", .Caption = "مدخل البيانات", .isWanted = False, .visable = False}
            trDate = New FieldMombers With {.IDF = 4, .Name = "DataTr", .Caption = "التاريخ", .isWanted = False, .visable = False}
            cashc = New FieldMombers With {.IDF = 5, .Name = "CashCr", .Caption = "كاش ام اجل", .isWanted = False, .visable = False}
            '
            m_QBB = New FieldMombers With {.IDF = 6, .Name = "QBB", .Caption = "كمية اول المدة", .isWanted = False, .visable = False}
            PBB = New FieldMombers With {.IDF = 7, .Name = "PBB", .Caption = "سعر اول المدة", .isWanted = False, .visable = False}
            qpbb = New FieldMombers With {.IDF = 8, .Name = "QPbb", .Caption = "اجمالي اول المدة", .isWanted = False, .visable = False}
            '
            Qsale = New FieldMombers With {.IDF = 9, .Name = "Qsale", .Caption = "كمية البيع", .isWanted = False, .visable = False}
            Psale = New FieldMombers With {.IDF = 10, .Name = "Psale", .Caption = "سعر البيع", .isWanted = False, .visable = False}
            Qpsale = New FieldMombers With {.IDF = 11, .Name = "Qpsale", .Caption = "اجمالي البيع", .isWanted = False, .visable = False}
            '
            Qpay = New FieldMombers With {.IDF = 12, .Name = "Qpay", .Caption = "كمية الشراء", .isWanted = False, .visable = False}
            pPay = New FieldMombers With {.IDF = 13, .Name = "pPay", .Caption = "سعر الشراء", .isWanted = False, .visable = False}
            QPPay = New FieldMombers With {.IDF = 14, .Name = "QPPay", .Caption = "مجمل الشراء", .isWanted = False, .visable = False}
            '
            QrturnSale = New FieldMombers With {.IDF = 15, .Name = "QrturnSale", .Caption = "كمية مرتجع البيع", .isWanted = False, .visable = False}
            PreturnSale = New FieldMombers With {.IDF = 16, .Name = "PreturnSale", .Caption = "سعر مرتجع البيع", .isWanted = False, .visable = False}
            TotalRetarnSale = New FieldMombers With {.IDF = 17, .Name = "TotalRetarnSale", .Caption = "مجمل مرتجع البيع", .isWanted = False, .visable = False}
            '
            QrturnPay = New FieldMombers With {.IDF = 18, .Name = "QrturnPay", .Caption = "كمية مرتجع الشراء", .isWanted = False, .visable = False}
            PreturnPay = New FieldMombers With {.IDF = 19, .Name = "PreturnPay", .Caption = "سعر مرتجع الشراء", .isWanted = False, .visable = False}
            TotalRetarnpay = New FieldMombers With {.IDF = 20, .Name = "TotalRetarnpay", .Caption = "محمل مرتجع الشراء", .isWanted = False, .visable = False}
            transNo = New FieldMombers With {.Name = "transNo"}
            '
            moveSer = New FieldMombers With {.IDF = 21, .Name = "ser", .visable = False}
            SaleMove_Table = "SalePayMovement"
        End Sub
    End Structure

    Public Structure CleintAcc
        Public ser As FieldMombers
        Public Namec As FieldMombers
        Public CleintSupp As FieldMombers
        Public Dr As FieldMombers
        Public Cr As FieldMombers
        Public FatoraNo As FieldMombers
        Public DataEnter As FieldMombers
        Public Account As FieldMombers
        Public transdate As FieldMombers
        Public transNo As FieldMombers
        Public DateSdad As FieldMombers
        Public matDate As FieldMombers
        '
        Public CleintAccTabe As String
        Public DBPath As String
        Public CleintAcc_Fm As FieldMombers()

        Public Sub load()
            Namec = New FieldMombers With {.Name = "Namec", .Caption = "الاسم"}
            CleintSupp = New FieldMombers With {.Name = "CleintSupp", .Caption = "عميل ام مورد"}
            Dr = New FieldMombers With {.Name = "Dr", .Caption = "القمية"}
            Cr = New FieldMombers With {.Name = "Cr", .Caption = "القيمة"}
            FatoraNo = New FieldMombers With {.Name = "FatoraNo", .Caption = "رقم الفاتورة"}
            DataEnter = New FieldMombers With {.Name = "DataEnter", .Caption = "المدخل"}
            Account = New FieldMombers With {.Name = "Account", .Caption = "اسم الحساب"}
            transdate = New FieldMombers With {.Name = "transdate", .Caption = "تاريخ المعاملة"}
            transNo = New FieldMombers With {.Name = "transNo"}
            ser = New FieldMombers With {.Name = "ser", .iskey = True}
            matDate = New FieldMombers With {.Name = "matDate", .Caption = "تاريخ الاستحقاق"}
            DateSdad = New FieldMombers With {.Name = "DateSdad", .Caption = "تاريخ السداد"}

            CleintAccTabe = "CleintAcc"

            CleintAcc_Fm = load_FM()
        End Sub
        Public Function load_FM() As FieldMombers()
            CleintAcc_Fm = {CleintSupp, Namec, FatoraNo, matDate, Dr, Cr, DataEnter _
                          , Account, transdate, transNo, DateSdad, ser}

            Return {CleintSupp, Namec, FatoraNo, matDate, Dr, Cr, DataEnter _
                          , Account, transdate, transNo, DateSdad, ser}

        End Function

    End Structure


    Public Structure RebExpensseTable
        Public ser As FieldMombers
        Public Account As FieldMombers
        Public proAcc As FieldMombers
        Public dr As FieldMombers
        Public cr As FieldMombers
        Public datae As FieldMombers
        Public Decoment As FieldMombers
        Public cashCr As FieldMombers
        Public dataentery As FieldMombers
        Public transNo As FieldMombers

        '
        Public RebExpensseTable As String
        Public DBPath As String
        Public RebExpensseTable_Fm As FieldMombers()

        Public Sub load()
            ser = New FieldMombers With {.Name = "ser"}
            Account = New FieldMombers With {.Name = "Account"}
            proAcc = New FieldMombers With {.Name = "proAcc"}
            dr = New FieldMombers With {.Name = "dr"}
            cr = New FieldMombers With {.Name = "cr"}
            datae = New FieldMombers With {.Name = "datae"}
            Decoment = New FieldMombers With {.Name = "Decoment"}
            cashCr = New FieldMombers With {.Name = "cashCr"}
            dataentery = New FieldMombers With {.Name = "dataentery"}
            transNo = New FieldMombers With {.Name = "transNo"}

            RebExpensseTable = "RebExpensseTable"
            RebExpensseTable_Fm = {ser, Account, proAcc, dr, cr _
                                 , datae, Decoment, cashCr, dataentery, transNo}
        End Sub
        Public Function load_FM() As FieldMombers()
            RebExpensseTable_Fm = {ser, Account, proAcc, dr, cr _
                                 , datae, Decoment, cashCr, dataentery, transNo}

            Return {ser, Account, proAcc, dr, cr _
                                 , datae, Decoment, cashCr, dataentery, transNo}

        End Function

    End Structure

End Module
