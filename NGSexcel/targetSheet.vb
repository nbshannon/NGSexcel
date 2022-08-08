Public Class targetSheet
    Private myFileMode As Boolean
    Private myFileName As String
    Private curRow As Long
    Private mySheet As Excel.Worksheet
    Private curIncrement As Integer
    Private myHeaders As Collection
    Private maxRow As Long
    Private myFileWriter As System.IO.StreamWriter
    Private myValid As Boolean

    ReadOnly Property isValid() As Boolean
        Get
            Return myValid
        End Get
    End Property

    ReadOnly Property SheetName() As String
        Get
            Return mySheet.Name
        End Get
    End Property

    ReadOnly Property CurrentRow() As Long
        Get
            Return curRow
        End Get
    End Property

    Public Sub New(ByVal targetName As String, Optional ByVal headers As Collection = Nothing, Optional ByVal FileMode As Boolean = False, Optional ByVal tempFolder As String = "")
        myValid = False
        On Error GoTo err
        If FileMode = True Then
            myFileMode = True
            targetName = StripInvalidFileChar(targetName)
            myFileWriter = My.Computer.FileSystem.OpenTextFileWriter(targetName, False)
            myFileName = targetName
            'need to change this to get a proper max row
            maxRow = 1000000
            curRow = 0
        Else
            mySheet = GetOrMakeSheet(targetName)
            maxRow = mySheet.MaxRow
            curRow = mySheet.LastRow
        End If
        curIncrement = 0
        If IsNothing(headers) Then
        Else
            myHeaders = headers
            WriteLines(headers)
        End If
        myValid = True
        Exit Sub

err:
        myValid = False
    End Sub
    Private Sub addSheet()
        curIncrement += 1
        If myFileMode = True Then
            myFileWriter.Close()
            myFileWriter = My.Computer.FileSystem.OpenTextFileWriter(myFileName & "_" & curIncrement & ".txt", False)
            curRow = 0
        Else
            mySheet = GetOrMakeSheet(mySheet.Name & "_" & curIncrement)
            curRow = mySheet.LastRow
        End If
        If IsNothing(myHeaders) Then
        Else
            WriteLines(myHeaders)
        End If
    End Sub
    Public Sub WriteLine(ByVal line As Object)
        curRow += 1
        If curRow > maxRow Then
            addSheet()
        End If

        If myFileMode = True Then
            myFileWriter.WriteLine(Join(line, vbTab))
        Else
            For i = LBound(line) To UBound(line)
                mySheet.Cells(curRow, i + 1).value = line(i)
            Next
        End If

        Exit Sub
    End Sub
    Public Sub close()
        If myFileMode = True Then
            myFileWriter.Close()
        End If
    End Sub
    Public Sub WriteLines(ByVal lines As Collection)
        For Each line In lines
            WriteLine(line)
        Next

    End Sub
End Class
