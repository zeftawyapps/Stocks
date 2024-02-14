Imports ZeftawyTools
Public Class ExpRevFrm
    Inherits myformDesign
    Private exrep As New RebExpensseTable
    Private mycashbankdata, myexrep_Datac, mydocdata As New OLEdatabaseCodeing
    Private proj As New projectDataBase
    Private IsExepence As Boolean
    Dim DocNo As New DocNo : Dim Cashflow As New CashFlow
    Dim FatoraNo As Integer
    Dim AccName, FatoraName, ClientSup As String
    Private Sub StockMoveFrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)

        TransActGrb.Visible = True



    End Sub
    Private Sub LoadCash()
        Cashflow = New CashFlow("")
        Cashflow.load_fm()

        If IsExepence Then
            Cashflow.DrAcc.isWanted = True
            Cashflow.Dr.isWanted = True


            Cashflow.CrAcc.isWanted = False
            Cashflow.Cr.isWanted = False
        Else
            Cashflow.CrAcc.isWanted = True
            Cashflow.Cr.isWanted = True


            Cashflow.DrAcc.isWanted = False
            Cashflow.Dr.isWanted = False
        End If
        Cashflow.RecOrPay.isWanted = True
        Cashflow.CashOrBank.isWanted = True
        Cashflow.DataEntery.isWanted = True
        Cashflow.invNo.isWanted = True
        Cashflow.TransData.isWanted = True
        Cashflow.ser.isWanted = True
        Cashflow.transNo.isWanted = True


        mycashbankdata.Load(proj.Dataconpath, Cashflow.CashFlowTabe, mycashbankdata.GetWantedFeild(Cashflow.load_fm()))
        Dim i As FieldMombers()
        i = mycashbankdata.TableCuloms

    End Sub
    Private Sub LoadDoc()
        DocNo = New DocNo("")
        DocNo.DocNo_Fm = {DocNo.Rev, DocNo.Expga, DocNo.ser}
        mydocdata.Load(proj.Dataconpath, DocNo.DocNoTabe, DocNo.DocNo_Fm)
        mydocdata.ShowDataValue()
        If IsExepence Then
            FatoraNo = mydocdata.FieldValue(1)
            AccName = "EX"
        Else
            FatoraNo = mydocdata.FieldValue(0)
            AccName = "Rev"
        End If
    End Sub
    Private Sub load_exrev()
        exrep.load()
        exrep.Account.Control = AccTyptxt
        exrep.proAcc.Control = NotComboBox
        exrep.datae.Control = DataeTextBox
        exrep.Decoment.Control = DecomentTextBox
        exrep.transNo.Control = Label2

        exrep.cashCr.Control = CashCrComboBox
        If IsExepence Then
            exrep.dr.Control = DrEXtxt
        Else
            exrep.cr.Control = DrEXtxt

        End If
        exrep.load_FM()

        myexrep_Datac.Load(proj.Dataconpath, exrep.RebExpensseTable, exrep.RebExpensseTable_Fm)

    End Sub
   
    Private Sub load_Ex()
        If AccountComb.SelectedIndex = 0 Then
            IsExepence = True
        Else
            IsExepence = False
        End If
        load_exrev()
        LoadDoc()
        LoadCash()
        ExRegrp.Visible = True
        myexrep_Datac.showDatabyReaderTocombobox(NotComboBox, "SELECT " + exrep.proAcc.Name + "," + exrep.Account.Name + " FROM " + exrep.RebExpensseTable + "    GROUP BY " + exrep.Account.Name + "," + exrep.proAcc.Name + " Having " + exrep.Account.Name + " like '%" + AccountComb.Text + "%' ")
        DataeTextBox.Text = Now.Date
        AccTyptxt.Text = AccountComb.Text
        DecomentTextBox.Text = AccName + Format(FatoraNo + 1, "0000")
        Label2.Text = AccName + Format(FatoraNo + 1, "0000")

    End Sub
    Private Sub AccountComb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountComb.SelectedIndexChanged
        load_Ex()
    End Sub
    Private Sub insertCashFlow()


        If Not IsExepence Then
            mycashbankdata.FieldValue(4) = "وارد"
            mycashbankdata.FieldValue(6) = "ايرادات من  " + NotComboBox.Text
            mycashbankdata.FieldValue(2) = CSng(DrEXtxt.Text)
        Else
            mycashbankdata.FieldValue(4) = "منصرف"
            mycashbankdata.FieldValue(6) = "مصروف في   " + NotComboBox.Text

            mycashbankdata.FieldValue(2) = CSng(DrEXtxt.Text)
        End If
        mycashbankdata.FieldValue(3) = Contorlpanal.User
        mycashbankdata.FieldValue(1) = DecomentTextBox.Text
        mycashbankdata.FieldValue(7) = Label2.Text

        mycashbankdata.FieldValue(0) = Now.Date
        Cashflow.Cashflow_Fm = mycashbankdata.TableCuloms
        mycashbankdata.insert()
        mycashbankdata.SaveInsert(False)
    End Sub
    Private Sub EdetDocNo()

        If IsExepence Then
            mydocdata.FieldValue(1) = FatoraNo + 1
        Else
            mydocdata.FieldValue(0) = FatoraNo + 1
        End If
        mydocdata.Edet()
        mydocdata.SaveEdite(False)
    End Sub
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click

        insertCashFlow()
        myexrep_Datac.insert()
        myexrep_Datac.SaveInsert()
        EdetDocNo()
        load_Ex()
    End Sub

    Private Sub DrEXtxt_TextChanged(sender As Object, e As EventArgs) Handles DrEXtxt.TextChanged

    End Sub
End Class