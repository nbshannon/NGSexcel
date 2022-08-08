Public Class TextInclusion
    Private myindex As Long
    Private myvalues As String()

    Public Sub New(ByVal index As Integer, ByVal values As String())
        myindex = index
        myvalues = values
    End Sub

    Public Function filterLine(ByVal line As String()) As Boolean
        On Error GoTo err
        If myvalues.Contains(line(myindex)) Then filterLine = True Else filterLine = False
        ' MsgBox("Does " & Chr(34) & line(myindex) & Chr(34) & " Exist in " & vbCrLf & Join(myvalues, ",") & "?" & vbCrLf & filterLine)
        Exit Function
err:
        filterLine = False
    End Function
End Class

Public Class TextExclusion
    Private myindex As Long
    Private myvalues As String()

    Public Sub New(ByVal index As Integer, ByVal values As String())
        myindex = index
        myvalues = values
    End Sub

    Public Function filterLine(ByVal line As String()) As Boolean
        On Error GoTo err
        If myvalues.Contains(line(myindex)) Then filterLine = False Else filterLine = True
        Exit Function
err:
        filterLine = True
    End Function
End Class

Public Class rangeInclusion
    Private myindex As Long
    Private mystart As Long
    Private myend As Long

    Public Sub New(ByVal index As Integer, ByVal this_start As Long, ByVal this_end As Long)
        myindex = index
        'MsgBox(values.Count)
        mystart = this_start
        myend = this_end
    End Sub

    Public Function filterLine(ByVal line As String()) As Boolean
        On Error GoTo err
        If mystart < (line(myindex)) And myend > (line(myindex)) Then filterLine = True Else filterLine = False
        Exit Function
err:
        filterLine = False
    End Function

End Class

Public Class rangeExclusion
    Private myindex As Long
    Private mystart As Long
    Private myend As Long

    Public Sub New(ByVal index As Integer, ByVal this_start As Long, ByVal this_end As Long)
        myindex = index
        'MsgBox(values.Count)
        mystart = this_start
        myend = this_end
    End Sub

    Public Function filterLine(ByVal line As String()) As Boolean
        'MsgBox("Asked to filter ")
        On Error GoTo err
        If mystart < (line(myindex)) And myend > (line(myindex)) Then filterLine = False Else filterLine = True
        'MsgBox(mystart & "<" & line(myindex) & ", " & myend & ">" & line(myindex))
        Exit Function
err:
        filterLine = True

    End Function

End Class


