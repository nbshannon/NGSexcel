Module formHolder
    Dim homeform As frmHome
    Dim splitform As frmSplit
    Dim browserform As frmBrowser
    Dim linksform As frmLinks
    Dim miscform As frmMisc

    Public Sub showBrowser(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err
        browserform.Show()
        GoTo closeOld
        Exit Sub
err:
        browserform = New frmBrowser
        browserform.Show()

closeOld:
        On Error Resume Next
        If sender.GetType.FullName = "System.Windows.Forms.Button" Then
            sender.FindForm.close()
        End If

    End Sub

    Public Sub showSplit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err
        splitform.Show()
        GoTo closeOld
        Exit Sub
err:
        splitform = New frmSplit
        splitform.Show()

closeOld:
        On Error Resume Next
        If sender.GetType.FullName = "System.Windows.Forms.Button" Then
            sender.FindForm.close()
        End If
    End Sub

    Public Sub showHome(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err
        homeform.Show()
        GoTo closeOld
        Exit Sub
err:
        homeform = New frmHome
        homeform.Show()

closeOld:
        On Error Resume Next
        If sender.GetType.FullName = "System.Windows.Forms.Button" Then
            sender.FindForm.close()
        End If
    End Sub

    Public Sub showMisc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err
        miscform.Show()
        GoTo closeOld
        Exit Sub
err:
        miscform = New frmMisc
        miscform.Show()

closeOld:
        On Error Resume Next
        If sender.GetType.FullName = "System.Windows.Forms.Button" Then
            sender.FindForm.close()
        End If
    End Sub

    Public Sub showLinks(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err
        linksform.Show()
        GoTo closeOld
        Exit Sub
err:
        linksform = New frmLinks
        linksform.Show()

closeOld:
        On Error Resume Next
        If sender.GetType.FullName = "System.Windows.Forms.Button" Then
            sender.FindForm.close()
        End If
    End Sub
End Module
