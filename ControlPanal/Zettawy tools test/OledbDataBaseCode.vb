Imports ZeftawyTools
Imports System.Data.OleDb

Public Class OLEdatabaseCodeing

    Public Sub New()

    End Sub
    Public Sub New(ByVal DataPath As String, ByVal Table As String, ByVal ControlFram As Control, Optional ByVal Where As String = "")
        ConnectToDataBase(DataPath)
        GetControl(ControlFram)
        gettable(Table, Where)
    End Sub


    Public Sub New(ByVal DataPath As String, ByVal Table As String, Optional ByVal Where As String = "")
        ConnectToDataBase(DataPath)
        gettable(Table, Where)
    End Sub
    Private tCou() As FieldMombers
    Public Property TableCuloms() As FieldMombers()
        Get
            Return tCou
        End Get
        Set(ByVal value As FieldMombers())
            tCou = value
        End Set
    End Property
    Public isLoaded As Boolean = False
    Public isFeildShow As Boolean = True
    ''' <summary>
    ''' اجراء تحميل البيانات
    ''' </summary>
    ''' <param name="DataPath">مسار قاعدة البيانات</param>
    ''' <param name="Table">اسم الجدول</param>
    ''' <param name="ControlFram">الاطار يحمل الادوات</param>
    ''' <param name="Where">شرط الفلترة</param>
    ''' <remarks></remarks>
    Public Sub Load(ByVal DataPath As String, ByVal Table As String, ByVal ControlFram As Control, Optional ByVal Where As String = "")
        ConnectToDataBase(DataPath)
        GetControl(ControlFram)
        gettable(Table, Where)
        isLoaded = True
    End Sub
    
    ''' <summary>
    ''' اجراء تحميل البيانات
    ''' </summary>
    ''' <param name="DataPath">مسار قاعدة البيانات</param>
    ''' <param name="Table">اسم الجدول</param>
    ''' <param name="Where">شرط الفلترة</param>
    ''' <remarks></remarks>
    Public Sub Load(ByVal DataPath As String, ByVal Table As String, Optional ByVal Where As String = "")
        ConnectToDataBase(DataPath)
        gettable(Table, Where)
        isLoaded = True
    End Sub
    ''' <summary>
    '''  تحميل البيانات باستخدام الهيكل كما يظهر البيانات في reader  
    ''' </summary>
    ''' <param name="Datapath">مسار القاعدة</param>
    ''' <param name="tablname">اسم الجدول</param>
    ''' <param name="tablC">هيكل الحقولFeildmimbers</param>
    ''' <param name="dgv">الداتا جريد</param>
    ''' <remarks></remarks>
    Public Sub load(ByVal Datapath As String, ByVal tablname As String, ByVal tablC() As FieldMombers, ByVal dgv As DataGridView, Optional ByVal Top As Integer = 0, Optional ByVal Wher As String = "")
        DataBasePath = Datapath
        TableName = tablname
        TableCuloms = tablC
        DataGridveiw = dgv
        LoadWithLinq(Top, Wher)
        'DataGridveiw.DataSource = GetDataGridViewDataSource()

        setDataGridViewHeaderText(DataGridveiw)
        setDataGridViewuseDGVVisalbe(DataGridveiw)
        Contronls = GetControl(tablC)
        FieldValue = GetfieldValue(tablC)
        ShowedContronls = GetShowedControl(tablC)
        isLoaded = True

        If Not isFeildShow Then Exit Sub
        DataShow()
        Me.ShowDataValue()
        
    End Sub

    ''' <summary>
    ''' تحميل البيانات باستخدام الهيكل
    ''' </summary>
    ''' <param name="Datapath">مسار القاعدة</param>
    ''' <param name="tablname">اسم الجدول</param>
    ''' <param name="tablC">هيكل الحقولFeildmimbers</param>
    ''' <remarks></remarks>
    Public Sub load(ByVal Datapath As String, ByVal tablname As String, ByVal tablC() As FieldMombers, Optional ByVal top As Integer = 0, Optional ByVal Wher As String = "")
        DataBasePath = Datapath
        TableCuloms = TableCuloms
        TableName = tablname

        TableCuloms = tablC

        LoadWithLinq(top, Wher)
        Contronls = GetControl(tablC)
        FieldValue = GetfieldValue(tablC)
        ShowedContronls = GetShowedControl(tablC)
        isLoaded = True

        If Not isFeildShow Then Exit Sub
        DataShow()
        Me.ShowDataValue()
    End Sub
    Private selectTableAndFeild, selectTableAndFeildAsFilter As String

    Public Function GetWantedFeild(ByVal fm As FieldMombers())
        Dim getdata = (From i In fm _
                       Where i.isWanted = True _
                         Select i)
        Return getdata.ToArray
    End Function
    Public Sub DataFilter(ByVal where As String)
        SQL = ""
        SQL = selectTableAndFeildAsFilter + " Where " + where
        reLoad()
    End Sub

    ''' <summary>
    ''' اجراء تحميل البيانات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub reLoad()
 
                ConnectToDataBase(DataBasePath)
        gettable(SQL)
       
        Contronls = GetControl(TableCuloms)
        FieldValue = GetfieldValue(TableCuloms)
        ShowedContronls = GetShowedControl(TableCuloms)
      
        If Not isFeildShow Then Exit Sub
        DataShow()
        isLoaded = True
        MoveFirst()
        If DataGridveiw Is Nothing Then Exit Sub
        DataGridveiw.DataSource = DataTable

        setDataGridViewHeaderText(DataGridveiw)

    End Sub


    ''' <summary>
    ''' اجراء تحميل البيانات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EditMyTools(ByVal Tc As FieldMombers())
        TableCuloms = Tc
        Contronls = GetControl(TableCuloms)
        FieldValue = GetfieldValue(TableCuloms)
        ShowedContronls = GetShowedControl(TableCuloms)

        


    End Sub


#Region "الاتصال بقاعدة البيانات"

    Private controlfrm As Control
    ''' <summary>
    ''' الاطار الذي نأخذ منه الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property controlFram As Control
        Get
            Return controlfrm
        End Get
        Set(ByVal value As Control)
            controlfrm = value
        End Set
    End Property
    Private conn As OleDbConnection
    Public Property Connection As OleDbConnection
        Get
            Return conn
        End Get
        Set(ByVal value As OleDbConnection)
            conn = value
        End Set
    End Property
    ''' <summary>
    ''' للاتصال بقاعدة البيانات
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Function ConnectToDataBase(ByVal DataPath As String) As OleDbConnection

        Dim conect As New OleDbConnection : conect.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataPath
        Connection = conect
        Me.DataBasePath = DataPath
        Return conect
    End Function
    ''' <summary>
    '''  للاتصال بقاعدة البيانات من المستخدم
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub ConnectToDataBase()
        Dim Datapath As String : Dim op As New OpenFileDialog
        op.Filter = " Accesse97 - 2003|*.mdb| Accesse2007|*.accdb"
        op.ShowDialog()
        Datapath = op.FileName
        If Datapath = "" Then Exit Sub
        Dim conect As New OleDbConnection : conect.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Datapath
        Me.DataBasePath = Datapath
        Connection = conect
        Connection.Open()
    End Sub
#End Region
#Region "فتح الجدول"

    ''' <summary>
    ''' فلترة الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Tn As String
    ''' <summary>
    ''' كتابة اسم الجدول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableName As String
        Get
            Return Tn
        End Get
        Set(ByVal value As String)
            Tn = value
        End Set
    End Property
    ''' <summary>
    ''' كوماند تكست
    ''' </summary>
    ''' <param name="tn">ادخل اسم الجدول على انه نص</param>
    ''' <param name="Where">ادخل شرط الفلتره بلغة اس كيو ال</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CommedText(ByVal tn As String, Optional ByVal Where As String = "") As String
        TableName = tn
        selectTableAndFeild = "select * From " + tn

        If Where = "" Then
            Return "select * From " + tn
        Else
            Return "select * From " + tn + " Where " + Where
        End If

    End Function

    Private datasql As String
    ''' <summary>
    ''' جملة الاس كيو ال المستخدمة في الفلترة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SQL As String
        Get
            Return datasql
        End Get
        Set(ByVal value As String)
            datasql = value
        End Set
    End Property
    ''' <summary>
    ''' الوصول للجدول
    ''' </summary>
    ''' <param name="comtxt">نص لغة الاس كيو ال </param>
    ''' <remarks></remarks>
    Public Overloads Sub gettable(ByVal comtxt As String)

        Dim comd As New OleDbCommand(comtxt, Connection)
        'البحث عن اسم الجدول
        Dim frm As String = "From"
        Dim whr As String = "Where"
        Dim frmi As Integer = InStr(comtxt, frm)
        Dim whri As Integer = InStr(comtxt, whr)

        If frmi >= 0 Then
            If whri > 0 Then
                TableName = Mid(comtxt, frmi, (whri - frmi + frm.Length))

            Else
                TableName = Mid(comtxt, frmi + frm.Length)

            End If
        End If

        command = comd
        SQL = command.CommandText
        Dim ad As New OleDbDataAdapter
        ad.SelectCommand = command
        TableAdabtor = ad

        Dim ds As New DataSet
        Dataset = ds
        TableAdabtor.Fill(Dataset, TableName)
        Dim dt As New DataTable
        dt = Dataset.Tables(TableName)
        DataTable = dt
        RowCount = DataTable.Rows.Count
        Connection.Close()
    End Sub
    ''' <summary>
    ''' الوصول للجدول
    ''' </summary>
    ''' <param name="tb">ادخل الجدول على انه نص</param>
    ''' <param name="where">شرط الفلترة على انها اس كيو ال </param>
    ''' <remarks></remarks>
    Public Overloads Sub gettable(ByVal tb As String, ByVal where As String)
        Dim comtxt As String = Me.CommedText(tb, where)
        Dim comd As New OleDbCommand(comtxt, Connection)
        command = comd
        SQL = command.CommandText
        Dim ad As New OleDbDataAdapter
        ad.SelectCommand = command

        TableAdabtor = ad
        Dim ds As New DataSet
        Dataset = ds
        TableAdabtor.Fill(Dataset, TableName)
        Dim dt As New DataTable
        dt = Dataset.Tables(TableName)
        DataTable = dt
        '' ينقص ان ندخل الحقول في مصفوفة الحقول 
        FildsName = getAllfieldName()
        RowCount = DataTable.Rows.Count
        Connection.Close()
    End Sub



    ''' <summary>
    ''' اظهار البيانات على الكونترول ويظهر كل الاعمدة
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub DataShow()
        On Error Resume Next
        DataRow = DataTable.Rows

        FildsName = getAllfieldName()

        For i = 0 To UBound(ShowedContronls)
            If ShowedContronls(i) Is Nothing Then
                Continue For

            End If
            If IsDBNull(DataRow(0).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(0).Item(FildsName(i))

            End If
          
        Next
    End Sub


    ''' <summary>
    '''  ادخال البيانات على القيم
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub ShowDataValue(Optional ByVal row As Integer = 0)
        On Error Resume Next
        DataRow = DataTable.Rows

        FildsName = getAllfieldName()

        For i = 0 To UBound(FieldValue)


            FieldValue(i) = DataRow(row).Item(FildsName(i))



        Next
    End Sub




  
    ''' <summary>
    ''' و اظهار البيانات على الكونترول ويظهر كل الاعمدة ويظهرها على الكنترولز التي تظهر على الحاوي المطلوبة 
    ''' </summary>
    ''' <param name="f">حاوية</param>
    ''' <remarks></remarks>
    Public Overloads Sub DataShow(ByVal f As Control)
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        FildsName = getAllfieldName()
        Contronls = GetControl(f)
        Do Until i > UBound(Contronls)
            Contronls(i).Text = DataRow(0).Item(FildsName(i))
            i += 1
        Loop
    End Sub


    ''' <summary>
    ''' و اظهار البيانات على الكونترول ويظهر كل الاعمدة ويظهرها على الكنترولز التي تظهر على الحاوي المطلوبة 
    ''' </summary>
    ''' <param name="c">مصفوفة الادوات</param>
    ''' <param name="Feild">الحقول</param>
    ''' <remarks></remarks>
    Public Overloads Sub DataShow(ByVal c As Control(), ByVal Feild As String())
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        FildsName = Feild
        Contronls = c

        Do Until i > UBound(Contronls)
            Contronls(i).Text = DataRow(0).Item(FildsName(i))
            i += 1
        Loop
    End Sub
    ''' <summary>
    ''' معرفة كل الادوات التي في حاوي معين ك جروب بوكس او فورم 
    ''' </summary>
    ''' <param name="f">كونترول حاوي</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetControl(ByVal f As Control) As Control()
        Dim c As Control
        Dim i As Integer
        For Each c In f.Controls
            c.Refresh()
            i += 1
        Next

        Dim count As Integer = i - 1
        i = 0
        Dim controls(count) As Control
        For Each cont In f.Controls
            controls(i) = cont
            i += 1
        Next
        i = 0
        controlFram = f
        Me.Contronls = controls
        Return controls
    End Function

    ''' <summary>
    ''' ايجاد الادوات عن طريق الهيكل
    ''' </summary>
    ''' <param name="tablc">الهيكل</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetControl(ByVal tablc() As FieldMombers) As Control()

        Try
            Dim i As Integer
            Dim c(tablc.Length - 1) As Control
            For i = 0 To tablc.Length - 1
                If tablc(i).Control Is Nothing Then
                    Continue For
                End If
                c(i) = tablc(i).Control

            Next
            Return c
        Catch ex As Exception

        End Try

    End Function



    ''' <summary>
    ''' ايجاد الادوات عن طريق الهيكل
    ''' </summary>
    ''' <param name="tablc">الهيكل</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetShowedControl(ByVal tablc() As FieldMombers) As Control()

        Try
            Dim i As Integer
            Dim c(tablc.Length - 1) As Control
            For i = 0 To tablc.Length - 1
                If tablc(i).visable = True Then
                    If tablc(i).Control Is Nothing Then
                        Continue For
                    End If

                    c(i) = tablc(i).Control
                End If


            Next
            Return c
        Catch ex As Exception

        End Try

    End Function
    ''' <summary>
    ''' ايجاد الادوات عن طريق الهيكل
    ''' </summary>
    ''' <param name="tablc">الهيكل</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetfieldValue(ByVal tablc() As FieldMombers) As Object()

        Try
            Dim i As Integer
            Dim c(tablc.Length - 1) As Object
            For i = 0 To tablc.Length - 1
                If tablc(i).value Is Nothing Then
                    If tablc(i).iskey Then tablc(i).value = 0 : c(i) = 0
                    Continue For
                End If

                c(i) = tablc(i).value

            Next
            FieldValue = c
            Return c
        Catch ex As Exception

        End Try

    End Function

    ''' <summary>
    ''' سجل تالي
    ''' </summary>
    ''' <remarks></remarks>
    Public Function MoveNext() As Integer
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        r += 1
        If r >= DataRow.Count - 1 Then r = DataRow.Count - 1
        rowNo = r
        Do Until i > UBound(ShowedContronls)
            If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

            End If
            i += 1
        Loop
        
        DatagrideCellfocuse()
        Return r
    End Function
    ''' <summary>
    ''' سجل سابق
    ''' </summary>
    ''' <remarks></remarks>
    Public Function MovePriviose() As Integer
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        r -= 1
        If r < 0 Then r = 0
        Do Until i > UBound(ShowedContronls)
            If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

            End If
            i += 1
        Loop
        If r <= 0 Then
            r = 0
        End If
        rowNo = r
        DatagrideCellfocuse()
        Return r
    End Function
    Private Sub DatagrideCellfocuse()
        If DataGridveiw Is Nothing Then

            Exit Sub
        End If
        DataGridveiw.CurrentCell = DataGridveiw.Item(0, rowNo)

    End Sub

    Public Function MoveByDataGrideView() As Integer

        If DataGridveiw Is Nothing Then Exit Function
        If isLoaded Then

            On Error Resume Next
            DataRow = DataTable.Rows
            Dim i As Integer = 0
            Dim r As Integer = rowNo
            r = DataGridveiw.CurrentCell.RowIndex
            Do Until i > UBound(ShowedContronls)
                If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                    ShowedContronls(i).Text = ""
                Else
                    ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

                End If
                i += 1
            Loop

            'DatagrideCellfocuse()
            rowNo = r
            Return r



        End If
    End Function
    ''' <summary>
    ''' الانتقال الى سجل رقم
    ''' </summary>
    ''' <param name="rowNomber">رقم السجل</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MoveTo(ByVal rowNomber As Integer) As Integer
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        r = rowNomber
        Do Until i > UBound(ShowedContronls)
            If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

            End If
            i += 1
        Loop

        DatagrideCellfocuse()
        rowNo = r
        Return r
    End Function


    ''' <summary>
    ''' اول سجل
    ''' </summary>
    ''' <remarks></remarks>
    Public Function MoveFirst() As Integer
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        r = 0
        Do Until i > UBound(Contronls)
            If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

            End If

            i += 1
        Loop
        rowNo = r
        DatagrideCellfocuse()
        Return r
    End Function
    ''' <summary>
    ''' اخر سجل
    ''' </summary>
    ''' <remarks></remarks>
    Public Function MoveLast() As Integer
        On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        r = DataRow.Count - 1


        Do Until i > UBound(ShowedContronls)
            If IsDBNull(DataRow(r).Item(FildsName(i))) Then
                ShowedContronls(i).Text = ""
            Else
                ShowedContronls(i).Text = DataRow(r).Item(FildsName(i))

            End If
            i += 1
        Loop
        rowNo = r
        DatagrideCellfocuse()

        Return r
    End Function

    ''' <summary>
    ''' اضافة سجل جديد
    ''' </summary>
    ''' <param name="ss">تفويض يعمل على تغيير القيم تحت العمود الذي يحتويل على المفتاح الاساسي </param>
    ''' <remarks></remarks>
    Public Overloads Sub AddNew(ByVal ss As AddnewInPrimary)
        On Error Resume Next
        DataRow = DataTable.Rows

        Dim i As Integer = 0
        Dim r As Integer = rowNo
        Do Until i > UBound(Contronls)
            Contronls(i).Text = ""
            i += 1
        Loop
        Contronls(0).Text = ss.Invoke()
        rowNo = r
        insert()
    End Sub
    ''' <summary>
    ''' سجل جديد
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub AddNew(Optional ByVal DefSer As Boolean = True)
        'On Error Resume Next
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        Dim ss As New AddnewInPrimary(AddressOf AddSerail)
        Do Until i > Contronls.Length - 1
            If Contronls(i) Is Nothing Then i += 1 : Continue Do
            Contronls(i).Text = ""

            i += 1
        Loop
        If DefSer Then
            FieldValue(0) = ss.Invoke()
        End If
        rowNo = r
        'insert()
        isinsert = True
    End Sub
    ''' <summary>
    ''' تسجيل سجل جديد من خلال الادوات ومصفوفة الحقول
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub insert()

        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        Row = DataTable.NewRow


        For i = 0 To UBound(Contronls)
            If Contronls(i) Is Nothing Then Continue For
            FieldValue(i) = CObj(Contronls(i).Text)

        Next
        Dim ss As Integer = 0
        For ss = 0 To UBound(FieldValue)
            Row(FildsName(ss)) = FieldValue(ss)

        Next

        DataTable.Rows.Add(Row)
        DataRow = DataTable.Rows
        rowNo = DataRow.Count
        'IsChange = True
        Dataset.HasChanges(DataRowState.Added)

    End Sub
    ''' <summary>
    ''' تسجيل سجل جديد من خلال الادوات ومصفوفة الحقول
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Gridinsert()
        On Error GoTo now
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        Row = DataTable.NewRow
        Do Until i > UBound(Contronls)
            Row(FildsName(i)) = Contronls(i).Text
            i += 1
        Loop
now:
        DataTable.Rows.Add(Row)
        DataRow = DataTable.Rows
        rowNo = DataRow.Count
        IsChange = True
        Dataset.HasChanges(DataRowState.Added)
        'Save()
    End Sub

    ''' <summary>
    ''' ادخال سجل جديد من خلال ادخال معامل مصفوفة حقول و مصفوفة نصوص
    ''' </summary>
    ''' <param name="Field">مصفوفة حقول</param>
    ''' <param name="Text">مصفوفة نصوص</param>
    ''' <remarks></remarks>
    Public Overloads Sub insert(ByVal Field As String(), ByVal Text As String())
        On Error GoTo now
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        Row = DataTable.NewRow
        Do Until i > UBound(Contronls)
            Row(Field(i)) = Text(i)
            i += 1
        Loop
now:
        DataTable.Rows.Add(Row)
        DataRow = DataTable.Rows
        rowNo = DataRow.Count
        IsChange = True
        Dataset.HasChanges(DataRowState.Added)
        isinsert = True
    End Sub
    ''' <summary>
    ''' تعديل حقول
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Edet()
        'On Error GoTo now
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        DataTable.Rows.Item(rowNo).BeginEdit()
        Row = DataRow.Item(rowNo)

        If Contronls Is Nothing Then GoTo Val
        Do Until i > UBound(Contronls) - 1
            If Contronls(i) Is Nothing Then i += 1 : Continue Do
            FieldValue(i) = Contronls(i).Text
            i += 1
        Loop
Val:
        i = 0
        Do Until i > UBound(FieldValue)
            If FieldValue(i) Is Nothing Then
                i += 1
                Continue Do
            End If
            Row(FildsName(i)) = FieldValue(i)
            i += 1
        Loop

now:

        DataTable.Rows.Item(rowNo).EndEdit()
        DataRow = DataTable.Rows

        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)

    End Sub
    ''' <summary>
    ''' تعديل حقول من خلال تمرير معاملات نصوص
    ''' </summary>
    ''' <param name="Feild">مصفوفة الحقول</param>
    ''' <param name="Text">مصفوفة النصوص</param>
    ''' <remarks></remarks>

    Public Sub Edet(ByVal Feild As String(), ByVal Text As String())
        On Error GoTo now
        DataRow = DataTable.Rows
        Dim i As Integer = 0
        Dim r As Integer = rowNo
        DataTable.Rows.Item(rowNo).BeginEdit()
        Row = DataRow.Item(rowNo)
        Do Until i > UBound(Contronls)
            Row(Feild(i)) = Text(i)
            i += 1
        Loop
        DataTable.Rows.Item(rowNo).EndEdit()
now:
        DataRow = DataTable.Rows
        rowNo = DataRow.Count
        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        Save()
    End Sub
    ''' <summary>
    ''' حفظ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save(Optional ByVal useMsg As Boolean = True)
        On Error Resume Next
        IsChange = True
        If isinsert Then

            insert()

            isinsert = False
            GoTo d
        Else

        End If
        If isDeleted Then
            GoTo d
        End If
        If IsChange Then
            Edet()
        End If
        If isEdited Then
            Edet()
        End If
d:
        isDeleted = False

        If Dataset.HasChanges Or IsChange Then

            Dim com As New OleDbCommandBuilder
            com.DataAdapter = TableAdabtor
            TableAdabtor.Update(Dataset, TableName)

            If useMsg Then
                Dim msg As New MyMsg
                msg.save()


            End If
        End If
        'اياااااااااااااااااك تحط الreload تاني لانه هيتعبك لما تتعامل مع قاعدتين
    End Sub

    ''' <summary>
    ''' حفظ التعديلات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveEdite(Optional ByVal useMsg As Boolean = True)
        If Dataset.HasChanges(DataRowState.Modified) Then
            Dim com As New OleDbCommandBuilder
            com.DataAdapter = TableAdabtor
            TableAdabtor.Update(Dataset, TableName)
            If useMsg Then
                Dim msg As New MyMsg
                msg.save()
            End If
        End If
        'اياااااااااااااااااك تحط الreload تاني لانه هيتعبك لما تتعامل مع قاعدتين
    End Sub

    ''' <summary>
    ''' حفظ اظافة جديد
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveInsert(Optional ByVal useMsg As Boolean = True)
        If Dataset.HasChanges(DataRowState.Added) Then
            Dim com As New OleDbCommandBuilder
            com.DataAdapter = TableAdabtor
            TableAdabtor.Update(Dataset, TableName)
            If useMsg Then
                Dim msg As New MyMsg
                msg.save()
            End If
        End If
        'اياااااااااااااااااك تحط الreload تاني لانه هيتعبك لما تتعامل مع قاعدتين
    End Sub
    ''' <summary>
    ''' حفظ الحذف
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveDelete(Optional ByVal useMsg As Boolean = True)
        If Dataset.HasChanges(DataRowState.Deleted) Then
            Dim com As New OleDbCommandBuilder
            com.DataAdapter = TableAdabtor
            TableAdabtor.Update(Dataset, TableName)
            If useMsg Then
                Dim msg As New MyMsg
                msg.save()
            End If
        End If
        'اياااااااااااااااااك تحط الreload تاني لانه هيتعبك لما تتعامل مع قاعدتين
    End Sub


    ''' <summary>
    ''' لاخذ اسماء كل الحقول ووضعها في مصفوفة
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllfieldName() As String()
        Dim i As Integer = 0
        Dim CC As Integer = DataTable.Columns.Count - 1
        Dim c(CC) As String
        Do Until i = CC + 1
            c(i) = DataTable.Columns.Item(i).ColumnName
            i += 1
        Loop
        Return c
    End Function

    ''' <summary>
    ''' لاخذ الاسماء المستعارة كل الحقول ووضعها في مصفوفة
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllfieldCaption() As String()
        Dim i As Integer = 0
        Dim CC As Integer = DataTable.Columns.Count - 1
        Dim c(CC) As String
        Do Until i = CC + 1
            c(i) = DataTable.Columns.Item(i).ColumnName
            i += 1
        Loop
        Return c
    End Function

    Dim Feldn As String()
    ''' <summary>
    ''' اخذ اسماء حقول معينة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FildsName As String()
        Get
            Return Feldn
        End Get
        Set(ByVal value As String())
            Feldn = value
        End Set
    End Property
    ''' <summary>
    ''' حذف 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Delete()
        On Error GoTo now
        Dim msg As New MyMsg

        Dim del As Boolean = msg.deletemsg()
        If del Then


            DataRow = DataTable.Rows
            Dim i As Integer = 0
            Dim r As Integer = rowNo
            Row = DataRow.Item(rowNo)
            Row.Delete()
now:
            DataRow = DataTable.Rows
            rowNo = DataRow.Count

            IsChange = True
            Dataset.HasChanges(DataRowState.Deleted)
            isDeleted = True
            Save(False)
            Dim msgno As New MyMassege
            msgno.msgbox("يتم الحذف")
            reLoad()
        Else
            Dim msgno As New MyMassege
            msgno.msgbox("لم يتم الحذف")
        End If

    End Sub
    Public Delegate Function AddnewInPrimary() As Object
    ''' <summary>
    ''' اضافة سيريل 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddSerail() As Integer
        Return DataRow.Count + 1
    End Function

    ''' <summary>
    ''' Reader
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks> 
    Public Function GetReader(ByVal comtxt As String) As OleDbDataReader
        Dim comd As New OleDbCommand(comtxt, Connection)
        command = comd
        Connection.Open()


        Dim rrd As OleDbDataReader


        rrd = command.ExecuteReader

        Datareader = rrd
        Return rrd
    End Function
    ''' <summary>
    ''' Reader
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks> 
    Public Sub LoadByReader(ByVal comtxt As String, ByVal conn As OleDbConnection)
        Dim comd As New OleDbCommand(comtxt, conn)
        Dim rrd As OleDbDataReader
        Connection = conn
        Connection.Open()
        rrd = comd.ExecuteReader
        Datareader = rrd

    End Sub
    ''' <summary>
    ''' اظهار البيانات عبر الداتا جريد عن طريق الداتا ريدر
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub showDatabyDataReader()
        Dim dgv As New DataGridView
        For i = 0 To TableCuloms.Length - 1
            dgv.Columns.Add(TableCuloms(i).Name, TableCuloms(i).Caption)
        Next

    End Sub

    
    ''' <summary>
    ''' يستخدم في اخبار الداتا سيت انه تم اضافة حقل عن طريق الداتا جريد
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub datagrideInserted()

        Dataset.HasChanges(DataRowState.Added)
    End Sub
    ''' <summary>
    ''' يستخدم في اخبار الداتا سيت انه تم حذف حقل عن طريق الداتا جريد
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub datagrideDeleted()
        Dataset.HasChanges(DataRowState.Deleted)
        isDeleted = True
    End Sub
#End Region
#Region "Linq"
    Public Sub LoadWithLinq(Optional ByVal top As Integer = 0, Optional ByVal Where As String = "")
        ConnectToDataBase(DataBasePath)

        Dim selectSql As String
        If top = 0 Then
            selectSql = "SELECT "
        Else
            selectSql = "SELECT  Top " + top.ToString

        End If

        Dim field As String = " "
        Dim i As Integer
        For i = 0 To TableCuloms.Length - 1
            If i < TableCuloms.Length - 1 Then
                field = field + TableCuloms(i).Name + " , "
            Else
                field = field + TableCuloms(i).Name + " From " + TableName
            End If
        Next
        Dim sql As String
        If Where = "" Then
            sql = selectSql + field
            selectTableAndFeild = sql
        Else
            sql = selectSql + field + " Where " + Where
            selectTableAndFeild = selectSql + field

        End If
        selectTableAndFeildAsFilter = "SELECT " + field

        gettable(sql)

        For Each c In TableCuloms
            c.DataType = DataTable.Columns.Item(c.Name).DataType
        Next

        If Me.DataGridveiw Is Nothing Then Exit Sub

        DataGridveiw.DataSource = DataTable


    End Sub

    Public Function GetDataGridViewDataSource() As Object
        Return DataGridveiw.DataSource
    End Function
    Public Function setDataGridViewHeaderText(ByVal dgv As DataGridView) As Object
        For Each c In TableCuloms
            If c.Caption Is Nothing Then

                dgv.Columns.Item(c.Name).HeaderText = c.Name

            Else
                dgv.Columns.Item(c.Name).HeaderText = c.Caption

            End If
Next
    End Function

    ''' <summary>
    ''' بحيث انه يستلم الداتا جريد فاضي وهو اللي بيملاه Querys  هذا الاجراء يستخدم في الاستعلامات  
    ''' </summary>
    ''' <param name="dgv">ه</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setDataGridViewuseDGVVisalbe(ByVal dgv As DataGridView) As Object
        For Each c In TableCuloms
            If c.dgvVisalbe = True Then

                dgv.Columns.Item(c.Name).Visible = True

            Else
                dgv.Columns.Item(c.Name).Visible = False

            End If
        Next
    End Function
#End Region
#Region "خصائص"
    Private isc, isDelete, isinsert As Boolean
    Private dg As DataGridView
    Private Property IsChange As Boolean
        Get
            Return isc
        End Get
        Set(ByVal value As Boolean)
            isc = value
        End Set
    End Property
    ''' <summary>
    ''' هل تم التعديل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isEdited As Boolean
        Get
            Return IsChange
        End Get
        Set(ByVal value As Boolean)
            IsChange = value
        End Set
    End Property
    ''' <summary>
    ''' تم ادخال جديد
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Isinserted As Boolean
        Get
            Return isinsert
        End Get
        Set(ByVal value As Boolean)
            isinsert = value
        End Set
    End Property
    ''' <summary>
    ''' تم ادخال تعديل 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isDeleted As Boolean
        Get
            Return isDelete
        End Get
        Set(ByVal value As Boolean)
            isDelete = value
        End Set
    End Property

    ''' <summary>
    ''' datagridveiw 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataGridveiw() As DataGridView
        Get
            Return dg
        End Get
        Set(ByVal value As DataGridView)
            dg = value
        End Set
    End Property

    Private rowp As Integer
    ''' <summary>
    ''' رقم السجل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property rowNo() As Integer
        Get
            Return rowp
        End Get
        Set(ByVal value As Integer)
            rowp = value
        End Set
    End Property
    Private con As Control()
    ''' <summary>
    '''  مصفوفة  المستخدمة في ادخال و تعديل البيانات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Contronls() As Control()
        Get
            Return con
        End Get
        Set(ByVal value As Control())
            con = value
        End Set
    End Property


    Private showcon As Control()
    ''' <summary>
    '''  مصفوفة الادوات التي ستظهر البيانات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ShowedContronls() As Control()
        Get
            Return showcon
        End Get
        Set(ByVal value As Control())
            showcon = value
        End Set
    End Property
    Private FieVal As Object()
    ''' <summary>
    ''' مصفوفة قيم الحقول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FieldValue() As Object()
        Get
            Return FieVal
        End Get
        Set(ByVal value As Object())
            FieVal = value
        End Set
    End Property


    Private datas As DataSet
    ''' <summary>
    ''' Data Set Control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Dataset() As DataSet
        Get
            Return datas
        End Get
        Set(ByVal value As DataSet)
            datas = value
        End Set
    End Property
    Private tableadt As OleDbDataAdapter
    ''' <summary>
    ''' Table Adabtor Control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableAdabtor() As OleDbDataAdapter
        Get
            Return tableadt
        End Get
        Set(ByVal value As OleDbDataAdapter)
            tableadt = value
        End Set
    End Property
    Private comd As OleDbCommand
    ''' <summary>
    ''' Command Control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property command() As OleDbCommand
        Get
            Return comd

        End Get
        Set(ByVal value As OleDbCommand)
            comd = value
        End Set
    End Property
    Private table As DataTable
    ''' <summary>
    ''' Data Table
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataTable() As DataTable
        Get
            Return table
        End Get
        Set(ByVal value As DataTable)
            table = value
        End Set
    End Property
    Private rows As DataRowCollection
    ''' <summary>
    ''' Data Row 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataRow() As DataRowCollection
        Get
            Return rows
        End Get
        Set(ByVal value As DataRowCollection)
            rows = value
        End Set
    End Property
    Private rowss As DataRow
    ''' <summary>
    ''' dataRow
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Row() As DataRow
        Get
            Return rowss
        End Get
        Set(ByVal value As DataRow)
            rowss = value
        End Set
    End Property

    Private rowc As Integer
    ''' <summary>
    ''' dataRow
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowCount() As Integer
        Get
            Return rowc
        End Get
        Set(ByVal value As Integer)
            rowc = value
        End Set
    End Property
    Private red As OleDbDataReader
    ''' <summary>
    ''' reader
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Datareader() As OleDbDataReader
        Get
            Return red
        End Get
        Set(ByVal value As OleDbDataReader)
            red = value
        End Set
    End Property
    Private datap As String
    ''' <summary>
    ''' مسار القاعدة 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataBasePath() As String
        Get
            Return datap
        End Get
        Set(ByVal value As String)
            datap = value
        End Set
    End Property
#End Region


    ''' <summary>
    ''' اظهار البيانات عبر الداتا جريد عن طريق الداتا ريدر
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub showDatabyReader()
        Dim i As Integer = DataGridveiw.ColumnCount
        Dim c(i - 1) As Object
        Do While DataReader.Read
            For ii = 0 To i - 1
                c(ii) = Datareader.Item(ii)
            Next
            Me.DataGridveiw.Rows.Add(c)
        Loop
        Me.Connection.Close()
    End Sub

    ''' <summary>
    ''' اظهار البيانات عبر الداتا جريد عن طريق الداتا ريدر
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub showDatabyReader(ByVal dg As DataGridView, Optional ByVal Start As Integer = 0, Optional ByVal readerItems As Integer = 0)
        On Error Resume Next
        Dim i As Integer = dg.ColumnCount
        Dim c(i - 1) As Object
        Dim o As Object
        Do While DataReader.Read
            For ii = Start To c.Length - 1
                o = Datareader.Item(ii)
                c(ii) = o
            Next
            dg.Rows.Add(c)
        Loop
        Me.Connection.Close()
        dg.Refresh()
    End Sub

    ''' <summary>
    ''' ملئ الكومبوا بالبيانات
    ''' </summary>
    ''' <param name="combo">الكومبو</param>
    ''' <param name="field">اسم الحقل</param>
    ''' <param name="tab">اسم الجدول</param>
    ''' <param name="con">Connection</param>
    ''' <remarks></remarks>
    Public Sub showDatabyReaderTocombobox(ByVal combo As ComboBox, ByVal field As String, ByVal tab As String, ByVal con As OleDbConnection)
        combo.Items.Clear()
        Dim s As String
        s = "SELECT   " + field + " FROM  " + tab + "    GROUP BY  " + field + ""
        GetReader(s, con)
        Dim sc As Object
        Do While Datareader.Read
            sc = Datareader.Item(0)
            If sc Is Nothing Then Continue Do
            combo.Items.Add(Datareader.Item(0))
        Loop
        Me.Connection.Close()
    End Sub
    ''' <summary>
    ''' ملئ الكومبوا بالبيانات
    ''' </summary>
    ''' <param name="combo">الكومبو</param>
    ''' <param name="Sql">  SQL</param>
    ''' <param name="con">Connection</param>
    ''' <remarks></remarks>
    Public Function showDatabyReaderTocombobox(ByVal combo As ComboBox, ByVal Sql As String, ByVal con As OleDbConnection) As List(Of String)
        Dim l As New List(Of String)
        GetReader(Sql, con)
        combo.Items.Clear()
        Dim sc As Object
        Do While Datareader.Read
            sc = Datareader.Item(0)
            If sc Is Nothing Then Continue Do
            combo.Items.Add(Datareader.Item(0))
            l.Add((Datareader.Item(0)))

        Loop
        Me.Connection.Close()
        Return l
    End Function
    ''' <summary>
    ''' ملئ  مصفوفه بالبيانات
    ''' </summary>
    ''' <param name="Sql">  SQL</param>
    ''' <param name="con">Connection</param>
    ''' <remarks></remarks>
    Public Function showDatabyReaderToArray(ByVal field As String, ByVal tab As String) As Object()
        Dim s As String
        s = "SELECT   " + field + " FROM  " + tab + "    GROUP BY  " + field + ""

        GetReader(s, Connection)
        Dim obj(RowCount - 1) As Object
        Dim sc As Object
        Dim i As Integer = 0
        Do While Datareader.Read


            obj(i) = Datareader.Item(0)
            i += 1
        Loop
        Me.Connection.Close()
        Return obj
    End Function


    ''' <summary>
    ''' ملئ  مصفوفه بالبيانات
    ''' </summary>
    ''' <param name="Sql">  SQL</param>
    ''' <param name="con">Connection</param>
    ''' <remarks></remarks>
    Public Function showDatabyReaderTolist(ByVal field As String, ByVal tab As String) As List(Of String)
        Dim s As String
        s = "SELECT   " + field + " FROM  " + tab + "    GROUP BY  " + field + ""
        Dim l As New List(Of String)
        GetReader(s, Connection)
        Dim obj(RowCount - 1) As Object
        Dim sc As Object
        Dim i As Integer = 0
        Do While Datareader.Read


            l.Add(Datareader.Item(0))

        Loop
        Me.Connection.Close()
        Return l
    End Function

    ''' <summary>
    ''' ملئ الكومبوا بالبيانات
    ''' </summary>
    ''' <param name="combo">الكومبو</param>
    ''' <param name="field">اسم الحقل</param>
    ''' <param name="tab">اسم الجدول</param>
    ''' <param name="con">Connection</param>
    ''' <remarks></remarks>
    Public Function showDatabyReaderTocombobox(ByVal combo As ComboBox, ByVal field As String, ByVal tab As String, Optional ByVal having As String = "") As List(Of String)
        On Error Resume Next
        combo.Items.Clear()
        Dim s As String
        If having = "" Then
            s = "SELECT   " + field + " FROM  " + tab + "    GROUP BY  " + field + ""
        Else
            s = "SELECT   " + field + " FROM  " + tab + "    GROUP BY  " + field + " Having " + having
        End If
        GetReader(s, Connection)
        Dim sc As Object
        Dim l As New List(Of String)
        Do While Datareader.Read
            sc = Datareader.Item(0)
            If sc Is Nothing Then Continue Do
            combo.Items.Add(Datareader.Item(0))
            l.Add(Datareader.Item(0))

        Loop
        Me.Connection.Close()
        Return l
    End Function
    ''' <summary>
    ''' ملئ الكومبوا بالبيانات
    ''' </summary>
    ''' <param name="combo">الكومبو</param>
    ''' <param name="Sql">  SQL</param>
    ''' <remarks></remarks>
    Public Sub showDatabyReaderTocombobox(ByVal combo As ComboBox, ByVal Sql As String)

        GetReader(Sql, Connection)
        combo.Items.Clear()
        Dim sc As Object
        Do While Datareader.Read
            sc = Datareader.Item(0)
            If sc Is Nothing Then Continue Do
            combo.Items.Add(Datareader.Item(0))
        Loop
        Me.Connection.Close()
    End Sub

    ''' <summary>
    ''' اظهار البيانات بقيمة واحدة فقط
    ''' </summary>
    ''' <remarks></remarks>
    Public Function showDataValuebyReader(ByVal sql As String, ByVal item As Integer) As Object
        GetReader(sql, Me.Connection)
        Dim op As Object
        Do While Datareader.Read

            op = Datareader.Item(item)


        Loop
        Me.Connection.Close()

        Return op
    End Function


    ''' <summary>
    ''' Reader
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks> 
    Public Function GetReader(ByVal comtxt As String, ByVal conn As OleDbConnection) As OleDbDataReader
        Dim comd As New OleDbCommand(comtxt, conn)
        Dim rrd As OleDbDataReader
        Connection = conn
        Connection.Open()
        rrd = comd.ExecuteReader
        Datareader = rrd
        Return rrd
    End Function

#Region "LoadQuereys"
    ''' <summary>
    '''  sum - GroubBy يستخدم في توليد جمل الاستعلام
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub loadQuarys(ByVal Datapath As String, ByVal tablname As String, ByVal tablC As FieldMombers(), ByVal Dgv As DataGridView, Optional ByVal Where As String = "")
        DataBasePath = Datapath
        TableCuloms = TableCuloms
        TableName = tablname
        TableCuloms = tablC
        DataGridveiw = Dgv

        ConnectToDataBase(DataBasePath)

        Dim selectSql As String = "SELECT "
        Dim field As String = " "
        Dim i As Integer

        Dim sql As String
        If Where = "" Then
            sql = selectSql + field
            selectTableAndFeild = sql
        Else
            sql = selectSql + field + " Where " + Where
            selectTableAndFeild = selectSql + field
        End If


    End Sub

    Private Clr As Boolean
    Public Sub ClearSQL()
        Clr = True
    End Sub
#End Region
#Region "SQL"
#Region "Select"
    Public Function SelectSum(ByVal Feild As String, ByVal SqlAs As String) As String
        Return "IIF(ISNull(Sum(" + Feild + ")),0,Sum(" + Feild + ")) As " + SqlAs
    End Function

    Public Function AddWhereSQL(ByVal Wheresql As String, Optional ByVal isAnd As String = " And ")
        Static s As String
        Static i As Integer = 1
        If Clr Then
            s = ""
            i = 1
            Clr = False
        End If



        If s = "" Then
            s = Wheresql
            Return "  " + Wheresql
        End If
        s = s + isAnd + Wheresql
        Return "  " + s
    End Function

    Public Function AddSelectSQL(ByVal Selectsql As String)
        Static s As String
        Static i As Integer = 1
        If Clr Then
            s = ""
            i = 1
            Clr = False
        End If

        If s = "" Then
            s = Selectsql
            Return "  " + Selectsql
        End If
        s = s + " , " + Selectsql
        Return "  " + s
    End Function

    ''' <summary>
    ''' هذا الاجراء يقوم بعمل جملة السليكت و يقوم ببناء الداتا جريد
    ''' </summary>
    ''' <param name="Selectsql"></param>
    ''' <param name="DatagrideCoulemsName"></param>
    ''' <param name="datagrideCulomnsHeads"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddSelectSQL(ByVal Selectsql As String, ByVal DatagrideCoulemsName As String, ByVal datagrideCulomnsHeads As String)
        Static s As String
        Static i As Integer = 1
        If Clr Then
            s = ""
            i = 1
            Clr = False
        End If

        DataGridveiw.Columns.Add(DatagrideCoulemsName, datagrideCulomnsHeads)
        If s = "" Then
            s = Selectsql
            Return "  " + Selectsql
        End If
        s = s + " , " + Selectsql
        Return "  " + s
    End Function

    ''' <summary>
    ''' هذا الاجراء يقوم بعمل جملة السليكت و يقوم ببناء الداتا جريد
    ''' </summary>
    ''' <param name="Ssql"></param>
    ''' <param name="DatagrideCoulemsName"></param>
    ''' <param name="datagrideCulomnsHeads"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectSQL(ByVal Ssql As String, ByVal DatagrideCoulemsName As String, ByVal datagrideCulomnsHeads As String)
        Static s As String
        Static i As Integer = 1
        If Clr Then
            s = ""
            i = 1
            Clr = False
        End If

        If s = "" Then
            s = Ssql
            Return "  " + Ssql
        End If
        s = s + " , " + Ssql

        DataGridveiw.Columns.Add(DatagrideCoulemsName, datagrideCulomnsHeads)


        Return "  " + s
    End Function
#End Region
#Region "Where"
    Public Function FeildWhere(ByVal feild As feildtyp, ByVal fieldname As String, ByVal prp As String) As String
        Try
            Select Case feild
                Case feildtyp.dates
                    Dim dd As Date = CDate(prp)
                    Dim d As String = Format(dd, "MM/dd/yyyy")
                    Return "" + fieldname + " = #" + d + "#"
                Case feildtyp.datesGreeterThan
                    Dim dd As Date = CDate(prp)
                    Dim d As String = Format(dd, "MM/dd/yyyy")
                    Return "" + fieldname + " =<  " + d + " "
                Case feildtyp.datesLowerThan
                    Dim dd As Date = CDate(prp)
                    Dim d As String = Format(dd, "MM/dd/yyyy")
                    Return " " + fieldname + " =>  " + d + " "

                Case feildtyp.int
                    Return " " + fieldname + " = " + prp + ""
                Case feildtyp.intGreeterThan
                    Return " " + fieldname + " < " + prp + ""
                Case feildtyp.intLowerThan
                    Return " " + fieldname + " > " + prp + ""

                Case feildtyp.simistring
                    Return " " + fieldname + "  like '%" + prp + "%'"

                Case feildtyp.simistringBiganWith
                    Return " " + fieldname + "  like '%" + prp + "'"
                Case feildtyp.simistringEndWith
                    Return " " + fieldname + "  like '" + prp + "%'"

                Case feildtyp.strings
                    Return " " + fieldname + " like '" + prp + "'"

            End Select
        Catch ex As Exception

        End Try



    End Function

    Public Function SqlDateBetween(ByVal Fild As String, ByVal D1 As Date, ByVal D2 As Date) As String
        Dim s1 As String = Format(D1, "MM/dd/yyyy")
        Dim s2 As String = Format(D2, "MM/dd/yyyy")

        Return " " + Fild + " BETWEEN #" + s1 + "# AND #" + s2 + "#"
    End Function
    Public Function SqlIntBetween(ByVal Fild As String, ByVal D1 As Double, ByVal D2 As Double) As String
        Dim s1 As String = D1.ToString
        Dim s2 As String = D2.ToString

        Return " " + Fild + " BETWEEN " + s1 + "AND " + s2 + ""
    End Function


#End Region
#End Region
#Region "Linq"
    Public Sub FillDataGridView()

    End Sub
#End Region
#Region "copy past"
    ''' <summary>
    ''' لكي يحدد مكان وقوف المؤشر بعد لصق الاضافة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CopyPast_RowNoAdded As Integer

    ''' <summary>
    ''' فتح الملفات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CopyPase_openFile()
        Dim opfd As New OpenFileDialog
        Dim x As String
        opfd.Filter = " word|*.doc|text files|*.txt |*excell|*.xls|dataAccesse|*.mdb"
        opfd.ShowDialog()
        x = opfd.FileName
        If x = "" Then Exit Sub
        Dim p As Process
        p = Process.Start(x)

    End Sub
    ''' <summary>
    ''' لصق جديد
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub CopyPase_PastNews(Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw

        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = dgv.CurrentCell.ColumnIndex
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        CopyPast_RowNoAdded = MoveLast()
        Do Until f = d
            row = DataTable.NewRow
            row(Coname) = s(f)
            DataTable.Rows.Add(row)
            f += 1
        Loop
        Dataset.HasChanges(DataRowState.Added)
        MoveTo(CopyPast_RowNoAdded)
    End Sub
    ''' <summary>
    ''' لصق جديد
    ''' </summary>
    ''' <param name="CollumNo">رقم العمود</param>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_PastNew(CollumNo As Integer, Optional start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = CollumNo
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        CopyPast_RowNoAdded = MoveLast()
        Do Until f = d
            row = DataTable.NewRow
            row(Coname) = s(f)
            DataTable.Rows.Add(row)
            f += 1
        Loop
        Dataset.HasChanges(DataRowState.Added)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

    ''' <summary>
    ''' لصق العمود
    ''' </summary>
    ''' <param name="collName">اسم العمود</param>
    ''' <param name="start"></param>
    ''' <remarks></remarks>
    Public Overloads Sub CopyPase_PastNew(collName As String, Optional start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))

        Dim Coname As String = collName
        Dim co As Integer = dgv.Columns(collName).Index
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        CopyPast_RowNoAdded = MoveLast()
        Do Until f = d
            row = DataTable.NewRow
            row(Coname) = s(f)
            DataTable.Rows.Add(row)
            f += 1
        Loop
        Dataset.HasChanges(DataRowState.Added)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

 
    ''' <summary>
    ''' لصق  
    ''' </summary>
    ''' <param name="Collumname">اسم العمود</param>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Past(Collumname As String, Optional start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))

        Dim Coname As String = dgv.Columns(Collumname).Name
        Dim co As Integer = dgv.Columns(Coname).Index
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = s(f)

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

    ''' <summary>
    ''' لصق  
    ''' </summary>
    ''' <param name="CollumNo"> رقم العمود</param>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Pasts(ByVal CollumNo As Integer, Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = CollumNo
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = s(f)

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub
    ''' <summary>
    ''' لصق  
    ''' </summary>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Past(Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = dgv.CurrentCell.ColumnIndex
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = s(f)

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

    ''' <summary>
    ''' بقيمة لصق  
    ''' </summary>
    ''' <param name="Collumname">اسم العمود</param>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Pastvalue(ByVal value As String, ByVal Collumname As String, Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw


        Dim Coname As String = dgv.Columns(Collumname).Name
        Dim co As Integer = dgv.Columns(Coname).Index
        Dim d As Integer = RowCount - rowNo
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = value

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

    ''' <summary>
    ''' لصق  
    ''' </summary>
    ''' <param name="CollumNo"> رقم العمود</param>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Pastvaluef(ByVal value As String, ByVal CollumNo As Integer, Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw

        Dim co As Integer = CollumNo
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = RowCount - rowNo
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = value

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub
    ''' <summary>
    ''' لصق  
    ''' </summary>
    ''' <param name="start">بداية النسخ</param>
    ''' <remarks></remarks>

    Public Overloads Sub CopyPase_Pastvalue(ByVal value As String, Optional ByVal start As Integer = 0)
        Dim dgv As New DataGridView
        dgv = DataGridveiw

        Dim co As Integer = dgv.CurrentCell.ColumnIndex
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = RowCount - rowNo
        Dim f As Integer = start
        Dim row As DataRow
        Dim r As Integer = rowNo
        CopyPast_RowNoAdded = rowNo
        Do Until f = d

            DataTable.Rows.Item(rowNo).BeginEdit()
            row = DataRow.Item(rowNo)
            row(Coname) = value

            f += 1
            DataTable.Rows.Item(rowNo).EndEdit()
            DataRow = DataTable.Rows
            MoveNext()
        Loop



        IsChange = True
        Dataset.HasChanges(DataRowState.Modified)
        MoveTo(CopyPast_RowNoAdded)
    End Sub

#End Region
End Class
Public Structure FieldMombers
    ''' <summary>
    ''' اسم الحقل من قاعدة البيانات
    ''' </summary>
    ''' <remarks></remarks>
    Public Name As String
    ''' <summary>
    ''' الاسم الذي سيظهر في راس الداتا جريد او صندوق العنوان المجاور اداة الادخال
    ''' </summary>
    ''' <remarks></remarks>
    Public Caption As String
    ''' <summary>
    ''' الاداة المستخدمة في ادخال وعرض البيانات من الحقل
    ''' </summary>
    ''' <remarks></remarks>
    Public Control As Control
    ''' <summary>
    ''' القيمة
    ''' </summary>
    ''' <remarks></remarks>
    Public value As Object
    ''' <summary>
    ''' هل هي مطلوبة ؟؟ ودائما يستخدم في الجدول الذي فيه حقول كثيرة 
    ''' </summary>
    ''' <remarks></remarks>
    Public isWanted As Boolean
    ''' <summary>
    ''' هل سيتم اظهار بيانات الحقل على الادوات؟؟
    ''' </summary>
    ''' <remarks></remarks>
    Public visable As Boolean
    ''' <summary>
    ''' نوع الحقل 
    ''' </summary>
    ''' <remarks></remarks>
    Public DataType As Type
    ''' <summary>
    ''' هل به المفتاح الاساسي
    ''' </summary>
    ''' <remarks></remarks>
    Public iskey As Boolean
    ''' <summary>
    ''' هل سيتم اظهاره على الداتا جريد
    ''' </summary>
    ''' <remarks></remarks>
    Public dgvVisalbe As Boolean
    ''' <summary>
    ''' رقم الحقل في الجدول
    ''' </summary>
    ''' <remarks></remarks>
    Public IDF As Integer
    ''' <summary>
    ''' مصفوفة بيانات الحقل من العمود
    ''' </summary>
    ''' <remarks></remarks>
    Public Values As Object()
    ''' <summary>
    ''' هذه الخاصية تستخدم في الاستعلام باستخدام الدوال Sum()
    ''' </summary>
    ''' <remarks></remarks>
    Public SQLFunction As String
    ''' <summary>
    ''' GroubBy تستخدم في الاستعلام لتوليد دالة 
    ''' </summary>
    ''' <remarks></remarks>
    Public isGroubBy As Boolean
    ''' <summary>
    ''' SQLWhere تخص الحقل ففط
    ''' </summary>
    ''' <remarks></remarks>
    Public where As String

    ''' <summary>
    ''' دالة الجمعة  Sql
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectSum()
        Return "Sum(" + Name + ") As EX" + Name
    End Function

    ''' <summary>
    ''' تحميل عناصر الاساسية في الحقل 
    ''' </summary>
    ''' <param name="n">اسم الحقل</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal n As String)
        Name = ""
        Caption = ""
        dgvVisalbe = True
    End Sub



End Structure
Public Interface TableFunctions
    Sub load(ByVal DataBase As String)
    Sub load()

    Property TableNaem As String
    Property FieldMumbers As FieldMombers()

End Interface
Public Enum feildtyp
    ''' <summary>
    ''' بحث نصي
    ''' </summary>
    ''' <remarks></remarks>
    strings

    ''' <summary>
    ''' بحث بجزئ من النص
    ''' </summary>
    ''' <remarks></remarks>
    simistring

    ''' <summary>
    '''  بحث بجزئ من النص يبدأ بـ
    ''' </summary>
    ''' <remarks></remarks>
    simistringBiganWith


    ''' <summary>
    '''  بحث بجزئ من النص ينتهي بـ
    ''' </summary>
    ''' <remarks></remarks>
    simistringEndWith
    ''' <summary>
    ''' بحث  برقم اكبر من
    ''' </summary>
    ''' <remarks></remarks>
    intGreeterThan
    ''' <summary>
    '''بحث برقم اصغر
    ''' </summary>
    ''' <remarks></remarks>
    intLowerThan
    ''' <summary>
    ''' بحث  رقم
    ''' </summary>
    ''' <remarks></remarks>
    int
    ''' <summary>
    ''' بحث بتاريخ
    ''' </summary>
    ''' <remarks></remarks>
    dates
    ''' <summary>
    '''  بحث بتاريخ اكبر من
    ''' </summary>
    ''' <remarks></remarks>
    datesGreeterThan
    ''' <summary>
    ''' بحث بتاريخ اصغر من
    ''' </summary>
    ''' <remarks></remarks>
    datesLowerThan
End Enum