Imports ZeftawyTools
Public Class DataEpFrm
    Inherits myformDesign
    Dim mydata As New TashfeenDataBaseWork.OLEDataBaseBinding
    Dim datas As New OLEdatabaseCodeing
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DataENameTableTableAdapter.Connection = datas.ConnectToDataBase("myData.mdb")
        'TODO: This line of code loads data into the 'MydataDataSet1.StockDataTable' table. You can move, or remove it, as needed.
        'Me.StockDataTableTableAdapter.Fill(Me.MydataDataSet1.StockDataTable)
        'TODO: This line of code loads data into the 'MydataDataSet1.DataENameTable' table. You can move, or remove it, as needed.
        Me.DataENameTableTableAdapter.Fill(Me.MydataDataSet1.DataENameTable)
        'TODO: This line of code loads data into the 'MydataDataSet1.ClientTable' table. You can move, or remove it, as needed.
        mydata.loading(DataENameTableBindingSource, DataENameTableTableAdapter.Adapter, MydataDataSet1.DataENameTable, Me, DataPostion1)
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(GroupBox1, T_textbox.textColor)
        Me.DataPostion1.GetT_buttonColor(Me.T_button)
        Me.Datacontrol3B1.GetT_buttonColor(Me.T_button)
    End Sub
    Private Sub Datacontrol3B1_addnew() Handles Datacontrol3B1.addnew
        mydata.addingNew()
    End Sub
    Private Sub Datacontrol3B1_delet() Handles Datacontrol3B1.delet
        mydata.deleteing()
        Me.DataENameTableTableAdapter.Fill(Me.MydataDataSet1.DataENameTable)
    End Sub
    Private Sub Datacontrol3B1_save() Handles Datacontrol3B1.save
        mydata.saveing()
        Me.DataENameTableTableAdapter.Fill(Me.MydataDataSet1.DataENameTable)
    End Sub

    Private Sub T_textbox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_textbox3.Enter
        Dim p As New PowersFrm
        p.powerString = T_textbox3.Text
        p.ShowDialog()
ss:
        If p.powerString = "" Then
            msgbox("يجب ادخال الصلاحيات", msgtype.oK)
            p.ShowDialog()
            GoTo ss
        End If
        T_textbox3.Text = p.powerString

        p.Close()
    End Sub

    Private Sub T_textbox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox3.TextChanged

    End Sub
End Class