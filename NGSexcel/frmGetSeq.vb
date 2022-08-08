Imports System.Xml
Public Class frmGetSeq
    Private lastExtend As String = 0

    Private Sub btnGetSeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetSeq.Click
        If checkInputs() = False Then
            Exit Sub
        End If
        Dim coord As New GenomicCoord
        coord.setFromValues(cboChr.SelectedItem, txtChrStart.Text, txtChrEnd.Text)
        If txtExtend.Text > 0 Then
            coord.extend(txtExtend.Text)
        End If

        ' okay to only set ensembl, since default is UCSC
        If cboSource.SelectedItem = "ensembl" Then
            coord.setSeqSource("ensembl")
        End If
        ' if we aren't using hg19, need to set it
        If cboSource.SelectedItem = "hg19" Then
        Else
            coord.setBuild(cboBuildVer.SelectedItem)
        End If

        Dim seq As String = coord.getSeq
        If chkEnclose.Checked = True Then
            seq = seq.Insert(txtExtend.Text, "[")
            seq = seq.Insert(txtChrEnd.Text - txtChrStart.Text + txtExtend.Text + 2, "]")
        End If
        If chkReverse.Checked = True Then
            If chkForceDirection.Checked = True Then
                seq = seqrevcomp(seq)
            Else
                seq = seqrev(seq)
            End If
        End If

        If seq = "RORRE" Then seq = "ERROR"
        If chkFasta.Checked = True Then
            Dim myName As String = ">" & cboChr.SelectedItem & ":" & txtChrStart.Text & "-" & txtChrEnd.Text & ", extend=" & txtExtend.Text
            Windows.Forms.Clipboard.SetText(myName & vbCrLf & seq)
            MsgBox("The following was copied to the clipboard:" & vbCrLf & myName & vbCrLf & seq)
        Else
            Windows.Forms.Clipboard.SetText(seq)
            'Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.StringFormat, seq.Trim)
            'Windows.Forms.Clipboard.SetDataObject(seq.Trim)
            MsgBox("The following was copied to the clipboard:" & vbCrLf & seq)
        End If

    End Sub

    Private Function checkInputs()
        checkInputs = True
        If txtExtend.Text = "" Then
            txtExtend.Text = 0
        End If
        On Error GoTo Err
        If cboChr.SelectedItem = "" Then
            GoTo err
        End If
        Dim num As Long
        num = txtChrEnd.Text
        num = txtChrStart.Text
        Exit Function
Err:
        checkInputs = False
        MsgBox("Please check input values")
    End Function

    Private Sub frmGetSeq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo err
        Dim genomic_coord As String = Globals.ThisAddIn.Application.ActiveCell.Value
        Dim range As New GenomicCoord
        range.setFromCoord(genomic_coord)
        Dim vals As String() = range.coordinatesAsArray
        If range.valid = True Then
            cboChr.SelectedItem = vals(0)
            txtChrStart.Text = vals(1)
            txtChrEnd.Text = vals(2)
        End If
        cboSource.SelectedItem = "UCSC"
        cboBuildVer.SelectedItem = "hg19"

err:
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

    Private Sub chkReverse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReverse.CheckedChanged
        If chkReverse.Checked = True Then chkForceDirection.Checked = True
    End Sub

    Private Sub cboSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSource.SelectedIndexChanged
        If cboSource.SelectedItem = "ensembl" Then
            cboBuildVer.Hide()
        Else
            cboBuildVer.Show()
        End If
    End Sub
End Class