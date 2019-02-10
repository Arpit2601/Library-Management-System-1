Public Class viewBookTable

    Private Sub BorrowedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowedBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet1)

    End Sub

    Private Sub IssueCountTextBox_TextChanged(sender As Object, e As EventArgs) Handles IssueCountTextBox.TextChanged

    End Sub
End Class
