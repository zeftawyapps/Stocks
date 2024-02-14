Public Class Picture
    Public Sub New()

    End Sub

    Private myrect As New Rectangle
    Public Property MYRectangle As Rectangle
        Get
            Return myrect
        End Get
        Set(value As Rectangle)
            myrect = value
        End Set
    End Property

    Private IMg As Image
    Public Property IMage As Image
        Get
            Return IMg
        End Get
        Set(value As Image)
            IMg = value
        End Set
    End Property
    Public Sub Print_picture(g As Graphics)
        If IMage Is Nothing Then Exit Sub
        g.DrawImage(Me.IMage, MYRectangle)
    End Sub
   
End Class
Public Enum location
    Left_Top
    Left_buttom
    Right_Top
    Right_Buttom
    Center_Top
    Center_Buttom

End Enum
