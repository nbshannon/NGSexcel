Module bigfile
    Dim mySplitFolderName As String
    Dim mySplitFileName As String
    Dim myDelim As String
    Dim myHeaderRow As Integer
    Dim mySplitOn As Collection
    Dim myFilters As Collection
    Dim myFilemode As Boolean

    Dim mytargetsheets As Collection
    Dim myheaders As Collection
    Dim mycurLine As Long
    Dim tempFolder As String
    Dim errSheet As Collection = New Collection

    Sub importBigFile(ByVal file As String,
                      Optional ByVal splitFolderName As String = "split",
                      Optional ByVal splitFileName As String = "split",
                      Optional ByVal delim As String = vbTab,
                      Optional ByVal headerRow As Integer = 1,
                      Optional ByVal splitOn As Collection = Nothing,
                      Optional ByVal filters As Collection = Nothing,
                      Optional ByVal filemode As Boolean = False)

        'check that we are working with a txt, csv or tsv file
        '?
        'On Error GoTo fail

        ' turn off screen updating
        Dim myScreenUpdating As Boolean
        myScreenUpdating = Globals.ThisAddIn.Application.ScreenUpdating
        If myFilemode = False Then
            Globals.ThisAddIn.Application.ScreenUpdating = False
        End If

        If IsNothing(Globals.ThisAddIn.Application.ActiveWorkbook) Then
            MsgBox("There is no active workbook")
            Exit Sub
        End If

        'setup global variables
        myheaders = New Collection
        mytargetsheets = New Collection

        'copy over parameters to globals
        mySplitFolderName = splitFolderName
        mySplitFileName = splitFileName
        myDelim = delim
        myHeaderRow = headerRow
        mySplitOn = splitOn
        myFilters = filters
        myFilemode = filemode

        'setup my variables
        Dim LastEndOfLinePos As Long
        Dim NextEndOfLinePos As Long
        Dim RequiredBlocks As Long
        Dim lastBlock As Long
        Dim buffer As Char()
        Dim bufferSize As Long = 32768
        Dim filesize As Long
        Dim thisLine As String = ""
        Dim updateAt As Integer = 10
        Dim curChunk As Long = 1
        Dim bCancel As Boolean = False
        mycurLine = 0

        'setup progress form
        Dim progress As New frmProgress
        progress.Show()

        ' make temp folder for generation of text files
        If myFilemode = True Then
            tempFolder = My.Computer.FileSystem.GetFileInfo(file).DirectoryName & "\" & mySplitFolderName & "\"
            My.Computer.FileSystem.CreateDirectory(tempFolder)
        End If
        ' setup filereader
        Dim filereader As System.IO.StreamReader
        filereader = My.Computer.FileSystem.OpenTextFileReader(file)
        ' setup buffer blocks
        filesize = My.Computer.FileSystem.GetFileInfo(file).Length
        RequiredBlocks = filesize \ bufferSize + 1
        progress.ProgressBar1.Maximum = RequiredBlocks
        lastBlock = filesize Mod bufferSize
        ReDim buffer(bufferSize)

        ' loop through buffer blocks

        Do While (Not bCancel And curChunk <= RequiredBlocks)

            progress.ProgressBar1.Value = curChunk

            If curChunk = RequiredBlocks Then
                ReDim buffer(lastBlock)
                'MsgBox("I've got to the end" & vbCrLf & "last block is " & lastBlock & "bytes long, and I want to get " & UBound(buffer) & " bytes")
            End If

            filereader.ReadBlock(buffer, LBound(buffer), UBound(buffer))
            LastEndOfLinePos = 0
            NextEndOfLinePos = InStr(Start:=LastEndOfLinePos + 1, String1:=buffer, String2:=Chr(10), Compare:=vbBinaryCompare)

            ' repeat until we don't have any EOL
            Do While NextEndOfLinePos <> 0
                thisLine = thisLine & Mid(buffer, LastEndOfLinePos + 1, NextEndOfLinePos - LastEndOfLinePos - 1)
                processline(thisLine)
                thisLine = ""
                LastEndOfLinePos = NextEndOfLinePos
                NextEndOfLinePos = InStr(Start:=LastEndOfLinePos + 1, String1:=buffer, String2:=Chr(10), Compare:=vbBinaryCompare)
            Loop

            ' If we have any buffer left, remember that for the next line
            If UBound(buffer) > LastEndOfLinePos Then
                thisLine = thisLine & Mid(buffer, LastEndOfLinePos + 1, UBound(buffer) - LastEndOfLinePos)
            End If

            'check we haven't cancelled
            System.Windows.Forms.Application.DoEvents()
            bCancel = progress.cancel
            curChunk += 1
        Loop

        ' if we have anything left, process that too
        If thisLine <> "" Then
            processline(thisLine)
        End If

        ' close the filereader
        filereader.Close()

        'close target files if required
        If myFilemode = True Then
            For Each thistargetSheet In mytargetsheets
                If thistargetSheet.isvalid Then
                    thistargetSheet.close()
                End If
            Next
        End If

        'close progress and alert to finish
        ' restore screenupdating default
        Globals.ThisAddIn.Application.ScreenUpdating = myScreenUpdating
        progress.Close()
        If bCancel = True Then
            MsgBox("Split cancelled")
        Else
            If errSheet.Count > 0 Then
                Dim errMsg As String = "Done, with errors:"
                For Each es In errSheet
                    errMsg += vbCrLf & es
                Next
                MsgBox(errMsg)
            Else
                MsgBox("Done")
            End If
        End If

        Exit Sub
fail:
        MsgBox("I failed" & vbCrLf & Err.Description)
        Globals.ThisAddIn.Application.ScreenUpdating = myScreenUpdating

    End Sub

    Private Sub processline(ByRef thisline As String)
        Dim linesplit As Object
        Dim targetSheetName As String
        Dim mysheet As targetSheet
        linesplit = Split(thisline, myDelim)
        mycurLine += 1

        ' check if we are still in a header
        If mycurLine < myHeaderRow + 1 Then
            myheaders.Add(linesplit)
            Exit Sub
        End If

        'check filters
        If myFilters.Count > 0 Then
            For Each thisFilter In myFilters
                If thisFilter.filterLine(linesplit) = False Then
                    Exit Sub
                End If
            Next
        End If

        targetSheetName = ""
        If mySplitOn.Count > 0 Then
            For Each spliton In mySplitOn
                targetSheetName = mySplitFileName & targetSheetName & linesplit(spliton)
            Next
            If targetSheetName = "" Then
                targetSheetName = mySplitFileName & "nil"
            End If
        Else
            targetSheetName = mySplitFileName
        End If

        'check if targetsheetname is acceptable
        'otherwise other

        If mytargetsheets.Contains(targetSheetName) Then
            mysheet = mytargetsheets.Item(targetSheetName)
        Else
            If myFilemode = False Then
                mysheet = New targetSheet(targetSheetName, headers:=myheaders, FileMode:=False)
                If mysheet.isValid = False Then
                    addErrSheet(targetSheetName & " (Used other instead)")
                    If mytargetsheets.Contains("other") Then
                        mysheet = mytargetsheets.Item("other")
                    Else
                        mysheet = New targetSheet(mySplitFileName & "other", headers:=myheaders, FileMode:=False)
                        mytargetsheets.Add(mysheet, "other")
                    End If
                Else
                    mytargetsheets.Add(mysheet, targetSheetName)
                End If
            Else
                mysheet = New targetSheet(tempFolder & targetSheetName & ".txt", headers:=myheaders, FileMode:=True, tempFolder:=tempFolder)
                If mysheet.isValid = False Then
                    addErrSheet(targetSheetName & ".txt (Used other.txt instead)")
                    If mytargetsheets.Contains("other") Then
                        mysheet = mytargetsheets.Item("other")
                    Else
                        mysheet = New targetSheet(tempFolder & mySplitFileName & "other.txt", headers:=myheaders, FileMode:=True, tempFolder:=tempFolder)
                        mytargetsheets.Add(mysheet, "other")
                    End If
                Else
                    mytargetsheets.Add(mysheet, targetSheetName)
                End If
            End If
        End If

        If mysheet.isValid Then
            mysheet.WriteLine(linesplit)
        Else
            addErrSheet(targetSheetName & " (couldn't write)")
        End If

        Exit Sub
    End Sub
    Private Sub addErrSheet(ByVal name As String)
        On Error Resume Next
        errSheet.Add(name, name)
    End Sub
    Private Sub loadSheetsIn(ByVal folder As String)
        Dim rootMainSheet As Excel.Worksheet
        Dim thisbook As Excel.Workbook
        Dim thissheet As Excel.Worksheet
        rootMainSheet = Nothing

        For Each filename In My.Computer.FileSystem.GetFiles(folder)
            thisbook = Globals.ThisAddIn.Application.Workbooks.Open(filename)
            thissheet = thisbook.ActiveSheet
            If IsNothing(rootMainSheet) Then
                rootMainSheet = thissheet
            Else
                thissheet.Move(Before:=rootMainSheet)
            End If
        Next
    End Sub
End Module

