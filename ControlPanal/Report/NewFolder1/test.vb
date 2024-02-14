Imports ZeftawyTools
Public Class test
    Dim mypages As New ReportPrint
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        'اعداد الصفحة
        mypages.SetPage(True, 50, 50, 50, 50)
        mypages.PageFormateSetting(Brushes.White, Color.Blue, 4)

        'نصوص اجزاء الصفحة
        mypages.SetHeaderReportText("بسم الله الرحمن الرحيم", allinge.reight)
        mypages.SetHeaderpageText("نتائج طلبة المرحلة الاعدادية بالغربيه", allinge.Center)
        mypages.SetFooterPageText("تصميم معاذ الزفتاوي", allinge.reight)
        mypages.SetFooterReportText("ذيل التقرير", allinge.reight)
        'خطوط اجزاء الصفحة
        mypages.SetHeaderReportFont(Color.Black, Label2.Font)
        mypages.SetHeaderpageFont(Color.Blue, Label2.Font)
        mypages.SetFooterPageFont(Color.Black, Label2.Font)
        mypages.SetFooterReportFont(Color.Black, Label2.Font)

        'خلفية اجزاء الصفحة
        mypages.SetHeaderReportBackColor(Brushes.Transparent)
        mypages.SetHeaderpageBackColor(Brushes.Transparent)
        mypages.SetFooterPageBackColor(Brushes.Transparent)
        mypages.SetFooterReportBackColor(Brushes.Transparent)
        'اطار الجزاء الصفحة
        mypages.SetHeaderReportFrames(Color.Transparent, 1)
        mypages.SetHeaderPageFrames(Color.Transparent, 2)
        mypages.SetFooterPageFrames(Color.Transparent, 3)
        mypages.SetFooterReportFrames(Color.Transparent, 4)

        ''mypages.SetPicture_options(My.Resources._2)
        'اخذ البيانات 
        mypages.Pages.Details.Table.setData(Me.EbTedaDataGridView)
        PrintDocument1 = mypages.PrintDcument
        PrintPreviewDialog1.Document = PrintDocument1
        Label1.Text = mypages.Pages.Details.Table.AllowArea.Height
        'شكل شاشة اظهار الطباعة 
        PrintPreviewDialog1.Width = 1000
        PrintPreviewDialog1.Height = 1000
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub test_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
           End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' اجراء الطباعة نفس كل حاجة ما عدا في الاخر 

        Dim mypages As New ReportPrint

        'اعداد الصفحة
        mypages.SetPage(False, 50, 50, 50, 50)
        mypages.PageFormateSetting(Brushes.LightBlue, Color.Blue, 4)

        'نصوص اجزاء الصفحة
        mypages.SetHeaderReportText("راس التقرير", allinge.reight)
        mypages.SetHeaderpageText("ASFDSDdsfsdfsdfwesd", allinge.left)
        mypages.SetFooterPageText("ذيل الصفحة", allinge.Center)
        mypages.SetFooterReportText("ذيل التقرير", allinge.left)
        'خطوط اجزاء الصفحة
        mypages.SetHeaderReportFont(Color.Black, Label2.Font)
        mypages.SetHeaderpageFont(Color.Blue, Label2.Font)
        mypages.SetFooterPageFont(Color.Black, Label2.Font)
        mypages.SetFooterReportFont(Color.Black, Label2.Font)

        'خلفية اجزاء الصفحة
        mypages.SetHeaderReportBackColor(Brushes.Transparent)
        mypages.SetHeaderpageBackColor(Brushes.Transparent)
        mypages.SetFooterPageBackColor(Brushes.Transparent)
        mypages.SetFooterReportBackColor(Brushes.Transparent)
        'اطار الجزاء الصفحة
        mypages.SetHeaderReportFrames(Color.Blue, 5)
        mypages.SetHeaderPageFrames(Color.Blue, 3)
        mypages.SetFooterPageFrames(Color.Blue, 5)
        mypages.SetFooterReportFrames(Color.Blue, 3)

        'اخذ البيانات 
        mypages.Pages.Details.Table.setData(Me.EbTedaDataGridView)
        PrintDocument1 = mypages.PrintDcument

        Label1.Text = mypages.Pages.Details.Table.AllowArea.Height
        PrintDocument1.Print()

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        PrintDocument1 = mypages.PrintDcument
        PrintPreviewDialog1.Document = PrintDocument1
        Label1.Text = mypages.Pages.Details.Table.AllowArea.Height

        PrintPreviewDialog1.Width = 1000
        PrintPreviewDialog1.Height = 1000
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub test_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class