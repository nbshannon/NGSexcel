Public Class frmProgress

    Private myCancel As Boolean
    ReadOnly Property cancel() As Boolean
        Get
            Return myCancel
        End Get
    End Property

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        myCancel = True
    End Sub
End Class