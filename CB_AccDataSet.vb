Partial Class CB_AccDataSet
    Partial Class CashAccNameDataTable

        Private Sub CashAccNameDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.EmprisseColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace CB_AccDataSetTableAdapters
    
    Partial Public Class AccNameTableAdapter
    End Class
End Namespace
