Public Class frmFilterOpt
    Dim _sender As System.Object
    Dim oldstart As Long
    Dim oldend As Long
    Public Sub New(Optional ByVal sender As System.Object = Nothing, Optional ByVal headerSplit As String() = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _sender = sender
        For Each header In headerSplit
            cboSplit.Items.Add(header)
        Next

    End Sub
    Private Sub cboFilterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilterType.SelectedIndexChanged
        lblCriteria.Show()
        If cboFilterType.SelectedItem = "text_inclusion" Or cboFilterType.SelectedItem = "text_exclusion" Then
            hide_num()
            show_text()
        ElseIf cboFilterType.SelectedItem = "range_inclusion (exclusive)" Or cboFilterType.SelectedItem = "range_exclusion (exclusive)" Then
            hide_text()
            show_num()
        End If
    End Sub
    Private Sub frmFilterOpt_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        _sender.show()
    End Sub

    Private Sub frmFilterOpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCriteria.Hide()
        hide_text()
        hide_num()
    End Sub
    Private Sub show_text()
        txtCriteria.Show()
    End Sub

    Private Sub hide_text()
        txtCriteria.Hide()
    End Sub
    Private Sub hide_num()
        lblStart.Hide()
        txtStart.Hide()
        txtEnd.Hide()
        lblEnd.Hide()
    End Sub
    Private Sub show_num()
        lblStart.Show()
        txtStart.Show()
        txtEnd.Show()
        lblEnd.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim filter As Object
        filter = Nothing
        If txtStart.Text = "" Then
            txtStart.Text = 0
        End If
        If txtEnd.Text = "" Then
            txtEnd.Text = 0
        End If
        If cboFilterType.SelectedItem = "text_inclusion" Then
            filter = New TextInclusion(cboSplit.SelectedIndex, txtCriteria.Lines)
        ElseIf cboFilterType.SelectedItem = "text_exclusion" Then
            filter = New TextExclusion(cboSplit.SelectedIndex, txtCriteria.Lines)
        ElseIf cboFilterType.SelectedItem = "range_inclusion (exclusive)" Then
            filter = New rangeInclusion(cboSplit.SelectedIndex, txtStart.Text, txtEnd.Text)
        ElseIf cboFilterType.SelectedItem = "range_exclusion (exclusive)" Then
            filter = New rangeExclusion(cboSplit.SelectedIndex, txtStart.Text, txtEnd.Text)
        End If

        If IsNothing(filter) Then
        Else
            _sender.new_filter(filter, cboFilterType.SelectedItem)
        End If
        Me.Hide()
        _sender.show()
    End Sub

    Private Sub txtStart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStart.TextChanged
        'check that I'm a number
        Dim num As Long
        On Error GoTo fail
        If txtStart.Text <> "" Then
            num = txtStart.Text
            oldstart = num
        End If
        Exit Sub
fail:
        MsgBox("please input a number")
        txtStart.Text = oldstart
    End Sub

    Private Sub txtEnd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnd.TextChanged
        'check that I'm a number
        Dim num As Long
        On Error GoTo fail
        If txtEnd.Text <> "" Then
            num = txtEnd.Text
            oldend = num
        End If
        Exit Sub
fail:
        MsgBox("please input a number")
        txtEnd.Text = oldend

    End Sub
End Class