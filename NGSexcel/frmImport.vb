Public Class frmImport

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If cboProvider.SelectedItem = "Complete Genomics" Then
            If cboSourceType.SelectedItem = "" Then
                MsgBox("Please select source type")
            Else
                Dim userctrl As New frmCGenomics
                userctrl.Show()
                Me.Close()
            End If
        Else
            MsgBox("Please select source provider")
        End If
    End Sub

    Private Sub cboProvider_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvider.SelectedValueChanged
        If cboProvider.SelectedItem = "Complete Genomics" Then
            cboSourceType.Visible = True
            cboSourceType.Items.Clear()
            cboSourceType.Items.Add("MasterVar")
            cboSourceType.SelectedItem = "MasterVar"
            cboSourceType.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        importBigFile("c:\temp\coding_gene_lengths.txt")
    End Sub
End Class