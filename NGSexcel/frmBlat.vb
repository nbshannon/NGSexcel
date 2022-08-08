Imports System
Imports System.IO
Imports System.Net
Imports System.Text
'Imports "wininet.dll"

Public Class frmBlat

    Private Sub btnBLAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBLAT.Click
        On Error GoTo err
        Dim userSeq As String = Globals.ThisAddIn.Application.ActiveCell.Value
        Dim URLString As String = ""
        URLString = "http://genome.ucsc.edu/cgi-bin/hgBlat" & "?command=start&org=Human&db=" & cboAssembly.SelectedItem & "&type=" & cboQuery.SelectedItem & "&sort=" & cboSort.SelectedItem & "&output=psl%20no%20header"
        URLString = URLString & "&userSeq=" & userSeq
        Dim req As WebRequest = WebRequest.Create(URLString)
        Dim res As WebResponse = req.GetResponse()
        Dim dataStream As Stream = res.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim responsefromserver As String = reader.ReadToEnd()
        Dim result As String = responsefromserver
        reader.Close()
        dataStream.Close()
        res.Close()
        Dim pattern = "<PRE>(.*\n)*<\/PRE>"
        Dim matches As RegularExpressions.MatchCollection = RegularExpressions.Regex.Matches(result, pattern)
        If matches.Count > 0 Then
            Dim outputsheet As Excel.Worksheet
            outputsheet = GetOrMakeSheet("BLATResults")
            outputsheet.Activate()
            'write header
            Dim header As String = Join(Split("match mismatch rep_match n_s q_gap_count q_gap_bases t_gap_count t_gap_bases strand q_name q_size q_start q_end t_name t_size t_start t_end block_count blockSizes qStarts tStarts", " "), vbTab)
            Windows.Forms.Clipboard.SetText(header)
            Globals.ThisAddIn.Application.Selection.pastespecial()
            outputsheet.Cells(1, 1).select()

            For Each match As RegularExpressions.Match In matches
                For groupCtr As Integer = 1 To match.Groups.Count - 1
                    Dim group As RegularExpressions.Group = match.Groups(groupCtr)
                    For captureCtr As Integer = 0 To group.Captures.Count - 1
                        Windows.Forms.Clipboard.SetText(group.Captures(captureCtr).Value)
                        outputsheet.Cells(captureCtr + 2, 1).Select()
                        Globals.ThisAddIn.Application.Selection.pastespecial()
                    Next
                Next
            Next

        End If
        Exit Sub
err:
        'getSeq = "Error"
    End Sub

    Private Sub frmBLAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo err
        Dim userSeq As String = Globals.ThisAddIn.Application.ActiveCell.Value
        'Dim userSeq As String = ""
        'For Each cell As Excel.Range In Globals.ThisAddIn.Application.Selection
        'userSeq = userSeq & cell.Value & vbNewLine
        'Next
        MsgBox(userSeq)
        cboAssembly.SelectedItem = "hg19"
        cboQuery.SelectedItem = "DNA"
        cboSort.SelectedItem = "chrom,start"
err:
    End Sub
End Class