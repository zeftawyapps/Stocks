Imports ZeftawyTools
Public Class ClientSupplierAccfrm
    Inherits myformDesign
    Dim AccName, FatoraName, ClientSup As String
    Private mycashbankdata, myClientdata, mydocdata As New OLEdatabaseCodeing
    Private clientAcc As New CleintAcc : Dim DocNo As New DocNo : Dim Cashflow As New CashFlow
    Dim isClint, isload As Boolean
    Dim Cmbindex As Integer = 0
    Dim FatoraNo As Integer
    Friend isBB, isGetFatora As Boolean
    Dim proj As New projectDataBase
    Private Sub ClientSupplaermovementFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isload = True
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)

       
        isClint = True
        ClientSup = myProjectWork.Client
       
        For Each c As Control In ClientAccgrp.Controls
            c.ForeColor = Color.DarkRed
        Next

        isload = False
    End Sub
    Dim sql As String
    Private Sub BalanceLoad()
              If isClint Then

            sql = "SELECT Namec   , " + myClientdata.SelectSum("Dr", "Ex") + "  FROM CleintAcc   GROUP BY " + clientAcc.Namec.Name + " HAVING    Namec like '%" + SerchTxt.Text + "%'"

            Label14.Text = myClientdata.showDataValuebyReader(sql, 1)
        Else
             sql = "  SELECT  Namec   , " + myClientdata.SelectSum("Cr", "Ex") + "  FROM CleintAcc GROUP BY   Namec   HAVING    Namec  like '%" + SerchTxt.Text + "%'"
            Label14.Text = myClientdata.showDataValuebyReader(sql, 1)
        End If
    End Sub

    Private Sub LoadDoc()
        DocNo = New DocNo("")
        DocNo.DocNo_Fm = {DocNo.Ap, DocNo.AR, DocNo.ser}
        mydocdata.Load(proj.Dataconpath, DocNo.DocNoTabe, DocNo.DocNo_Fm)
        mydocdata.ShowDataValue()
        If isClint Then
            FatoraNo = mydocdata.FieldValue(1)
            AccName = "AR"
        Else
            FatoraNo = mydocdata.FieldValue(0)
            AccName = "AP"
        End If
    End Sub
    Private Sub loadClintACc()

        clientAcc.load()
        Dim i As Integer
      
        clientAcc.Namec.Control = NamecTextBox
        clientAcc.FatoraNo.Control = FatoraNoTextBox
        clientAcc.transNo.Control = Label2
        clientAcc.Account.Control = AccountTextBox
        clientAcc.CleintSupp.Control = CleintSuppTextBox

        clientAcc.Namec.isWanted = True
        clientAcc.FatoraNo.isWanted = True
        clientAcc.transdate.isWanted = True
        clientAcc.Account.isWanted = True
        clientAcc.CleintSupp.isWanted = True
        clientAcc.transNo.isWanted = True
        clientAcc.Namec.dgvVisalbe = True
        clientAcc.FatoraNo.dgvVisalbe = True
        clientAcc.matDate.dgvVisalbe = True
        clientAcc.transdate.dgvVisalbe = True

        'clientAcc.Namec.visable = True
        'clientAcc.FatoraNo.visable = True
        'clientAcc.matDate.visable = True
        'clientAcc.transdate.visable = True
        'clientAcc.Namec.visable = True
        'clientAcc.FatoraNo.visable = True
        'clientAcc.transNo.visable = True
        'clientAcc.Account.visable = True
        'clientAcc.CleintSupp.visable = True


        clientAcc.matDate.isWanted = False
        clientAcc.DateSdad.isWanted = True
       
        If isClint Then

            clientAcc.Dr.isWanted = True
            clientAcc.Cr.isWanted = False
            clientAcc.Dr.dgvVisalbe = True
            'clientAcc.Dr.visable = True

        Else

            clientAcc.Cr.isWanted = True
            clientAcc.Dr.isWanted = False
            clientAcc.Cr.dgvVisalbe = True
            'clientAcc.Cr.visable = True

        End If
    
        If isGetFatora Then
            clientAcc.matDate.isWanted = True
            clientAcc.transdate.dgvVisalbe = True


            clientAcc.Namec.visable = True
            clientAcc.FatoraNo.visable = True
            clientAcc.transNo.visable = True
            clientAcc.Account.visable = True
            clientAcc.CleintSupp.visable = True

         
        End If
        clientAcc.CleintAcc_Fm = myClientdata.GetWantedFeild(clientAcc.load_FM)
       
        'If isBB Then
        '    myClientdata.Load(proj.Dataconpath, clientAcc.CleintAccTabe, clientAcc.CleintAcc_Fm, SalePayMovementDataGridView, , Wher)

        'Else
        '    If isload Then
        '        myClientdata.Load(proj.Dataconpath, clientAcc.CleintAccTabe, clientAcc.CleintAcc_Fm, SalePayMovementDataGridView, , Wher)

        '    Else
        myClientdata.Load(proj.Dataconpath, clientAcc.CleintAccTabe, clientAcc.CleintAcc_Fm, SalePayMovementDataGridView, , Wher)
        If Not isGetFatora Then BalanceLoad()

        '    End If

        'End If
    End Sub
    Private Sub LoadCashflow()
        Cashflow = New CashFlow("")
        Cashflow.load_fm()

        If isClint Then
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

    End Sub

    Private Sub insertCashFlow()
        If isBB Then Exit Sub

        If isClint Then
            mycashbankdata.FieldValue(4) = "وارد"
            mycashbankdata.FieldValue(6) = "سداد حساب عميل "
            mycashbankdata.FieldValue(2) = CSng(Valuetxt.Text)
        Else
            mycashbankdata.FieldValue(4) = "منصرف"
            mycashbankdata.FieldValue(6) = "سداد حساب مورد "
            mycashbankdata.FieldValue(2) = CSng(Valuetxt.Text)
        End If
        mycashbankdata.FieldValue(3) = Contorlpanal.User
        mycashbankdata.FieldValue(1) = FatoraNoTextBox.Text
        mycashbankdata.FieldValue(7) = FatoraNoTextBox.Text

        mycashbankdata.FieldValue(0) = Now.Date
        Cashflow.Cashflow_Fm = mycashbankdata.TableCuloms
        mycashbankdata.insert()
        mycashbankdata.SaveInsert(False)
    End Sub
    
    Private Sub setClienSub(ByVal isclient As Boolean)
        If isclient Then
            ClientSup = myProjectWork.Client
        Else
            ClientSup = myProjectWork.Moarid
        End If
        loadClintACc()
        
        LoadCashflow()

        LoadDoc()
        SerchTxt.Focus()
    End Sub

    Private Sub SerchTxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SerchTxt.Enter
        Dim F As New smallQfrm
        F.snf = False
        F.isclient = isClint
        F.ShowDialog()
        SerchTxt.Text = F.Quima
        F.Close()

        myClientdata.DataFilter(Wher)
        Dim sql As String = "SELECT   FatoraNo , Namec FROM  CleintAcc    GROUP BY  FatoraNo ,Namec Having    Namec  like '%" + SerchTxt.Text + "%'"
        myClientdata.showDatabyReaderTocombobox(FatoraCmb, sql)
        If Not isGetFatora Then BalanceLoad()

        If isBB Then
            InsertBtn.me_text = "ادخال الرصيد"
        Else
            InsertBtn.me_text = "السداد"
        End If
        SalePayMovementDataGridView.Focus()
    End Sub

    Private Function Wher() As String
        Dim s As String
        myClientdata.ClearSQL()
        If isBB Then
            If isload Then
                s = myClientdata.AddWhereSQL(myClientdata.FeildWhere(feildtyp.strings, clientAcc.FatoraNo.Name, "BB"))

            Else
                myClientdata.AddWhereSQL(myClientdata.FeildWhere(feildtyp.simistring, clientAcc.Namec.Name, SerchTxt.Text))
                s = myClientdata.AddWhereSQL(myClientdata.FeildWhere(feildtyp.strings, clientAcc.FatoraNo.Name, "BB"))

            End If
            Return s
        Else
            If isGetFatora Then
                s = myClientdata.AddWhereSQL(myClientdata.FeildWhere(feildtyp.simistring, clientAcc.FatoraNo.Name, FatoraCmb.Text))
                Return s
            Else
                s = myClientdata.AddWhereSQL(myClientdata.FeildWhere(feildtyp.simistring, clientAcc.Namec.Name, SerchTxt.Text))
                Return s
            End If

        End If
    End Function

    Private Sub InsertBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertBtn.Click
        If isBB Then
            If myClientdata.RowCount > 0 Then
                msgbox("يوجد رصيد اول المدة مسجل من قبل")
                Exit Sub
            Else
                FatoraNoTextBox.Text = "BB"
                TransdateTextBox.Text = Format(DateTime.Now, "dd/MM/yyyy")
                CleintSuppTextBox.Text = ClientSup
                NamecTextBox.Text = SerchTxt.Text
                AccountTextBox.Text = "رصيد اول المدة"
            End If
        Else
            isGetFatora = False
            loadClintACc()
            FatoraNoTextBox.Text = AccName + Format(FatoraNo + 1, "0000")
            Label2.Text = AccName + Format(FatoraNo + 1, "0000")

            TransdateTextBox.Text = Format(DateTime.Now, "dd/MM/yyyy")
            CleintSuppTextBox.Text = ClientSup
            NamecTextBox.Text = SerchTxt.Text
            AccountTextBox.Text = "سداد حساب"
        End If
        Valuetxt.Text = ""
        Valuetxt.Focus()
    End Sub
    Private Sub insertClientAcc()
        If isClint Then
            If isBB Then
                clientAcc.Dr.value = CSng(Valuetxt.Text) * 1
            Else
                clientAcc.Dr.value = CSng(Valuetxt.Text) * -1
            End If

            clientAcc.Dr.isWanted = True
            clientAcc.Cr.isWanted = False
        Else
            If isBB Then
                clientAcc.Cr.value = CSng(Valuetxt.Text) * 1
            Else
                clientAcc.Cr.value = CSng(Valuetxt.Text) * -1
            End If

            clientAcc.Cr.isWanted = True
            clientAcc.Dr.isWanted = False
        End If
        clientAcc.transdate.value = Now.Date
        clientAcc.DateSdad.value = Now.Date

        clientAcc.CleintAcc_Fm = myClientdata.GetWantedFeild(clientAcc.load_FM())
        myClientdata.EditMyTools(clientAcc.CleintAcc_Fm)
        myClientdata.insert()
        myClientdata.SaveInsert(False)
        'myClientdata.reLoad()
    End Sub
    Private Sub EdetDocNo()
        If isBB Then Exit Sub
        If isClint Then
            mydocdata.FieldValue(1) = FatoraNo + 1
        Else
            mydocdata.FieldValue(0) = FatoraNo + 1
        End If
        mydocdata.Edet()
        mydocdata.SaveEdite()
    End Sub
    Private Sub SaveBen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBen.Click
        save()
       
    End Sub
    Private Sub save()
        insertClientAcc()
        insertCashFlow()
        EdetDocNo()
        loadClintACc()
        LoadDoc()
        LoadCashflow()
    End Sub
    Private Sub SupBtn_isChecked() Handles SupBtn.isChecked
        Clientbtn.Checked = False
        isClint = False


        setClienSub(False)
    End Sub

    Private Sub Clientbtn_isChecked() Handles Clientbtn.isChecked
        SupBtn.Checked = False
        isClint = True

        setClienSub(True)
    End Sub

    Private Sub Valuetxt_pressEnter() Handles Valuetxt.pressEnter
        save()
    End Sub

    Private Sub SalePayMovementDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellDoubleClick
        If Me.SalePayMovementDataGridView.CurrentCell.ColumnIndex = 2 Then
            FatoraCmb.Text = SalePayMovementDataGridView.CurrentCell.Value
            isGetFatora = True
            loadClintACc()

        End If
      
    End Sub

    Private Sub SalePayMovementDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellEnter
        myClientdata.MoveByDataGrideView()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FatoraCmb.SelectedIndexChanged
        isGetFatora = True
        loadClintACc()
        Label14.Text = ""
    End Sub

    Private Sub SerchTxt_TextChanged(sender As Object, e As EventArgs) Handles SerchTxt.TextChanged

    End Sub

    Private Sub Clientbtn_Click(sender As Object, e As EventArgs) Handles Clientbtn.Click

    End Sub

    Private Sub SalePayMovementDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalePayMovementDataGridView.CellContentClick

    End Sub
End Class