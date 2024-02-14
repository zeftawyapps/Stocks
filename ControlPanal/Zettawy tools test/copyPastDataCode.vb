Public Class copyPastDataCode
    

    ''' <summary>
    ''' فتح الملفات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub openFile()
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
    ''' <param name="dgv"></param>
    ''' <remarks></remarks>
    Public Overloads Sub PastNewd(ByVal dgv As DataGridView, ByVal datac As OLEdatabaseCodeing, Optional ByVal start As Integer = 0)
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = dgv.CurrentCell.ColumnIndex
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Do Until f = d
            row = datac.DataTable.NewRow
            row(Coname) = s(f)
            datac.DataTable.Rows.Add(row)
            f += 1
        Loop
        datac.Dataset.HasChanges(DataRowState.Added)
    End Sub


    Public Overloads Sub PastNew(ByVal dgv As DataGridView, datac As OLEdatabaseCodeing, CollumNo As Integer, Optional start As Integer = 0)
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))
        Dim co As Integer = CollumNo
        Dim Coname As String = dgv.Columns(co).Name
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Do Until f = d
            row = datac.DataTable.NewRow
            row(Coname) = s(f)
            datac.DataTable.Rows.Add(row)
            f += 1
        Loop
        datac.Dataset.HasChanges(DataRowState.Added)
    End Sub


    Public Overloads Sub PastNew(ByVal dgv As DataGridView, datac As OLEdatabaseCodeing, collName As String, Optional start As Integer = 0)
        Dim x As String = Clipboard.GetText
        Dim s() As String = x.Split(Chr(10))

        Dim Coname As String = collName
        Dim co As Integer = dgv.Columns(collName).Index
        Dim d As Integer = UBound(s)
        Dim f As Integer = start
        Dim row As DataRow
        Do Until f = d
            row = datac.DataTable.NewRow
            row(Coname) = s(f)
            datac.DataTable.Rows.Add(row)
            f += 1
        Loop
        datac.Dataset.HasChanges(DataRowState.Added)
    End Sub

End Class
