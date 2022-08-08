Public Class frmSplit

    Dim headerChange As Boolean
    Dim headerSplit As String()
    Dim curFile As String
    Public HeaderOpt As String
    Dim frmSplitOpt1 As frmSplitOpt
    Dim filters As Collection = New Collection

    Private Sub cboProvider_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvider.SelectedValueChanged
        If cboProvider.SelectedItem = "Complete Genomics" Then
            cboSourceType.Visible = True
            cboSourceType.Items.Clear()
            cboSourceType.Items.Add("MasterVar")
            cboSourceType.SelectedItem = "MasterVar"
            cboSourceType.Show()
        End If
    End Sub

    Private Sub cboSourceType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSourceType.SelectedValueChanged
        If cboSourceType.SelectedItem = "MasterVar" Then
            numHeader.Value = 20
        End If
    End Sub

    Private Sub numHeader_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numHeader.ValueChanged
        headerChange = True
    End Sub

    Private Sub cboFilter_SelectedIndexEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If headerChange = True Then
            readValuesOn(txtFileName.Text, numHeader.Value)
        End If
    End Sub

    Private Sub txtFileName_TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.Enter
        Dim myfile As String
        curFile = txtFileName.Text
        myfile = Globals.ThisAddIn.Application.GetOpenFilename

        If myfile = "False" Then
            hideOptions()
            Exit Sub
        Else
            txtFileName.Text = myfile
            cboDelim.SelectedItem = "tab"
            txtDelim.Text = vbTab
            showOptions()
        End If
    End Sub
    Private Sub txtFileName_TextLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.Leave
        If txtFileName.Text = curFile Then

        Else
            If txtFileName.Text = "" Then
            Else
                headerChange = True
            End If
        End If

    End Sub

    Private Sub readValuesOn(ByVal myfile As String, ByVal headerRow As Integer)
        If txtDelim.Text <> "" Then
        Else
            MsgBox("Please choose delimiter for text file")
            Exit Sub
        End If
        Dim rowCount As Integer = 1
        Dim filereader As System.IO.StreamReader
        Dim headers As String
        filereader = My.Computer.FileSystem.OpenTextFileReader(myfile)
        Do While rowCount < headerRow
            filereader.ReadLine()
            rowCount += 1
        Loop
        headers = (filereader.ReadLine)
        headerSplit = Split(headers, txtDelim.Text)
        headerChange = False
    End Sub

    Private Sub cboDelim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDelim.SelectedIndexChanged
        'headerChange = True
        With cboDelim
            If .SelectedItem = "tab" Then
                txtDelim.Text = vbTab
            ElseIf .SelectedItem = "comma" Then
                txtDelim.Text = ","
            ElseIf .SelectedItem = "other" Then
                txtDelim.Show()
                txtDelim.Text = ""
                hideOptions()
            End If
        End With
    End Sub

    Private Sub txtDelim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelim.TextChanged
        headerChange = True
        If txtDelim.Text <> "" Then
            showOptions()
        Else
            hideOptions()
        End If

    End Sub

    Private Sub cboSourceType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSourceType.SelectedIndexChanged
        numHeader.Enabled = False
        cboDelim.Enabled = False
    End Sub

    Private Sub showOptions()
        LblHeaderDelim.Show()
        lblHeader.Show()
        numHeader.Show()
        lblDelim.Show()
        cboDelim.Show()
        txtDelim.Show()

        lblOptions.Show()
        btnAddSplit.Show()
        btnAddFilter.Show()
        treeOptions.Show()

        btnSplit.Show()
    End Sub

    Private Sub hideOptions()
        LblHeaderDelim.Hide()
        lblHeader.Hide()
        numHeader.Hide()
        lblDelim.Hide()
        cboDelim.Hide()
        txtDelim.Hide()

        lblOptions.Hide()
        btnAddSplit.Hide()
        btnAddFilter.Hide()
        treeOptions.Hide()

        btnSplit.Hide()
    End Sub
    Private Sub headerCheck()
        If headerChange = True Then
            readValuesOn(txtFileName.Text, numHeader.Value)
        End If
    End Sub

    Private Sub frmSplit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hideOptions()
        headerChange = True
    End Sub

    Private Sub btnAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFilter.Click
        headerCheck()
        Me.Hide()
        Dim form As frmFilterOpt
        form = New frmFilterOpt(Me, headerSplit)
        form.Show()
    End Sub

    Public Sub new_filter(ByVal filter As Object, ByVal filtertext As String)
        filters.Add(filter)
        treeOptions.Nodes.Find("filters", False)(0).Nodes.Add(filtertext, filtertext)
    End Sub
    Private Sub btnAddSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSplit.Click
        headerCheck()
        Me.Hide()
        frmSplitOpt1 = New frmSplitOpt(Me, headerSplit)
        frmSplitOpt1.Show()

    End Sub
    Public Sub new_split(ByVal splitCol As Integer)
        treeOptions.Nodes.Find("splits", False)(0).Nodes.Add(splitCol, headerSplit(splitCol))
    End Sub

    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click
        Dim spliton As Collection
        spliton = New Collection
        For Each node In treeOptions.Nodes.Find("splits", False)(0).Nodes
            spliton.Add(node.name)
        Next
        Me.Hide()
        importBigFile(txtFileName.Text, splitFolderName:=txtFolderName.Text, splitFileName:=TxtOutFileName.Text, headerRow:=numHeader.Value, delim:=txtDelim.Text, splitOn:=spliton, filters:=filters, filemode:=True)

    End Sub


End Class