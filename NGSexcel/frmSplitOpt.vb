Public Class frmSplitOpt

    Dim _sender As System.Object
    Public Sub New(Optional ByVal sender As System.Object = Nothing, Optional ByVal headerSplit As String() = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _sender = sender
        For Each header In headerSplit
            cboSplit.Items.Add(header)
        Next

    End Sub


    Private Sub btnAddSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSplit.Click
        If cboSplit.SelectedItem <> "" Then
            _sender.new_split(cboSplit.SelectedIndex)
            Me.Hide()
            _sender.show()
        End If
        Me.Hide()
    End Sub

    Private Sub frmSplitOpt_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        _sender.show()
    End Sub

End Class