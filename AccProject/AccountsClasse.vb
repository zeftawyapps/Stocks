Public Class AccountsClasse

    Private GetAcc As String
    ''' <summary>
    ''' لدمج الحسابات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GetAccount As String
        Get
            Return GetAcc
        End Get
        Set(ByVal value As String)
            GetAcc = value
        End Set
    End Property
    Public Function GetmyAccount(ByVal code As String, ByVal Acc As String) As String
        GetAccount = code + "\" + Acc
        Return code + "\" + Acc
    End Function

End Class
