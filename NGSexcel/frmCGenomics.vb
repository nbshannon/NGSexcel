Public Class frmCGenomics

    Private Sub frmCGenomics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim clbs As Collection
        clbs = New Collection
        clbs.Add(clbZygosity)
        clbs.Add(clbVarType)
        clbs.Add(clbAllele1Q)
        clbs.Add(clbAllele2Q)

        For Each clb In clbs
            For i = 0 To clb.items.count - 1
                clb.SetItemChecked(i, True)
            Next
        Next

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        'check that at least one option from each box is selected

        Dim clbs As Collection
        clbs = New Collection
        clbs.Add(clbZygosity)
        clbs.Add(clbVarType)
        clbs.Add(clbAllele1Q)
        clbs.Add(clbAllele2Q)

        For Each clb In clbs
            If clb.CheckedItems.Count = 0 Then
                MsgBox("Please select at least one option from each box")
                Exit Sub
            End If
        Next

        Dim myfile As String
        myfile = Globals.ThisAddIn.Application.GetOpenFilename

        If myfile = "False" Then
            Exit Sub
        End If

        Dim mysplit
        mysplit = cboSplit.SelectedItem
        If mysplit = "varType" Then
            mysplit = 6
        Else
            mysplit = -1
        End If


        'need to reverse these, seeing as we want to exclude things
        Dim filters As Collection
        filters = New Collection
        filters.Add(clbZygosity.CheckedItems, "zygosity")
        filters.Add(clbVarType.CheckedItems, "varType")
        filters.Add(clbAllele1Q.CheckedItems, "allele1VarQuality")
        filters.Add(clbAllele2Q.CheckedItems, "allele2VarQuality")

        Dim headerRow As Integer
        headerRow = 20
        Call importBigFile(file:=myfile, splitOn:=mysplit, headerRow:=headerRow)

    End Sub

End Class