Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class ReportPrint

    'هذا النصنيف هو الواجهة الخارجية للتقرير حيث ان المبرمج يقوم بتغيير خصائص التقرير من خلالها وطباعة التقرير من خلالها فهي عبارة عن لوحة التحكم  

#Region "اعداد الصفحة"
    Private page As New Pages
    ''' <summary>
    ''' صفحات التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Pages As Pages
        Get
            Return page
        End Get
        Set(value As Pages)
            page = value
        End Set
    End Property
    Private WithEvents PD As New Printing.PrintDocument
    Public Property PrintDcument As Printing.PrintDocument
        Get
            Return PD
        End Get
        Set(value As Printing.PrintDocument)
            PD = value
        End Set
    End Property
#End Region

#Region "اجراء الطباعة"
    Public Sub New()
        Pages.PageSitting(False, 50, 50, 50, 50)
        PrintDcument = Pages.MyPage
        Pages.DefPartRect()
        Pages.DefPartTxt()
        DefPageFormat()
    End Sub
    Private Sub Print_Details(g As Graphics)
        page.Details.Table.PrintMe = True ' لانه يحدد هل يتم طباعة الجدول ام جدول الحقل الواحد
        page.Details.Detail_Print(g)

    End Sub
    Private Sub Print_HeaderReport(g As Graphics)
        If page.Details.Table.DataSource.IsFirstPage Then
            Pages.HeaderReport.Print_Rect(g)
            Pages.HeaderReport.Print_String(g)
        End If
    End Sub

    Private Sub Print_HeaderPage(g As Graphics)
        Pages.HeaderPage.Print_Rect(g)
        Pages.HeaderPage.Print_String(g)
    End Sub
    Private Sub Print_FooterPage(g As Graphics)
        Pages.FooterPage.Print_Rect(g)
        Pages.FooterPage.Print_String(g)
    End Sub
    Private Sub Print_FooterReport(g As Graphics)
        If page.Details.Table.DataSource.IsLastPage Then
            Pages.FooterReport.Print_Rect(g)
            Pages.FooterReport.Print_String(g)
        End If
    End Sub
    Private FootRep As Rectangle
    Private headRep As Rectangle
    Public Sub FirstPageSet()
        If page.Details.Table.DataSource.IsFirstPage Then
            Dim hr As New Rectangle
            hr = headRep
            hr.Y = page.PageArea.Y
            SetHeaderReportRec(hr)
            Dim hp As New Rectangle
            hp = page.HeaderPage.Rectangle
            hp.Y = page.HeaderReport.Rectangle.Bottom
            SetHeaderPageRect(hp)
            Dim rec As New Rectangle
            rec = Pages.FooterReport.Rectangle
            rec.Height = 0
            SetFooterReportRect(rec)

            Dim Fp As New Rectangle
            Fp = page.FooterPage.Rectangle
            Fp.Y = page.PageArea.Bottom - Fp.Height
            SetFooterPageRect(Fp)
            Dim det As New Rectangle

            det = page.Details.DetailesPart.Rectangle
            det.Y = page.HeaderPage.Rectangle.Bottom
            det.Height = page.FooterPage.Rectangle.Y - det.Y
            page.Details.DetailesPart.Rectangle = det
            page.Details.setDeff()
        End If
    End Sub
    Private Sub LastPageSet()

        If Pages.Details.Table.DataSource.IsLastPage Then
            If Pages.Details.Table.DataSource.IsFirstPage Then
                Dim hr As New Rectangle
                hr = headRep
                hr.Y = page.PageArea.Y
                SetHeaderReportRec(hr)

                Dim hp As New Rectangle
                hp = page.HeaderPage.Rectangle
                hp.Y = page.HeaderReport.Rectangle.Bottom
                SetHeaderPageRect(hp)

              
                Dim det As New Rectangle
                det = page.Details.Table.AllowArea
                det.Y = page.HeaderPage.Rectangle.Bottom
                page.Details.DetailesPart.Rectangle = det


                Dim FP As Rectangle
                FP = page.FooterPage.Rectangle
                FP.Y = page.Details.DetailesPart.Rectangle.Bottom
                SetFooterPageRect(FP)

                FootRep.Y = page.FooterPage.Rectangle.Bottom
                SetFooterReportRect(FootRep)

                Dim area As New Rectangle
                area = page.PageArea
                area.Height = page.FooterReport.Rectangle.Bottom - area.Y
                page.PageArea = area
            Else
                Dim rec As New Rectangle
                rec = page.HeaderReport.Rectangle
                rec.Height = 0
                SetHeaderReportRec(rec)

                Dim hp As New Rectangle
                hp = page.HeaderPage.Rectangle
                hp.Y = page.HeaderReport.Rectangle.Bottom
                SetHeaderPageRect(hp)

                Dim det As New Rectangle
                det = page.Details.Table.AllowArea
                det.Y = page.HeaderPage.Rectangle.Bottom
                page.Details.DetailesPart.Rectangle = det

                Dim FP As Rectangle
                FP = page.FooterPage.Rectangle
                FP.Y = page.Details.DetailesPart.Rectangle.Bottom
                SetFooterPageRect(FP)

                FootRep.Y = page.FooterPage.Rectangle.Bottom
                SetFooterReportRect(FootRep)

                Dim area As New Rectangle
                area = page.PageArea
                area.Height = page.FooterReport.Rectangle.Bottom - area.Y
                page.PageArea = area
            End If
        End If
    End Sub
    Private Sub PageSet()

        Dim f, l As Boolean
        f = Pages.Details.Table.DataSource.IsFirstPage
        l = Pages.Details.Table.DataSource.IsLastPage
        If Not f And Not l Then
            Dim rec As New Rectangle
            rec = page.HeaderReport.Rectangle
            rec.Height = 0
            SetHeaderReportRec(rec)

            Dim hp As New Rectangle
            hp = page.HeaderPage.Rectangle
            hp.Y = page.HeaderReport.Rectangle.Bottom
            SetHeaderPageRect(hp)

            Dim rect As New Rectangle
            rect = Pages.FooterReport.Rectangle
            rect.Height = 0
            SetFooterReportRect(rect)
            Dim Fp As New Rectangle
            Fp = page.FooterPage.Rectangle
            Fp.Y = page.PageArea.Bottom - rec.Height
            SetFooterReportRect(rec)

            Dim det As New Rectangle
            det = page.Details.DetailesPart.Rectangle
            det.Y = page.HeaderPage.Rectangle.Bottom
            det.Height = page.FooterPage.Rectangle.Y - det.Y
            page.Details.DetailesPart.Rectangle = det
            page.Details.setDeff()

        End If
    End Sub
    Private Sub SetReport()
        FirstPageSet()
        PageSet()
        page.Details.Table.GetData()
        LastPageSet()
    End Sub

    Private Sub Print_Image(g As Graphics)
        Picture.Print_picture(g)
    End Sub

    Public Sub Print(sent As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
        SetReport()
        Pages.Print_PageFram(e.Graphics)
        Print_HeaderReport(e.Graphics)
        Print_HeaderPage(e.Graphics)
        Print_FooterPage(e.Graphics)
        Print_FooterReport(e.Graphics)
        Print_Details(e.Graphics)
        Print_Image(e.Graphics)

        ' يحدث اذا كان  طور الجدول اطول من المساحة المطلوبة 
        If Pages.Details.HasMorePage Then
            page.Details.Table.DataSource.IsFirstPage = False
            e.HasMorePages = True

        Else
            e.HasMorePages = False

        End If
        If e.HasMorePages = False Then
            FinshReport()
        End If


    End Sub
    Private Sub FinshReport()

        page.Details.Table.DataSource.IsFirstPage = True
        page.Details.Table.DataSource.IsLastPage = False
        page.Details.Table.DataSource.FinshPrint = True
        page.PageArea = page.DefpageArea
    End Sub

    Public Sub relood()
        Pages.PageSitting(False, 50, 50, 50, 50)
        PrintDcument = Pages.MyPage
        Pages.DefPartRect()
        Pages.DefPartTxt()
        DefPageFormat()
    End Sub

#End Region

#Region "تعديل التقرير "
#Region "ابعاد اقسام التقرير"
    Public Sub SetHeaderReportRec(t As Integer, l As Integer, w As Integer, h As Integer)
        page.HeaderReport.reCtSetting(l, t, h, w)
    End Sub

    Public Sub SetHeaderPageRect(t As Integer, l As Integer, w As Integer, h As Integer)
        page.HeaderPage.reCtSetting(l, t, h, w)
    End Sub
    Public Sub SetFooterPageRect(t As Integer, l As Integer, w As Integer, h As Integer)
        page.FooterPage.reCtSetting(l, t, h, w)
    End Sub
    Public Sub SetFooterReportRect(t As Integer, l As Integer, w As Integer, h As Integer)
        page.FooterReport.reCtSetting(l, t, h, w)
    End Sub

    Public Sub SetHeaderReportRec(rect As Rectangle)
        page.HeaderReport.reCtSetting(rect)
        Dim rec As New Rectangle


    End Sub

    Public Sub SetHeaderPageRect(rect As Rectangle)
        page.HeaderPage.reCtSetting(rect)
    End Sub
    Public Sub SetFooterPageRect(rect As Rectangle)
        page.FooterPage.reCtSetting(rect)

    End Sub
    Public Sub SetFooterReportRect(rect As Rectangle)
        page.FooterReport.reCtSetting(rect)
    End Sub


#End Region
#Region "لون خلفية ابعاد التقرير"
    Public Sub SetHeaderReportBackColor(BC As Brush)
        page.HeaderReport.BackColorSetting(BC)
    End Sub

    Public Sub SetHeaderpageBackColor(BC As Brush)
        page.HeaderPage.BackColorSetting(BC)
    End Sub

    Public Sub SetFooterPageBackColor(BC As Brush)
        page.FooterPage.BackColorSetting(BC)
    End Sub

    Public Sub SetFooterReportBackColor(BC As Brush)
        page.FooterReport.BackColorSetting(BC)
    End Sub
#End Region
#Region "الاطار"
    Public Sub SetHeaderReportFrames(c As Color, w As Single)
        page.HeaderReport.FramSetting(c, w)
    End Sub

    Public Sub SetHeaderPageFrames(c As Color, w As Single)
        page.HeaderPage.FramSetting(c, w)
    End Sub

    Public Sub SetFooterPageFrames(c As Color, w As Single)
        page.FooterPage.FramSetting(c, w)
    End Sub

    Public Sub SetFooterReportFrames(c As Color, w As Single)
        page.FooterReport.FramSetting(c, w)
    End Sub
#End Region
#Region "النصوص"
    Public Sub SetHeaderReportText(txt As String, alligne As allinge)
        Pages.HeaderReport.SetText(txt, alligne)
    End Sub

    Public Sub SetHeaderpageText(txt As String, alligne As allinge)
        Pages.HeaderPage.SetText(txt, alligne)
    End Sub

    Public Sub SetFooterPageText(txt As String, alligne As allinge)
        Pages.FooterPage.SetText(txt, alligne)
    End Sub

    Public Sub SetFooterReportText(txt As String, alligne As allinge)
        Pages.FooterReport.SetText(txt, alligne)
    End Sub
#End Region
#Region "اعداد النصوص"
    Public Sub SetHeaderReportFont(c As Color, F As Font)
        page.HeaderReport.StringFont.SetFont(c, F)
        Dim rec As New Rectangle
        rec = page.HeaderReport.Rectangle
        rec.Height = page.RectHieght(Pages.HeaderReport.StringFont)
        SetHeaderReportRec(rec)

        Dim hp As New Rectangle
        hp = page.HeaderPage.Rectangle
        hp.Y = page.HeaderReport.Rectangle.Bottom
        SetHeaderPageRect(hp)

        Dim det As New Rectangle
        det = page.Details.DetailesPart.Rectangle
        det.Y = page.HeaderPage.Rectangle.Bottom
        det.Height = page.FooterPage.Rectangle.Y - det.Y
        page.Details.DetailesPart.Rectangle = det
        page.Details.setDeff()
        headRep = page.HeaderReport.Rectangle
    End Sub

    Public Sub SetHeaderpageFont(c As Color, F As Font)
        page.HeaderPage.StringFont.SetFont(c, F)
        Dim rec As New Rectangle

        rec = page.HeaderPage.Rectangle
        rec.Height = page.RectHieght(Pages.HeaderPage.StringFont)
        SetHeaderPageRect(rec)

        Dim det As New Rectangle
        det = page.Details.DetailesPart.Rectangle
        det.Y = page.HeaderPage.Rectangle.Bottom
        det.Height = page.FooterPage.Rectangle.Y - det.Y
        page.Details.DetailesPart.Rectangle = det
        page.Details.setDeff()
    End Sub

    Public Sub SetFooterPageFont(c As Color, F As Font)
        page.FooterPage.StringFont.SetFont(c, F)
        Dim rec As New Rectangle
        rec = page.FooterPage.Rectangle

        rec.Height = page.RectHieght(Pages.FooterPage.StringFont)
        rec.Y = page.FooterReport.Rectangle.Y - rec.Height
        SetFooterPageRect(rec)


        Dim det As New Rectangle
        det = page.Details.DetailesPart.Rectangle
        det.Y = page.HeaderPage.Rectangle.Bottom
        det.Height = page.FooterPage.Rectangle.Y - det.Y
        page.Details.DetailesPart.Rectangle = det
        page.Details.setDeff()

        FootRep = page.FooterReport.Rectangle
    End Sub

    Public Sub SetFooterReportFont(c As Color, F As Font)
        page.FooterReport.StringFont.SetFont(c, F)
        Dim rec As New Rectangle
        rec = page.FooterReport.Rectangle
        rec.Height = page.RectHieght(Pages.FooterReport.StringFont)
        rec.Y = page.PageArea.Bottom - rec.Height
        SetFooterReportRect(rec)

        Dim hp As New Rectangle
        hp = page.FooterPage.Rectangle
        hp.Y = page.FooterReport.Rectangle.Y - hp.Height
        SetFooterPageRect(hp)

        Dim det As New Rectangle
        det = page.Details.DetailesPart.Rectangle
        det.Y = page.HeaderPage.Rectangle.Bottom
        det.Height = page.FooterPage.Rectangle.Y - det.Y
        page.Details.DetailesPart.Rectangle = det
        page.Details.setDeff()

        FootRep = page.FooterReport.Rectangle
    End Sub
#End Region
#Region "page"
    ''' <summary>
    ''' شكل الصفحة من ناحية الالوان
    ''' </summary>
    ''' <param name="bc">الخلفية</param>
    ''' <param name="framC">لون البرواز</param>
    ''' <param name="w">عرض خط البرواز</param>
    ''' <param name="isdf">هل يطبع الخط مزدوج</param>
    ''' <remarks></remarks>
    Public Sub PageFormateSetting(ByVal bc As Brush, ByVal framC As Color, ByVal w As Single, Optional ByVal isdf As Boolean = True)
        page.BackColor = bc
        Dim p As New Pen(framC, w)
        page.PageFrame = p
        page.isFramDouble = isdf
        page.setPageArea()
    End Sub
    Public Sub DefPageFormat()
        PageFormateSetting(Brushes.White, Color.Black, 5)
    End Sub
    ''' <summary>
    ''' تعديل في الصفحة
    ''' </summary>
    ''' <param name="lan">افقي ام راسي</param>
    ''' <param name="t">الهامش العلوي</param>
    ''' <param name="l">الهامش شمال الصفحة</param>
    ''' <param name="r">هامش يمين الصفحة</param>
    ''' <param name="b">هامش اسفل الصفحة</param>
    ''' <remarks></remarks>
    Public Sub SetPage(ByVal lan As Boolean, ByVal t As Integer, ByVal l As Integer, ByVal r As Integer, ByVal b As Integer)
        page.PageSitting(lan, b, t, l, r)
        PD = Pages.MyPage
        Pages.DefPartRect()
        Pages.DefPartTxt()
        DefPageFormat()

    End Sub
#End Region
#Region "Table Setting"
    'Dim table As New Table
    Public Sub SetTableFrame(bc As Brush, fc As Color, w As Single, Optional isdf As Boolean = True)
        Pages.Details.Table.SetFrameColors(bc, fc, w)
    End Sub

    Public Sub SetTableFrameCell(ByVal fc As Color, ByVal w As Single)
        Pages.Details.Table.setCellFrame(fc, w)
    End Sub

    Public Sub SetTableFontCell(ByVal fc As Color, ByVal f As Font, ByVal a As allinge)
        Pages.Details.Table.SetCellFont(fc, f, a)
    End Sub

    Public Sub SetTableFrameCellBackColor(ByVal bc As Brush)
        Pages.Details.Table.SetCellBackColor(bc)
    End Sub
    Public Sub SetTableFrameheaderCellBackColor(ByVal bc As Brush)
        Pages.Details.Table.SetFrameHeadColors(bc)
    End Sub
    Public Sub GEtDataTable(ByVal dg As DataGridView, ByVal rtl As Boolean)
        Pages.Details.Table.setData(dg, rtl)
    End Sub
#End Region
#Region "Picture Setting"
    Private Pect As New Picture
    Public Property Picture As Picture
        Get
            Return Pect
        End Get
        Set(value As Picture)
            Pect = value
        End Set
    End Property
    Public Sub SetPicture_options(img As Image, Optional w As Integer = 100, Optional h As Integer = 100, Optional location As location = location.Left_Top)
        Dim l As location
        l = location
        Dim rect As New Rectangle
        rect.Height = h
        rect.Width = w
        Select Case l
            Case location.Center_Buttom
                rect.X = page.PageArea.Right / 2 - rect.Width / 2
                rect.Y = page.PageArea.Bottom - rect.Height
            Case location.Center_Top
                rect.X = page.PageArea.Right / 2 - rect.Width / 2
                rect.Y = page.PageArea.Top

            Case location.Left_buttom
                rect.X = page.PageArea.Left
                rect.Y = page.PageArea.Bottom - rect.Height

            Case location.Left_Top
                rect.X = page.PageArea.Left
                rect.Y = page.PageArea.Top

            Case location.Right_Buttom
                rect.X = page.PageArea.Right - rect.Width
                rect.Y = page.PageArea.Bottom - rect.Height

            Case location.Right_Top
                rect.X = page.PageArea.Right - rect.Width
                rect.Y = page.PageArea.Top

        End Select
        Dim im As Image = img
        Picture.IMage = im
        Picture.MYRectangle = rect
    End Sub

#End Region
#End Region

End Class
