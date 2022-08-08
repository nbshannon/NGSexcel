Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Dim homeform As frmHome
    Dim splitform As frmSplit
    Dim browserform As frmBrowser
    Dim linksform As frmLinks
    Dim miscform As frmMisc

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnBrowser.Click
        formHolder.showBrowser(sender, e)
    End Sub

    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnSplit.Click
        formHolder.showSplit(sender, e)
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnHome.Click
        formHolder.showHome(sender, e)
    End Sub

    Private Sub btnMisc_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnMisc.Click
        formHolder.showMisc(sender, e)
    End Sub

    Private Sub btnLinks_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnLinks.Click
        formHolder.showLinks(sender, e)
    End Sub
End Class
