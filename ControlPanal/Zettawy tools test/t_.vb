Public Class t_lableButton
    Inherits Label
    Public Property check As Boolean
    Public Property checkText As String
    Public Property nocheckText As String
    Public Property moveForecolor As Color
    Public Property leaveForecolor As Color
    Public Property clickForecolor As Color
    Dim schk As Boolean
    Public Property ischeck As Boolean
        Get
            Return schk
        End Get
        Set(ByVal value As Boolean)
            RaiseEvent cheked()
            schk = value
        End Set
    End Property
    Public Event cheked()

    Private Sub t_lableButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ForeColor = clickForecolor

        RaiseEvent cheked()

         
    End Sub
    Public Sub Checked()
        RaiseEvent cheked()
    End Sub
    Private Sub ckecked() Handles Me.cheked
        If check Then
            check = False
            Me.Text = nocheckText
        Else
            check = True
            Me.Text = checkText
        End If
    End Sub

    Private Sub t_lableButton_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        Me.ForeColor = Me.moveForecolor

    End Sub

    Private Sub t_lableButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.ForeColor = Me.leaveForecolor
    End Sub
End Class
