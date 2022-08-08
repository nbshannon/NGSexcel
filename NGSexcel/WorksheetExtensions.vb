'Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.CompilerServices
Module Worksheet
    <Extension()>
    Public Function MaxRow(ByVal curSheet As Excel.Worksheet)
        On Error Resume Next
        With curSheet
            MaxRow = .Cells(1, 1).End(Excel.XlDirection.xlDown).Row
        End With
    End Function
    <Extension()>
    Public Function LastRow(ByVal curSheet As Excel.Worksheet)
        On Error Resume Next
            With curSheet
                LastRow = .Cells.Find(What:="*", SearchDirection:=Excel.XlSearchDirection.xlPrevious, SearchOrder:=Excel.XlSearchOrder.xlByRows).Row
            End With
    End Function

End Module

