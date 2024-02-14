Public Class TestPrint

    Private Dataconpath = "mydata.mdb"
    Private StockDataTable = "StockDataBookShops"

    Dim project As New projectDataBase
    Dim mydatac As New OLEdatabaseCodeing
    Private Sub loadLnq()

    End Sub

    Private Sub TestPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        project.StockData_BookShope.load()


        mydatac.Load(project.dataConPath_MyData, project.StockData_BookShope.StockData_TabaleName, project.StockData_BookShope.StockDataBookShope_Fm, DataGridView1)
        
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cap As New copyPastDataCode
        cap.PastNewd(DataGridView1, mydatac)
    End Sub
End Class