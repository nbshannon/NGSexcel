Public Class frmHome

    Private Sub btnSplitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click
        formHolder.showSplit(sender, e)
    End Sub


    Private Sub brnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnBrowser.Click
        formHolder.showBrowser(sender, e)
    End Sub

    Private Sub btnMisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMisc.Click
        formHolder.showMisc(sender, e)
    End Sub

End Class