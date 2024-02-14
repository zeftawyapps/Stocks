Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing

Public Class MySimpleReport
#Region "الصفحة"
    Private Page As PrintDocument
    ''' <summary>
    ''' الصفحة المطلوب الرسم عليها
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyPage() As PrintDocument
        Get
            Return Page

        End Get
        Set(ByVal value As PrintDocument)
            Page = value
        End Set
    End Property
    Dim dd As New PrintDocument

#Region "الهوامش"
    Private hmarg As Integer
    ''' <summary>
    ''' هامش اعلى الصفحة 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property topMargen() As Integer
        Get
            Return hmarg
        End Get
        Set(ByVal value As Integer)
            hmarg = value

        End Set
    End Property
    Private Vmarg As Integer
    ''' <summary>
    ''' هامش يسار الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property leftMargen() As Integer
        Get
            Return Vmarg
        End Get
        Set(ByVal value As Integer)
            Vmarg = value
        End Set
    End Property

    Private RVmarg As Integer
    ''' <summary>
    ''' لهامش اسفل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property buttomMargen() As Integer
        Get
            Return RVmarg
        End Get
        Set(ByVal value As Integer)
            RVmarg = value
            'Me.Hieght = value
        End Set
    End Property
    Private RHmarg As Integer
    ''' <summary>
    ''' لهامش   يمين الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RightMargen() As Integer
        Get
            Return RHmarg
        End Get
        Set(ByVal value As Integer)
            RHmarg = value
        End Set
    End Property
    '''''''''''''''''''''''''''''''''''''''''''''''''
#End Region
#End Region
#Region "الاطار"
    Private ett As Rectangle
    ''' <summary>
    ''' شكل الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableFrame() As Rectangle
        Get
            Return ett
        End Get
        Set(ByVal value As Rectangle)
            ett = value
        End Set
    End Property
    Private pp As Pen
    ''' <summary>
    ''' قلم الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FramePen() As Pen
        Get
            Return pp
        End Get
        Set(ByVal value As Pen)
            pp = value
        End Set
    End Property

    ''' <summary>
    ''' رسم الاطار
    ''' </summary>
    ''' <param name="g">قلم الرسم</param>
    ''' <param name="x">X</param>
    ''' <param name="y">Y</param>
    ''' <param name="w">العرض</param>
    ''' <param name="h">الطول</param>
    ''' <remarks></remarks>
    Public Sub DrowFram(ByVal g As Graphics, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer)
        Dim rec As New Rectangle(x, y, w, h)
        TableFrame = rec
        SetFramTablePen()
        g.DrawRectangle(FramePen, TableFrame)
        DoubleFrame(g)
    End Sub
    ''' <summary>
    ''' رسم الاطار بالاطوال الافتراضية
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub DrowFram(ByVal g As Graphics)
        'DefoultPage()
        Take_line()
        Dim l As Integer = Me.TableLeft
        Dim T As Integer = TableTop
        Dim W As Integer = TableWidth
        Dim H As Integer = Me.TableHieght
        Dim rec As New Rectangle(l, T, W, H)
        TableFrame = rec
        SetFramTablePen()
        g.DrawRectangle(FramePen, TableFrame)

        DoubleFrame(g)
    End Sub
    Private Sub DoubleFrame(ByVal g As Graphics)
        Dim l As Integer = Me.TableLeft
        Dim T As Integer = TableTop
        Dim W As Integer = TableWidth
        Dim H As Integer = Me.TableHieght

        Dim rec1 As New Rectangle(l - 2, T - 2, W + 5, H + 5)
        Dim pen1 As Pen
        pen1 = FramePen
        pen1.Width = 2
        If Doubleline = doublelines.yes Then
            g.DrawRectangle(pen1, rec1)
        End If
    End Sub
    Private dl As doublelines = doublelines.yes
    Public Property Doubleline() As doublelines
        Get
            Return dl
        End Get
        Set(ByVal value As doublelines)
            dl = value
        End Set
    End Property
    Public Sub DefoultTableFrame()
        TableTop = Me.PageHeaderRectangel.Top + Me.PageHeaderRectangel.Height
        Me.TableLeft = leftMargen
        Me.TableHieght = Me.TableHieght
        TableWidth = RightMargen - 50
    End Sub

    ''' <summary>
    ''' لحساب اطوال الجدول
    ''' </summary>
    ''' <param name="ftop">العلوي</param>
    ''' <param name="fleft">اليسار</param>
    ''' <param name="fhight">الارتفاع</param>
    ''' <param name="fwidth">العرض</param>
    ''' <remarks></remarks>
    Public Sub FramDestenation(ByVal ftop As Integer, ByVal fleft As Integer, ByVal fhight As Integer, ByVal fwidth As Integer)
        TableTop = ftop
        Me.TableLeft = fleft
        Me.TableHieght = fhight
        TableWidth = fwidth
    End Sub
    Private FC As Color = Color.Blue
    Public Property FrameColor() As Color
        Get
            Return FC
        End Get
        Set(ByVal value As Color)
            FC = value
        End Set
    End Property
#End Region
#Region "الاعمدة والصفوف"
    Private cc As Color = Color.Black
    ''' <summary>
    '''  لون الاعمدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CullomColor() As Color
        Get
            Return cc
        End Get
        Set(ByVal value As Color)
            cc = value
        End Set
    End Property

    Private rc As Color = Color.Black
    ''' <summary>
    '''  لون الاعمدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowColor() As Color
        Get
            Return rc
        End Get
        Set(ByVal value As Color)
            rc = value
        End Set
    End Property

    Private cline As Integer = 5
    ''' <summary>
    ''' عدد الاعمدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CulloumLineCount() As Integer
        Get
            Return cline
        End Get
        Set(ByVal value As Integer)
            cline = value
        End Set
    End Property

    Private rw() As line
    Public Property Row() As line()
        Get
            Return rw
        End Get
        Set(ByVal value As line())
            rw = value
        End Set
    End Property
    Private cl As line()
    Public Property Cullome() As line()
        Get
            Return cl
        End Get
        Set(ByVal value As line())
            cl = value
        End Set
    End Property
    Private Sub Take_Row()
        On Error Resume Next
        Dim lines(DefutlRowForPage) As line
        'رسم صف بعد الهامش

        Dim headerPoint As Integer = TableTop + Me.headerMargen
        Dim llhا As New line
        Dim rph1 As New Point(Me.TableLeft, headerPoint)
        Dim rph2 As New Point(TableWidth + Me.TableLeft, headerPoint)
        llhا.point1 = rph1
        llhا.point2 = rph2
        lines(0) = llhا
        Row = lines
        'رسم الصف
        Dim rr As Integer = 1
        Dim r As Integer = 1
        Dim rCount As Integer = DefutlRowForPage
        Do Until rr >= rCount
            Dim lll As New line
            Dim rp1 As New Point(Me.TableLeft, headerPoint + Me.rowFeildMargen * r)
            Dim rp2 As New Point(TableWidth + Me.TableLeft, headerPoint + Me.rowFeildMargen * r)
            lll.point1 = rp1
            lll.point2 = rp2
            lines(r) = lll
            Row() = lines
            r += 1
            rr += 1
        Loop

    End Sub
    Private ly As MelanguageType = MelanguageType.Arabic
    Public Property LanguageType() As MelanguageType
        Get
            Return ly
        End Get
        Set(ByVal value As MelanguageType)
            ly = value
        End Set
    End Property
    Public Enum doublelines
        yes
        no
    End Enum
    Private Sub Take_Cullom()
        On Error Resume Next
        Dim x As Integer


        Dim lines(DefutlRowForPage) As line
        Dim cCount As Integer = CulloumLineCount
        Dim linesc(CulloumLineCount) As line
        Dim c As Integer = 0
        Dim cc As Integer = 0
        Dim ccs As Integer
        Do Until cc > cCount + 1
            Dim clll As New line
            If c = 0 Then
                Select Case LanguageType
                    Case MelanguageType.Arabic
                        x = TableLeft + TableWidth
                    Case MelanguageType.English
                        x = Me.TableLeft
                End Select
                Dim cp1 As New Point(x, TableTop)
                Dim cp2 As New Point(x, Me.TableFrame.Bottom)

                clll.point1 = cp1
                clll.point2 = cp2
                linesc(c) = clll
                c += 1
            Else

                ccs = ccs + Me.culmefeildMargiene(c)
                Select Case LanguageType
                    Case MelanguageType.Arabic
                        x = TableLeft + TableWidth - ccs
                    Case MelanguageType.English
                        x = Me.TableLeft + ccs
                End Select
                Dim cp1 As New Point(x, TableTop)
                Dim cp2 As New Point(x, Me.TableHieght + TableTop)

                clll.point1 = cp1
                clll.point2 = cp2
                linesc(c) = clll

                Cullome() = linesc
                c += 1
                cc += 1
            End If
        Loop

    End Sub
    Private Sub Take_line()
        Take_Row()
        Take_Cullom()
    End Sub
    '""""""""""""""""""""""""""""""""""""""""""""""""
    Private rline As Integer = 5
    ''' <summary>
    ''' عدد الصفوف
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowLineCount() As Integer
        Get
            Return rline
        End Get
        Set(ByVal value As Integer)
            rline = value
        End Set
    End Property
    Private ppc As Pen = Pens.Blue
    ''' <summary>
    ''' قلم العمود
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property cullomePen() As Pen
        Get
            Return ppc
        End Get
        Set(ByVal value As Pen)
            ppc = value
        End Set
    End Property
    Private ppr As Pen = Pens.DarkCyan
    ''' <summary>
    ''' قلم الصف
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property rowPen() As Pen
        Get
            Return ppr
        End Get
        Set(ByVal value As Pen)
            ppr = value
        End Set
    End Property
    Private rFeild As Integer = 200
    ''' <summary>
    ''' الهامش بين الصفين
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property rowFeildMargen() As Integer
        Get
            Return rFeild
        End Get
        Set(ByVal value As Integer)
            rFeild = value
        End Set
    End Property

    Private cFeild As Integer = 100
    ''' <summary>
    ''' الهامش بين العمودين
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property cullomFeildMargen() As Integer
        Get
            Return cFeild
        End Get
        Set(ByVal value As Integer)
            cFeild = value
        End Set
    End Property
    ' """"""""""""""""""""""""""""""""""""""""""""""
    ''' <summary>
    ''' الخط المستخدم في رسم العمود و الصف
    ''' </summary>
    ''' <remarks></remarks>
    Public Class line
        Private p1 As Point
        Public Property point1() As Point
            Get
                Return p1
            End Get
            Set(ByVal value As Point)
                p1 = value
            End Set
        End Property
        Private p2 As Point
        Public Property point2() As Point
            Get
                Return p2
            End Get
            Set(ByVal value As Point)
                p2 = value
            End Set
        End Property
        ''' <summary>
        ''' نقاط تحديد الخد المرسوم في الجدول
        ''' </summary>
        ''' <param name="x1">X1</param>
        ''' <param name="y1">Y1</param>
        ''' <param name="x2">X2</param>
        ''' <param name="y2">Y2</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
            Dim pp1 As New Point(x1, y1)
            Dim pp2 As New Point(x2, y2)
            point1 = pp1
            point2 = pp2
        End Sub
        Public Sub TakePoint(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
            Dim pp1 As New Point(x1, y1)
            Dim pp2 As New Point(x2, y2)
            point1 = pp1
            point2 = pp2
        End Sub
        Public Sub New()
        End Sub
        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
#End Region
#Region "رسم الجدول"
    ''' <summary>
    ''' رسم الصفوف
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub DrowRow(ByVal g As Graphics)
        On Error Resume Next
        Dim Rcount As Integer = Me.DefutlRowForPage
        Dim dow As Integer = 0
        Dim rMargen As Integer = 1

        Do Until dow >= Rcount
            g.DrawLine(rowPen, Me.Row(dow).point1.X, Me.Row(dow).point1.Y, Me.Row(dow).point2.X, Me.Row(dow).point2.Y)

            rMargen += 1

            dow += 1

        Loop

    End Sub
    ''' <summary>
    ''' رسم العمود
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub Drowcullome(ByVal g As Graphics)

        Dim dow As Integer = 1
        Dim CMargen As Integer = 1

        Do Until dow = Me.CulloumLineCount
            g.DrawLine(cullomePen, Me.Cullome(dow).point1, Me.Cullome(dow).point2)
            dow += 1
        Loop
    End Sub
    Private hm As Integer = 50
    ''' <summary>
    ''' الهامش في خانة راس العمود
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property headerMargen() As Integer
        Get
            Return hm
        End Get
        Set(ByVal value As Integer)
            hm = value
        End Set
    End Property
    Private burh1 As Color = Color.LightCyan
    ''' <summary>
    ''' اللون الطرفي في خالنة رأس الجدول  
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Headercolor1() As Color
        Get
            Return burh1
        End Get
        Set(ByVal value As Color)
            burh1 = value
        End Set
    End Property

    Private burh2 As Color = Color.DarkOliveGreen
    ''' <summary>
    ''' اللون الطرفي في خالنة الوسطي الجدول 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Headercolor2() As Color
        Get
            Return burh2
        End Get
        Set(ByVal value As Color)
            burh2 = value
        End Set
    End Property


    Private Sub DrowHeader(ByVal g As Graphics)
        Dim rec As New Rectangle(Me.TableLeft + 2, TableTop + 2, TableWidth - 2, headerMargen - 2)

        Dim shape2 As New GraphicsPath
        shape2.AddRectangle(rec)

        Dim brush As New PathGradientBrush(shape2)
        Dim sc As Color() = {Headercolor1}

        brush.SurroundColors = sc
        brush.CenterColor = Headercolor2
        g.FillRectangle(brush, rec)
        'اخذ عناوين الاعمدة
        GetHeaderString(g)
    End Sub
    Private rrrr As Integer
#End Region
#Region "وضع النصوص"
   
    Private thS() As String
    Public Property strings() As String()
        Get
            Return thS
        End Get
        Set(ByVal value As String())
            thS = value
        End Set
    End Property

    Private ff As Font

    Public Property font() As Font
        Get
            Return ff
        End Get
        Set(ByVal value As Font)
            ff = value
        End Set
    End Property

    Private ffh As Font
    Public Property HeaderFont() As Font
        Get

            Return ffh
        End Get
        Set(ByVal value As Font)
            ffh = value
        End Set
    End Property
    Private prf As Color = Color.Black
    Public Property FontColor() As Color
        Get
            Return prf
        End Get
        Set(ByVal value As Color)
            prf = value
        End Set
    End Property


    Private prfh As Color = Color.Gray
    Public Property HeaderFontColor() As Color
        Get
            Return prfh
        End Get
        Set(ByVal value As Color)
            prfh = value
        End Set
    End Property
    Private curruntrow As Integer
    ''' <summary>
    ''' حساب الصف الحالي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property CurrentRow() As Integer
        Get
            If Endrow > 0 Then
                Return Endrow
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            curruntrow = value
        End Set
    End Property
    Private test As Boolean
    Public Property ISTest() As Boolean
        Get
            Return test
        End Get
        Set(ByVal value As Boolean)
            test = value
        End Set
    End Property

    Private Sub drowString(ByVal g As Graphics)

        'On Error Resume Next
        '' أخذ النصوص من الجدول
        Dim i, r, c As Integer
        i = 0
        r = CurrentRow
        Dim rr As Integer = r
        c = 0
        Dim s As String

        Do Until c = DataGridVeiw.ColumnCount
            Do Until i >= DefutlRowForPage - 1
                Dim cs As Integer
                cs = Me.Cullome(c + 1).point1.X + culmefeildMargiene(c + 1) - 3
                Dim rs As Integer = Row(i).point1.Y + Me.rowFeildMargen / 6
                s = mystring(c, rr)
                If mystring(c, rr) = Nothing Then s = ""
                Dim p As New Point(cs, rs)
                Dim sf As New StringFormat
                If LanguageType = MelanguageType.Arabic Then
                    Dim ssf As New StringFormat
                    ssf.FormatFlags = StringFormatFlags.DirectionRightToLeft
                    sf = ssf
                Else
                    Dim ssf As New StringFormat
                    sf = ssf
                End If
                Dim b As New SolidBrush(FontColor)

                g.DrawString(s, Me.font, b, p, sf)
                rr += 1
                i += 1
                Endrow = rr
            Loop
            c += 1

            rr = r

            i = 0
        Loop
        Me.MorePageNeeded()
        Dim tsts As Integer = Endrow
    End Sub
    Dim mystring(,) As String
    Private Sub GetString()

        On Error Resume Next
        '' أخذ النصوص من الجدول
        Dim dg As DataGridView = Me.DataGridVeiw
        Dim i, r, c, cc, rrr As Integer
        rrr = dg.RowCount
        cc = dg.ColumnCount
      
        Dim rr As Integer = 0
        c = 0
        Dim s As String
        Dim ss(cc, rrr) As String
        Do Until c = DataGridVeiw.ColumnCount
            Do Until i >= DataGridVeiw.RowCount - 1
                Dim cs As Integer
                s = dg.Item(c, rr).Value
                If dg.Item(c, rr).Value = Nothing Then s = ""
                ss(c, rr) = s
                rr += 1
                i += 1

            Loop
            c += 1

            rr = r

            i = 0
        Loop
        mystring = ss
    End Sub

    Private Sub GetHeaderString(ByVal g As Graphics)
        On Error Resume Next
        '' أخذ النصوص من الجدول
        Dim c As Integer
        c = 0

        Dim s As String
        Do Until c = DataGridVeiw.ColumnCount
            Dim cs As Integer
            cs = Me.Cullome(c + 1).point1.X + culmefeildMargiene(c + 1) / 1.5
            Dim rs As Integer = (TableTop + Me.headerMargen / 6) - 2
            s = DataGridVeiw.Columns.Item(c).HeaderText
            Dim p As New Point(cs, rs)
            Dim sf As New StringFormat
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft
            Dim b As New SolidBrush(HeaderFontColor)
            g.DrawString(s, HeaderFont, b, p, sf)
            c += 1
        Loop
    End Sub

    Private sf As StringFormat
    Public Property stringfromat() As StringFormat
        Get
            Return sf
        End Get
        Set(ByVal value As StringFormat)
            sf = value
        End Set
    End Property
#End Region
#Region "خواص مهمة"
    Private culmefeildMargien() As Integer
    ''' <summary>
    ''' هوامش الاعمدة التي في الداتا جريد
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property culmefeildMargiene() As Integer()
        Get
            Return culmefeildMargien
        End Get
        Set(ByVal value() As Integer)
            culmefeildMargien = value
        End Set
    End Property
    Private hasmorp As Boolean
    ''' <summary>
    ''' هل تحتاج لصفحة اخرى
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property hasMorPage() As Boolean
        Get
            Return hasmorp
        End Get
        Set(ByVal value As Boolean)
            hasmorp = value
        End Set
    End Property
    Private enr As Integer
    Private Property Endrow() As Integer
        Get
            If ISTest Then
                Return 0
            Else
                Return enr
            End If
        End Get
        Set(ByVal value As Integer)
            enr = value
        End Set
    End Property
    Private Sub MorePageNeeded()
        If CurrentpagecRowCount > DefutlRowForPage Then
            hasMorPage = True
            CurrentRow = Endrow
            IsFirstPage = False
        Else
            hasMorPage = False

        End If

    End Sub
    Private isEnd As Boolean
    Private CurrentpagecRowCount As Integer
    Public Enum MelanguageType
        Arabic
        English
    End Enum

    Private dg As DataGridView
    Public Property DataGridVeiw() As DataGridView
        Get
            Return dg
        End Get
        Set(ByVal value As DataGridView)
            dg = value
        End Set
    End Property
    Friend Fields(CulloumLineCount, RowLineCount) As String

    Private Wi As Integer = RightMargen
    Public Property TableWidth() As Integer
        Get
            Return Wi
        End Get
        Set(ByVal value As Integer)
            Wi = value

        End Set
    End Property
    Private he As Integer = buttomMargen
    Public Property TableHieght() As Integer
        Get
            Return he
        End Get
        Set(ByVal value As Integer)
            he = value

        End Set
    End Property
    Private xx As Integer = leftMargen
    Public Property TableLeft() As Integer
        Get
            Return xx
        End Get
        Set(ByVal value As Integer)
            xx = value

        End Set
    End Property
    Private yy As Integer = topMargen
    Public Property TableTop() As Integer
        Get
            Return yy
        End Get
        Set(ByVal value As Integer)
            yy = value

        End Set
    End Property
#End Region
#Region "اجراءات"
    Private Sub GetDataRow()
        On Error Resume Next
        'DefoultPage()
        Dim dg As DataGridView = Me.DataGridVeiw
        Dim w, h, l, t As Integer
        Dim r, c As Integer
        Dim cf, rf As Integer
        Dim mehight As Integer
        Me.headerMargen = Me.DataGridVeiw.ColumnHeadersHeight
        'حساب عدد الصفوف
        'حساب طول الجدول بالنسبة للصفحة

        RowLineCount = r ' مساواتها بالخاصية
        Dim ir As Integer = Me.CurrentRow

        Dim rowmargen As Integer = Me.DataGridVeiw.Rows(0).Height 'حساب الهامش الطبيعي
        CurrentpagecRowCount = Me.DataGridVeiw.RowCount - DefutlRowForPage '  حساب عدد الصفوف الموجودة في الصفحة

        Dim drr As Integer = NewPageRowcount()
        DefutlRowForPage = drr
        ''حساب عدد الصفوف القياسية في الصفحة
        Dim indexrow As Integer = Me.TableHieght / Me.DataGridVeiw.Rows.Item(ir).Height

        ''
        If CurrentpagecRowCount >= indexrow Then ' لوكان عدد الصفوف اكبر من العدد الافتراصي
            'عمل حقلة تكرارية لحساب طول الجدول بحيث ينتهي بطول الافتراضي للجدول
            mehight = 0
            Do Until mehight >= Me.TableHieght
                rowmargen = Me.DataGridVeiw.Rows.Item(ir).Height ' حساب طول الهامش
                mehight = mehight + rowmargen
                ir += 1

            Loop

            Me.TableHieght = mehight

        Else 'اذا لم يكن اكبر 
            mehight = Me.DataGridVeiw.Rows.Item(0).Height 'حساب المسافة بين الصفين
            Me.rowFeildMargen = mehight 'ارفاقها بالخاصية 
            Dim totalhight As Integer = mehight * DefutlRowForPage 'حساب الطول الكلي للجدول
            Me.TableHieght = totalhight 'ارفاقه في الخاصية 
            DefutlRowForPage = CurrentpagecRowCount ' ارقاق عدد الصفوف في الخاصية 

        End If



    End Sub
    Public dw As Integer
    Public Property DataGrideWidth()
        Get
            Return dw
        End Get
        Set(ByVal value)
            dw = value
        End Set
    End Property
    Private Sub GetDataCullome()
        On Error Resume Next
        'DefoultPage()
        Dim dg As DataGridView = Me.DataGridVeiw
        Dim w, h, l, t As Integer
        Dim r, c As Integer
        Dim cf, rf As Integer
        Me.headerMargen = Me.DataGridVeiw.ColumnHeadersHeight
        w = TableWidth
        c = dg.ColumnCount
        CulloumLineCount = c
        r = dg.RowCount
        RowLineCount = r
        Dim i As Integer = 0
        Dim mewith, withs, hight, mehight As Integer
        Dim cu(c) As Integer

        'لحساب العرض الجدول مقارتنه مع عرض الصفحة
        Do Until i = c
            withs = dg.Columns.Item(i).Width
            mewith = mewith + withs
            i += 1
        Loop
        i = 0 ' تصبح القيمة 1 لدخول حلقة تكرارية اخرى
        'حساب عرض الحقول 

        If mewith > w Then

            MsgBox("اكبر")

        Else
            Dim irr As Integer
            Do Until i = c + 1.0R ' لو كان اكبر منها
                cu(i) = dg.Columns.Item(i - 1).Width
                culmefeildMargiene = cu
                i += 1
            Loop
            i = 1
        End If


    End Sub
   
    Private TableNo As Integer
    ''' <summary>
    '''  علمية اخذ البيانات من الداتا جريد    
    ''' </summary>
    Public Sub GetData_TableFlexadle()
        On Error Resume Next
        'DefoultPage()
        Dim dg As DataGridView = Me.DataGridVeiw
        Dim w, h, l, t As Integer
        Dim r, c As Integer
        Dim cf, rf As Integer
        Me.headerMargen = Me.DataGridVeiw.ColumnHeadersHeight
        Dim mewith, withs, hight, mehight As Integer

        '' حساب عرض الجدول
        w = RightMargen 'حساب عرض الصفحة
        c = dg.ColumnCount 'حساب عدد الاعمدة المطلوب طباعتها
        CulloumLineCount = c 'ادخالها في الخاصية
        r = dg.RowCount 'حساب عدد الصفوف المطلوب طباعتها
        RowLineCount = r ' ادخله في الخاصية

        Dim i As Integer = 0 'هذا المتغير عبارة عن عداد يستخدم في الحلقات التكرارية
        '' ''عمل متغيرات تتعامل مع الاطوال المطلوبة
        Dim cu(c) As Integer 'هذه المصفوفة للتعامل مع اعمدة الجدول

        '' ''لحساب العرض الجدول مقارتنه مع عرض الصفحة
        Do Until i = c
            withs = dg.Columns.Item(i).Width
            mewith = mewith + withs
            i += 1
        Loop
        i = 0 ' تصبح القيمة 0 لدخول حلقة تكرارية اخرى
        '' ''اختباره مع عرض الصفحة الافتراضي 

        If mewith > w Then

            MsgBox("العرض المطلوب اكبر من العرض الصفحة الافتراضي")
            isgetDatagrideheigt = False
            Exit Sub

        Else
            Dim irr As Integer
            Do Until i = c + 1.0R
                cu(i) = dg.Columns.Item(i - 1).Width
                culmefeildMargiene = cu 'يتم ادخال عرض الحقول  في خاصية هوامش التي بين الاعمدة 
                i += 1
            Loop
            i = 1
        End If
        Me.TableWidth = mewith
        'اذا كان الجدول المرسوم هو جدول واحد في الصفحة
        If TablesInPage = TableInPage._1Inpage Then
            Me.TableLeft = RightMargen / 2 - TableWidth / 2
        End If

        If TablesInPage = TableInPage._2InPage Then
            TableNo = 2

            w = RightMargen / 2
            If mewith > w Then

                MsgBox("العرض المطلوب اكبر من العرض الصفحة الافتراضي")
                isgetDatagrideheigt = False
                Exit Sub

            Else
                Dim irr As Integer
                Do Until i = c + 1.0R
                    cu(i) = dg.Columns.Item(i - 1).Width
                    culmefeildMargiene = cu 'يتم ادخال عرض الحقول  في خاصية هوامش التي بين الاعمدة 
                    i += 1
                Loop
                i = 1
            End If
            Me.TableWidth = mewith
        End If
        ''""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        'حساب عدد الصفوف
        'حساب طول الجدول بالنسبة للصفحة

        RowLineCount = r ' مساواتها بالخاصية
        Dim ir As Integer = Me.CurrentRow

        Dim rowmargen As Integer = Me.DataGridVeiw.Rows(0).Height 'حساب الهامش الافتراضي
        CurrentpagecRowCount = Me.DataGridVeiw.RowCount - Endrow

        Dim drr As Integer = NewPageRowcount()
        DefutlRowForPage = drr
        ''حساب عدد الصفوف القياسية في الصفحة

        Dim indexrow As Integer = Me.PageFooterRectangel.Top / Me.DataGridVeiw.Rows.Item(0).Height

        ''
        If CurrentpagecRowCount >= indexrow Then ' لوكان عدد الصفوف اكبر من العدد الافتراصي
            'عمل حقلة تكرارية لحساب طول الجدول بحيث ينتهي بطول الافتراضي للجدول
            mehight = 0
            ir = 0
            Do Until mehight >= Me.PageFooterRectangel.Top - TableTop 'حساب الارتفاع
                rowmargen = Me.DataGridVeiw.Rows.Item(ir).Height ' حساب طول الهامش
                mehight = mehight + rowmargen
                ir += 1

            Loop

            Me.TableHieght = mehight + 1 'عمل طول جديد للجدول

            Me.DefutlRowForPage = ir 'حساب عدد الصفوف التي سيتم طباعتها في الصفحة

            isgetDatagrideheigt = True 'هل تم القرائة من الداتا جريد
        Else 'اذا لم يكن اكبر 
            mehight = Me.DataGridVeiw.Rows.Item(0).Height 'حساب المسافة بين الصفين
            Me.rowFeildMargen = mehight 'ارفاقها بالخاصية 
            Dim totalhight As Integer = mehight * CurrentpagecRowCount 'حساب الطول الكلي للجدول
            Me.TableHieght = totalhight + 1 'ارفاقه في الخاصية 
            DefutlRowForPage = CurrentpagecRowCount ' ارقاق عدد الصفوف في الخاصية 
            isgetDatagrideheigt = True 'هل تم القرائة من الداتا جريد
            isEnd = True ' هل انتهى التقرير 
            IsLastPage = True ' هذة اخر صفحة
        End If

    End Sub
    Public Function getDatagridWith()
        Dim dg As DataGridView = Me.DataGridVeiw
        Dim w As Integer
        Dim r, c As Integer

        Me.headerMargen = Me.DataGridVeiw.ColumnHeadersHeight
        Dim mewith, withs As Integer
        '' حساب عرض الجدول
        w = RightMargen 'حساب عرض الصفحة
        c = dg.ColumnCount 'حساب عدد الاعمدة المطلوب طباعتها
        CulloumLineCount = c 'ادخالها في الخاصية
        r = dg.RowCount 'حساب عدد الصفوف المطلوب طباعتها
        RowLineCount = r ' ادخله في الخاصية

        Dim i As Integer = 0 'هذا المتغير عبارة عن عداد يستخدم في الحلقات التكرارية
        '' ''عمل متغيرات تتعامل مع الاطوال المطلوبة
        Dim cu(c) As Integer 'هذه المصفوفة للتعامل مع اعمدة الجدول

        '' ''لحساب العرض الجدول مقارتنه مع عرض الصفحة
        Do Until i = c
            withs = dg.Columns.Item(i).Width
            mewith = mewith + withs
            i += 1
        Loop
        i = 0 ' تصبح القيمة 0 لدخول حلقة تكرارية اخرى
        '' ''اختباره مع عرض الصفحة الافتراضي 
        Return mewith
    End Function
    '''<summary>
    ''' حساب الصفوف في الصفحة الجديدة
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function NewPageRowcount() As Integer
        ''حساب عدد الصفوف القياسية في الصفحة
        ''يتم حسابها على اساس ان طول الجدول يساوي ارتفاع ذيل الصفحة
        Dim indexrow As Integer = Me.PageFooterRectangel.Top / Me.DataGridVeiw.Rows.Item(0).Height

        If CurrentRow > 0 Then 'اذا  كان الصف الحالي اكبر من الصفر 
            If Me.DataGridVeiw.RowCount - DefutlRowForPage >= indexrow Then ' اذا كان اكبر من من الصفحة الحالية 
                'لحساب طول الجدول  و مقارتنه مع طول الصفحة
                Dim rowmargen As Integer = Me.DataGridVeiw.Rows(0).Height 'حساب الهامش الافتراضي

                rowFeildMargen = rowmargen ' ارفاقه للخاصية
                Dim dr As Integer = Me.PageFooterRectangel.Top / rowmargen 'حساب اقصى عدد تستوعبه الصفحة

                '
                Return dr
            Else
                ''   يساوي العدد الكلي للصفوف مطروح منه عدد الصفوف في الصفحة السابقة لانها اصغر من حجم الصفحة الحالية 
                Return Me.DataGridVeiw.RowCount - DefutlRowForPage
            End If
        Else
            If Me.DataGridVeiw.RowCount - DefutlRowForPage >= indexrow Then ' اذا كان اكبر من من الصفحة الحالية 
                'لحساب طول الجدول  و مقارتنه مع طول الصفحة
                Dim rowmargen As Integer = Me.DataGridVeiw.Rows(0).Height 'حساب الهامش الطبيعي

                rowFeildMargen = rowmargen ' ارفاقه للخاصية
                Dim dr As Integer = Me.PageFooterRectangel.Top / rowmargen 'حساب اقصى عدد تستوعبه الصفحة

                '
                Return dr
            Else
                ''   يساوي العدد الكلي للصفوف مطروح منه عدد الصفوف في الصفحة السابقة لانها اصغر من حجم الصفحة الحالية 
                Return Me.DataGridVeiw.RowCount - DefutlRowForPage
            End If

        End If

    End Function
    Private defr As Integer
    ''' <summary>
    ''' عدد الصفوف في الصحفة الواحدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property DefutlRowForPage() As Integer
        Get
            Return defr
        End Get
        Set(ByVal value As Integer)
            defr = value
        End Set
    End Property
    ''' <summary>
    ''' لرسم التقرير
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub DrowReport(ByVal g As Graphics)
        'Try
        GetString()
        GetData_TableFlexadle()

        If isgetDatagrideheigt = False Then Exit Sub
        Dim sf As New StringFormat
        sf.FormatFlags = StringFormatFlags.DirectionRightToLeft

        Dim rhb As New SolidBrush(Me.ReportHeaderColor)
        Dim rfb As New SolidBrush(Me.ReportFooterColor)
        Dim phb As New SolidBrush(Me.PageHeaderColor)
        Dim pfb As New SolidBrush(Me.PageFooterColor)
        DrowPicture(g)
        WtiteReportHeaderString(g, Me.ReportHeaderString, Me.FontReportHeader, sf, rhb)

        WtitePageHeaderString(g, Me.PageheaderString, Me.FontPageHeader, sf, phb)
        If TablesInPage = TableInPage._2InPage Then

            Dim i As Integer = 1
            Do Until i > TableNo
                Tableposs(i)
                Drowtable(g)
                i += 1

            Loop
        Else
            Drowtable(g)
        End If
        WtitePageFooterString(g, Me.PageFooterString, Me.FontPageFooter, sf, pfb)
        WtiteReportFooterString(g, Me.ReportFooterString, Me.FontReportFooter, sf, rfb)

        DrowReportFram(g)
        RedefoultPage()
        loodMe()
        'Catch ex As Exception
        '    Dim i As New melood
        '    i.msgbox("يوجد خطأ في تحميل التقرير ", msgtype.oK)
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Public Enum TableInPage
        _1Inpage
        _2InPage

    End Enum
    Private tb As TableInPage = TableInPage._1Inpage
    ''' <summary>
    ''' كم الجدول المرسوم في الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TablesInPage() As TableInPage
        Get
            Return tb
        End Get
        Set(ByVal value As TableInPage)
            tb = value
        End Set
    End Property

#End Region

    '"""""""""""""""""""""""""""""""
#Region "رأس وذيل الصفحة"
    Private Hrec As Rectangle
    ''' <summary>
    ''' مربع رأس الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageHeaderRectangel() As Rectangle
        Get
            Return Hrec
        End Get
        Set(ByVal value As Rectangle)
            Hrec = value
        End Set
    End Property

    Private Frec As Rectangle
    ''' <summary>
    ''' مربع ذيل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageFooterRectangel() As Rectangle
        Get
            Return Frec
        End Get
        Set(ByVal value As Rectangle)
            Frec = value
        End Set
    End Property
    ''' <summary>
    ''' عمل مربع في ذيل الصفحة
    ''' </summary>
    ''' <param name="x">اليسار</param>
    ''' <param name="y">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks>
    Public Sub setFooterRectangel(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim rr As New Rectangle(x, y, w, h)
        Me.PageHeaderRectangel = rr
    End Sub
    ''' <summary>
    ''' عمل مربع في رأس الصفحة
    ''' </summary>
    ''' <param name="x">اليسار</param>
    ''' <param name="y">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks
    Public Sub setHeaderRectangel(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim rr As New Rectangle(x, y, w, h)
        Me.PageFooterRectangel = rr
    End Sub
    ''' <summary>
    ''' الشكل الافتراضي لمربع رأس الصفحة
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub defoultHeaderRectangel()

        Dim rr As New Rectangle(Me.leftMargen, Me.topMargen + Me.ReportHeaderRectangel.Height, Me.RightMargen, 50)
        Me.PageHeaderRectangel = rr

    End Sub
    ''' <summary>
    ''' الشكل الافتراضي لمربع ذيل الصفحة
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub defoultFooterRectangel()
        Dim y As Integer
        If isgetDatagrideheigt Then
            y = Me.TableFrame.Height + TableTop
            isgetDatagrideheigt = False
        Else
            y = Me.buttomMargen - 50
        End If
        Dim rr As New Rectangle(Me.leftMargen, y, Me.RightMargen, 50)
        Me.PageFooterRectangel = rr

    End Sub
    Private txt As String
    ''' <summary>
    ''' النص المكتوب في أول الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageFooterString()
        Get
            Return txt
        End Get
        Set(ByVal value)
            txt = value
        End Set
    End Property

    Private txtf As String
    ''' <summary>
    ''' النص المكتوب في ذيل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageheaderString()
        Get
            Return txtf
        End Get
        Set(ByVal value)
            txtf = value
        End Set
    End Property
    Private g As Graphics
    ''' <summary>
    ''' قلم رسم في الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Graphic() As Graphics
        Get
            Return g
        End Get
        Set(ByVal value As Graphics)
            g = value
        End Set
    End Property
    ''' <summary>
    ''' كتابة النص
    ''' </summary>
    ''' <param name="s">النص</param>
    ''' <param name="f">الخص</param>
    ''' <param name="sf">شكل الخط</param>
    ''' <param name="color">لون النص</param>
    ''' <remarks></remarks>
    Public Sub WtitePageHeaderString(ByVal g As Graphics, ByVal s As String, ByVal f As Font, ByVal sf As StringFormat, ByVal color As SolidBrush)
        Me.defoultHeaderRectangel()
        pageHeaderStringPosaion()
        g.DrawString(s, f, color, phx, phy, sf)
    End Sub
    ''' <summary>
    '''   كتابة النص اسفل الصفحة
    ''' </summary>
    ''' <param name="s">النص</param>
    ''' <param name="f">الخص</param>
    ''' <param name="sf">شكل الخط</param>
    ''' <param name="color">لون النص</param>
    ''' <remarks></remarks>
    Public Sub WtitePageFooterString(ByVal g As Graphics, ByVal s As String, ByVal f As Font, ByVal sf As StringFormat, ByVal color As SolidBrush)
        Me.defoultFooterRectangel()
        pageFooterStringPosaion()
        g.DrawString(s, f, color, phx, phy, sf)
    End Sub
    ' نقاط وضع النص
    Private phx As Integer
    Private phy As Integer
    Private Sub pageHeaderStringPosaion()

        Dim rec As New Rectangle
        rec = Me.PageHeaderRectangel
        phx = rec.Left + (rec.Width) - SetPageHeaderStringFormat(SetStringAlighntpageHeader)
        phy = rec.Top + (Me.PageHeaderRectangel.Height / 2)
        phyy = phy
    End Sub
    Public phyy As Integer
    Private Sub pageFooterStringPosaion()
        Dim rec As New Rectangle
        rec = Me.PageFooterRectangel
        phx = rec.Left + (rec.Width) - SetPageFooterStringFormat(SetStringAlighntPageFooter)
        phy = rec.Top + 50
        phyy = phy
    End Sub
    ''' <summary>
    ''' تستخدم لاختبار اذا تم تحديد ارتفاع جديد للجدول
    ''' </summary>
    ''' <remarks></remarks>
    Private isgetDatagrideheigt As Boolean



    Private pfc As Color = Color.BlanchedAlmond
    ''' <summary>
    '''لون نص الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageFooterColor() As Color
        Get
            Return pfc
        End Get
        Set(ByVal value As Color)
            pfc = value
        End Set
    End Property
    Private Fsfp As Font
    ''' <summary>
    '''خط نص راس الصفحة 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FontPageFooter() As Font
        Get
            Return Fsfp
        End Get
        Set(ByVal value As Font)
            Fsfp = value
        End Set
    End Property

    Private sffp As StringFormat
    ''' <summary>
    ''' شكل نص راس الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageFooterStringFormat() As StringFormat
        Get
            Return sffp
        End Get
        Set(ByVal value As StringFormat)
            sffp = value
        End Set
    End Property

    Private phc As Color = Color.Blue
    ''' <summary>
    '''لون نص اعلى  الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageHeaderColor() As Color
        Get
            Return phc
        End Get
        Set(ByVal value As Color)
            phc = value
        End Set
    End Property
    Private Fshp As Font
    ''' <summary>
    '''خط نص راس الصفحة 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FontPageHeader() As Font
        Get
            Return Fshp
        End Get
        Set(ByVal value As Font)
            Fshp = value
        End Set
    End Property

    Private sfhp As StringFormat
    ''' <summary>
    ''' شكل نص راس الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageHeaderStringFormat() As StringFormat
        Get
            Return sfhp
        End Get
        Set(ByVal value As StringFormat)
            sfhp = value
        End Set
    End Property
#End Region



#Region "رأس وذيل التقرير"
    Private rHrec As Rectangle
    ''' <summary>
    ''' مربع رأس التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportHeaderRectangel() As Rectangle
        Get
            Return rHrec
        End Get
        Set(ByVal value As Rectangle)
            rHrec = value
        End Set
    End Property

    Private rFrec As Rectangle
    ''' <summary>
    ''' مربع ذيل التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFooterRectangel() As Rectangle
        Get
            Return rFrec
        End Get
        Set(ByVal value As Rectangle)
            rFrec = value
        End Set
    End Property
    ''' <summary>
    ''' عمل مربع في ذيل التقرير
    ''' </summary>
    ''' <param name="x">اليسار</param>
    ''' <param name="y">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks>
    Public Sub setReportFooterRectangel(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim rr As New Rectangle(x, y, w, h)
        Me.PageHeaderRectangel = rr
    End Sub
    ''' <summary>
    ''' عمل مربع في رأس التقرير
    ''' </summary>
    ''' <param name="x">اليسار</param>
    ''' <param name="y">الاعلى</param>
    ''' <param name="h">الطول</param>
    ''' <param name="w">العرض</param>
    ''' <remarks></remarks
    Public Sub setReportHeaderRectangel(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim rr As New Rectangle(x, y, w, h)
        Me.PageFooterRectangel = rr
    End Sub
    ''' <summary>
    ''' الشكل الافتراضي لمربع رأس التقرير
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub defoultReportHeaderRectangel()
        If IsFirstPage Then
            Dim rr As New Rectangle(Me.leftMargen, Me.topMargen, Me.RightMargen, 50)
            Me.ReportHeaderRectangel = rr
        Else
            Dim rr As New Rectangle(Me.leftMargen, Me.topMargen, Me.RightMargen, 0)
            Me.ReportHeaderRectangel = rr

        End If
    End Sub
    ''' <summary>
    ''' الشكل الافتراضي لمربع ذيل التقرير
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub defoultReportFooterRectangel()
        Dim y As Integer
        If IsLastPage Then
            y = Me.PageFooterRectangel.Height + Me.PageFooterRectangel.Top
        Else
            y = Me.buttomMargen - 50
        End If
        Dim rr As New Rectangle(Me.leftMargen, y, Me.RightMargen, 50)
        Me.ReportFooterRectangel = rr
    End Sub
    Private rtxt As String
    ''' <summary>
    ''' النص المكتوب في أول التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFooterString()
        Get
            Return rtxt
        End Get
        Set(ByVal value)
            rtxt = value
        End Set
    End Property
    ''' <summary>
    ''' اختبار ادا كانت الصفحة المطبوعة اول الصفحة او اخر الصفحة
    ''' </summary>
    ''' <remarks></remarks>
    Private IsFirstPage, IsLastPage As Boolean
    Private rtxtf As String
    ''' <summary>
    ''' النص المكتوب في ذيل التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportHeaderString()
        Get
            Return rtxtf
        End Get
        Set(ByVal value)
            rtxtf = value
        End Set
    End Property
    ''' <summary>
    ''' كتابة النص
    ''' </summary>
    ''' <param name="s">النص</param>
    ''' <param name="f">الخص</param>
    ''' <param name="sf">شكل الخط</param>
    ''' <param name="color">لون النص</param>
    ''' <remarks></remarks>
    Public Sub WtiteReportHeaderString(ByVal g As Graphics, ByVal s As String, ByVal f As Font, ByVal sf As StringFormat, ByVal color As SolidBrush)
        If Not IsFirstPage Then Exit Sub
        Me.defoultReportHeaderRectangel()
        ReportHeaderStringPosaion()
        g.DrawString(s, Me.FontReportHeader, color, Rhx, Rhy, sf)
    End Sub
    ''' <summary>
    '''   كتابة النص اسفل التقرير
    ''' </summary>
    ''' <param name="s">النص</param>
    ''' <param name="f">الخص</param>
    ''' <param name="sf">شكل الخط</param>
    ''' <param name="color">لون النص</param>
    ''' <remarks></remarks>
    Public Sub WtiteReportFooterString(ByVal g As Graphics, ByVal s As String, ByVal f As Font, ByVal sf As StringFormat, ByVal color As SolidBrush)
        If Not IsLastPage Then Exit Sub
        Me.defoultReportFooterRectangel()
        ReportFooterStringPosaion()
        g.DrawString(s, FontReportFooter, color, Rhx, Rhy, sf)
    End Sub
    ' نقاط وضع النص
    Private Rhx As Integer
    Private Rhy As Integer
    Private Sub ReportHeaderStringPosaion()
        Dim rec As New Rectangle
        rec = Me.ReportHeaderRectangel
        Rhx = rec.Left + (rec.Width) - SetReportHeaderStringFormat(SetStringAlighntReportHeader)
        Rhy = rec.Top + (Me.ReportHeaderRectangel.Height / 2)
    End Sub
    Public Rhyy As Integer
    Private Sub ReportFooterStringPosaion()
        Dim rec As New Rectangle
        rec = Me.ReportFooterRectangel
        Rhx = rec.Left + (rec.Width) - SetReportFooterStringFormat(SetStringAlighntReportFooter)
        Rhy = rec.Top + 50
        Rhyy = phy
    End Sub
    Private rfc As Color = Color.Black
    ''' <summary>
    '''لون نص التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFooterColor() As Color
        Get
            Return rfc
        End Get
        Set(ByVal value As Color)
            rfc = value
        End Set
    End Property
    Private Fsfr As Font
    ''' <summary>
    '''خط نص راس التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FontReportFooter() As Font
        Get
            Return Fsfr
        End Get
        Set(ByVal value As Font)
            Fsfr = value
        End Set
    End Property

    Private sffr As StringFormat
    ''' <summary>
    ''' شكل نص ذيل التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFooterStringFormat() As StringFormat
        Get
            Return sffr
        End Get
        Set(ByVal value As StringFormat)
            sffr = value
        End Set
    End Property

    Private rhc As Color = Color.Black
    ''' <summary>
    '''لون نص اعلى  التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportHeaderColor()
        Get
            Return rhc
        End Get
        Set(ByVal value)
            rhc = value
        End Set
    End Property
    Private Fshr As Font
    ''' <summary>
    '''خط نص راس التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FontReportHeader() As Font
        Get
            Return Fshr
        End Get
        Set(ByVal value As Font)
            Fshr = value
        End Set
    End Property

    Private sfhr As StringFormat
    ''' <summary>
    ''' شكل نص راس التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportHeaderStringFormat() As StringFormat
        Get
            Return sfhr
        End Get
        Set(ByVal value As StringFormat)
            sfhr = value
        End Set
    End Property
#End Region
#Region "اجراءات التحميل "
    ''' <summary>
    ''' استخراج تقرير جديد
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.DefoultPage()
    End Sub
    ''' <summary>
    ''' استخراج تقرير جديد
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal dg As DataGridView)
        Dim dgv As New DataGridView
        dgv = dg
        DataGridVeiw = dgv
        Me.DefoultPage()
    End Sub
    ''' <summary>
    ''' تحميل بيانات التقرير
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Loading()
        Me.DefoultPage()
    End Sub
    Public Enum myStingAllighin
        Right
        Left
        Center
    End Enum
    Private saph As myStingAllighin = myStingAllighin.Right
    ''' <summary>
    ''' وضع النص في رأس الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetStringAlighntpageHeader() As myStingAllighin
        Get
            Return saph
        End Get
        Set(ByVal value As myStingAllighin)
            saph = value
        End Set
    End Property
    Private sapf As myStingAllighin = myStingAllighin.Right
    ''' <summary>
    ''' وضع النص في ذيل الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetStringAlighntPageFooter() As myStingAllighin
        Get
            Return sapf
        End Get
        Set(ByVal value As myStingAllighin)
            sapf = value
        End Set
    End Property
    Private sarh As myStingAllighin = myStingAllighin.Right
    ''' <summary>
    ''' وضع النص في رأس التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetStringAlighntReportHeader() As myStingAllighin
        Get
            Return sarh
        End Get
        Set(ByVal value As myStingAllighin)
            sarh = value
        End Set
    End Property
    Private sarf As myStingAllighin = myStingAllighin.Right
    ''' <summary>
    ''' وضع النص في ذيل التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetStringAlighntReportFooter() As myStingAllighin
        Get
            Return sarf
        End Get
        Set(ByVal value As myStingAllighin)
            sarf = value
        End Set
    End Property
#End Region



#Region "لوحة التحكم"
    ''' <summary>
    ''' الشكل الافتراضي للصفحة
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub DefoultPage()
        IsFirstPage = True
        If hasMorPage Then
            IsFirstPage = False
        End If
        Dim ddd As New PrintDocument
        IsLastPage = False
        If isEnd Then
            IsLastPage = True
        End If
        ddd.DefaultPageSettings.Landscape = False
        MyPage = ddd

        MyNewpageMargine(50, MyPage.DefaultPageSettings.PaperSize.Width - 100, 50, MyPage.DefaultPageSettings.PaperSize.Height - 100, False)

        defoultReportHeaderRectangel()
        defoultHeaderRectangel()
        defoultFooterRectangel()
        defoultReportFooterRectangel()
        DefoultTableFrame()
        SetFontReport()
        SetMyStringAllighne()
        SetMyPicturePossion()
    End Sub
    ''' <summary>
    ''' تحديد هوامش الصفحة
    ''' </summary>
    ''' <param name="left">من اليسار </param>
    ''' <param name="right">من اليمين</param>
    ''' <param name="top">من الاعلى</param>
    ''' <param name="down">من السفل</param>
    ''' <param name="landscape">وضع الصفحة افقى ام عرضي</param>
    ''' <remarks></remarks>
    Public Sub MyNewpageMargine(Optional ByVal left As Integer = 50, Optional ByVal right As Integer = 850, Optional ByVal top As Integer = 50, Optional ByVal down As Integer = 1000, Optional ByVal landscape As Boolean = False)
        MyPage.DefaultPageSettings.Landscape = landscape
        Dim margine As New Printing.Margins(left, right, top, down)
        MyPage.DefaultPageSettings.Margins = margine
        leftMargen = MyPage.DefaultPageSettings.Margins.Left
        RightMargen = MyPage.DefaultPageSettings.Margins.Right
        topMargen = MyPage.DefaultPageSettings.Margins.Top
        buttomMargen = MyPage.DefaultPageSettings.Margins.Bottom




    End Sub
    Private Sub RedefoultPage()
        defoultReportHeaderRectangel()
        defoultHeaderRectangel()
        defoultFooterRectangel()
        defoultReportFooterRectangel()
    End Sub
    ''' <summary>
    ''' عمل الجدول المشكل لأطارالصفحة
    ''' </summary>
    ''' <param name="DashCap"></param>
    ''' <param name="widfh"></param>
    ''' <param name="DashSteyt"></param>
    ''' <param name="doublLine"></param>
    ''' <remarks></remarks>
    Public Sub SetFramTablePen(Optional ByVal DashCap As Drawing2D.DashCap = DashCap.Flat, Optional ByVal widfh As Integer = 1, Optional ByVal DashSteyt As Drawing2D.DashStyle = DashStyle.Custom, Optional ByVal doublLine As doublelines = doublelines.yes)

        Dim p As New Pen(Me.FrameColor)
        p.DashCap = DashCap
        p.Width = widfh
        p.DashStyle = DashSteyt
        Me.FramePen = p
        Me.Doubleline = doublLine
    End Sub
    ''' <summary>
    ''' اعادة تحميل
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reload()
        IsFirstPage = True
        If hasMorPage Then
            IsFirstPage = False
        End If
        Dim ddd As New PrintDocument
        IsLastPage = False
        If isEnd Then
            IsLastPage = True
        End If
        ddd.DefaultPageSettings.Landscape = True
        MyPage = ddd


        defoultReportHeaderRectangel()
        defoultHeaderRectangel()
        defoultFooterRectangel()
        defoultReportFooterRectangel()
        DefoultTableFrame()
        SetFontReport()
        SetMyStringAllighne()
        SetMyPicturePossion()

    End Sub
    ''' <summary>
    ''' عمل الجدول المشكل لأطارالصفحة
    ''' </summary>
    ''' <param name="DashCap"></param>
    ''' <param name="widfh"></param>
    ''' <param name="DashSteyt"></param>
    ''' <param name="doublLine"></param>
    ''' <remarks></remarks>
    Public Sub SetFramReportPen(Optional ByVal DashCap As Drawing2D.DashCap = DashCap.Flat, Optional ByVal widfh As Integer = 1, Optional ByVal DashSteyt As Drawing2D.DashStyle = DashStyle.Custom, Optional ByVal doublLine As doublelines = doublelines.yes)

        Dim p As New Pen(Me.ReportFrameColor)
        p.DashCap = DashCap
        p.Width = widfh
        p.DashStyle = DashSteyt
        Me.ReportFramePen = p
        Me.DoubleReportline = doublLine
    End Sub





    ''' <summary>
    ''' شكل الوان الخطوط المشكلة للجدول
    ''' </summary>
    ''' <param name="fc">اطار الجدول</param>
    ''' <param name="rc">صف الجدول</param>
    ''' <param name="cc"> عملو الجدول</param>
    ''' <param name="hcc">اللون الوسطي في رأس الجدول</param>
    ''' <param name="hcs">اللون الطرفي في رأس الجدول</param>
    ''' <remarks></remarks>
    Public Sub SetTableColor(ByVal fc As Color, ByVal rc As Color, ByVal cc As Color, ByVal hcc As Color, ByVal hcs As Color)
        Me.FrameColor = fc
        Me.RowColor = rc
        Me.CullomColor = cc
        Me.Headercolor1 = hcc
        Me.Headercolor2 = hcs
        SetCullomPen()
        SetRowPen()

    End Sub
    ''' <summary>
    ''' شكل الخط الفاصل بين الصفين
    ''' </summary>
    ''' <param name="DashCap"></param>
    ''' <param name="widfh"></param>
    ''' <param name="DashSteyt"></param>
    ''' <remarks></remarks>
    Public Sub SetRowPen(Optional ByVal DashCap As Drawing2D.DashCap = DashCap.Flat, Optional ByVal widfh As Integer = 1, Optional ByVal DashSteyt As Drawing2D.DashStyle = DashStyle.Custom)
        Dim p As New Pen(RowColor)
        p.DashCap = DashCap
        p.Width = widfh
        p.DashStyle = DashSteyt
        Me.rowPen = p
    End Sub
    ''' <summary>
    ''' شكل الخط الفاصل بين العمودين
    ''' </summary>
    ''' <param name="DashCap"></param>
    ''' <param name="widfh"></param>
    ''' <param name="DashSteyt"></param>
    ''' <remarks></remarks>
    Public Sub SetCullomPen(Optional ByVal DashCap As Drawing2D.DashCap = DashCap.Flat, Optional ByVal widfh As Integer = 1, Optional ByVal DashSteyt As Drawing2D.DashStyle = DashStyle.Custom)
        Dim p As New Pen(Me.CullomColor)
        p.DashCap = DashCap
        p.Width = widfh
        p.DashStyle = DashSteyt
        Me.cullomePen = p
    End Sub
    Public Sub SetRepotFrameColor(ByVal c As Color)
        Me.ReportFrameColor = c
    End Sub
    ''' <summary>
    '''  رسم الجدول
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>

    Public Sub Drowtable(ByVal g As Graphics)


        DrowFram(g)
        DrowHeader(g)

        DrowRow(g)
        Drowcullome(g)
        drowString(g)
      
    End Sub
    Private Sub Tableposs(ByVal i As Integer)
        Select Case i
            Case 1
                Me.TableLeft = RightMargen / 2 - Me.TableWidth
            Case 2
                Me.TableLeft = RightMargen / 2 + 5
            Case 3
                Exit Sub
        End Select

    End Sub
    ''' <summary>
    ''' عمل خط في بيانات الجدول
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Overloads Sub SetTextFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 8, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Regular)
        Dim f As New Font(fonttype, size, fontStyl)
        Me.font = f

    End Sub
    ''' <summary>
    ''' عمل خط في بيانات الجدول
    ''' </summary>
    ''' <param name="f"></param>
    ''' <remarks></remarks>
    Public Overloads Sub SetTextFont(ByVal f As Font)

        Me.font = f

    End Sub

    ''' <summary>
    ''' عمل خط في بيانات الجدول
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub SetTextFontWithDataGrid()

        Me.font = Me.DataGridVeiw.DefaultCellStyle.Font

    End Sub

    ''' <summary>
    ''' الوان الخطوط البيانات في الجدول
    ''' </summary>
    ''' <param name="fc">بيانات الجدول</param>
    ''' <param name="FHc">بيانات رأس عمود الجدول</param>
    ''' <remarks></remarks>
    Public Sub SetFontcolor(ByVal fc As Color, ByVal FHc As Color)
        FontColor = fc
        HeaderFontColor = FHc

    End Sub
    ''' <summary>
    ''' عمل خط في بيانات راس الجدول
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Sub SetTextHeaderFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 12, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Bold)
        Dim f As New Font(fonttype, size, fontStyl)
        HeaderFont = f
    End Sub
    ''' <summary>
    ''' عمل خط في بيانات راس الجدول
    ''' </summary>
        ''' <remarks></remarks>
    Public Sub SetTextHeaderFont(ByVal ff As Font)
        Dim f As Font
        f = ff
        HeaderFont = ff
    End Sub



    ''' <summary>
    ''' عمل خط في رأس الصفحة
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Sub SetPageHeaderFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 12, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Bold)
        Dim f As New Font(fonttype, size, fontStyl)
        FontPageHeader = f
    End Sub
    ''' <summary>
    ''' خطوط الرأس وذيل التقرير
    ''' </summary>
    ''' <param name="rhf">راس التقرير</param>
    ''' <param name="phf">راس الصفحة</param>
    ''' <param name="rff">ذيل التقرير</param>
    ''' <param name="pff">ذيل الصفحة</param>
    ''' <remarks></remarks>
    Public Sub setReportPageFont(ByVal rhf As Font, ByVal phf As Font, ByVal rff As Font, ByVal pff As Font)
        FontReportHeader = rhf
        FontReportFooter = rff
        FontPageFooter = pff
        FontPageHeader = phf
    End Sub
    ''' <summary>
    ''' عمل خط في ذيل الصفحة
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Sub SetPageFooterFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 12, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Bold)
        Dim f As New Font(fonttype, size, fontStyl)
        FontPageFooter = f
    End Sub
    ''' <summary>
    ''' عمل خط في رأس التقرير
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Sub SetReportFooterFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 12, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Bold)
        Dim f As New Font(fonttype, size, fontStyl)
        FontReportFooter = f
    End Sub
    ''' <summary>
    ''' عمل خط في رأس التقرير
    ''' </summary>
    ''' <param name="fonttype">اسم الخط</param>
    ''' <param name="size">حجم الخط</param>
    ''' <param name="fontStyl">الشكل</param>
    ''' <remarks></remarks>
    Public Sub SetReportHeaderFont(Optional ByVal fonttype As String = "Times New Roman", Optional ByVal size As Integer = 12, Optional ByVal fontStyl As Drawing.FontStyle = FontStyle.Bold)
        Dim f As New Font(fonttype, size, fontStyl)
        FontReportHeader = f
    End Sub
    ''' <summary>
    ''' الوان الخطوط
    ''' </summary>
    ''' <param name="rhc">راس التقرير</param>
    ''' <param name="rfc">ذيل التقرير</param>
    ''' <param name="phc">راس الصفحة</param>
    ''' <param name="pfc">ذيل الصفحة</param>
    ''' <remarks></remarks>
    Public Sub SetReportFontColor(ByVal rhc As Color, ByVal rfc As Color, ByVal phc As Color, ByVal pfc As Color)
        PageHeaderColor = phc
        PageFooterColor = pfc
        ReportFooterColor = rfc
        ReportHeaderColor = rhc
    End Sub
    ''' <summary>
    ''' ادخال النصوص رأس وذيل التقرير
    ''' </summary>
    ''' <param name="hs">الراس</param>
    ''' <param name="fs">الذيل</param>
    ''' <remarks></remarks>
    Public Sub SetReportText(Optional ByVal hs As String = "رأس التقرير", Optional ByVal fs As String = "ذيل التقرير")
        ReportFooterString = fs
        ReportHeaderString = hs
    End Sub
    ''' <summary>
    ''' ادخال النصوص رأس وذيل الصفحة
    ''' </summary>
    ''' <param name="hs">الراس</param>
    ''' <param name="fs">الذيل</param>
    ''' <remarks></remarks>
    Public Sub SetpageText(Optional ByVal hs As String = "رأس الصفحة", Optional ByVal fs As String = "ذيل الصفحة")
        PageFooterString = fs
        PageheaderString = hs
    End Sub
    ''' <summary>
    ''' الخطوط الافتراضية
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetFontReport()
        SetPageFooterFont()
        SetPageHeaderFont()
        SetReportHeaderFont()
        SetReportFooterFont()
        SetTextFont()
        SetTextHeaderFont()
    End Sub
    Private Function SetPageHeaderStringFormat(Optional ByVal A As myStingAllighin = myStingAllighin.Right) As Integer
        Select Case A
            Case myStingAllighin.Center
                Return Me.PageHeaderRectangel.Width / 2
                Me.PageHeaderStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft
            Case myStingAllighin.Left
                Return (Me.PageHeaderRectangel.Width - 100)
                Me.PageHeaderStringFormat.FormatFlags = StringFormatFlags.FitBlackBox
            Case myStingAllighin.Right
                Return 100
                Me.PageHeaderStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        End Select
    End Function
    Private Function SetReportFooterStringFormat(Optional ByVal A As myStingAllighin = myStingAllighin.Right) As Integer
        Select Case A
            Case myStingAllighin.Center
                Return Me.ReportFooterRectangel.Width / 2
                Me.ReportFooterStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft
            Case myStingAllighin.Left
                Return Me.ReportFooterRectangel.Width - 100
                Me.ReportFooterStringFormat.FormatFlags = StringFormatFlags.FitBlackBox
            Case myStingAllighin.Right
                Return 100
                Me.ReportFooterStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        End Select
    End Function
    Private Function SetReportHeaderStringFormat(Optional ByVal A As myStingAllighin = myStingAllighin.Right) As Integer
        Select Case A
            Case myStingAllighin.Center
                Return Me.ReportHeaderRectangel.Width / 2
                Me.ReportHeaderStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft
            Case myStingAllighin.Left
                Return ReportHeaderRectangel.Width - 100
                Me.ReportHeaderStringFormat.FormatFlags = StringFormatFlags.FitBlackBox
            Case myStingAllighin.Right
                Return 100
                Me.ReportHeaderStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        End Select
    End Function

    Private Function SetPageFooterStringFormat(Optional ByVal A As myStingAllighin = myStingAllighin.Right) As Integer
        Select Case A
            Case myStingAllighin.Center
                Return Me.ReportFooterRectangel.Width / 2
                Me.PageFooterStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft
            Case myStingAllighin.Left
                Return Me.ReportFooterRectangel.Width - 100
                Me.PageFooterStringFormat.FormatFlags = StringFormatFlags.FitBlackBox
            Case myStingAllighin.Right
                Return 100
                Me.PageFooterStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        End Select
    End Function

    ''' <summary>
    ''' وضع النصوص في التقرير
    ''' </summary>
    ''' <param name="rh">رأس التفرير</param>
    ''' <param name="rf">ذيل التقرير</param>
    ''' <param name="ph">راس الصفحة</param>
    ''' <param name="pf">ذيل الصفحة</param>
    ''' <remarks></remarks>
    Public Sub SetMyStringAllighne(Optional ByVal rh As myStingAllighin = myStingAllighin.Right, Optional ByVal rf As myStingAllighin = myStingAllighin.Right, Optional ByVal ph As myStingAllighin = myStingAllighin.Right, Optional ByVal pf As myStingAllighin = myStingAllighin.Right)
        SetStringAlighntPageFooter = pf
        SetStringAlighntpageHeader = ph
        SetStringAlighntReportFooter = rf
        SetStringAlighntReportHeader = rh
    End Sub
#End Region
#Region "تنسيقات الصفحة"
    Private img As Image
    ''' <summary>
    ''' الشعار التي سيتم وضعه في التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyImage() As Image
        Get
            Return img
        End Get
        Set(ByVal value As Image)
            img = value
        End Set
    End Property

    Private imgR As Rectangle
    ''' <summary>
    ''' مربع اطار التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyImageRectangel() As Rectangle
        Get
            Return imgR
        End Get
        Set(ByVal value As Rectangle)
            imgR = value
        End Set
    End Property
    Private pr As Integer
    Private pl As Integer
    Private pt As Integer
    Private pb As Integer
    ''' <summary>
    ''' عرض الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pictureWidth() As Integer
        Get
            Return pr
        End Get
        Set(ByVal value As Integer)
            pr = value
        End Set
    End Property
    ''' <summary>
    ''' شمال التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pictureLeft() As Integer
        Get
            Return pl
        End Get
        Set(ByVal value As Integer)
            pl = value
        End Set
    End Property
    ''' <summary>
    ''' رأس الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pictureTop() As Integer
        Get
            Return pt
        End Get
        Set(ByVal value As Integer)
            pt = value
        End Set
    End Property
    ''' <summary>
    ''' ارتفاع الاطار
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pictureHight() As Integer
        Get
            Return pb
        End Get
        Set(ByVal value As Integer)
            pb = value
        End Set
    End Property
    Private CanDrow As Boolean
    ''' <summary>
    ''' رسم الصورة
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub DrowPicture(ByVal g As Graphics)
        Try
            If Me.MyImage Is Nothing Then Exit Sub
            g.DrawImage(MyImage, MyImageRectangel)
        Catch ex As Exception

        End Try

    End Sub
    Private mypicp As PicturePossion
    ''' <summary>
    ''' لتحديدموقع الصورة في التقرير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyImagePossion() As PicturePossion
        Get
            Return mypicp
        End Get
        Set(ByVal value As PicturePossion)
            mypicp = value
        End Set
    End Property
    ''' <summary>
    ''' تحديد موقع الصورة في التقير
    ''' </summary>
    ''' <param name="p">مكان الصورة</param>
    ''' <param name="a">ازاحة</param>
    ''' <param name="w">العرض و الطول</param>
    ''' <remarks></remarks>
    Public Sub SetMyPicturePossion(Optional ByVal p As PicturePossion = PicturePossion.UpRight, Optional ByVal a As Integer = 30, Optional ByVal w As Integer = 50)
        If w > 50 Then w = 50
        Select Case p
            Case PicturePossion.UpRight
                Me.pictureLeft = Me.RightMargen
                Me.pictureWidth = w
                Me.pictureTop = Me.topMargen - a
                Me.pictureHight = w
            Case PicturePossion.UpLeft
                Me.pictureLeft = Me.leftMargen - a
                Me.pictureWidth = w
                Me.pictureTop = Me.topMargen - a
                Me.pictureHight = w
            Case PicturePossion.DownRight
                Me.pictureLeft = Me.RightMargen
                Me.pictureWidth = w
                Me.pictureTop = Me.buttomMargen
                Me.pictureHight = w
            Case PicturePossion.DownLeft
                Me.pictureLeft = Me.leftMargen - a
                Me.pictureWidth = w
                Me.pictureTop = Me.buttomMargen
                Me.pictureHight = w

        End Select
        Dim rec As New Rectangle(pictureLeft, pictureTop, pictureWidth, pictureHight)
        MyImageRectangel = rec
    End Sub
    ''' <summary>
    ''' اخذ الصورة
    ''' </summary>
    ''' <param name="img"></param>
    ''' <remarks></remarks>
    Public Sub SetImage(ByVal img As Image)
        MyImage = img
        SetMyPicturePossion(PicturePossion.UpLeft)
    End Sub
    Public Enum PicturePossion
        ''' <summary>
        ''' اعلى يمين
        ''' </summary>
        ''' <remarks></remarks>
        UpRight
        ''' <summary>
        ''' اعلى يسار
        ''' </summary>
        ''' <remarks></remarks>
        UpLeft
        ''' <summary>
        ''' اسفل يمين 
        ''' </summary>
        ''' <remarks></remarks>
        DownRight
        ''' <summary>
        ''' اسفل يسار
        ''' </summary>
        ''' <remarks></remarks>
        DownLeft
    End Enum
    Private ta As myStingAllighin
    Public Property MyTextAlighn() As myStingAllighin
        Get
            Return ta
        End Get
        Set(ByVal value As myStingAllighin)
            ta = value
        End Set
    End Property
#Region "الاطار"
    Private rett As Rectangle
    ''' <summary>
    ''' مربع البرواز
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFrame() As Rectangle
        Get
            Return rett
        End Get
        Set(ByVal value As Rectangle)
            rett = value
        End Set
    End Property
    Private rpp As Pen
    ''' <summary>
    ''' قلم البرواز
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFramePen() As Pen
        Get
            Return rpp
        End Get
        Set(ByVal value As Pen)
            rpp = value
        End Set
    End Property
    ''' <summary>
    ''' رسم البرواز بالاطوال الافتراضية
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub DrowReportFram(ByVal g As Graphics)
        'DefoultPage()
        Dim l As Integer = leftMargen - 40
        Dim T As Integer = topMargen - 40
        Dim W As Integer = RightMargen + 75
        Dim H As Integer = buttomMargen + 50

        Dim rec As New Rectangle(l, T, W, H)
        TableFrame = rec
        SetFramReportPen()
        g.DrawRectangle(ReportFramePen, TableFrame)

        DoubleReportFrame(g)
    End Sub
    Private Sub DoubleReportFrame(ByVal g As Graphics)
        Dim l As Integer = leftMargen - 40
        Dim T As Integer = topMargen - 40
        Dim W As Integer = RightMargen + 75
        Dim H As Integer = buttomMargen + 50

        Dim rec1 As New Rectangle(l - 2, T - 2, W + 5, H + 5)
        Dim pen1 As Pen
        pen1 = FramePen
        pen1.Width = 2
        If Doubleline = doublelines.yes Then
            g.DrawRectangle(pen1, rec1)
        End If
    End Sub
    Private rdl As doublelines = doublelines.yes
    ''' <summary>
    ''' هل يتم رسم البرواز بشكل مزدوج 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DoubleReportline() As doublelines
        Get
            Return dl
        End Get
        Set(ByVal value As doublelines)
            dl = value
        End Set
    End Property



    Private ReFC As Color = Color.Blue
    ''' <summary>
    ''' لون البرواز
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFrameColor() As Color
        Get
            Return ReFC
        End Get
        Set(ByVal value As Color)
            ReFC = value
        End Set
    End Property
#End Region
#End Region
    Public Sub Fenish()
        Me.Cullome = Nothing
        Me.Row = Nothing
        Me.Endrow = 0
        Me.CurrentRow = 0
        Me.IsLastPage = False
        Me.IsFirstPage = True
        Me.Finalize()
    End Sub
    Private mys As MySimpleReport
    Public Property MySimpileReport() As MySimpleReport
        Get
            Return mys
        End Get
        Set(ByVal value As MySimpleReport)
            mys = value
        End Set
    End Property
    Private Sub loodMe()
        MySimpileReport = Me
    End Sub
End Class



