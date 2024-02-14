Imports ZeftawyTools
Public Class Welcomeform
    Inherits WelcomeFrm
    Dim proj As New projectDataBase
    Private Sub FirstFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'نوع المخزون
        Contorlpanal.StockType = StockType.Shope



        Contorlpanal.ShopName = "Z-Apps"
        Contorlpanal.isTransactCash = False
        Contorlpanal.At_Least_Q = 2
        Contorlpanal.AoutoFatorano = True
        Contorlpanal.ismatueDateUsed = True
        Contorlpanal.matueDateTime = 1 'تستخدم عندما لا يستخدم تاريخ الاستحققا لملئ بيان تاريخ الاستحقاق عند الدائنين
        Contorlpanal.islicended = False
        Contorlpanal.isShowPrintInv = False
        Contorlpanal.isprintinv = False
        Contorlpanal.isKg = True 'لكي يتم اظهار الوزن بالكيلو مش بالجرام في شاشة البيع 
        proj.loadWelcome()
        Me.prograamName = Contorlpanal.WelcomeProgramName
        loadNextFrom()
    End Sub

    Private Sub loadNextFrom()

        Select Case Contorlpanal.StockType
            Case StockType.BookShop
                NextForm = StockMove
            Case StockType.Casher
                Contorlpanal.isTransactCash = True
                NextForm = StockMove

            Case StockType.Shope
                NextForm = StockMove
        End Select
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class