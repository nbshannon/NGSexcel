Public Class frmUseStrand
    Dim _sender As System.Object

    Private Sub txtHeaderRow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHeaderRow.Click
        On Error GoTo ErrorHandler
        Dim HeaderRow As Excel.Range
        HeaderRow = Globals.ThisAddIn.Application.InputBox(Prompt:="Select Header Row", Title:="Header Selection", Type:=8)
        txtHeaderRow.Text = HeaderRow.Row
        Dim headers As Collection
        headers = ValuesOnRow(HeaderRow)
        Me.Focus()
        cboStrand.Items.Clear()
        For Each header In headers
            cboStrand.Items.Add(header)
        Next
        For Each strandTest In Split("strand,STRAND", ",")
            If cboStrand.Items.Contains(strandTest) Then
                cboStrand.SelectedItem = strandTest
                Exit For
            End If
        Next
        cboStrand.Visible = True
        Exit Sub
ErrorHandler:
        MsgBox("Please choose header row")
        Me.Focus()
        'Resume Next
    End Sub

    Public Sub New(Optional ByVal sender As System.Object = Nothing)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _sender = sender
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If cboStrand.SelectedItem <> "" Then
            _sender.strandCol = cboStrand.SelectedIndex + 1
            _sender.setUseStrand(True)
            _sender.forceDirection = chkForceDirection.Checked
        Else
            _sender.setUseStrand(False)
        End If
        Me.Hide()
        _sender.show()
    End Sub

    Private Sub frmUseStrand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _sender.setUseStrand(False)
        cboStrand.Visible = False
        txtHeaderRow_Click(sender, e)
    End Sub

    Private Sub frmUseStrand_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        _sender.show()
    End Sub
End Class