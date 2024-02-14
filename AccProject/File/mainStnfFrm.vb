Imports ZeftawyTools
Public Class mainStnfFrm
    Inherits myformDesign

    Dim mydata As New TashfeenDataBaseWork.OLEDataBaseBinding
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet1.markadata' table. You can move, or remove it, as needed.
        Me.MarkadataTableAdapter.Fill(Me.MydataDataSet1.markadata)
        'TODO: This line of code loads data into the 'MydataDataSet1.DataENameTable' table. You can move, or remove it, as needed.
        Me.DataENameTableTableAdapter.Fill(Me.MydataDataSet1.DataENameTable)
        'TODO: This line of code loads data into the 'MydataDataSet1.mainSanftable' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'MydataDataSet.mainSanftable' table. You can move, or remove it, as needed.

        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(mainGrp, T_textbox.textColor)
        Me.DataPostion1.GetT_buttonColor(Me.T_button)
        Me.Datacontrol3B1.GetT_buttonColor(Me.T_button)
        mydata.loading(DataENameTableBindingSource, DataENameTableTableAdapter.Adapter, MydataDataSet1.DataENameTable, Me, DataPostion1)
        If isMain Then
            loodTool(mainGrp)
            DataPostion1.bindingsouce = DataENameTableBindingSource
            mydata.loading(DataENameTableBindingSource, DataENameTableTableAdapter.Adapter, MydataDataSet1.DataENameTable, Me, DataPostion1)

        Else
            loodTool(markagrp)
            DataPostion1.bindingsouce = MarkadataBindingSource
            mydata.loading(MarkadataBindingSource, MarkadataTableAdapter.Adapter, MydataDataSet1.markadata, Me, DataPostion1)

        End If
    End Sub

    Private Sub Datacontrol3B1_addnew() Handles Datacontrol3B1.addnew
        mydata.addingNew()
    End Sub


    Private Sub Datacontrol3B1_delet() Handles Datacontrol3B1.delet
        mydata.deleteing()
        Me.MainSanftableTableAdapter.Fill(Me.MydataDataSet1.mainSanftable)
        Me.MarkadataTableAdapter.Fill(Me.MydataDataSet1.markadata)

    End Sub


    Private Sub Datacontrol3B1_save() Handles Datacontrol3B1.save
        mydata.saveing()
        Me.MainSanftableTableAdapter.Fill(Me.MydataDataSet1.mainSanftable)
        Me.MarkadataTableAdapter.Fill(Me.MydataDataSet1.markadata)
    End Sub


    Public Property isMain As Boolean = True

    Private Sub loodTool(g As GroupBox)
        For Each c As Control In Me.Controls
            If TypeOf c Is GroupBox Then
                c.Visible = False
            End If
        Next
        g.Left = 55
        g.Top = 55
        g.Visible = True
    End Sub
   
End Class