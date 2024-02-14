Imports ZeftawyTools
Public Class TrailBalanceFrm
    Inherits myformDesign
    Dim Cash, invent, Ar, Ap As Single
    Dim Sale, SaleR, Pay, PayR, BB As Single
    Dim NetSale, Netpay, Margin, NetProft As Single
    Dim totalinvent, totalAsset As Single
    Dim EXp, Rev As Single
    Dim proj As New projectDataBase
    Dim mydatac As New OLEdatabaseCodeing
    Dim saleTabe As New SaleMove
    Private Sub TrailBalanceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        mydatac.ConnectToDataBase(proj.Dataconpath)
        setInv()

        setSQlCash()
        SetSQLEXrev()
        SetSQLClint()
        totalAsset = Cash + Ar + invent
        TotalAssetlbl.Text = totalAsset
        TotalSuplbl.Text = Ap
    End Sub
    Private Sub setSQlCash()
        Dim input, output As Single
        Dim sqlI, sqlo As String
        sqlo = "SELECT    RecOrPay ,  SUM(cr) AS Expr1  FROM CashFlow  GROUP BY  RecOrPay  HAVING     RecOrPay  = 'منصرف'"
        output = mydatac.showDataValuebyReader(sqlo, 1)

        sqlI = "SELECT    RecOrPay ,  SUM(dr) AS Expr1  FROM CashFlow  GROUP BY  RecOrPay  HAVING     RecOrPay  = 'وارد'"
        input = mydatac.showDataValuebyReader(sqlI, 1)
        Cash = input - output
        Cashlbl.Text = Cash

    End Sub
    Private Sub SetSQLEXrev()


        Dim sqlr, sqle As String
        sqlr = "SELECT    Account ,  SUM(dr) AS Expr1 " + _
            " FROM RebExpensseTable  GROUP BY  Account  HAVING     Account  = 'مصروفات'"
        EXp = mydatac.showDataValuebyReader(sqlr, 1)

        sqle = " SELECT  Account ,   SUM(cr) AS Expr1   " + _
         " FROM RebExpensseTable  GROUP BY    Account HAVING     Account  = 'ايرادات'"
        Rev = mydatac.showDataValuebyReader(sqle, 1)

        Explbl.Text = EXp
        Revlbl.Text = Rev

        NetProft = (Margin + Rev) - EXp
        NetProftlbl.Text = NetProft
    End Sub

    Private Sub SetSQLClint()

        Dim sqlC, sqls As String
        sqlC = "SELECT  CleintSupp  , " + mydatac.SelectSum("Dr", "Ex") + "  FROM CleintAcc   GROUP BY  CleintSupp   HAVING    CleintSupp = 'عميل'"

        Ar = mydatac.showDataValuebyReader(sqlC, 1)

        sqls = "  SELECT  CleintSupp   , " + mydatac.SelectSum("Cr", "Ex") + "  FROM CleintAcc GROUP BY  CleintSupp   HAVING    CleintSupp = 'مورد'"
        Ap = mydatac.showDataValuebyReader(sqls, 1)

        Clientlbl.Text = Ar
        Sublbl.Text = Ap
    End Sub
    Private Sub setInv()
        saleTabe.load()
        Dim sqlsale As String
        sqlsale = "SELECT " + mydatac.SelectSum(saleTabe.Qpsale.Name, "EX") + "  From " + saleTabe.SaleMove_Table
        Sale = mydatac.showDataValuebyReader(sqlsale, 0)
        Salelbl.Text = Sale

        sqlsale = "SELECT " + mydatac.SelectSum(saleTabe.TotalRetarnSale.Name, "EX") + "  From " + saleTabe.SaleMove_Table
        SaleR = mydatac.showDataValuebyReader(sqlsale, 0)
        SaleRlbl.Text = SaleR

        NetSale = Sale - SaleR
        NetSalelbl.Text = NetSale

        sqlsale = "SELECT " + mydatac.SelectSum(saleTabe.QPPay.Name, "EX") + "  From " + saleTabe.SaleMove_Table
        Pay = mydatac.showDataValuebyReader(sqlsale, 0)
        Paylbl.Text = Pay

        sqlsale = "SELECT " + mydatac.SelectSum(saleTabe.TotalRetarnpay.Name, "EX") + "  From " + saleTabe.SaleMove_Table
        PayR = mydatac.showDataValuebyReader(sqlsale, 0)
        PayRlbl.Text = PayR

        Netpay = Pay - PayR
        NetPayblb.Text = Netpay

        Margin = NetSale - Netpay
        Marginlbl.Text = Margin
        sqlsale = "SELECT " + mydatac.SelectSum(saleTabe.qpbb.Name, "EX") + "  From " + saleTabe.SaleMove_Table
        BB = mydatac.showDataValuebyReader(sqlsale, 0)

        invent = (BB + Netpay) - NetSale
        invlbl.Text = invent

    End Sub
End Class