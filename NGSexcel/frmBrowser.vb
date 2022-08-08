Public Class frmBrowser

    Private Sub txtHeaderRow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHeaderRow.Click
        On Error GoTo ErrorHandler
        Dim HeaderRow As Excel.Range
        HeaderRow = Globals.ThisAddIn.Application.InputBox(Prompt:="Select Header Row", Title:="Header Selection", Type:=8)
        txtHeaderRow.Text = HeaderRow.Row
        Dim headers As Collection
        headers = ValuesOnRow(HeaderRow)
        Me.Focus()
        Call setCols(headers)
        Exit Sub
ErrorHandler:
        'MsgBox("Please choose header row")
        Me.Focus()
        'Resume Next
    End Sub

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' select ensembl for default
        cboBrowser.SelectedItem = "ensembl"
        txtHeaderRow_Click(sender, e)
    End Sub

    Private Sub setCols(ByVal headers As Collection)
        Dim boxes As Collection
        boxes = New Collection
        boxes.Add(cboChr)
        boxes.Add(cboStart)
        boxes.Add(cboEnd)
        For Each box In boxes
            With box
                .Visible = True
                .Items.Clear()
                For Each header In headers
                    .items.add(header)
                Next
            End With
        Next
        ' try and find default headers
        For Each chrTest In Split("chromosome,CHROMOSOME,chr,CHR", ",")
            If cboChr.Items.Contains(chrTest) Then
                cboChr.SelectedItem = chrTest
                Exit For
            End If
        Next
        For Each startTest In Split("start,begin,START,BEGIN,chr_start,CHR_START", ",")
            If cboStart.Items.Contains(startTest) Then
                cboStart.SelectedItem = startTest
                Exit For
            End If
        Next
        For Each endTest In Split("end,END,chr_end,CHR_END", ",")
            If cboEnd.Items.Contains(endTest) Then
                cboEnd.SelectedItem = endTest
                Exit For
            End If
        Next
    End Sub

    Private Sub btnInsertLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertLink.Click
        Dim chrcol, startcol, endcol As Long
        Dim chrVal As String
        Dim startVal As Long
        Dim endVal As Long

        If cboChr.SelectedItem = "" Or cboStart.SelectedItem = "" Or cboEnd.SelectedItem = "" Then
            If txtHeaderRow.Text = "" Then
                MsgBox("Please choose header row")
            Else
                MsgBox("Please choose chr, start and end")
            End If
            Exit Sub
        End If

        chrcol = cboChr.Items.IndexOf(cboChr.Text) + 1
        startcol = cboStart.Items.IndexOf(cboStart.Text) + 1
        endcol = cboStart.Items.IndexOf(cboEnd.Text) + 1
        Globals.ThisAddIn.Application.Columns(chrcol).insert()
        If startcol > chrcol Then
            startcol += 1
        End If
        If endcol > chrcol Then
            endcol += 1
        End If
        chrcol += 1
        Globals.ThisAddIn.Application.Cells(txtHeaderRow.Text, chrcol - 1) = "Browser_link"
        Dim thisSheet As Excel.Worksheet
        thisSheet = Globals.ThisAddIn.Application.ActiveSheet
        For i = txtHeaderRow.Text + 1 To thisSheet.LastRow()
            chrVal = Globals.ThisAddIn.Application.Cells(i, chrcol).value
            chrVal = RegExpSubstitute(chrVal, "chr", "")
            chrVal = RegExpSubstitute(chrVal, "c", "")
            chrVal = RegExpSubstitute(chrVal, ".fa", "")
            startVal = Globals.ThisAddIn.Application.Cells(i, startcol).value
            endVal = Globals.ThisAddIn.Application.Cells(i, endcol).value
            Globals.ThisAddIn.Application.ActiveSheet.Hyperlinks.Add(Globals.ThisAddIn.Application.Cells(i, chrcol - 1), browser_locToLink(cboBrowser.Text, chrVal, startVal, endVal), TextToDisplay:=cboBrowser.Text)
        Next
        Me.Close()
    End Sub


End Class