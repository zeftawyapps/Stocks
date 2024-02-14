Public Class RunTimeColorPorperty

    Private Sub RunTimePorperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Event ColorChange()
    Private Txt As String = "اسم الخاصية"
    ''' <summary>
    ''' اسم الخاصية 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PropartyName As String
        Get
            PropertyNamelbl.Text = Txt
            Return Txt
        End Get
        Set(ByVal value As String)
            Txt = value
            PropertyNamelbl.Text = value
        End Set
    End Property
    Private Clr As Color = Drawing.Color.Blue
    ''' <summary>
    ''' لون الخاصية 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Color As Color
        Get
            Colorlbl.BackColor = Clr
            Return Clr
        End Get
        Set(ByVal value As Color)
            Clr = value
            Colorlbl.BackColor = value
        End Set
    End Property

    Private Sub Colorlbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colorlbl.Click
        Dim colordg As New ColorDialog
        colordg.ShowDialog()
        Color = colordg.Color
        RaiseEvent ColorChange()
    End Sub
End Class
