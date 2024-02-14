Public Class Detailes
    ' هذا الجزء مخصص للبيانات التي نستقبلها من الخارج 
    Public Sub New()

    End Sub
    Public Sub setDeff()
        DefTableAllowedArea()
    End Sub
    Private Sub DefTableAllowedArea()
        Table.SetAllowAreaDestenations(DetailesPart.Rectangle)
    End Sub
    Friend Sub DefnewDetailRec()
        DetailesPart.Rectangle = Table.AllowArea
    End Sub
    Private Det As New reportPart
    Public Property DetailesPart() As reportPart
        Get
            Return Det
        End Get
        Set(ByVal value As reportPart)
            Det = value
        End Set
    End Property


    Private Tab As New Table
    Public Property Table As Table
        Get
            Return Tab
        End Get
        Set(value As Table)
            Tab = value
        End Set
    End Property
    Private rtl As Boolean
    Public Property ReightToLeft As Boolean
        Get
            Return rtl
        End Get
        Set(value As Boolean)
            rtl = value
        End Set
    End Property

#Region "print"
    Public Function HasMorePage() As Boolean
        If Table.isNotAllowheight Then

            Return True

        Else
            Return False
        End If
    End Function
    Public Sub Detail_Print(g As Graphics)
        Table.Table_Print(g)
    End Sub
#End Region

End Class

 

Public Class GetDataFromDataGrideView
    '' هذا التصنيف يقوم باخذ البيانات فقط وحساب الاعمدة و الصفوف فقط ولا يقوم بتحديد موضعها في الصفحة

    Private DG As New DataGridView
    Public Property DataGrideView As DataGridView
        Get
            Return DG
        End Get
        Set(ByVal value As DataGridView)
            DG = value
        End Set
    End Property
    Private WT As Integer
    Public Property DataTableWidth As Integer
        Get
            Return WT
        End Get
        Set(ByVal value As Integer)
            WT = value
        End Set
    End Property

    Private hT As Integer
    Public Property DataTablehight As Integer
        Get
            Return hT
        End Get
        Set(ByVal value As Integer)
            hT = value
        End Set
    End Property
    ''' <summary>
    ''' ويستخدم في الطباعة اول مرة data grid view هذا الاجراء يستخدم في اخذالبيانات من ال
    ''' </summary>
    ''' <param name="dg"></param>
    ''' <remarks></remarks>
    Public Sub GetDataFromDGV(ByVal dg As DataGridView)
        DataGrideView = dg
        Dim CW, CC, rh, Cr As Integer
        CC = dg.ColumnCount
        Dim i As Integer = 0
        Dim w As Integer
        ''حساب عرض الجدول
        For i = 0 To CC - 1
            CW = dg.Columns(i).Width + 20
            w = w + CW
        Next
        DataTableWidth = w
        '' حساب طول الجدول 
        i = 0
        Dim h As Integer
        Cr = dg.Rows.Count
        For i = 0 To Cr - 1
            rh = dg.Rows(i).Height
            h = h + rh
        Next
        DataTablehight = h
        'ايجاد النصوص
        Dim strF(dg.Columns.Count, dg.Rows.Count) As String
        Dim ir, ic As Integer
        For ir = 0 To dg.Rows.Count - 1
            For ic = 0 To dg.Columns.Count - 1
                Dim sf As String
                sf = dg.Item(ic, ir).Value.ToString
                strF(ic, ir) = sf
            Next
        Next
        DataString = strF

        'ايجاد نص راس الجدول
        Dim ih As Integer
        Dim stringHeader(CC) As String
        For ih = 0 To CC - 1
            Dim str As String
            str = dg.Columns.Item(ih).HeaderText
            stringHeader(ih) = str
        Next
        DataHeadString = stringHeader
        IsFirstPage = True
    End Sub
    Private EPR As Integer = 0
    Friend Property EndPageRow As Integer
        Get
            Return EPR
        End Get
        Set(ByVal value As Integer)
            EPR = value
        End Set
    End Property
    Private FPage As Boolean
    Friend Property IsFirstPage As Boolean
        Get
            Return FPage
        End Get
        Set(ByVal value As Boolean)
            FPage = value
        End Set
    End Property


    Private lPage As Boolean
    Friend Property IsLastPage As Boolean
        Get
            Return lPage
        End Get
        Set(ByVal value As Boolean)
            lPage = value
        End Set
    End Property

    Friend Sub GetDataFromDGV()
        On Error Resume Next
        Finsh()
        Dim dgv As New DataGridView
        Me.DataString = Nothing
        Me.DataTablehight = Nothing
        Me.DataTableWidth = Nothing
        dgv = DataGrideView
        DG = DataGrideView
        Dim CW, CC, rh, Cr As Integer
        CC = DG.ColumnCount
        Dim i As Integer = 0
        Dim w As Integer
        For i = 0 To CC - 1
            CW = DG.Columns(i).Width + 20
            w = w + CW
        Next
        DataTableWidth = w
        i = 0

        Dim eprr As Integer = EndPageRow
        Dim h As Integer
        Cr = DG.Rows.Count
        For i = eprr To Cr - 1
            rh = DG.Rows(i).Height
            h = h + rh
        Next
        DataTablehight = h
        eprr = EndPageRow
        'ايجاد النصوص
        Dim strF(DG.Columns.Count, DG.Rows.Count) As String
        Dim ir, ic As Integer


        For ir = eprr To DG.Rows.Count - 1
            For ic = 0 To DG.Columns.Count - 1
                Dim sf As String
                sf = DG.Item(ic, ir).Value.ToString
                strF(ic, ir) = sf
            Next
        Next
        DataString = strF
        'ايجاد نص راس الجدول

        Dim ih As Integer
        Dim stringHeader(CC) As String
        For ih = 0 To CC - 1
            Dim str As String
            str = DG.Columns.Item(ih).HeaderText
            stringHeader(ih) = str
        Next
        DataHeadString = stringHeader

    End Sub


    Private FinshP As Boolean
    Public Property FinshPrint
        Get
            Return FinshP
        End Get
        Set(ByVal value)
            FinshP = value
        End Set
    End Property
    Private Sub Finsh()
        If FinshPrint Then
            EndPageRow = 0
            FinshPrint = False
        End If
    End Sub

    Private StF(,) As String
    Public Property DataString As String(,)
        Get
            Return StF
        End Get
        Set(ByVal value As String(,))
            StF = value
        End Set
    End Property


    Private Sh() As String
    ''' <summary>
    ''' نص راس الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataHeadString As String()
        Get
            Return Sh
        End Get
        Set(ByVal value As String())
            Sh = value
        End Set
    End Property
    ''' <summary>
    ''' هذا التصنيف يقوم باخذ البيانات فقط وحساب الاعمدة و الصفوف فقط ولا يقوم بتحديد موضعها في الصفحة
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
End Class