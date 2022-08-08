Module SequenceTools
    Function seqrev(ByVal seq As String)
        seqrev = StrReverse(seq)
    End Function
    Function seqcomp(ByVal seq As String)
        Dim i As Long = Len(seq)
        Dim newstr As String = ""
        For i = 1 To i
            Select Case Mid(seq, i, 1)
                Case "a"
                    newstr += "t"
                Case "A"
                    newstr += "T"
                Case "c"
                    newstr += "g"
                Case "C"
                    newstr += "G"
                Case "g"
                    newstr += "c"
                Case "G"
                    newstr += "C"
                Case "t"
                    newstr += "a"
                Case "T"
                    newstr += "A"
                Case "n"
                    newstr += "n"
                Case "N"
                    newstr += "N"
                Case "["
                    newstr += "]"
                Case "]"
                    newstr += "["
                Case Else
                    newstr += UCase(Mid(seq, i, 1))
            End Select
        Next
        seqcomp = newstr
    End Function
    Function seqrevcomp(ByVal seq As String)
        seq = StrReverse(seq)
        seq = seqcomp(seq)
        seqrevcomp = seq
    End Function
End Module
