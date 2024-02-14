Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class reportOverPart
    ' هذا التصنيف يقوم بوضع الحقول الاضافية على التقرير التي لا تستطيع الاجزاءا لاساسية بوضعها 
    'مثل البادج في اعلى التقرير و الصور اللوجوا 
    'او يتم وضع التوقيعات في اسمفل التقرير 
    ' يتكون من المربع الذي يحدد المكان على صفحة التقرير 
    'ثم ثلاثة اقسام و التي يتم وضع فيها الحقول 
    '
    '
    '
    '

    '''  """"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

#Region "خصائص مهمة"
    Dim ROPartFram As New Rectangle
    ''' <summary>
    ''' يحدد مربع الاطار في الجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportOverPartFrame() As Rectangle
        Get
            Return ROPartFram
        End Get
        Set(ByVal value As Rectangle)
            ROPartFram = value
        End Set
    End Property

    Private isFDl As Boolean
    ''' <summary>
    ''' هل يتم رسم اطار مزدوج
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isFramDouble() As Boolean
        Get
            Return isFDl
        End Get
        Set(ByVal value As Boolean)
            isFDl = value
        End Set
    End Property

    Private isActl As Boolean
    ''' <summary>
    ''' هل يتم تفعيله 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isReportOverPart_Active() As Boolean
        Get
            Return isActl
        End Get
        Set(ByVal value As Boolean)
            isActl = value
        End Set
    End Property

    Private inrecs As Rectangle
    ''' <summary>
    ''' المساحة المطلوبة في التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property InternelRectangle() As Rectangle
        Get
            Return inrecs
        End Get
        Set(ByVal value As Rectangle)
            inrecs = value
        End Set
    End Property
    Private isCel As Boolean = False
    Friend Property Iscell() As Boolean
        Get
            Return isCel
        End Get
        Set(ByVal value As Boolean)
            isCel = value
        End Set
    End Property
    Private FC As Pen
    ''' <summary>
    ''' لون الاطار 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FramColor() As Pen
        Get
            Return FC
        End Get
        Set(ByVal value As Pen)
            FC = value
        End Set
    End Property
    Private BC As Brush
    ''' <summary>
    ''' تحدد لون خلفية الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BackColor() As Brush
        Get
            Return BC
        End Get
        Set(ByVal value As Brush)
            BC = value
        End Set
    End Property
    Dim RightP, MiddelP, LeftP As reportPart
    ''' <summary>
    ''' القسم الايمن  للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RightPart() As reportPart
        Get
            Return RightP
        End Get
        Set(ByVal value As reportPart)
            RightP = value
        End Set
    End Property
    ''' <summary>
    ''' القسم الاوسط للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MiddelPart() As reportPart
        Get
            Return MiddelP
        End Get
        Set(ByVal value As reportPart)
            MiddelP = value
        End Set
    End Property
    ''' <summary>
    ''' القسم الايسر  للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LeftPart() As reportPart
        Get
            Return LeftP
        End Get
        Set(ByVal value As reportPart)
            LeftP = value
        End Set
    End Property


    Dim RightRec, Middelrec, Leftrec As Rectangle
    ''' <summary>
    ''' مربع القسم الايمن  للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RightPartRect() As Rectangle
        Get
            Return RightRec
        End Get
        Set(ByVal value As Rectangle)
            RightRec = value
        End Set
    End Property
    ''' <summary>
    '''  مربع القسم الاوسط للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MiddelPartRect() As Rectangle
        Get
            Return Middelrec
        End Get
        Set(ByVal value As Rectangle)
            Middelrec = value
        End Set
    End Property
    ''' <summary>
    ''' مربع القسم الايسر  للجزء
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LeftPartRect() As Rectangle
        Get
            Return Leftrec
        End Get
        Set(ByVal value As Rectangle)
            Leftrec = value
        End Set
    End Property

#End Region
#Region "القيم الافتراضية"
    ''' <summary>
    ''' اعطاء البيانات الاساسية للمستطيل 
    ''' </summary>
    ''' <param name="rect">الاطوال</param>
    ''' <param name="bc">لون الخلفية</param>
    ''' <param name="c">لون االطار</param>
    ''' <param name="w">حجم خط الاطار</param>
    ''' <param name="isFdouble">هل الاطار مزدوج؟؟</param>
    ''' <remarks></remarks>
    Public Sub SetRectPart(ByVal rect As Rectangle, ByVal bc As Brush, ByVal c As Color, Optional ByVal w As Integer = 1, Optional ByVal isFdouble As Boolean = True)
        ReportOverPartFrame = rect
        isFramDouble = isFdouble
        DefPartsRect() ' ظبط الاطوال على طووووووول بعد ما تتعدل على المستطيل الكبير 
        Dim p As New Pen(c, w)
        FramColor = p
        isFramDouble = isFdouble
        Dim b As Brush
        b = bc
        BackColor = b
    End Sub
    Private Sub DefPartsRect()
        Dim rRect, mRect, lRect, inRect As New Rectangle
        With lRect ' الجزء الايسر 
            .Y = ReportOverPartFrame.Y
            .Width = ReportOverPartFrame.Width / 3
            .X = ReportOverPartFrame.X
            .Height = ReportOverPartFrame.Height
        End With
        With mRect ' الجزء الاوسط
            .Y = ReportOverPartFrame.Y
            .Width = ReportOverPartFrame.Width / 3
            .X = lRect.Right
            .Height = ReportOverPartFrame.Height
        End With
        With rRect ' الجزء الايمن
            .Y = ReportOverPartFrame.Y
            .Width = ReportOverPartFrame.Width / 3
            .X = mRect.Right
            .Height = ReportOverPartFrame.Height
        End With
        If isFramDouble Then
            With inRect ' الجزء الايمن
                .Y = ReportOverPartFrame.Y + 5
                .Width = ReportOverPartFrame.Width - 10
                .X = mRect.Right + 5
                .Height = ReportOverPartFrame.Height - 10
            End With
        End If
        RightPart.Rectangle = rRect
        MiddelPart.Rectangle = mRect
        LeftPart.Rectangle = lRect
        InternelRectangle = inRect
    End Sub
    ''' <summary>
    ''' تحديد اطوال الجزء الايمن
    ''' </summary>
    ''' <param name="l">اليسار</param>
    ''' <param name="t">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks>
    Public Sub RightPartreCtSetting(ByVal l As Integer, ByVal t As Integer, ByVal h As Integer, ByVal w As Integer)
        RightPart.reCtSetting(l, t, h, w)
    End Sub
    ''' <summary>
    ''' تحديد اطوال الجزء الاوسط
    ''' </summary>
    ''' <param name="l">اليسار</param>
    ''' <param name="t">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks>
    Public Sub medilPartreCtSetting(ByVal l As Integer, ByVal t As Integer, ByVal h As Integer, ByVal w As Integer)
        MiddelPart.reCtSetting(l, t, h, w)
    End Sub
    ''' <summary>
    ''' تحديد اطوال الجزء الايسر
    ''' </summary>
    ''' <param name="l">اليسار</param>
    ''' <param name="t">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks>
    Public Sub leftPartreCtSetting(ByVal l As Integer, ByVal t As Integer, ByVal h As Integer, ByVal w As Integer)
        LeftPart.reCtSetting(l, t, h, w)
    End Sub
    ''' <summary>
    ''' تحديد اطوال الجزء الايمن
    ''' </summary>
    ''' <param name="rect">الاطوال</param>
    ''' <remarks></remarks>
    Public Sub RightPartreCtSetting(ByVal rect As Rectangle)
        RightPart.reCtSetting(rect)
    End Sub

    ''' <summary>
    ''' تحديد اطوال الجزء الاوسط
    ''' </summary>
    ''' <param name="rect">الاطوال</param>
    ''' <remarks></remarks>
    Public Sub MedellPartreCtSetting(ByVal rect As Rectangle)
        MiddelPart.reCtSetting(rect)
    End Sub
    ''' <summary>
    ''' تحديد اطوال الجزء الايسر
    ''' </summary>
    ''' <param name="rect">الاطوال</param>
    ''' <remarks></remarks>
    Public Sub LeftPartreCtSetting(ByVal rect As Rectangle)
        LeftPart.reCtSetting(rect)
    End Sub
    '"""""""""""""""""""""""""""""""""""""""""""""""""""تحديد لون الخلفية و تحديد لون الاطار"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ''' <summary>
    ''' تحديد  لون الخلفية الجزء الايمن
    ''' </summary>
    ''' <param name="Bc">لون الخلفية</param>
    ''' <remarks></remarks>
    Public Sub RightPartreCtSetting(ByVal Bc As Brush)
        RightPart.BackColorSetting(Bc)
    End Sub
    ''' <summary>
    ''' تحديد  لون الخلفية الجزء الاوسط
    ''' </summary>
    ''' <param name="Bc">لون الخلفية</param>
    ''' <remarks></remarks>
    Public Sub MidelPartreCtSetting(ByVal Bc As Brush)
        MiddelPart.BackColorSetting(Bc)
    End Sub
    ''' <summary>
    ''' تحديد  لون الخلفية الجزء الايسر 
    ''' </summary>
    ''' <param name="Bc">لون الخلفية</param>
    ''' <remarks></remarks>
    Public Sub LeftPartreCtSetting(ByVal Bc As Brush)
        LeftPart.BackColorSetting(Bc)
    End Sub

    ''' <summary>
    ''' لتحديد شكل الاطار للجزء الايمن
    ''' </summary>
    ''' <param name="c">اللون</param>
    ''' <param name="w">حجم الاطار</param>
    ''' <param name="isFdouble"></param>
    ''' <remarks></remarks>
    Public Sub RightPartFramSetting(ByVal c As Color, ByVal w As Single, Optional ByVal isFdouble As Boolean = True)
        RightPart.FramSetting(c, w, isFdouble)
    End Sub

    ''' <summary>
    ''' لتحديد شكل الاطار للجزء الاوسط
    ''' </summary>
    ''' <param name="c">اللون</param>
    ''' <param name="w">حجم الاطار</param>
    ''' <param name="isFdouble"></param>
    ''' <remarks></remarks>
    Public Sub MiddelPartFramSetting(ByVal c As Color, ByVal w As Single, Optional ByVal isFdouble As Boolean = True)
        MiddelPart.FramSetting(c, w, isFdouble)
    End Sub

    ''' <summary>
    ''' لتحديد شكل الاطار للجزء الايسر
    ''' </summary>
    ''' <param name="c">اللون</param>
    ''' <param name="w">حجم الاطار</param>
    ''' <param name="isFdouble"></param>
    ''' <remarks></remarks>
    Public Sub LeftPartFramSetting(ByVal c As Color, ByVal w As Single, Optional ByVal isFdouble As Boolean = True)
        LeftPart.FramSetting(c, w, isFdouble)
    End Sub
    '"""""""""""""""""""""""""""""""""""""""""كتابة النص وتحديد خط النص""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ''' <summary>
    ''' تحديد النص وموقعه في الجزء الايمن
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="Alli"></param>
    ''' <remarks></remarks>
    Public Sub RightPartSetText(ByVal txt As String, ByVal Alli As allinge)
        RightPart.SetText(txt, Alli)
    End Sub

    ''' <summary>
    ''' تحديد النص وموقعه في الجزء الاوسط
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="Alli"></param>
    ''' <remarks></remarks>
    Public Sub MiddelPartSetText(ByVal txt As String, ByVal Alli As allinge)
        MiddelPart.SetText(txt, Alli)
    End Sub
    ''' <summary>
    ''' تحديد النص وموقعه في الجزء الايسر
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="Alli"></param>
    ''' <remarks></remarks>
    Public Sub LeftPartSetText(ByVal txt As String, ByVal Alli As allinge)
        LeftPart.SetText(txt, Alli)
    End Sub

    ''' <summary>
    ''' تحديد  خط النص و لونه في الجزء الايمن
    ''' </summary>
    ''' <param name="c"></param>
    ''' <param name="f"></param>
    ''' <remarks></remarks>
    Public Sub RightPartSetText(ByVal c As Color, ByVal f As Font)
        RightPart.StringFont.SetFont(c, f)
    End Sub
    ''' <summary>
    ''' تحديد  خط النص و لونه في الجزء الاوسط
    ''' </summary>
    ''' <param name="c"></param>
    ''' <param name="f"></param>
    ''' <remarks></remarks>
    Public Sub MiddelPartSetText(ByVal c As Color, ByVal f As Font)
        MiddelPart.StringFont.SetFont(c, f)
    End Sub
    ''' <summary>
    ''' تحديد  خط النص و لونه في الجزء الايسر
    ''' </summary>
    ''' <param name="c"></param>
    ''' <param name="f"></param>
    ''' <remarks></remarks>
    Public Sub LeftPartSetText(ByVal c As Color, ByVal f As Font)
        LeftPart.StringFont.SetFont(c, f)
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' اجراءات الرسم ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' طباعة الجزء الايمن
    ''' </summary>
    ''' <param name="G"></param>
    ''' <param name="Mult"></param>
    ''' <remarks></remarks>
    Public Sub RightPart_print(ByVal G As Graphics, ByVal Mult As Boolean)
        RightPart.Print_Rect(G)
        RightP.Print_String(G, Mult)
    End Sub
    ''' <summary>
    ''' طباعة الجزء الاوسط
    ''' </summary>
    ''' <param name="G"></param>
    ''' <param name="Mult"></param>
    ''' <remarks></remarks>
    Public Sub MiddelPart_print(ByVal G As Graphics, ByVal Mult As Boolean)
        MiddelPart.Print_Rect(G)
        MiddelPart.Print_String(G, Mult)
    End Sub
     ''' <summary>
    ''' طباعة الجزء الايسر
    ''' </summary>
    ''' <param name="G"></param>
    ''' <param name="Mult"></param>
    ''' <remarks></remarks>
    Public Sub LeftPart_print(ByVal G As Graphics, ByVal Mult As Boolean)
        LeftPart.Print_Rect(G)
        LeftPart.Print_String(G, Mult)
    End Sub
    ''' <summary>
    ''' طباعة 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub RoportOVerPart_Print(ByVal g As Graphics)
        g.FillRectangle(BackColor, ReportOverPartFrame)
        If Me.isFramDouble Then
            Dim p As New Pen(FramColor.Color, FramColor.Width * 2)
            g.DrawRectangle(p, Me.InternelRectangle)
            g.DrawRectangle(FramColor, ReportOverPartFrame)

        Else
            g.DrawRectangle(FramColor, ReportOverPartFrame)
        End If
    End Sub
#End Region



End Class
