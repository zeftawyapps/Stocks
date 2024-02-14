Imports ZeftawyTools

Public Class logeinFrm

    Inherits myformDesign
    Dim mylogein As New OLEdatabaseCodeing
    Dim loginStr As New LogeIn
    Private Sub lageinFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
               loginStr.load()
        mylogein.Load("mydata.mdb", loginStr.dataEnterTable, loginStr.logine_Fm)
        mylogein.showDatabyReaderTocombobox(ComboBox1, loginStr.name.Name, loginStr.dataEnterTable)
        ComboBox1.Focus()
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Application.Exit()
    End Sub
    Private Sub Enters()
        Dim x As String = Passwardtxt.Text
        If pass = x Then
            msgbox("Welcom")
            powrstr.GetPower(power)
            user = ComboBox1.Text
            Me.Close()
        Else
            Static i As Integer
            i += 1

            If i > 6 Then
                msgbox(" خروج من البرنامج")
                Application.Exit()
            Else

                msgbox(" ادخل كلمة المرور الصحيحة")
            End If
        End If
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click

        Enters()


    End Sub
    Dim pass, power As String
    Friend powrstr As New Power
    Friend user As String
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        mylogein.DataFilter(loginStr.name.Name + "  = '" + ComboBox1.Text + "'")
        mylogein.ShowDataValue()
        pass = mylogein.FieldValue(1)
        power = mylogein.FieldValue(2)
        Passwardtxt.Focus()
        Passwardtxt.Clear()

    End Sub

    Private Sub Passwardtxt_pressEnter() Handles Passwardtxt.pressEnter
        Enters()
    End Sub

    Private Sub Passwardtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Passwardtxt.TextChanged

    End Sub

    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        Application.Exit()
    End Sub
End Class