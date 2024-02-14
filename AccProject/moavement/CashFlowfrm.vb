Imports ZeftawyTools
Public Class CashFlowfrm
    Dim dats As New TashfeenDataBaseWork.OLEDataBaseBinding
    Private Sub CashFlowfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet1.CahfFlow' table. You can move, or remove it, as needed.
        Me.CahfFlowTableAdapter.Fill(Me.MydataDataSet1.CahfFlow)
        'TODO: This line of code loads data into the 'MovementDataSet.CahfFlow' table. You can move, or remove it, as needed.
         
        myProjectWork.GetFormDesign(DesgineFrm, Me)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        'Datacontrol3B1.GetT_buttonColor(Me.T_button)
        dats.loading(CahfFlowBindingSource, CahfFlowTableAdapter.Adapter, MydataDataSet1.CahfFlow, Me)
    End Sub
    Private Sub groubbox(ByVal gr As GroupBox)
        Dim c As Control
        For Each c In cashFlowGrb.Controls
            If TypeOf c Is GroupBox Then
                c.Visible = False
            End If
        Next

        gr.Height = 91
        gr.Width = 352
        gr.Left = 9
        gr.Top = 125
        gr.Visible = True

    End Sub

    Private Sub Datacontrol3B1_addnew()
        dats.addingNew()
        AddnewWorks()
    End Sub
 
    Private Sub Datacontrol3B1_delet()
        dats.deleteing()
    End Sub


    Private Sub Datacontrol3B1_save()
        dats.saveing()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 1 Then
            GroupBox4.Visible = True
            AccNameDataGridView.Columns.Item(5).Visible = True

        Else
            GroupBox4.Visible = False
            AccNameDataGridView.Columns.Item(5).Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            groubbox(CrAccGrb)
            AccNameDataGridView.Columns.Item(6).Visible = True
            AccNameDataGridView.Columns.Item(7).Visible = True

            AccNameDataGridView.Columns.Item(8).Visible = False
            AccNameDataGridView.Columns.Item(9).Visible = False

        Else
            groubbox(DrAccGrb)
            AccNameDataGridView.Columns.Item(8).Visible = True
            AccNameDataGridView.Columns.Item(9).Visible = True

            AccNameDataGridView.Columns.Item(6).Visible = False
            AccNameDataGridView.Columns.Item(7).Visible = False

        End If
    End Sub

    Dim project As ProjectFunc
    Private Sub T_textbox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox3.TextChanged

    End Sub

    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged

    End Sub
    Private Sub AddnewWorks()
        T_textbox8.Text = Now.Date.ToString
        T_textbox9.Text = ComboBox1.Text

    End Sub

End Class