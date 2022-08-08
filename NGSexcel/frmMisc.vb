Public Class frmMisc

    Private Sub btnGetSeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetSeq.Click
        Dim form As New frmGetSeq
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddCoords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCoords.Click
        Dim form As New frmAddCoords
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form As New frmGetSeqFromCoords
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnLinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinks.Click
        formHolder.showLinks(sender, e)
    End Sub

    Private Sub btnBLAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBLAT.Click
        Dim form As New frmBlat
        form.Show()
        Me.Hide()
    End Sub
End Class