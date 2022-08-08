Module SheetFunctions
    Public Function ValuesOnRow(ByVal row As Excel.Range)
        On Error GoTo ErrorHandler
        'make sure we are using whole row
        row = row.Worksheet.Rows(row.Row)
        Dim values As Collection
        Dim myval As String
        Dim nilcount As Long
        values = New Collection
        For i = 1 To LastColOnRow(row)
            myval = row.Cells(i).value
            If myval = "" Then
                values.Add("nil" & nilcount)
                nilcount += 1
            Else
                values.Add(row.Cells(i).value)
            End If
        Next
        ValuesOnRow = values
        Exit Function

ErrorHandler:
        MsgBox("I've had a problem looking at the values on a row")
    End Function

    Public Function LastColOnRow(ByVal row As Excel.Range)
        On Error Resume Next
        lastColOnRow = row.Find(What:="*", SearchDirection:=Excel.XlSearchDirection.xlPrevious, SearchOrder:=Excel.XlSearchOrder.xlByColumns).Column
        'lastColOnRow = row.Find(What:="*", SearchDirection:=xlPrevious, SearchOrder:=xlByColumns).Column
    End Function

    Public Function GetOrMakeSheet(ByVal sheetName As String) As Excel.Worksheet
        Dim curSheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet
start:
        On Error GoTo makeSheet
        GetOrMakeSheet = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(sheetName)
        Exit Function

makeSheet:
        Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets.Add().name = sheetName
        curSheet.Activate()
        GoTo start

        'WARNING: could messup in loop
    End Function
End Module
