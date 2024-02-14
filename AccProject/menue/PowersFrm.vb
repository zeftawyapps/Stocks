Imports ZeftawyTools
Imports System.Linq
Public Class PowersFrm

    Inherits myformDesign
    Dim p As New Power
    Private Sub PowersFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(DesgineFrm, Me, ZeftawyTools.recshaps.rectopleft)
        myProjectWork.changeTextforcolor(Me, T_textbox.textColor)
        p.load()
        p.GetPower(powerString)

        Setpower()
    End Sub
  
    Public powers As Power()
    Public powerString As String
    Private Sub SaleChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleChk.Click
        p.sale.powr = isPower(SaleChk)

    End Sub
    Private Function isPower(ByVal b As t_button) As Boolean
        If b.Checked Then
            Return True
        Else
            AdminChk.Checked = False
            Return False
        End If
    End Function
    Private Sub Setpower()
        If p.Admin.powr Then
            DataChk.Checked = True
            SaleChk.Checked = True
            rsalechk.Checked = True
            parshChk.Checked = True
            RparshChek.Checked = True

            ReportsChk.Checked = True
            'Formatbtn.Visible = True
            FormatChk.Checked = True
            p.sale.powr = True
            p.rsale.powr = True
            p.parshase.powr = True
            p.reparshase.powr = True

            p.data.powr = True
            p.Format.powr = True
            p.report.powr = True
        Else
            SaleChk.Checked = p.sale.powr
            rsalechk.Checked = p.rsale.powr
            parshChk.Checked = p.parshase.powr
            RparshChek.Checked = p.reparshase.powr

            DataChk.Checked = p.data.powr
            FormatChk.Checked = p.Format.powr
            ReportsChk.Checked = p.report.powr
            If p.casher.powr Then
               
            End If
        End If
    End Sub

 
    Private Sub rsalechk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rsalechk.Click
        p.rsale.powr = isPower(rsalechk)

    End Sub

    Private Sub parshChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parshChk.Click
        p.parshase.powr = isPower(parshChk)

    End Sub

    Private Sub RparshChek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RparshChek.Click
        p.reparshase.powr = isPower(RparshChek)

    End Sub

    Private Sub DataChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataChk.Click
        p.data.powr = isPower(DataChk)
    End Sub

    Private Sub ReportsChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsChk.Click
        p.report.powr = isPower(ReportsChk)
    End Sub

    Private Sub FormatChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatChk.Click
        p.Format.powr = isPower(FormatChk)
    End Sub

    Private Sub AdminChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminChk.Click
        p.Admin.powr = isPower(AdminChk)
        If p.Admin.powr Then
            For Each b As t_button In GroupBox1.Controls
                b.Checked = True
            Next
        Else
            For Each b As t_button In GroupBox1.Controls
                b.Checked = False
            Next
        End If
    End Sub
    Private Function GetPower() As String
        p.powers = p.powsmembers_reload
        Dim str As String = ""
        If p.Admin.powr = True Then
            For Each c In p.powers
                c.powr = True

            Next
        End If

        Dim pe = (From i In p.powers _
                   Where i.powr = True _
                    Select i.Caption)

        For Each c In pe
            str = str + " - " + c
        Next
        Return str
    End Function

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        powerString = GetPower()
        Close()
    End Sub

    Private Sub T_button2_Click(sender As Object, e As EventArgs) Handles Cahserchk.Click
        If AdminChk.Checked Then
            msgbox("لا يجوز ان يكون المدير العام كاشير", msgtype.oK)
            Cahserchk.Checked = False
            Exit Sub
        End If

        p.casher.powr = isPower(Cahserchk)
    End Sub

   
End Class
Public Structure Power
    Dim sale As powerMember
    Dim rsale As powerMember
    Dim parshase As powerMember
    Dim reparshase As powerMember
    Dim data As powerMember
    Dim Admin As powerMember
    Dim report As powerMember
    Dim Format As powerMember
    Dim casher As powerMember
    Dim powers As powerMember()
    Public Sub load()
        sale = New powerMember With {.Caption = "مبيعات"}
        parshase = New powerMember With {.Caption = "مشتريات"}
        rsale = New powerMember With {.Caption = "مرتجع بيع"}
        reparshase = New powerMember With {.Caption = "مرتجع شراء"}

        Admin = New powerMember With {.Caption = "مدير عام"}
        Format = New powerMember With {.Caption = "تنسيقات"}
        data = New powerMember With {.Caption = "البيانات"}
        report = New powerMember With {.Caption = "الارصدة"}
        report = New powerMember With {.Caption = "الارصدة"}
        casher = New powerMember With {.Caption = "كاشير"}
        powers = {sale, rsale, parshase, reparshase, data, Format, report, Admin, casher}
    End Sub
    Public Function powsmembers_reload() As powerMember()
        Return {sale, rsale, parshase, reparshase, data, Format, report, Admin, casher}

    End Function


    Public Sub GetPower(ByVal power As String)
        sale = New powerMember With {.Caption = "مبيعات"}
        sale.powr = ispower(power, sale.Caption)
        parshase = New powerMember With {.Caption = "مشتريات"}
        parshase.powr = ispower(power, parshase.Caption)
        rsale = New powerMember With {.Caption = "مرتجع بيع"}
        rsale.powr = ispower(power, rsale.Caption)
        reparshase = New powerMember With {.Caption = "مرتجع شراء"}
        reparshase.powr = ispower(power, reparshase.Caption)

        Admin = New powerMember With {.Caption = "مدير عام"}
        Admin.powr = ispower(power, Admin.Caption)
        Format = New powerMember With {.Caption = "تنسيقات"}
        Format.powr = ispower(power, Format.Caption)
        data = New powerMember With {.Caption = "البيانات"}
        data.powr = ispower(power, data.Caption)
        report = New powerMember With {.Caption = "الارصدة"}
        report.powr = ispower(power, report.Caption)
        casher = New powerMember With {.Caption = "كاشير"}
        casher.powr = ispower(power, casher.Caption)

        powers = {sale, rsale, parshase, reparshase, data, Format, report, Admin, casher}
        Dim po As powerMember()
        po = powers
        If Admin.powr Then
            For Each c In po
                c.powr = True

            Next
            powers = po
        End If
       

    End Sub
    Private Function ispower(ByVal p As String, ByVal s As String) As Boolean
        Dim i As Integer
        i = InStr(p, s)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Structure

Public Structure powerMember
    Dim powr As Boolean
    Dim Caption As String
End Structure