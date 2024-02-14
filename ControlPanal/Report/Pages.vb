Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Public Class Pages
    'هذا التصنيف مصمم لكي يكون هو  شكل  الصفحة الافتراضية قبل تغيير 
    'اي بيانات عليها 
#Region "الصفحة"
    Private MyPge As PrintDocument
    ''' <summary>
    ''' شكل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyPage As PrintDocument
        Get
            Return MyPge
        End Get
        Set(value As PrintDocument)
            MyPge = value
        End Set
    End Property
    Private marge As Margins
    ''' <summary>
    ''' يحدد هوامش الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageMargien As Margins
        Get
            Return marge
        End Get
        Set(value As Margins)
            marge = value
        End Set
    End Property
    Private recpage As Rectangle
    ''' <summary>
    ''' يحدد حدود التقرير يعني يطرح من الصفحة الهوامش
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property PageArea As Rectangle
        Get
            Return recpage
        End Get
        Set(value As Rectangle)
            recpage = value
        End Set
    End Property
    ''' <summary>
    ''' الشكل الافتراضي للصفحة
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DefultPage()
        Dim doc As New PrintDocument
        Dim marg As New Margins
        doc.DefaultPageSettings.Margins.Top = 1
        doc.DefaultPageSettings.Margins.Bottom = 1
        doc.DefaultPageSettings.Margins.Left = 1
        doc.DefaultPageSettings.Margins.Right = 1
        doc.DefaultPageSettings.Landscape = False
        MyPage = doc
        marg = doc.DefaultPageSettings.Margins

        PageMargien = marg
        setPageArea()
    End Sub
    Friend Sub setPageArea()


        Dim rec As New Rectangle
        rec.Y = MyPage.DefaultPageSettings.Bounds.Top + PageMargien.Top
        rec.X = MyPage.DefaultPageSettings.Bounds.Left + PageMargien.Left
        rec.Height = MyPage.DefaultPageSettings.Bounds.Height - PageMargien.Bottom - rec.Y
        rec.Width = MyPage.DefaultPageSettings.Bounds.Width - PageMargien.Right - rec.X
        PageArea = rec
        DefpageArea = rec
        If isFramDouble Then
            Dim inrect As New Rectangle
            Dim rect As New reportPart
            rect.Rectangle = PageArea
            inrect.X = rect.Rectangle.X + 10
            inrect.Y = rect.Rectangle.Y + 10
            inrect.Height = rect.Rectangle.Height - 20
            inrect.Width = rect.Rectangle.Width - 20
            innerRectangle = inrect
            PageArea = innerRectangle


        End If
    End Sub
    Friend DefpageArea As Rectangle
    ''' <summary>
    ''' تعديل في بعض الخصائص
    ''' </summary>
    ''' <param name="lan"></param>
    ''' <param name="b">الهامش السفلي</param>
    ''' <param name="t">الهامش العلوي</param>
    ''' <param name="l">الهامش اليساري</param>
    ''' <param name="r">الهامش اليميني</param>
    ''' <remarks></remarks>
    Public Sub PageSitting(lan As Boolean, b As Integer, t As Integer, l As Integer, r As Integer)
        Dim doc As New PrintDocument
        Dim marg As New Margins
        doc.DefaultPageSettings.Margins.Top = t
        doc.DefaultPageSettings.Margins.Bottom = b
        doc.DefaultPageSettings.Margins.Left = l
        doc.DefaultPageSettings.Margins.Right = r
        doc.DefaultPageSettings.Landscape = lan
        MyPage = doc
        marg = doc.DefaultPageSettings.Margins
        PageMargien = marg
        setPageArea()
    End Sub
#End Region
#Region "اجزاء التقرير"
    Private fr, fp, hr, hp As New reportPart
    Private Hrop, Frop As New reportOverPart
    Private dait As New Detailes
    ''' <summary>
    ''' تفاصيل التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Details As Detailes
        Get
            Return dait
        End Get
        Set(value As Detailes)
            dait = value
        End Set
    End Property
    ''' <summary>
    ''' ذيل  التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FooterReport As reportPart
        Get
            Return fr
        End Get
        Set(value As reportPart)
            fr = value
        End Set
    End Property


    ''' <summary>
    ''' ذيل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FooterPage As reportPart
        Get
            Return fp
        End Get
        Set(value As reportPart)
            fp = value
        End Set
    End Property
    ''' <summary>
    ''' راس الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HeaderPage As reportPart
        Get
            Return hp
        End Get
        Set(value As reportPart)
            hp = value
        End Set
    End Property

    ''' <summary>
    ''' راس التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HeaderReport As reportPart
        Get
            Return hr
        End Get
        Set(value As reportPart)
            hr = value
        End Set
    End Property
    ''' <summary>
    '''الراس   فوق الجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HeaderReportOverPart()
        Get
            Return Hrop
        End Get
        Set(ByVal value)
            Hrop = value
        End Set
    End Property

    ''' <summary>
    '''الذيل   فوق الجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FooererReportOverPart()
        Get
            Return Frop
        End Get
        Set(ByVal value)
            Frop = value
        End Set
    End Property
#End Region
#Region "Page Settings"
    Private Function DefHieght() As Integer
        Dim i As New StringFont
        i.DeffoultFontSetting()
        Dim h As Integer
        h = i.Font.Height * 2
        Return h
    End Function

    Friend Function RectHieght(i As StringFont) As Integer
        Dim h As Integer
        h = i.Font.Height * 2
        Return h
    End Function

    Public Sub DefPartRect()
        Dim aria As New Rectangle
        aria = PageArea
        Dim hr, hp, fr, fp, dai As New Rectangle

        'Report Header rectangle

        HeaderReport.BackColorSetting(Brushes.Brown)
        HeaderReport.FramSetting(Color.Blue, 6)
        hr.Height = DefHieght() : hr.Width = aria.Width - 4 : hr.X = aria.X + 2 : hr.Y = aria.Y + 2
        HeaderReport.Rectangle = hr
        HeaderReport.InternelRectangle = hr


        'Report Header Page
        hp.Height = DefHieght() : hp.Width = aria.Width - 4 : hp.X = aria.X + 2 : hp.Y = HeaderReport.Rectangle.Bottom + 2
        HeaderPage.Rectangle = hp

        HeaderPage.BackColorSetting(Brushes.Brown)
        HeaderPage.FramSetting(Color.Blue, 1)

        ' ''Report Details
        ' هنا حسبت ارتفاع جزء التفاصيل على اساس انه طول المنطقة الحرة مطروح منه طول النص الذي سيكتب في ذيل التقرير و ذيل الصفحة
        dai.Height = (aria.Height - DefHieght() * 4) - 8 : dai.Width = aria.Width - 4 : dai.X = aria.X - 2 : dai.Y = HeaderPage.Rectangle.Bottom + 2
        Details.DetailesPart.Rectangle = dai
        Details.setDeff()

        ' ''page Footer rectangle
        fp.Height = DefHieght() : fp.Width = aria.Width - 4 : fp.X = aria.X + 2 : fp.Y = Details.DetailesPart.Rectangle.Bottom
        FooterPage.Rectangle = fp
        FooterPage.InternelRectangle = fp


        FooterPage.BackColorSetting(Brushes.Brown)
        FooterPage.FramSetting(Color.Blue, 1)

        ''Report Footer rectangle
        fr.Height = DefHieght() : fr.Width = aria.Width - 4 : fr.X = aria.X + 2 : fr.Y = FooterPage.Rectangle.Bottom
        FooterReport.InternelRectangle = fr
        FooterReport.Rectangle = fr

        FooterReport.BackColorSetting(Brushes.Brown)
        FooterReport.FramSetting(Color.Blue, 5)

    End Sub
    Public Sub DefPartTxt()
        HeaderReport.SetText("راس التقرير", allinge.reight)
        HeaderPage.SetText("راس الصفحة", allinge.Center)
        FooterPage.SetText("ذيل الصفحة", allinge.left)
        FooterReport.SetText("ذيل التقرير", allinge.reight)
    End Sub
    Private BC As Brush
    Public Property BackColor As Brush
        Get
            Return BC
        End Get
        Set(value As Brush)
            BC = value
        End Set
    End Property

    Private Frame As Pen
    Public Property PageFrame As Pen
        Get
            Return Frame
        End Get
        Set(value As Pen)
            Frame = value
        End Set
    End Property
    Private isFDl As Boolean
    ''' <summary>
    ''' هل يتم رسم اطار مزدوج
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isFramDouble As Boolean
        Get
            Return isFDl
        End Get
        Set(value As Boolean)
            isFDl = value
        End Set
    End Property
    Private inrectang As Rectangle
    Friend Property innerRectangle As Rectangle
        Get
            Return inrectang
        End Get
        Set(value As Rectangle)
            inrectang = value
        End Set
    End Property


    Public Sub Print_PageFram(g As Graphics)

        If isFramDouble Then
            Dim rect As New reportPart
            rect.Rectangle = DefpageArea
            rect.BackColorSetting(BackColor)
            rect.FramSetting(PageFrame)
            Dim p As New Pen(rect.FramColor.Color, rect.FramColor.Width + 2)
            g.FillRectangle(rect.BackColor, rect.Rectangle)

            g.DrawRectangle(rect.FramColor, innerRectangle)

            g.DrawRectangle(p, rect.Rectangle)


        Else
            Dim rect As New reportPart
            rect.Rectangle = PageArea
            rect.InternelRectangle = PageArea
            rect.BackColorSetting(BackColor)
            rect.FramSetting(PageFrame)
            g.DrawRectangle(rect.FramColor, rect.Rectangle)
            g.FillRectangle(rect.BackColor, rect.Rectangle)

        End If
    End Sub
    ''' <summary>
    '''  هذا التصنيف مصمم لكي يكون هو  شكل  الصفحة الافتراضية قبل  تغيير  اي بيانات عليها 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
#End Region

End Class