Imports ZeftawyTools
Public Class CleintData
    Inherits myformDesign

    Dim mydata As New TashfeenDataBaseWork.OLEDataBaseBinding
    Public Property isclient As Boolean
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isclient Then
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Client)
        Else
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Moarid)

        End If

        mydata.loading(ClientTableBindingSource, ClientTableTableAdapter.Adapter, MydataDataSet1.ClientTable, Me, DataPostion1)
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(GroupBox1, T_textbox.textColor)
        Me.DataPostion1.GetT_buttonColor(Me.T_button)
        Me.Datacontrol3B1.GetT_buttonColor(Me.T_button)
        DataPostion1.pchang()

    End Sub

    Private Sub Datacontrol3B1_addnew() Handles Datacontrol3B1.addnew
        mydata.addingNew()
        If isclient Then
            TextBox1.Text = myProjectWork.Client
        Else
            TextBox1.Text = myProjectWork.Moarid

        End If
        T_textbox1.Focus()
    End Sub

    Private Sub Datacontrol3B1_delet() Handles Datacontrol3B1.delet
        mydata.deleteing()
        If isclient Then
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Client)
        Else
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Moarid)

        End If

    End Sub

    Private Sub Datacontrol3B1_save() Handles Datacontrol3B1.save
        T_textbox1.Text = WordProcesse.WordProcess(T_textbox1.Text)
        mydata.saveing()
        If isclient Then
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Client)
        Else
            ClientTableTableAdapter.FillBymoared(MydataDataSet1.ClientTable, myProjectWork.Moarid)

        End If
    End Sub

End Class