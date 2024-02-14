Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1
    Friend mydata As New OLEdatabaseCodeing
    Dim prj As New projectDataBase
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mydata.Load(prj.Dataconpath, prj.stockMoveTable, "FatoraNo = '" + fator + "'")
 
        Me.Controls.Add(crstVew)
        Dim nn As String = names
        printinve()

    End Sub
    Friend names, dates, fator As String
    Friend total, paid, steal As String
    Private Sub printinve()

        Dim rd As New ReportDocument

        Dim filePath As String = Application.StartupPath + "\\inv.rpt"
        Dim dt As DataTable = mydata.DataTable
        rd.Load(filePath)
        rd.SetDataSource(dt)

        rd.SetParameterValue("Names", names)
        rd.SetParameterValue("Fat", fator)
        rd.SetParameterValue("Dates", dates)
        rd.SetParameterValue("Total", total)
        rd.SetParameterValue("Paid", paid)
        rd.SetParameterValue("Steal", steal)

        crstVew.ReportSource = rd
        crstVew.Dock = DockStyle.Fill
        crstVew.Refresh()
        crstVew.PrintReport()
        Me.Close()
    End Sub
    Friend Overridable Sub show(ByVal n As String, ByVal fat As String, ByVal d As String, ByVal tot As String, ByVal pai As String, ByVal stes As String)
        dates = d
        names = n
        fator = fat
        total = tot
        paid = pai
        steal = stes
        MyBase.Show()
    End Sub

End Class