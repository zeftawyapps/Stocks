Imports ZeftawyTools
Public Class DataChoseFrm
    Inherits DesgineFrm
    Public Property ChosedDate As Date
   

    Private Sub T_button1_Click(sender As Object, e As EventArgs) Handles T_button1.Click
        ChosedDate = MonthCalendar1.SelectionRange.Start
        Me.Close()
    End Sub

   
    Private Sub DataChoseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        If Not ChosedDate = Nothing Then
            MonthCalendar1.SetDate(ChosedDate)
        Else
            MonthCalendar1.SetDate(Now)
        End If
        Me.Left = MonthCalendar1.Left
        ChosedDate = MonthCalendar1.SelectionRange.Start
        Label1.Text = Format(ChosedDate, "dd/MM/yyyy")
    End Sub
    Public Function GetChosedDate() As Date
        Me.ShowDialog()
        Return ChosedDate
    End Function
    Private Sub MonthCalendar1_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        ChosedDate = MonthCalendar1.SelectionRange.Start
        Label1.Text = Format(ChosedDate, "dd/MM/yyyy")
    End Sub
End Class