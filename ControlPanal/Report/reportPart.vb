Imports System.Drawing
Imports System.Drawing.Drawing2D
#Region "اجزاء التقرير"
Public Class reportPart
    '  هذا الجزء هو وحدة بناء التقرير 
    'يتم وضع فيه كل خصائص الجزء بحيث يمكنك ان ترسم المربع و تكتب البيانات عليه
    ' يجب ان نعرف ان هذه الجزء لا يحوي على اجراءات البيانات الاضافية فهو ياخد ويتم تعديل البيانات
    'عليه
    '
    '
    '
    '"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
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
    Private recs As Rectangle
    ''' <summary>
    ''' المساحة المطلوبة في التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Rectangle() As Rectangle
        Get
            Return recs
        End Get
        Set(ByVal value As Rectangle)
            recs = value
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
    Private Strx, Stry As Integer
    ''' <summary>
    ''' موقع النص الافقي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StringX() As Integer
        Get
            Return Strx
        End Get
        Set(ByVal value As Integer)
            Strx = value
        End Set
    End Property
    ''' <summary>
    ''' موقع النص الراسي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Stringy() As Integer
        Get
            Return Stry
        End Get
        Set(ByVal value As Integer)
            Stry = value
        End Set
    End Property
    Private SF As New StringFont
    ''' <summary>
    ''' شكل النص المكتوب داخل الاطار 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StringFont() As StringFont
        Get
            Return SF
        End Get
        Set(ByVal value As StringFont)
            SF = value
        End Set
    End Property

#Region "Sittings"
    Public Sub reCtSetting(ByVal l As Integer, ByVal t As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim rec As New Rectangle(l, t, w, h)
        Me.Rectangle = rec
        TextPossision(Me.StringFont.Allignt)
    End Sub
    Private dublLine As Boolean
    ''' <summary>
    ''' هل يكتب النص على عدة اسطر ؟؟
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Is_DoubleLineString() As Boolean
        Get
            Return dublLine
        End Get
        Set(ByVal value As Boolean)
            dublLine = value
        End Set
    End Property
    ''' <summary>
    '''  لتحديد المساحة
    ''' </summary>
    ''' <param name="rect"></param>
    ''' <remarks></remarks>
    Public Sub reCtSetting(ByVal rect As Rectangle)
        Dim rec As New Rectangle
        Dim enrec As New Rectangle
        rec = rect
        enrec.X = rec.X + 5
        enrec.Y = rec.Y + 5
        enrec.Height = rec.Height - 10
        enrec.Width = rec.Width - 10
        Me.Rectangle = rec

        If isFramDouble Then
            InternelRectangle = enrec
        Else
            InternelRectangle = rec
        End If
        TextPossision(Me.StringFont.Allignt)
    End Sub
    ''' <summary>
    ''' لتحديد شكل الاطار
    ''' </summary>
    ''' <param name="c">اللون</param>
    ''' <param name="w">حجم الاطار</param>
    ''' <param name="isFdouble"></param>
    ''' <remarks></remarks>
    Public Sub FramSetting(ByVal c As Color, ByVal w As Single, Optional ByVal isFdouble As Boolean = True)
        Dim p As New Pen(c, w)
        FramColor = p
        isFramDouble = isFdouble
    End Sub
    ''' <summary>
    ''' لتحديد قلم رسم الاطار
    ''' </summary>
    ''' <param name="p"></param>
    ''' <remarks></remarks>
    Public Sub FramSetting(ByVal p As Pen)
        FramColor = p
    End Sub
    ''' <summary>
    ''' لتحديد لون الخلفية
    ''' </summary>
    ''' <param name="brush"></param>
    ''' <remarks></remarks>
    Public Sub BackColorSetting(ByVal brush As Brush)
        Dim b As Brush
        b = brush
        BackColor = b
    End Sub
    ''' <summary>
    ''' لتحديد شكل النص
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="Alli"></param>
    ''' <remarks></remarks>
    Public Sub SetText(ByVal txt As String, ByVal Alli As allinge)
        StringFont.text = txt
        StringFont.Allignt = TextPossision(Alli)
        StringFont.DeffoultFontSetting()
    End Sub
    Private Stringsx, stringsy As Integer
    Private Function TextPossision(ByVal a As allinge) As allinge

        Select Case a
            Case allinge.reight
                Me.StringX = InternelRectangle.Right - 2
                Me.Stringy = InternelRectangle.Top + 1
            Case allinge.Center
                Me.StringX = InternelRectangle.X + (InternelRectangle.Width / 2)
                Me.Stringy = InternelRectangle.Top + 1
            Case allinge.left
                Me.StringX = InternelRectangle.Left + 2
                Me.Stringy = InternelRectangle.Top + 1
        End Select

        Return a
    End Function

    Public Sub Print_Rect(ByVal g As Graphics)
        g.FillRectangle(BackColor, Rectangle)
        If Me.isFramDouble Then
            Dim p As New Pen(FramColor.Color, FramColor.Width * 2)
            g.DrawRectangle(p, Me.InternelRectangle)
            g.DrawRectangle(FramColor, Rectangle)

        Else
            g.DrawRectangle(FramColor, Rectangle)
        End If
    End Sub
    Public Sub Print_String(ByVal g As Graphics, Optional ByVal isdouble As Boolean = False)
        If isdouble Then
            Print_DoubleLineString(g)
            Exit Sub
        End If
        Dim b As New SolidBrush(StringFont.ForeColor)
        g.DrawString(StringFont.text, StringFont.Font, b, StringX, Stringy, StringFont.StringFormat)
    End Sub

    Private Sub Print_DoubleLineString(ByVal g As Graphics)
        Dim b As New SolidBrush(StringFont.ForeColor)
        g.DrawString(StringFont.text, StringFont.Font, b, inrecs, StringFont.StringFormat)
    End Sub
#End Region

    Public Sub New()

    End Sub
End Class
#End Region

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
#Region "Text"
''' <summary>
''' النص 
''' </summary>
''' <remarks></remarks>
Public Class StringFont
    Private rs As RectangleF
    ''' <summary>
    ''' يحدد المحيط الذي يكتب النص بداخله
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StringRect As RectangleF
        Get
            Return rs
        End Get
        Set(value As RectangleF)

            rs = value
        End Set
    End Property
    Private s As String
    ''' <summary>
    '''  النص
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property text As String
        Get
            Return s
        End Get
        Set(value As String)
            s = value
        End Set
    End Property
    Private fc As Color
    ''' <summary>
    ''' لون الخط
    '''
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ForeColor As Color
        Get
            Return fc
        End Get
        Set(value As Color)
            fc = value
        End Set
    End Property
    Private f As Font
    Public Property Font As Font
        Get
            Return f
        End Get
        Set(value As Font)
            f = value
        End Set
    End Property
    Private fs As StringFormat
    Public Property StringFormat As StringFormat
        Get
            Return fs
        End Get
        Set(value As StringFormat)
            fs = value
        End Set
    End Property
    Public a As allinge
    Public Property Allignt As allinge
        Get
            Return a
        End Get
        Set(value As allinge)
            a = value
        End Set
    End Property
#Region "اجراءات"
    Public Sub New()

    End Sub

    Public Sub New(txt As String)
        text = txt

    End Sub
  
    Public Sub SetFont(FC As Color, font As Font)
        ForeColor = FC
        Me.Font = font
        AlligneStringFormat()
    End Sub

    Public Sub AlligneStringFormat()
        Dim a As allinge = Allignt
        Select Case a
            Case allinge.Center
                Dim sf As New StringFormat
                sf.FormatFlags = StringFormatFlags.DirectionRightToLeft
                sf.Alignment = StringAlignment.Center
                StringFormat = sf
            Case allinge.left
                Dim sf As New StringFormat
                                 StringFormat = sf
            Case allinge.reight
                Dim sf As New StringFormat
                sf.FormatFlags = StringFormatFlags.DirectionRightToLeft
                sf.Alignment = StringAlignment.Near
                StringFormat = sf
        End Select

    End Sub

    Public Sub DeffoultFontSetting()
        Dim ff As New Font("Tahoma", 8)
        ForeColor = Color.Black
        Font = ff
        AlligneStringFormat()
    End Sub
   
#End Region
End Class
Public Enum allinge
    Center
    left
    reight
End Enum
#End Region