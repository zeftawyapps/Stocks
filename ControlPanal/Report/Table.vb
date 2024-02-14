Imports System.Linq.Expressions
Imports System.Linq
Public Class Table
    Public Sub New()
        DefFrameSetting()
    End Sub
    Private Tsf As New StringFont
    ''' <summary>
    ''' لتحديد نص خلايا الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableStringFont As StringFont
        Get
            Return Tsf
        End Get
        Set(ByVal value As StringFont)
            Tsf = value
        End Set
    End Property

    Private Thsf As New StringFont
    ''' <summary>
    ''' لتحديد نص راس الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableHeadStringFont As StringFont
        Get
            Return Thsf
        End Get
        Set(ByVal value As StringFont)
            Thsf = value
        End Set
    End Property
    Private prntme As Boolean
    ''' <summary>
    ''' اطبعني
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property PrintMe As Boolean
        Get
            Return prntme
        End Get
        Set(ByVal value As Boolean)
            prntme = value
        End Set
    End Property


    Private prntmore As Boolean
    ''' <summary>
    ''' طباعة جداول متعددة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property PrintMoreTable As Boolean
        Get
            Return prntmore
        End Get
        Set(ByVal value As Boolean)
            prntmore = value
        End Set
    End Property
    Private GetSource As New GetDataFromDataGrideView
    Public Property DataSource As GetDataFromDataGrideView
        Get
            Return GetSource
        End Get
        Set(ByVal value As GetDataFromDataGrideView)
            GetSource = value
        End Set
    End Property

    Private Tab As New reportPart
    ''' <summary>
    ''' اطار الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableFrame As reportPart
        Get
            Return Tab
        End Get
        Set(ByVal value As reportPart)
            Tab = value
        End Set
    End Property

    Private moreTab As reportPart()
    ''' <summary>
    ''' اطار الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MoreTableFrame() As reportPart()
        Get
            Return moreTab
        End Get
        Set(ByVal value As reportPart())
            moreTab = value
        End Set
    End Property

#Region "اعدادات الجدول"
    Public Sub SetFrameColors(ByVal bc As Brush, ByVal fc As Color, ByVal w As Single, Optional ByVal isdf As Boolean = True)
        TableFrame.BackColorSetting(bc)
        TableFrame.FramSetting(fc, w)
        isDoubleFrame = isdf
    End Sub


    Public Sub SetFrameHeadColors(ByVal bc As Brush, ByVal fc As Color, ByVal w As Single)
        RowHead.BackColorSetting(bc)
        RowHead.FramSetting(fc, w)
    End Sub
    Public Sub SetFrameHeadColors(ByVal bc As Brush)
        RowHead.BackColorSetting(bc)

    End Sub
    Public Sub DefFrameSetting()
        SetFrameColors(Brushes.White, Color.Black, 1)
        Tablelood()
    End Sub
    Public Sub DefFrameheadSetting()
        SetFrameHeadColors(Brushes.Gray, Color.Black, 1)
    End Sub
    Public Sub DeffTableFrame()
        Dim rect As New Rectangle
        rect.Width = DataSource.DataTableWidth
        rect.X = AllowArea.Right / 2 - rect.Width / 2
        rect.Y = AllowArea.Y
        rect.Height = DataSource.DataTablehight
        TableFrame.reCtSetting(rect)
    End Sub

    Private Overloads Sub SetTableDestenations(ByVal t As Integer, ByVal l As Integer, ByVal h As Integer, ByVal w As Integer)
        TableFrame.reCtSetting(l, t, h, w)
    End Sub

    Private Overloads Sub SetTableDestenations(ByVal rec As Rectangle)
        Dim i As New Rectangle
        i = rec
        TableFrame.Rectangle = i
    End Sub

    Public Overloads Sub SetAllowAreaDestenations(ByVal t As Integer, ByVal l As Integer, ByVal h As Integer, ByVal w As Integer)
        Dim i As New Rectangle(l, t, w, h)
        AllowArea = i
    End Sub

    Public Overloads Sub SetAllowAreaDestenations(ByVal rec As Rectangle)
        Dim i As New Rectangle
        i = rec
        AllowArea = i
    End Sub
#End Region
    Private Crect As Rectangle()
    ''' <summary>
    ''' الاعمدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Column() As Rectangle()
        Get
            Return Crect
        End Get
        Set(ByVal value As Rectangle())
            Crect = value
        End Set
    End Property
    Private Rrect As Rectangle()
    ''' <summary>
    ''' الصفوف
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Row() As Rectangle()
        Get
            Return Rrect
        End Get
        Set(ByVal value As Rectangle())
            Rrect = value
        End Set
    End Property


    Private Rhead As New reportPart
    ''' <summary>
    ''' راس الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowHead() As reportPart
        Get
            Return Rhead
        End Get
        Set(ByVal value As reportPart)
            Rhead = value
        End Set
    End Property

    Private R, C As Integer
    ''' <summary>
    ''' عدد الصفوف
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowCount() As Integer
        Get
            Return R
        End Get
        Set(ByVal value As Integer)
            R = value
        End Set
    End Property
    ''' <summary>
    ''' عدد الاعمدة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ColumnCount() As Integer
        Get
            Return C
        End Get
        Set(ByVal value As Integer)
            C = value
        End Set
    End Property
    Private Cell(,) As reportPart
    Public Property TableCell() As reportPart(,)
        Get
            Return Cell
        End Get
        Set(ByVal value As reportPart(,))
            Cell = value
        End Set
    End Property


    Private hCell() As reportPart
    Public Property TableHeadCell() As reportPart()
        Get
            Return hCell
        End Get
        Set(ByVal value As reportPart())
            hCell = value
        End Set
    End Property

    Private AllAria As New Rectangle
    ''' <summary>
    ''' المنطقة المسموع بالطباعة بها
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AllowArea() As Rectangle
        Get
            Return AllAria
        End Get
        Set(ByVal value As Rectangle)
            AllAria = value
        End Set
    End Property
#Region "اجراءات  تخص الجدول"
    Public Sub setData(ByVal Dg As DataGridView, Optional ByVal rtl As Boolean = True)
        DataSource.DataGrideView = Dg
        ReToLeft = rtl 'لتحديد اطوال العمود بعد التعديل الاخير 
        DataSource.IsFirstPage = True
    End Sub
    Friend Sub GetData()
        ' اخذ بيانات وتصميم جدول واحد داخل صفحة التقرير
        DataSource.GetDataFromDGV()
        DeffTableFrame()

        DGV_setTableCulume(ReToLeft)
        DGV_setTableRow()
        DGV_SetTableCells()
        DGV_SetTableheadCells()

        'لتحديد اطوال العمود بعد التعديل الاخير 
        DGV_setTableCulume(ReToLeft)

    End Sub

    Friend Sub GetDataToMoreTable()
        ' اخذ بيانات وتصميم عدة جدول   داخل صفحة التقرير
        DataSource.GetDataFromDGV()
        DeffTableFrame()

        DGV_setTableCulume(ReToLeft)
        DGV_setTableRow()
        DGV_SetTableCells()
        DGV_SetTableheadCells()

        'لتحديد اطوال العمود بعد التعديل الاخير 
        DGV_setTableCulume(ReToLeft)

    End Sub

    Public Function isAllowWidth() As Boolean
        If Me.DataSource.DataTableWidth > AllowArea.Width Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function isNotAllowheight() As Boolean
        If Me.DataSource.DataTablehight < AllowArea.Height Then
            Return False
        Else
            Return True
        End If
    End Function

    Private ReToLeft As Boolean
    Private Sub DGV_setTableCulume(Optional ByVal rtl As Boolean = True)
        If Not isAllowWidth() Then Exit Sub
        '' يحدد موقع  الاعمدة و لصفوف في الجدول داخل الصفحة
        If rtl Then
            ' اذا كانت اللغة عربيه
            Dim dg As New DataGridView
            dg = DataSource.DataGrideView
            Dim cc As Integer
            cc = dg.Columns.Count
            ColumnCount = cc
            Dim Cs(cc - 1) As Rectangle

            For i As Integer = 0 To cc - 1
                Dim c As New Rectangle
                If i = 0 Then
                    c.Y = TableFrame.Rectangle.Y
                    c.Height = TableFrame.Rectangle.Height
                    c.Width = dg.Columns.Item(i).Width + 20
                    c.X = TableFrame.Rectangle.X + TableFrame.Rectangle.Width - c.Width
                Else
                    c.Y = TableFrame.Rectangle.Y
                    c.Height = TableFrame.Rectangle.Height
                    c.Width = dg.Columns.Item(i).Width + 20
                    c.X = Cs(i - 1).X - c.Width
                End If

                Cs(i) = c
                Column = Cs
            Next
        Else
            ' اذا كانت اللغة انجليزية
            Dim dg As New DataGridView
            dg = DataSource.DataGrideView
            Dim cc As Integer
            cc = dg.Columns.Count
            ColumnCount = cc
            Dim Cs(cc - 1) As Rectangle
            For i As Integer = 0 To cc - 1
                Dim c As New Rectangle
                If i = 0 Then
                    c.Y = TableFrame.Rectangle.Y
                    c.Height = TableFrame.Rectangle.Height
                    c.Width = dg.Columns.Item(i).Width
                    c.X = TableFrame.Rectangle.X
                Else
                    c.Y = TableFrame.Rectangle.Y
                    c.Height = TableFrame.Rectangle.Height
                    c.Width = dg.Columns.Item(i).Width + 20
                    c.X = Cs(i - 1).X + Cs(i - 1).Width
                End If
                Cs(i) = c
                Column = Cs
            Next


        End If

        Dim w As Integer
        For i As Integer = 0 To UBound(Column)
            w = w + Column(i).Width

        Next
        DataSource.DataTableWidth = w
        Dim rec As New Rectangle
        rec = TableFrame.Rectangle
        rec.Width = w
        TableFrame.reCtSetting(rec)
    End Sub

    Dim isdf As Boolean
    Public Property isDoubleFrame() As Boolean
        Get
            Return isdf
        End Get
        Set(ByVal value As Boolean)
            isdf = value
        End Set
    End Property
    Private Sub DGV_setTableRow()

        'الاعدادات
        Dim dg As New DataGridView
        dg = DataSource.DataGrideView
        Dim rs(dg.Rows.Count - 1) As Rectangle
        RowCount = dg.Rows.Count
        Dim i As Integer = 0
        'لحساب طول الاطار
        Dim thr As New Rectangle
        thr = TableFrame.Rectangle
        thr.Height = 0
        '''''''''''''''''''''''''
        'راس الجدول
        Dim rh As Rectangle
        rh.X = TableFrame.Rectangle.X
        rh.Y = TableFrame.Rectangle.Y
        rh.Height = dg.ColumnHeadersHeight
        rh.Width = TableFrame.Rectangle.Width
        RowHead.reCtSetting(rh)
        thr.Height = thr.Height + rh.Height 'اضافة طول راس الجدول للاطار
        ''''''''''''''''''''''''
        'لاخذ الصفوف التي يتم طباعتها على الصفحة
        Dim rowhight(RowCount - 1) As Integer 'حساب طول الصف الواحد
        If Not isNotAllowheight() Then '  في حالة ان طول الجدول اصغر من المساحة المسموحة
            For ir = DataSource.EndPageRow To RowCount - 1

                rowhight(ir) = dg.Rows.Item(ir).Height ' حساب طول الصف 

            Next
            DataSource.IsLastPage = True
        Else '  في حالة ان طول الجدول اكبر من المساحة المسموحة

            Dim rrh As Integer = RowHead.Rectangle.Height 'الاخذ في الاعتبار راس الجدول


            Dim ir As Integer = DataSource.EndPageRow

            Do Until rrh >= AllowArea.Height
                rrh = rrh + dg.Rows.Item(ir).Height
                If rrh > AllowArea.Height Then Continue Do ' حتى لا تنزل تحت المساحة المطلوبة
                rowhight(ir) = dg.Rows.Item(ir).Height ' حساب الطول الصف 
                ir += 1
            Loop
            DataSource.EndPageRow = ir
            RowCount = ir
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' التعامل مع خصائص الصفوف 
        Dim bb As Boolean = isNotAllowheight()

        Dim rhh As Integer = DataSource.DataTablehight
        Dim r As Rectangle
        For i = 0 To RowCount - 1
            If i = 0 Then
                r.X = TableFrame.Rectangle.X
                r.Width = TableFrame.Rectangle.Width
                r.Height = rowhight(i)
                r.Y = rh.Bottom
                thr.Height = thr.Height + r.Height 'اضافة طول الصف ا لاول للاطار
            Else
                r.X = TableFrame.Rectangle.X
                r.Width = TableFrame.Rectangle.Width
                r.Height = rowhight(i)
                r.Y = rs(i - 1).Bottom
                ' لحساب طول الاطار بعد ان تم وضع 

                thr.Height = thr.Height + r.Height
                TableFrame.reCtSetting(thr)

            End If
            rs(i) = r
            Row = rs ' وضع الاطوال في مصفوفة الصفوف 
        Next
        'تحديد الاطوال الجديدة للمنطقة الحرة حتى يتاح لذيل التقرير الطباعة بعدها مباشرة
        Dim allw As New Rectangle
        allw = AllowArea
        allw.Height = TableFrame.Rectangle.Height
        AllowArea = allw
        rowshight = rowhight
    End Sub
    Private rowshight() As Integer 'لاخذ ارتفاع الصفوف قبل تعديل حجم  الخط وبعد التعديل

    Friend Sub finsh()

        Me.Column = Nothing
        Me.Row = Nothing
        Me.Cell = Nothing

    End Sub
    Private Sub DGV_SetTableheadCells()
        ' بيانات راس الجدول 
        Dim dg As New DataGridView
        dg = DataSource.DataGrideView
        Dim ce(ColumnCount) As reportPart
        ColumnCount = dg.Columns.Count

        Dim i As Integer
        For i = 0 To ColumnCount - 1
            Dim rec As Rectangle
            Dim cee As New reportPart
            With cee
                rec.X = Column(i).X
                rec.Y = RowHead.Rectangle.Y
                rec.Width = Column(i).Width
                rec.Height = RowHead.Rectangle.Height
                .reCtSetting(rec)

                .Iscell = True
                .StringFont.SetFont(TableStringFont.ForeColor, TableStringFont.Font)

                .BackColorSetting(CellBC)
                .FramSetting(CellFram)
                .SetText(DataSource.DataHeadString(i), allign)
                rec.Height = RowHead.Rectangle.Height


                ce(i) = cee
            End With
        Next
        TableHeadCell = ce


    End Sub
    Private Sub DGV_SetTableCells()
        'طباعة نصوص البيانات ووضعها في الجدول 
        'تؤخذ الاطوال  الاجراءات السابقة في الصفوف و الاعمدة

        Dim dg As New DataGridView
        dg = DataSource.DataGrideView
        Dim ce(ColumnCount, RowCount) As reportPart
        Dim ic, ir As Integer
        For ic = 0 To ColumnCount - 1
            For ir = 0 To RowCount - 1
                Dim rec As Rectangle
                Dim cee As New reportPart
                With cee
                    rec.X = Column(ic).X
                    rec.Y = Row(ir).Y
                    rec.Width = Column(ic).Width
                    .Iscell = True
                    .reCtSetting(rec)
                    .StringFont.SetFont(TableStringFont.ForeColor, TableStringFont.Font)
                    .BackColorSetting(CellBC)
                    .FramSetting(CellFram)
                    .SetText(DataSource.DataString(ic, ir), allign)

                    rowshight(ir) = cee.Rectangle.Height
                    ce(ic, ir) = cee
                End With
            Next
        Next
        Cell = ce
    End Sub

#End Region
#Region "الاعدادات"
    Dim allign As allinge
    Public Sub SetCellFont(ByVal fc As Color, ByVal Fn As String, ByVal fs As Single, ByVal a As allinge)
        Dim ff As New Font(Fn, fs)
        TableStringFont.Font = ff
        TableStringFont.ForeColor = fc
        allign = a
    End Sub
    Public Sub SetCellFont(ByVal fc As Color, ByVal f As Font, ByVal a As allinge)
        TableStringFont.Font = f
        TableStringFont.ForeColor = fc
        allign = a
    End Sub
    Public Sub DefCellFont()
        Dim ff As New Font("Tahoma", 10)
        TableStringFont.Font = ff
        TableStringFont.ForeColor = Color.Black
        allign = allinge.reight
    End Sub
    Private CellBC As Brush
    Public Sub SetCellBackColor(ByVal bc As Brush)
        CellBC = bc
    End Sub
    Public Sub defCellBackColor()
        CellBC = Brushes.White
    End Sub
    Dim tablebc As Brush


    Dim CellFram As Pen
    Public Sub setCellFrame(ByVal tp As Pen)
        CellFram = tp
    End Sub

    Public Sub setCellFrame(ByVal f As Color, ByVal w As Integer)
        Dim p As New Pen(f, w)
        CellFram = p
    End Sub


    Public Sub defCellFrame()
        Dim p As New Pen(Brushes.Black, 1)
        CellFram = p
    End Sub

    Public Sub Tablelood()
        DefCellFont()
        DefFrameheadSetting()
        defCellBackColor()
        defCellFrame()
    End Sub

#End Region
#Region "اجراء الطباعة"
    Public Sub Table_Print(ByVal g As Graphics)

        If PrintMe Then

            Dim rect As New Rectangle
            Dim pen As New Pen(TableFrame.FramColor.Color, TableFrame.FramColor.Width + 2)

            rect = TableFrame.Rectangle

            g.FillRectangle(TableFrame.BackColor, TableFrame.Rectangle)
            g.DrawRectangle(pen, TableFrame.Rectangle)
            If isDoubleFrame Then
                Dim inrec As New Rectangle
                inrec.X = TableFrame.Rectangle.X - 4
                inrec.Y = TableFrame.Rectangle.Y - 4
                inrec.Height = TableFrame.Rectangle.Height + 8
                inrec.Width = TableFrame.Rectangle.Width + 8

                g.DrawRectangle(TableFrame.FramColor, inrec)
            End If
            Dim fh As Integer = TableStringFont.Font.Height
            For i As Integer = 0 To ColumnCount - 1
                g.DrawRectangle(TableFrame.FramColor, Me.Column(i))
            Next

            For i As Integer = 0 To RowCount - 1
                g.DrawRectangle(Pens.Red, Row(i))
            Next
            g.FillRectangle(RowHead.BackColor, RowHead.Rectangle)
            g.DrawRectangle(RowHead.FramColor, RowHead.Rectangle)

            Dim ic, ir As Integer
            For ic = 0 To ColumnCount - 1
                For ir = 0 To RowCount - 1
                    'g.FillRectangle(Cell(ic, ir).BackColor, Cell(ic, ir).Rectangle)
                    g.DrawString(Cell(ic, ir).StringFont.text, TableStringFont.Font, New SolidBrush(Cell(ic, ir).StringFont.ForeColor), Cell(ic, ir).StringX, _
                    Cell(ic, ir).Stringy, Cell(ic, ir).StringFont.StringFormat)
                Next
            Next


            'رسم اطار راس التقرير
            For i As Integer = 0 To ColumnCount - 1
                g.DrawRectangle(TableFrame.FramColor, Me.Column(i))
            Next
            ' رسم اطار صفوف الجدول
            For i As Integer = 0 To RowCount - 1
                g.DrawRectangle(TableFrame.FramColor, Row(i))
            Next
            'كتابة راس الجدول
            For i = 0 To ColumnCount - 1

                g.DrawString(TableHeadCell(i).StringFont.text, TableStringFont.Font, New SolidBrush(TableHeadCell(i).StringFont.ForeColor), TableHeadCell(i).StringX, _
                                                                                                                TableHeadCell(i).Stringy, TableHeadCell(i).StringFont.StringFormat)
            Next
        End If
    End Sub
#End Region
End Class

