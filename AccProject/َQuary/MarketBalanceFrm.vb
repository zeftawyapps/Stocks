Imports ZeftawyTools
Public Class MarketBalanceFrm
    Inherits myformDesign
    Dim myDataR, mydatarDataEntery, myDataREfresh As New OLEdatabaseCodeing
    Dim proj As New projectDataBase
    Dim SaleData As SaleMove
    Dim dataEntery As LogeIn
    Private Sub MarketBalanceFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopleft)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        SaleData = New SaleMove("")
        myDataR.ConnectToDataBase(proj.Dataconpath)
        myDataR.DataGridveiw = DataGridView1
        '>>>
        Timer1.Interval = 1500
        Timer1.Enabled = True

        dataEntery.load()
        mydatarDataEntery.Load(proj.dataConPath_MyData, dataEntery.dataEnterTable, dataEntery.logine_Fm)

        mydatarDataEntery.showDatabyReaderTocombobox(ComboBox2, dataEntery.name.Name, dataEntery.dataEnterTable)
        ComboBox2.Items.Add("الكل")

    End Sub



    Private Delegate Function SelectQP() As String
    Dim Vals As Boolean
    Private Sub ShowDataInLablesVals()
        Try
            If Vals Then
                'Qpay
                QBBLbl.Text = DataGridView1.CurrentRow.Cells.Item("BB").Value
                QPaylbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.Qpay.Name).Value
                QRpaylbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.QrturnPay.Name).Value
                QnetPaylbl1.Text = CInt(QPaylbl.Text) - CInt(QRpaylbl.Text)
                Qgasbl.Text = DataGridView1.CurrentRow.Cells.Item("GAForSaleQ").Value
                Qagsbl1.Text = Qgasbl.Text
                'Qsale
                Qsalelbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.Qsale.Name).Value
                QrSalelbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.QrturnSale.Name).Value
                QnetSalelbl.Text = DataGridView1.CurrentRow.Cells.Item("NetQSate").Value
                QEBlbl.Text = DataGridView1.CurrentRow.Cells.Item("EBQ").Value
                'CPU
                CPUlbl.Text = DataGridView1.CurrentRow.Cells.Item("CostPerUnit").Value
                'PayVal
                ValBBlbl.Text = DataGridView1.CurrentRow.Cells.Item("vBB").Value
                ValPaylbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.QPPay.Name).Value
                ValrPaylbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.TotalRetarnpay.Name).Value
                ValNetPaylbl.Text = CSng(ValPaylbl.Text) - CSng(ValrPaylbl.Text)
                Valgaslbl.Text = DataGridView1.CurrentRow.Cells.Item("GAForSale").Value
                'SaleVal
                ValSalelbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.Qpsale.Name).Value
                ValrSalelbl.Text = DataGridView1.CurrentRow.Cells.Item(SaleData.TotalRetarnSale.Name).Value
                ValNetSalelbl.Text = CSng(ValSalelbl.Text) - CSng(ValrSalelbl.Text)
                CGSlbl.Text = DataGridView1.CurrentRow.Cells.Item("CGS").Value
                '
                GrosMarginelbl.Text = DataGridView1.CurrentRow.Cells.Item("GMarge").Value
            End If

        Catch ex As Exception
            msgbox("الرجاء اعادة المحاولة في البحث ")
            Refresh_Me()
            Refresh()
        End Try
          End Sub

    Private Function SelectDataEnteryAll() As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()


        Dim W, DE, SQl As String
        'myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "QS"), "QSale", "كمية البضاعة المباعة")
        'myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), "QrSale", "كمية مرتجع البيع")
        'myDataR.AddSelectSQL("( Qs - QrS ) as NetSale", "NetSate", "صافي المبيعات")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpsale.Name, "vS"), "VSale", "قيمة البضاعة المباعة")
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnSale.Name, "vrS"), "VrSale", "قيمة مرتجع البيع")
        myDataR.AddSelectSQL("( vs - VrS ) as NetSaleValue", "NetSate", "صافي المبيعات")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QPPay.Name, "vpa"), "Vpa", "قيمة البضاعة المشتراه")
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnpay.Name, "vrp"), "Vrpa", "قيمة مرتجع الشراء")
        SQl = myDataR.AddSelectSQL("( vpa - Vrp ) as NetPayValue", "NetPay", "صافي المشتريات")

        DE = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.DataEntery.Name, ComboBox2.Text)
        If ComboBox2.Text = "الكل" Then DE = ""
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)

        SQl = "Select" + SQl + " From " + SaleData.SaleMove_Table + " Where " + W + DE + " GROUP BY   year (" + SaleData.trDate.Name + ")  "
        Return SQl
    End Function

    Private Function SelectDataEnterySanf() As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()


        Dim W, DE, SQl As String
        myDataR.AddSelectSQL(SaleData.m_sandf.Name, "Sanf", "الاصناف")
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "QS"), "QSale", "كمية البضاعة المباعة")
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), "QrSale", "كمية مرتجع البيع")
        myDataR.AddSelectSQL("( Qs - QrS ) as NetSale", "NetSate", "صافي المبيعات")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpsale.Name, "vS"), "VSale", "قيمة البضاعة المباعة")
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnSale.Name, "vrS"), "VrSale", "قيمة مرتجع البيع")
        SQl = myDataR.AddSelectSQL("( vs - VrS ) as NetSaleValue", "NetSate", "صافي المبيعات")


        DE = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.DataEntery.Name, ComboBox2.Text)
        If ComboBox2.Text = "الكل" Then DE = ""
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)

        SQl = "Select" + SQl + " From " + SaleData.SaleMove_Table + " Where " + W + DE + " GROUP BY " + SaleData.m_sandf.Name + " , year (" + SaleData.trDate.Name + ")  "
        Return SQl
    End Function



    
    Private Overloads Function SelectSanf() As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()


        Dim W, DE, SQl, enf As String
        enf = myDataR.AddSelectSQL(SaleData.m_sandf.Name, "Sanf", "الاصناف")

        SQl = SQLVal()
        'DE = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.DataEntery.Name, ComboBox2.Text)
        'If ComboBox2.Text = "الكل" Then DE = ""
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)

        SQl = "Select" + enf + "," + SQl + " From " + SaleData.SaleMove_Table + " Where " + W + " GROUP BY " + SaleData.m_sandf.Name + " , year (" + SaleData.trDate.Name + ")  "
        Return SQl
    End Function


    Private Overloads Function SelectSanf(ByVal Sanfs As String) As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()


        Dim W, San, DE, SQl, enf As String
        enf = myDataR.AddSelectSQL(SaleData.m_sandf.Name, "Sanf", "الاصناف")

        SQl = SQLVal()
        'DE = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.DataEntery.Name, ComboBox2.Text)
        'If ComboBox2.Text = "الكل" Then DE = ""
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)
        San = myDataR.FeildWhere(feildtyp.strings, SaleData.m_code.Name, Sanfs)
        SQl = "Select " + SaleData.m_code.Name + " , " + enf + "," + SQl + " From " + SaleData.SaleMove_Table + " Where " + W + " And " + San + " GROUP BY " + SaleData.m_code.Name + " , " + SaleData.m_sandf.Name + " , year (" + SaleData.trDate.Name + ")  "
        Return SQl
    End Function

    Private Function SelectDataEnteryDetails() As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()


        Dim W, DE, SQls, Fat, se, sql As String
        'myDataR.AddSelectSQL("Format (" + SaleData.trDate.Name + ",'MM/dd/yyyy')", "Date", "التاريخ")
        'myDataR.AddSelectSQL(SaleData.trDate.Name, "Date", "التاريخ")

        myDataR.AddSelectSQL(SaleData.m_sandf.Name, "Sanf", "الاصناف")
        myDataR.AddSelectSQL(SaleData.FatoraNo.Name, "fatora", " الفاتورة")
        'تحديد نوع المعاملة 
        Select Case ComboBox3.SelectedIndex
            Case 1
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "QS"), "QSale", "كمية البضاعة المباعة")
                se = myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpsale.Name, "vS"), "VSale", "قيمة البضاعة المباعة")
            Case 2

                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), "QrSale", "كمية مرتجع البيع")
                se = myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnSale.Name, "vsr"), "VrSale", "قيمة  مرتجع البيع  ")

            Case 3

                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpay.Name, "QrS"), "QrSale", "كمية الشراء")
                se = myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QPPay.Name, "vrS"), "VrSale", "قيمة الشراء")

            Case 4
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "QrS"), "QrSale", "كمية  مرتجع الشراء")
                se = myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "vrS"), "VrSale", "قيمة مرتجع الشراء")

            Case 0
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "QS"), "QSale", "كمية البضاعة المباعة")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpsale.Name, "vS"), "VSale", "قيمة البضاعة المباعة")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), "QrSale", "كمية مرتجع البيع")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnSale.Name, "vsr"), "VrSale", "قيمة  مرتجع البيع  ")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpay.Name, "Qpa"), "Qp", "كمية الشراء")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QPPay.Name, "vpa"), "Vp", "قيمة الشراء")
                myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "Qpr"), "Qrp", "كمية  مرتجع الشراء")
                se = myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "vpr"), "Vrp", "قيمة مرتجع الشراء")

        End Select
        sql = se
        Fat = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.FatoraNo.Name, trans)

        DE = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.DataEntery.Name, ComboBox2.Text)
        If ComboBox2.Text = "الكل" Then DE = ""
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)

        SQls = "Select " + se + " From " + SaleData.SaleMove_Table + " Where " + W + DE + Fat + " GROUP BY " + SaleData.FatoraNo.Name + " , " + SaleData.m_sandf.Name + " , year (" + SaleData.trDate.Name + ")  "
        Return SQls

    End Function
    Private Function SelectDateOnly(ByVal se As SelectQP) As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()
        Dim SQp, W, SQl As String
        SQp = se.Invoke()
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)
        SQl = "Select" + SQp + " From " + SaleData.SaleMove_Table + " Where " + W + " GROUP BY " + SaleData.m_sandf.Name + " , year (" + SaleData.trDate.Name + ") "
        Return SQl
    End Function

    Private Function SelectDateWithDetials(ByVal se As SelectQP) As String

        myDataR.DataGridveiw.Columns.Clear()
        Dim SQp, W, SQl, main As String
        myDataR.ClearSQL()
        main = myDataR.AddSelectSQL(SaleData.trDate.Name, "Dates", "التاريخ")

        SQp = se.Invoke()
        W = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)
       
        SQl = "Select  " + SQp + " From " + SaleData.SaleMove_Table + " Where " + W + " GROUP BY " + SaleData.m_sandf.Name + "  ,  year (" + SaleData.trDate.Name + ") "
        Return SQl
    End Function
    Dim date1, date2 As Date
    Dim GroupDate As String = "year"
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sd As String
        Dim dm, dy As Double
        dm = Now.Month
        dy = Now.Year
        Select Case ComboBox1.SelectedIndex
            Case 0
                date1 = Now.Date
                date2 = DateAdd(DateInterval.Day, -1, date2)
                GroupDate = "year"
            Case 1
                date2 = Now.Date
                date1 = DateAdd(DateInterval.Day, -1, date2)
                GroupDate = "year"
            Case 2
                dm = Now.Month
                dy = Now.Year
                sd = Format("  01 /" + dm.ToString + "/" + dy.ToString + " ")
                date1 = CDate(sd)
                date2 = DateAdd(DateInterval.Month, 1, date1)
                GroupDate = "Day"

            Case 3
                If Now.Month > 1 Then
                    sd = Format("  01 / 01/" + dy.ToString + " ")
                    date1 = CDate(sd)
                    date2 = DateAdd(DateInterval.Month, 3, date1)
                    GroupDate = "month"
                Else
                    msgbox("نحن لسنا في الربع الاول", msgtype.oK)
                End If

            Case 4
                If Now.Month > 4 Then
                    sd = Format("  01 / 04/" + dy.ToString + " ")
                    date1 = CDate(sd)
                    date2 = DateAdd(DateInterval.Month, 3, date1)
                    GroupDate = "month"
                Else
                    msgbox("نحن لسنا في الربع الثاني", msgtype.oK)
                End If
            Case 5
                If Now.Month > 7 Then
                    sd = Format("  01 / 07/" + dy.ToString + " ")
                    date1 = CDate(sd)
                    date2 = DateAdd(DateInterval.Month, 3, date1)
                    GroupDate = "month"
                Else
                    msgbox("نحن لسنا في الربع الثالث", msgtype.oK)

                End If
            Case 6
                If Now.Month > 10 Then

                    sd = Format("  01 / 10/" + dy.ToString + " ")
                    date1 = CDate(sd)
                    date2 = DateAdd(DateInterval.Month, 3, date1)
                    GroupDate = "month"
                Else
                    msgbox("نحن لسنا في الربع الرابع", msgtype.oK)

                End If

            Case 7
                sd = Format("  01 / 01/" + dy.ToString + " ")
                date1 = CDate(sd)
                date2 = DateAdd(DateInterval.Year, 1, date1)
                GroupDate = "month"
            Case 8
                DateGrp.Visible = True
                date1 = D1Date.Value
                date2 = D1Date.Value
                GroupDate = "year"
        End Select
        D1Date.Value = date1
        D2Date.Value = date2
        SQLDate()
    End Sub
    Private Sub SQLDate()
        myDataR.ClearSQL()
        Dim s As String = SelectDateOnly(AddressOf SQLQ)
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)
        myDataR.DataGridveiw.Refresh()
    End Sub

    Private Function SQLQ() As String
        Dim s As String
        myDataR.ClearSQL()
        'myDataR.AddSelectSQL(" year ( " + SaleData.trDate.Name + ") ", "Dates", "التاريخ")
        myDataR.AddSelectSQL(SaleData.m_sandf.Name, "Sanf", SaleData.m_sandf.Caption)

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.m_QBB.Name, "QBBs"), "BB", SaleData.m_QBB.Caption)

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpay.Name, "Qps"), SaleData.Qpay.Name, SaleData.Qpay.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "QRps"), SaleData.QrturnPay.Name, SaleData.QrturnPay.Caption)

        myDataR.AddSelectSQL("( QBBs +([Qps]-[QRps])) as NetPay", "GAForSale", "البضاعة المعدة للبيع")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "Qs"), SaleData.Qsale.Name, SaleData.Qsale.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), SaleData.QrturnSale.Name, SaleData.QrturnSale.Caption)
        's = myDataR.AddSelectSQL("( IIF(isnull(Sum(" + SaleData.Qsale.Name + "-" + SaleData.QrturnSale.Name + ")),0,Sum(" + SaleData.Qsale.Name + "-" + SaleData.QrturnSale.Name + ")) ) as NetSale", "NetSale", "صافي المبيعات")
        myDataR.AddSelectSQL("( Qs- QrS ) as NetSale", "NetSate", "صافي المبيعات")

        s = myDataR.AddSelectSQL("(  [NetPay]-[NetSale]) as EB", "EntInventory", "المتبيقي من المخزن")
        Return s
        
    End Function

    Private Function SQLVal() As String
        Dim s As String
        myDataR.ClearSQL()
        'myDataR.AddSelectSQL(" year ( " + SaleData.trDate.Name + ") ", "Dates", "التاريخ")

      
     
     
        'Dim netpq As String = "sum(" + SaleData.m_QBB.Name + ")+(sum(" + SaleData.Qpay.Name + ")-sum(" + SaleData.QrturnPay.Name + "))"
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.m_QBB.Name, "QBBs"), "BB", SaleData.m_QBB.Caption)

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpay.Name, "Qps"), SaleData.Qpay.Name, SaleData.Qpay.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnPay.Name, "QRps"), SaleData.QrturnPay.Name, SaleData.QrturnPay.Caption)

        myDataR.AddSelectSQL("( QBBs +([Qps]-[QRps])) as NetqPay", "GAForSaleQ", "البضاعة المعدة للبيع كميات")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.qpbb.Name, "VBBs"), "vBB", SaleData.m_QBB.Caption)

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QPPay.Name, "Vps"), SaleData.QPPay.Name, SaleData.QPPay.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnpay.Name, "VRps"), SaleData.TotalRetarnpay.Name, SaleData.TotalRetarnpay.Caption)
        myDataR.AddSelectSQL("( VBBs +([Vps]-[VRps])) as NetPay", "GAForSale", "البضاعة المعدة للبيع")


        Dim cpu As String = " format((NetPay /  NetqPay),'##.00') "
        myDataR.AddSelectSQL("IIF(ISNull( " + cpu + ") ,0, " + cpu + "  ) As Cpu    ", "CostPerUnit", "تكلفة الوحدة ")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qsale.Name, "Qs"), SaleData.Qsale.Name, SaleData.Qsale.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.QrturnSale.Name, "QrS"), SaleData.QrturnSale.Name, SaleData.QrturnSale.Caption)
        myDataR.AddSelectSQL("( Qs- QrS ) as NetQSale", "NetQSate", "كمية صافي المبيعات")

        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.Qpsale.Name, "Vs"), SaleData.Qpsale.Name, SaleData.Qpsale.Caption)
        myDataR.AddSelectSQL(myDataR.SelectSum(SaleData.TotalRetarnSale.Name, "VrS"), SaleData.TotalRetarnSale.Name, SaleData.TotalRetarnSale.Caption)
        myDataR.AddSelectSQL("( Vs- VrS ) as NetSale", "NetSate", "قيمة صافي المبيعات")
      
        Dim csg As String = " NetQSale * Cpu"

        myDataR.AddSelectSQL("IIF(ISNull( " + csg + ") ,0, " + csg + ")  As CGs", "CGS", "تكلفة البضاعة المباعة")
        Dim EBQ As String = "[NetqPay]-[NetQSale]"

        myDataR.AddSelectSQL("IIF(ISNull( " + EBQ + ") ,0, " + EBQ + ")  As EBQ", "EBQ", "كمية مخزون اخر المدة ")
        Dim EBV As String = "EBQ *  Cpu "
        myDataR.AddSelectSQL("IIF(ISNull( " + EBV + ") ,0, " + EBV + ")  As EBV", "EBV", " قيمة مخزون اخر المدة")

               Dim Grossmargien As String = "NetSale - CGs "
        s = myDataR.AddSelectSQL("IIF(ISNull( " + Grossmargien + ") ,0, " + Grossmargien + ")  As GMarge", "GMarge", "هامش الربح")
        'ShowData in labels

        Return s

    End Function

    Private Function SelectDelgats(ByVal se As SelectQP) As String
        Dim SQp, SQl As String
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()
        SQp = se.Invoke()

        SQl = "Select " + SQp + " From SalePayMovement"

        Return SQl
    End Function
    Private Sub T_button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button6.Click
        Dim s As String
        s = SelectDateWithDetials(AddressOf SQLQ)
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub SQLSaleValue()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged


        Dim s As String
        s = SelectDataEnteryAll()
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)

    End Sub

    Private Sub T_button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button9.Click
        Dim s As String
        s = SelectDataEnterySanf()
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)

    End Sub

    Private Sub T_button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button7.Click
        ComboBox3.SelectedIndex = 0

        FatoraSearch()

    End Sub
    Private Sub FatoraSearch()
        Dim s As String
        s = SelectDataEnteryDetails()
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click

    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Dim s As String
        s = SelectDateWithDetials(AddressOf SQLVal)
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)

    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button8.Click
       
        SanfSearch()
    End Sub
    Private Sub SanfSearch()
        Dim s As String
        s = SelectSanf()
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)
        Vals = True
        ShowDataInLablesVals()
    End Sub

    Private Sub SanfSearch(ByVal san As String)
        Dim s As String
        s = SelectSanf(san)
        myDataR.GetReader(s, myDataR.Connection)

        myDataR.showDatabyReader(myDataR.DataGridveiw)
        If DataGridView1.Rows.Count > 0 Then
            Vals = True
            ShowDataInLablesVals()
        Else
            Vals = False
        End If


    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        ShowDataInLablesVals()
    End Sub

   

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowLeave

    End Sub

    Private Sub AllAccsgrp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAccsgrp.Enter

    End Sub
    Dim trans As String
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.SelectedIndex
            Case 0
                trans = ""
            Case 1
                trans = "sa"
            Case 2
                trans = "sr"
            Case 3
                trans = "pa"
            Case 4
                trans = "pr"
        End Select
        FatoraSearch()
    End Sub

    Private Sub T_textbox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_textbox3.DoubleClick
        Dim search As New smallQfrm
        search.isclient = True
        'search.power = power.data.powr
        search.ShowDialog()
        T_textbox3.Text = search.Quima

        search.Close()
        SanfSearch(T_textbox3.Text)
    End Sub

    Private Sub T_textbox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles T_textbox3.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim search As New smallQfrm
            search.isclient = True
            'search.power = power.data.powr
            search.ShowDialog()
            T_textbox3.Text = search.Quima
           
            search.Close()
            SanfSearch(T_textbox3.Text)
        End If
    End Sub

    Private Sub T_textbox3_pressEnter() Handles T_textbox3.pressEnter
        SanfSearch(T_textbox3.Text)
    End Sub

    Private Sub T_textbox3_TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_textbox3.TabStopChanged

    End Sub

    Private Sub T_textbox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox3.TextChanged
 
    End Sub

    Private Sub D2Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2Date.ValueChanged
        date2 = D2Date.Value

        SQLDate()
    End Sub

    Private Sub D1Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1Date.ValueChanged
        date1 = D1Date.Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ComboBox1.SelectedIndex = 1
        Timer1.Enabled = False
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        Vals = False
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()

        Dim where, sanfwhere, datawhere As String
       
        SaleData.SaleMove_FM = {SaleData.m_code, SaleData.m_sandf, SaleData.trDate, SaleData.FatoraNo, SaleData.m_QBB, SaleData.qpbb _
                                , SaleData.Qsale, SaleData.Qpsale, SaleData.Qpay _
                                 , SaleData.QPPay, SaleData.QrturnSale, SaleData.TotalRetarnSale _
                                , SaleData.QrturnPay, SaleData.TotalRetarnpay}

        Dim li As New List(Of FieldMombers)
        For Each i In SaleData.SaleMove_FM
            i.dgvVisalbe = True
            li.Add(i)
        Next
        SaleData.SaleMove_FM = li.ToArray

        sanfwhere = myDataR.FeildWhere(feildtyp.strings, SaleData.m_code.Name, T_textbox3.Text)
        datawhere = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)
        where = sanfwhere + " And " + datawhere
        myDataR.Load(proj.Dataconpath, SaleData.SaleMove_Table, SaleData.SaleMove_FM, DataGridView1, , where)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

        Vals = False
        myDataR.ClearSQL()
        myDataR.DataGridveiw.Columns.Clear()

        Dim where, sanfwhere, datawhere, fat As String

        Select Case ComboBox4.SelectedIndex
            Case 0
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo, SaleData.m_QBB, SaleData.qpbb _
                              , SaleData.Qsale, SaleData.Qpsale, SaleData.Qpay _
                               , SaleData.QPPay, SaleData.QrturnSale, SaleData.TotalRetarnSale _
                              , SaleData.QrturnPay, SaleData.TotalRetarnpay, SaleData.transNo}

            Case 2
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo _
                             , SaleData.Qsale, SaleData.Qpsale, SaleData.transNo}
                trans = "sa"
            Case 3
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo _
                             , SaleData.TotalRetarnSale, SaleData.TotalRetarnSale, SaleData.transNo}
                trans = "sr"
            Case 4
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo _
                            , SaleData.Qpay, SaleData.QPPay, SaleData.transNo}
                trans = "pa"
            Case 1
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo _
                            , SaleData.m_QBB, SaleData.qpbb, SaleData.transNo}
                trans = "BB"
            Case 5
                SaleData.SaleMove_FM = {SaleData.trDate, SaleData.m_code, SaleData.m_sandf, SaleData.FatoraNo _
                                            , SaleData.QrturnPay, SaleData.TotalRetarnpay, SaleData.transNo}
                trans = "Pr"
        End Select


      
        Dim li As New List(Of FieldMombers)
        For Each i In SaleData.SaleMove_FM
            i.dgvVisalbe = True
            li.Add(i)
        Next
        SaleData.transNo.dgvVisalbe = False
        SaleData.SaleMove_FM = li.ToArray

        sanfwhere = myDataR.FeildWhere(feildtyp.strings, SaleData.m_code.Name, T_textbox3.Text)
        datawhere = myDataR.SqlDateBetween(SaleData.trDate.Name, date1, date2)
        fat = " And " + myDataR.FeildWhere(feildtyp.simistring, SaleData.transNo.Name, trans)

        where = sanfwhere + " And " + datawhere + fat
        myDataR.Load(proj.Dataconpath, SaleData.SaleMove_Table, SaleData.SaleMove_FM, DataGridView1, , where)

    End Sub

    Private Sub Refresh_Me()
        SaleData = New SaleMove("")
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = Nothing
        myDataR = myDataREfresh
        myDataR.ConnectToDataBase(proj.Dataconpath)
        myDataR.DataGridveiw = DataGridView1
        Vals = False
        '>>>
        Timer1.Interval = 1500
        Timer1.Enabled = True

        dataEntery.load()
        mydatarDataEntery.Load(proj.dataConPath_MyData, dataEntery.dataEnterTable, dataEntery.logine_Fm)

        mydatarDataEntery.showDatabyReaderTocombobox(ComboBox2, dataEntery.name.Name, dataEntery.dataEnterTable)
        ComboBox2.Items.Add("الكل")

    End Sub
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        Refresh_Me()
        Refresh()

    End Sub
End Class