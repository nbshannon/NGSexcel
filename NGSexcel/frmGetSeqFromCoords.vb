Public Class frmGetSeqFromCoords
    Private lastExtend As String = 0
    Dim frmUseStrand1 As frmUseStrand
    Public strandCol As Integer = 1
    Public forceDirection As Boolean = False
    Private Sub btnGetSeqs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetSeqs.Click
        Dim test As New GenomicCoord
        test.setFromCoord(Globals.ThisAddIn.Application.Selection(1).value)
        If test.valid = True Then
            getSeqs(Globals.ThisAddIn.Application.Selection)
        Else
            If MsgBox("Couldn't find genomic coord in first cell" & vbCrLf & "Okay to continue?", vbYesNo, "Okay to continue?") = vbYes Then
                getSeqs(Globals.ThisAddIn.Application.Selection)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub getSeqs(ByVal selection As Excel.Range)
        ProgressBar.Show()
        ProgressBar.Maximum = selection.Count
        ProgressBar.Step = selection.Count / 100
        Dim mysheet As Excel.Worksheet
        mysheet = selection.Worksheet
        Dim outputsheet As Excel.Worksheet
        Dim myCoord As New GenomicCoord
        outputsheet = GetOrMakeSheet("sequences")
        Dim start As Long = outputsheet.LastRow
        Dim count As Long = 0
        For Each cell In selection
            count += 1
            ProgressBar.Value = count
            myCoord.setFromCoord(cell.value)
            If myCoord.valid = True Then
                Dim myLength As Long = myCoord.length
                Dim myName As String = cell.value
                If txtExtend.Text <> "" Then
                    myCoord.extend(txtExtend.Text)
                    myName = myName & ", extend=" & txtExtend.Text
                End If

                ' okay to only set ensembl, since default is UCSC
                If cboSource.SelectedItem = "ensembl" Then
                    myCoord.setSeqSource("ensembl")
                End If
                ' if we aren't using hg19, need to set it
                If cboSource.SelectedItem = "hg19" Then
                Else
                    myCoord.setBuild(cboBuildVer.SelectedItem)
                End If

                Dim seq As String = myCoord.getSeq
                If chkEnclose.Checked = True Then
                    seq = seq.Insert(txtExtend.Text, "[")
                    seq = seq.Insert(myLength + txtExtend.Text + 2, "]")
                End If
                If chkUseStrand.Checked = True Then

                    Select Case mysheet.Cells(cell.row, strandCol).value.ToString
                        Case "-1"
                            If forceDirection = True Then
                                seq = seqrevcomp(seq)
                            Else
                                seq = seqcomp(seq)
                            End If
                        Case "-"
                            If forceDirection = True Then
                                seq = seqrevcomp(seq)
                            Else
                                seq = seqcomp(seq)
                            End If
                    End Select
                End If
                If chkFasta.Checked = True Then
                    outputsheet.Cells(count * 2 - 1 + start, 1).value = ">" & myName
                    outputsheet.Cells(count * 2 + start, 1).value = seq
                Else
                    outputsheet.Cells(count + start, 1).value = myName
                    outputsheet.Cells(count + start, 1).value = seq
                End If
            End If
        Next
        MsgBox("Done")
        outputsheet.Activate()
        Me.Hide()
    End Sub

    Private Sub frmGetSeqFromCoords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar.Hide()
        cboSource.SelectedItem = "UCSC"
        cboBuildVer.SelectedItem = "hg19"
    End Sub

    Private Sub txtExtend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtend.TextChanged
        On Error GoTo err
        Dim num As Long
        If txtExtend.Text <> "" Then
            num = txtExtend.Text
        End If
        lastExtend = txtExtend.Text
        Exit Sub
err:
        txtExtend.Text = lastExtend
    End Sub
    Public Sub setUseStrand(ByVal chkval As Boolean)
        chkUseStrand.Checked = chkval
    End Sub
    Private Sub chkUseStrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseStrand.Click
        Me.Hide()
        frmUseStrand1 = New frmUseStrand(Me)
        frmUseStrand1.Show()
    End Sub
    Private Sub cboSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSource.SelectedIndexChanged
        If cboSource.SelectedItem = "ensembl" Then
            cboBuildVer.Hide()
        Else
            cboBuildVer.Show()
        End If
    End Sub
End Class